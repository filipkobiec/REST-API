using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDataAccessLibrary.DataAccess
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductsContext _context;

        public ProductsRepository(ProductsContext context)
        {
            _context = context;
        }

        public Product GetById(int id) => _context.Products.FirstOrDefault(p => p.Id == id);
        public IEnumerable<Product> GetAllProducts() => _context.Products;

        public Product Update(Product product)
        {
            var entity = _context.Products.Attach(product);
            entity.State = EntityState.Modified;
            return product;
        }

        public Product Delete(int id)
        {
            var product = GetById(id);

            if (product != null)
            {
                _context.Products.Remove(product);
            }

            return product;
        }

        public Product Insert(Product product)
        {
            _context.Products.Add(product);
            return product;
        }

        public int SaveChanges() => _context.SaveChanges();
    }
}
