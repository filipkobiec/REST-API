using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;


namespace EFDataAccessLibrary.DataAccess
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                new Product { Id = 1, Name = "Product1", ShortDescription = "Very cool product1", Price = 1 },
                new Product { Id = 2, Name = "Product2", ShortDescription = "Very cool product2", Price = 2 },
                new Product { Id = 3, Name = "Product3", ShortDescription = "Very cool product3", Price = 3 },
                new Product { Id = 4, Name = "Product4", ShortDescription = "Very cool product4", Price = 4 });
        }

        public DbSet<Product> Products { get; set; }
    }
}
