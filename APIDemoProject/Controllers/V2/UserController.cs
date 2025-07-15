using APIDemoProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIDemoProject.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
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
        public async Task<ActionResult<object>> GetAllUsers()
        {
            var data = await context.Users.ToListAsync();
            // V2 enhancement: Add metadata
            var response = new
            {
                Version = "2.0",
                Count = data.Count,
                Data = data,
                Timestamp = DateTime.UtcNow
            };
            return Ok(response);
        }
        #endregion

        #region GetUserById
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetUserById(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { Message = "User not found", RequestedId = id });
            }

            // V2 enhancement: Enhanced response format
            var response = new
            {
                Version = "2.0",
                Data = user,
                Timestamp = DateTime.UtcNow
            };
            return Ok(response);
        }
        #endregion

        #region CreateUser
        [HttpPost]
        public async Task<ActionResult<object>> CreateUser(User u)
        {
            await context.Users.AddAsync(u);
            await context.SaveChangesAsync();

            // V2 enhancement: Enhanced response with creation info
            var response = new
            {
                Version = "2.0",
                Message = "User created successfully",
                Data = u,
                CreatedAt = DateTime.UtcNow
            };
            return Ok(response);
        }
        #endregion

        #region UpdateUser
        [HttpPut("{id}")]
        public async Task<ActionResult<object>> UpdateUser(int id, User u)
        {
            if (id != u.UserId)
            {
                return BadRequest(new { Message = "User ID mismatch", ProvidedId = id, UserObjectId = u.UserId });
            }

            context.Entry(u).State = EntityState.Modified;
            await context.SaveChangesAsync();

            // V2 enhancement: Enhanced response with update info
            var response = new
            {
                Version = "2.0",
                Message = "User updated successfully",
                Data = u,
                UpdatedAt = DateTime.UtcNow
            };
            return Ok(response);
        }
        #endregion

        #region DeleteUser
        [HttpDelete("{id}")]
        public async Task<ActionResult<object>> DeleteUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound(new { Message = "User not found", RequestedId = id });
            }

            context.Users.Remove(user);
            await context.SaveChangesAsync();

            // V2 enhancement: Enhanced response with deletion info
            var response = new
            {
                Version = "2.0",
                Message = "User deleted successfully",
                DeletedUser = user,
                DeletedAt = DateTime.UtcNow
            };
            return Ok(response);
        }
        #endregion

    }
}