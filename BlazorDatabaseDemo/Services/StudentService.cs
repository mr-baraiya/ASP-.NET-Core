using BlazorDatabaseDemo.Data;
using BlazorDatabaseDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDatabaseDemo.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }   
    }
}
