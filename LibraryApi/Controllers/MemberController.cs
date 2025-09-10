using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly LibraryContext _context;
        public MemberController(LibraryContext context) => _context = context;

        [HttpPost]
        public IActionResult AddMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
            return Ok(member);
        }
    }
}
