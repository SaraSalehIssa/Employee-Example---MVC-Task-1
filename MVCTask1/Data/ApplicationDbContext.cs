using Microsoft.EntityFrameworkCore;
using MVCTask1.Models;

namespace MVCTask1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=Task1MVC;trusted_connection=true;trustServerCertificate=true");
        }
    }
}
