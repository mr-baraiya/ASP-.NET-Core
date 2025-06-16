using HospitalManagementProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagementProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {

        #region Configuration Fields 
        private readonly HospitalManagementContext _context;
        public PatientsController(HospitalManagementContext context)
        {
            _context = context;
        }
        #endregion

        #region  GetAllPatients
        [HttpGet]
        public IActionResult GetAllPatients()
        {
            var patients = _context.Patients.ToList();
            return Ok(patients);
        }
        #endregion

        #region GetPatientByID
        [HttpGet("{id}")]
        public IActionResult GetPatientByID(int id)
        {
            var patient = _context.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }
        #endregion

        #region DeletePatientByID
        [HttpDelete("{id}")]
        public IActionResult DeletePatientByID(int id)
        {
            var patient = _context.Patients.Find(id);
            if (patient == null)
            {
                return NotFound();
            }
            _context.Patients.Remove(patient);
            _context.SaveChanges();
            return Ok(patient);
        }
        #endregion

        #region InsertPatient
        [HttpPost]
        public IActionResult InsertPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return Ok(patient);
        }
        #endregion

        #region UpdatePatient
        [HttpPut("{id}")]
        public IActionResult UpdatePatient(int id, Patient patient)
        {
            if (id != patient.PatientId)
            {
                return BadRequest();
            }
            var existingPatient = _context.Patients.Find(id);
            if (existingPatient == null)
            {
                return NotFound();
            }
            existingPatient.PatientName = patient.PatientName;
            existingPatient.Contact = patient.Contact;
            existingPatient.Age = patient.Age;
            existingPatient.EarlierOperation = patient.EarlierOperation;
            existingPatient.BloodGroup = patient.BloodGroup;

            _context.Patients.Update(existingPatient);
            _context.SaveChanges();
            return NoContent();
        }

        #endregion

    }
}
