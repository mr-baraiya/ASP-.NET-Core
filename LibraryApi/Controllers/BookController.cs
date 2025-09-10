using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryContext _context;
        public BookController(LibraryContext context) => _context = context;

        [HttpGet("available")]
        public IActionResult GetAvailableBooks() =>
            Ok(_context.Books.Where(b => b.IsAvailable).ToList());

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return Ok(book);
        }
    }
}
