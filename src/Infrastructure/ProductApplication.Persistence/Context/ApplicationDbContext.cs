using Microsoft.EntityFrameworkCore;
using ProductApplication.Domain.Entities;

namespace ProductApplication.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pen", Value = 1, Quantity = 500 },
                new Product() { Id = Guid.NewGuid(), Name = "Paper-A4", Value = 10, Quantity = 250 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value = 30, Quantity = 100 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
