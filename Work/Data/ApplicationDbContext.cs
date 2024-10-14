using Microsoft.EntityFrameworkCore;
using Work.Models;

namespace Work.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Name = "John Smith", DisplayOrder = 1 },
            new Employee { Id = 2, Name = "Karen West", DisplayOrder = 2 },
            new Employee { Id = 3, Name = "Jake Trust", DisplayOrder = 3 }
            );

        }
    }
}
