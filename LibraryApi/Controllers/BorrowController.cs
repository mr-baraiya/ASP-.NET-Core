using LibraryApi.Data;
using LibraryApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowController : ControllerBase
    {
        private readonly LibraryContext _context;
        public BorrowController(LibraryContext context) => _context = context;

        [HttpPost("borrow")]
        public IActionResult BorrowBook(int bookId, int memberId)
        {
            var book = _context.Books.Find(bookId);
            if (book == null || !book.IsAvailable) return BadRequest("Book not available");

            var borrow = new BorrowRecord
            {
                BookId = bookId,
                MemberId = memberId,
                BorrowDate = DateTime.Now
            };

            book.IsAvailable = false;
            _context.BorrowRecords.Add(borrow);
            _context.SaveChanges();

            return Ok(borrow);
        }

        [HttpPost("return")]
        public IActionResult ReturnBook(int borrowId)
        {
            var borrow = _context.BorrowRecords.Include(b => b.Book).FirstOrDefault(b => b.Id == borrowId);
            if (borrow == null || borrow.ReturnDate != null) return BadRequest("Invalid borrow record");

            borrow.ReturnDate = DateTime.Now;
            borrow.Book!.IsAvailable = true;
            _context.SaveChanges();

            return Ok(borrow);
        }

        [HttpGet("borrowed")]
        public IActionResult GetBorrowedBooks()
        {
            var result = _context.BorrowRecords
                .Where(br => br.ReturnDate == null)
                .Include(br => br.Book)
                .Include(br => br.Member)
                .Select(br => new { br.Book!.Title, br.Member!.Name })
                .ToList();
            return Ok(result);
        }

        [HttpGet("top-members")]
        public IActionResult GetTopMembers()
        {
            var result = _context.BorrowRecords
                .GroupBy(br => br.Member!.Name)
                .Select(g => new { MemberName = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(3)
                .ToList();

            return Ok(result);
        }
    }
}
