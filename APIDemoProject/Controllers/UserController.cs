﻿using APIDemoProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIDemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            var data = await context.Users.ToListAsync();
            return Ok(data);
        }
        #endregion

        #region GetUserById
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUserById(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        #endregion

        #region CreateUser
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User u)
        {
            await context.Users.AddAsync(u);
            await context.SaveChangesAsync();
            return Ok(u);
        }
        #endregion

        #region UpdateUser
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, User u)
        {
            if (id != u.UserId)
            {
                return BadRequest("User ID mismatch");
            }
            context.Entry(u).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(u);
        }
        #endregion

        #region DeleteUser
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return Ok(user);
        }
        #endregion

    }
}
