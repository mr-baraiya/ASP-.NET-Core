using BlazorDatabaseDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorDatabaseDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
