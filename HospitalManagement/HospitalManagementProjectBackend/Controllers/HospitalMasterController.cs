using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalManagementProject.Models;

namespace HospitalManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalMasterController : ControllerBase
    {
        #region Configuration Fields 
        private readonly HospitalManagementContext _context;
        public HospitalMasterController(HospitalManagementContext context)
        {
            _context = context;
        }
        #endregion

        #region GetAllHospitals
        [HttpGet]
        public async Task<IActionResult> GetAllHospitals()
        {
            try
            {
                var hospitals = await _context.HospitalMasters.ToListAsync();
                return Ok(hospitals);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error fetching hospital list.", error = ex.Message });
            }
        }
        #endregion

        #region GetHospitalById
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHospitalById(int id)
        {
            try
            {
                var hospital = await _context.HospitalMasters.FindAsync(id);
                if (hospital == null)
                {
                    return NotFound(new { message = $"Hospital with ID {id} not found." });
                }
                return Ok(hospital);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error fetching hospital by ID.", error = ex.Message });
            }
        }
        #endregion

        #region DeleteHospitalById
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospitalById(int id)
        {
            try
            {
                var hospital = await _context.HospitalMasters.FindAsync(id);
                if (hospital == null)
                {
                    return NotFound(new { message = $"Hospital with ID {id} not found." });
                }

                _context.HospitalMasters.Remove(hospital);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error deleting hospital.", error = ex.Message });
            }
        }
        #endregion

        #region InsertHospital
        [HttpPost]
        public async Task<IActionResult> InsertHospital([FromBody] HospitalMaster hospital)
        {
            try
            {
                await _context.HospitalMasters.AddAsync(hospital);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Hospital inserted successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error inserting hospital.", error = ex.Message });
            }
        }
        #endregion

        #region UpdateHospital
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHospital(int id, [FromBody] HospitalMaster hospital)
        {
            try
            {
                if (id != hospital.HospitalId)
                {
                    return BadRequest(new { message = "Route ID and body ID do not match." });
                }

                var existingHospital = await _context.HospitalMasters.FindAsync(id);
                if (existingHospital == null)
                {
                    return NotFound(new { message = $"Hospital with ID {id} not found." });
                }

                // Update fields
                existingHospital.HospitalName = hospital.HospitalName;
                existingHospital.HospitalAddress = hospital.HospitalAddress;
                existingHospital.ContactNumber = hospital.ContactNumber;
                existingHospital.EmailAddress = hospital.EmailAddress;
                existingHospital.OwnerName = hospital.OwnerName;
                existingHospital.OpeningDate = hospital.OpeningDate;
                existingHospital.TotalStaffs = hospital.TotalStaffs;
                existingHospital.SundayOpen = hospital.SundayOpen;

                _context.HospitalMasters.Update(existingHospital);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Hospital updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error updating hospital.", error = ex.Message });
            }
        }
        #endregion

        #region SuccessAndFailure
        [HttpGet("success")]
        public ActionResult GetSuccess()
        {
            return Ok(new { message = "API is working fine!" });
        }

        [HttpGet("fail")]
        public ActionResult GetFailure()
        {
            // This will throw an exception and be caught by global exception handling (if configured)
            throw new Exception("This is a test exception.");
        }
        #endregion

    }
}
