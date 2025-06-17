using JSONSerealizedAndDeSerealizedDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JSONSerealizedAndDeSerealizedDemo.Controllers
{
    public class EmployeeController : ControllerBase
    {
        #region Serialized
        [HttpPost("serialize")]
        public IActionResult Create([FromBody] Employee employee)
        {
            if (ModelState.IsValid)
            {
                var jsonOutput = JsonConvert.SerializeObject(employee, Formatting.Indented);
                return Ok(new
                {
                    Message = "Employee data received and serialized successfully.",
                    Data = jsonOutput
                });
            }
            return BadRequest(ModelState);
        }
        #endregion

        #region Deserialized
        [HttpPost("deserialize")]
        public IActionResult DeserializeJson([FromBody] string json)
        {
            try
            {
                var employee = JsonConvert.DeserializeObject<Employee>(json);

                return Ok(new
                {
                    Message = "JSON deserialized successfully.",
                    Employee = employee
                });
            }
            catch (JsonException ex)
            {
                return BadRequest(new
                {
                    Message = "Invalid JSON format",
                    Error = ex.Message
                });
            }
        }
        #endregion
    }
}
