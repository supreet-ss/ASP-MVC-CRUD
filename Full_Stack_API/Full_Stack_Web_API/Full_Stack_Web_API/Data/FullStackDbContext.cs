using Full_Stack_Web_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Full_Stack_Web_API.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees{ get; set; }

    }
}
