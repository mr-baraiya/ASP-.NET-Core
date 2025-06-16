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

        #region  GetHospitalById
        [HttpGet("{id}")]
        public IActionResult GetAllHospitalById(int id)
        {
            var hospital = _context.HospitalMasters.Find(id);
            if(hospital == null)
            {
                return NotFound();
            }
            return Ok(hospital);
        }
        #endregion

        #region  DeleteHospitalByID
        [HttpDelete("{id}")]
        public IActionResult DeleteHospitalByID(int id)
        {
            var hospital = _context.HospitalMasters.Find(id);
            if (hospital == null)
            {
                return NotFound();
            }
            _context.HospitalMasters.Remove(hospital);
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
            var existingHospital = _context.HospitalMasters.Find(id);
            if (existingHospital == null)
            {
                return NotFound();
            }
            existingHospital.HospitalName = hospital.HospitalName;
            existingHospital.HospitalAddress = hospital.HospitalAddress;
            existingHospital.ContactNumber = hospital.ContactNumber;
            existingHospital.EmailAddress = hospital.EmailAddress;
            existingHospital.OwnerName = hospital.OwnerName;
            existingHospital.OpeningDate = hospital.OpeningDate;
            existingHospital.TotalStaffs = hospital.TotalStaffs;
            existingHospital.SundayOpen = hospital.SundayOpen;

            _context.HospitalMasters.Update(existingHospital);
            _context.SaveChanges();
            return NoContent();
        }
        #endregion

    }
}
