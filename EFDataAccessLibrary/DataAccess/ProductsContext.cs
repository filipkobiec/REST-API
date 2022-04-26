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
                new Product { Id = 1, Name = "Product1", ShortDescription = "Very cool product1", Price = 1, CreationDate = new DateTime(2020, 4, 3, 13, 20, 0) },
                new Product { Id = 2, Name = "Product2", ShortDescription = "Very cool product2", Price = 2, CreationDate = new DateTime(2020, 5, 3, 11, 30, 33) },
                new Product { Id = 3, Name = "Product3", ShortDescription = "Very cool product3", Price = 3, CreationDate = new DateTime(2021, 5, 6, 8, 20, 0) },
                new Product { Id = 4, Name = "Product4", ShortDescription = "Very cool product4", Price = 4, CreationDate = new DateTime(2022, 1, 3, 15, 30, 0) });
        }

        public DbSet<Product> Products { get; set; }
    }
}
