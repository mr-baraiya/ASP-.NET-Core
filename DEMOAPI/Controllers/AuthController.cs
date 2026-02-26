using BCrypt.Net;
using DEMOAPI.DTOs;
using DEMOAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DEMOAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DemoApiDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(DemoApiDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        #region Register

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto model)
        {
            try
            {
                if (_context.Users.Any(x => x.Email == model.Email))
                    return BadRequest("Email already exists");

                var user = new User
                {
                    Name = model.Name,
                    Email = model.Email,
                    Role = model.Role,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(model.Password)
                };

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();

                return Ok("User Registered Successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion


        #region Login

        [HttpPost("login")]
        public IActionResult Login(LoginDto model)
        {
            try
            {
                var user = _context.Users
                    .FirstOrDefault(x => x.Email == model.Email);

                if (user == null)
                    return Unauthorized("Invalid Email");

                bool isValid = BCrypt.Net.BCrypt.Verify(
                    model.Password,
                    user.PasswordHash
                );

                if (!isValid)
                    return Unauthorized("Invalid Password");

                var jwtSettings = _configuration.GetSection("Jwt");

                var claims = new[]
                {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

                var key = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(jwtSettings["Key"])
                );

                var token = new JwtSecurityToken(
                    issuer: jwtSettings["Issuer"],
                    audience: jwtSettings["Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(
                        Convert.ToDouble(jwtSettings["TokenExpiryMinutes"])
                    ),
                    signingCredentials: new SigningCredentials(
                        key, SecurityAlgorithms.HmacSha256)
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion

    }
}