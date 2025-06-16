using HospitalManagementProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        #region  GetAllDoctors
        [HttpGet]
        public IActionResult GetAllDoctors()
        {
            var doctors = _context.Doctors.ToList();
            return Ok(doctors);
        }
        #endregion

        #region GetDoctorByID
        [HttpGet("{id}")]
        public IActionResult GetDoctorByID(int id)
        {
            var doctor = _context.Doctors.Find(id);
            if (doctor == null) { 
                return NotFound();
            }
            return Ok(doctor);
        }
        #endregion

        #region DeleteDoctorByID
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctorByID(int id)
        {
            var doctor = _context.Doctors.Find(id);
            if (doctor == null)
            {
                return NotFound();
            }
            _context.Doctors.Remove(doctor);
            _context.SaveChanges();
            return Ok(doctor);
        }
        #endregion

        #region InserDoctor
        [HttpPost]
        public IActionResult InserDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return Ok(doctor);
        }
        #endregion

        #region UpdateDoctor
        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, Doctor doctor)
        {
            if (id != doctor.DoctorId)
            {
                return BadRequest();
            }
            var existingDoctor = _context.Doctors.Find(id);
            if (existingDoctor == null)
            {
                return NotFound();
            }
            existingDoctor.DoctorName = doctor.DoctorName;
            existingDoctor.Dob = doctor.Dob;
            existingDoctor.Degree = doctor.Degree;
            existingDoctor.Age = doctor.Age;
            existingDoctor.Experience = doctor.Experience;
            existingDoctor.Specification = doctor.Specification;

            _context.Doctors.Update(existingDoctor);
            _context.SaveChanges();
            return NoContent();
        }

        #endregion

    }
}
