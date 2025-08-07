using HospitalManagementProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        #region Configuration Fields 
        private readonly HospitalManagementContext _context;

        public DoctorsController(HospitalManagementContext context)
        {
            _context = context;
        }
        #endregion

        #region GetAllDoctors
        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            try
            {
                var doctors = await _context.Doctors.ToListAsync();
                return Ok(doctors);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error fetching doctors: {ex.Message}");
            }
        }
        #endregion

        #region GetDoctorByID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorByID(int id)
        {
            try
            {
                var doctor = await _context.Doctors.FindAsync(id);
                if (doctor == null)
                {
                    return NotFound($"Doctor with ID {id} not found.");
                }
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error retrieving doctor: {ex.Message}");
            }
        }
        #endregion

        #region InsertDoctor
        [HttpPost]
        public async Task<IActionResult> InsertDoctor([FromBody] Doctor doctor)
        {
            try
            {
                await _context.Doctors.AddAsync(doctor);
                await _context.SaveChangesAsync();
                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error inserting doctor: {ex.Message}");
            }
        }
        #endregion

        #region UpdateDoctor
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDoctor(int id, [FromBody] Doctor doctor)
        {
            if (id != doctor.DoctorId)
            {
                return BadRequest("Doctor ID mismatch.");
            }

            try
            {
                var existingDoctor = await _context.Doctors.FindAsync(id);
                if (existingDoctor == null)
                {
                    return NotFound($"Doctor with ID {id} not found.");
                }

                existingDoctor.DoctorName = doctor.DoctorName;
                existingDoctor.Dob = doctor.Dob;
                existingDoctor.Degree = doctor.Degree;
                existingDoctor.Age = doctor.Age;
                existingDoctor.Experience = doctor.Experience;
                existingDoctor.Specification = doctor.Specification;

                _context.Doctors.Update(existingDoctor);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error updating doctor: {ex.Message}");
            }
        }
        #endregion

        #region DeleteDoctorByID
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDoctorByID(int id)
        {
            try
            {
                var doctor = await _context.Doctors.FindAsync(id);
                if (doctor == null)
                {
                    return NotFound($"Doctor with ID {id} not found.");
                }

                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();

                return Ok(doctor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error deleting doctor: {ex.Message}");
            }
        }
        #endregion

    }
}
