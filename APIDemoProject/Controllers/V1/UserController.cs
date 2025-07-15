using APIDemoProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIDemoProject.Controllers.V1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MyDbContext context;

        public UserController(MyDbContext context)
        {
            this.context = context;
        }

        #region GetAllUsers
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            try
            {
                var data = await context.Users.ToListAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving users: {ex.Message}");
            }
        }
        #endregion

        #region GetUserById
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            try
            {
                var user = await context.Users.FindAsync(id);
                if (user == null)
                    return NotFound("User not found");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving the user: {ex.Message}");
            }
        }
        #endregion

        #region CreateUser
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser([FromBody] User u)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await context.Users.AddAsync(u);
                await context.SaveChangesAsync();
                return Ok(u);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.Message.Contains("UNIQUE") == true || ex.InnerException?.Message.Contains("duplicate") == true)
                {
                    return Conflict("User with the same email or username already exists.");
                }
                return StatusCode(500, $"Database error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
        }
        #endregion

        #region UpdateUser
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, [FromBody] User u)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != u.UserId)
                return BadRequest("User ID mismatch");

            try
            {
                var existingUser = await context.Users.FindAsync(id);
                if (existingUser == null)
                    return NotFound("User not found");

                context.Entry(existingUser).CurrentValues.SetValues(u);
                await context.SaveChangesAsync();
                return Ok(u);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(500, $"Database update error: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An unexpected error occurred: {ex.Message}");
            }
        }
        #endregion

        #region DeleteUser
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            try
            {
                var user = await context.Users.FindAsync(id);
                if (user == null)
                    return NotFound("User not found");

                context.Users.Remove(user);
                await context.SaveChangesAsync();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while deleting the user: {ex.Message}");
            }
        }
        #endregion

    }
}
