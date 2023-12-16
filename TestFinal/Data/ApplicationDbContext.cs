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

        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "History", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Science", DisplayOrder = 3 }
                );
        }
    }
}
