using HospitalManagementProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        #region Constructor & Context
        private readonly HospitalManagementContext _context;

        public PatientsController(HospitalManagementContext context)
        {
            _context = context;
        }
        #endregion

        #region GetAllPatients (GET: api/Patients)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetAllPatients()
        {
            try
            {
                var patients = await _context.Patients.ToListAsync();
                return Ok(patients);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while fetching patients: {ex.Message}");
            }
        }
        #endregion

        #region GetPatientByID (GET: api/Patients/{id})
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatientByID(int id)
        {
            try
            {
                var patient = await _context.Patients.FindAsync(id);
                if (patient == null)
                    return NotFound($"Patient with ID {id} not found.");

                return Ok(patient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while retrieving patient: {ex.Message}");
            }
        }
        #endregion

        #region InsertPatient (POST: api/Patients)
        [HttpPost]
        public async Task<ActionResult<Patient>> InsertPatient(Patient patient)
        {
            try
            {
                await _context.Patients.AddAsync(patient);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetPatientByID), new { id = patient.PatientId }, patient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while inserting patient: {ex.Message}");
            }
        }
        #endregion

        #region UpdatePatient (PUT: api/Patients/{id})
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePatient(int id, Patient patient)
        {
            if (id != patient.PatientId)
                return BadRequest("Patient ID mismatch.");

            try
            {
                var existingPatient = await _context.Patients.FindAsync(id);
                if (existingPatient == null)
                    return NotFound($"Patient with ID {id} not found.");

                existingPatient.PatientName = patient.PatientName;
                existingPatient.Contact = patient.Contact;
                existingPatient.Age = patient.Age;
                existingPatient.EarlierOperation = patient.EarlierOperation;
                existingPatient.BloodGroup = patient.BloodGroup;

                _context.Patients.Update(existingPatient);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while updating patient: {ex.Message}");
            }
        }
        #endregion

        #region DeletePatientByID (DELETE: api/Patients/{id})
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientByID(int id)
        {
            try
            {
                var patient = await _context.Patients.FindAsync(id);
                if (patient == null)
                    return NotFound($"Patient with ID {id} not found.");

                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();

                return Ok(patient);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while deleting patient: {ex.Message}");
            }
        }
        #endregion

    }
}
