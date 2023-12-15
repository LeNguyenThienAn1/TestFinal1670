using Microsoft.EntityFrameworkCore;
using TestFinal.Models;

namespace TestFinal.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
