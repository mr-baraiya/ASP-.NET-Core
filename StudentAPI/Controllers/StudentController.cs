using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController() 
        { 

        }

        #region In-memory data store for demonstration purposes

        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Class = "10A" },
            new Student { Id = 2, Name = "Jane Smith", Class = "10B" },
            new Student { Id = 3, Name = "Alice Johnson", Class = "10A" },
            new Student { Id = 4, Name = "Bob Brown", Class = "10C" }
        };

        #endregion

        #region StudentList
        [HttpGet]
        public IActionResult GetStudents()
        {
            try
            {
                return Ok(students);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving students: {ex.Message}");
            }           
        }

        #endregion
    }
}
