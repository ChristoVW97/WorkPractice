using Microsoft.EntityFrameworkCore;

namespace Work.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
    }
}
