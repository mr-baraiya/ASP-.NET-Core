using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        #region  GetAllHospitals
        [HttpGet]
        public IActionResult GetAllHospitals()
        {
            var hospitals = _context.HospitalMasters.ToList();
            return Ok(hospitals);
        }
        #endregion

        #region  GetAllHospitalById
        [HttpGet("{id}")]
        public IActionResult GetAllHospitalById(int id)
        {
            var hospitals = _context.HospitalMasters.Find(id);
            if(hospitals == null)
            {
                return NotFound();
            }
            return Ok(hospitals);
        }
        #endregion

        #region  DeleteHospital
        [HttpDelete("{id}")]
        public IActionResult DeleteHospital(int id)
        {
            var hospitals = _context.HospitalMasters.Find(id);
            if (hospitals == null)
            {
                return NotFound();
            }
            _context.HospitalMasters.Remove(hospitals);
            _context.SaveChanges();
            return NoContent();
        }
        #endregion

        #region  InsertHospital
        [HttpPost]
        public IActionResult InsertHospital(HospitalMaster hospital)
        {
            _context.HospitalMasters.Add(hospital);
            _context.SaveChanges();
            return NoContent();
        }
        #endregion

        #region  UpdateHospital
        [HttpPut("{id}")]
        public IActionResult UpdateHospital(int id , HospitalMaster hospital)
        {
            if (id != hospital.HospitalId)  // Ensure route ID matches the student ID 
            {
                return BadRequest();
            }
            var existingStudent = _context.HospitalMasters.Find(id);
            if (existingStudent == null)
            {
                return NotFound();
            }
            existingStudent.HospitalName = hospital.HospitalName;
            existingStudent.HospitalAddress = hospital.HospitalAddress;
            existingStudent.ContactNumber = hospital.ContactNumber;
            existingStudent.EmailAddress = hospital.EmailAddress;
            existingStudent.OwnerName = hospital.OwnerName;
            existingStudent.OpeningDate = hospital.OpeningDate;
            existingStudent.TotalStaffs = hospital.TotalStaffs;
            existingStudent.SundayOpen = hospital.SundayOpen;

            _context.HospitalMasters.Update(existingStudent);
            _context.SaveChanges();
            return NoContent();
        }
        #endregion

    }
}
