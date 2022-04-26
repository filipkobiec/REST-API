using EFDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.DataAccess
{
    public class SqlProductsData : IProductsData
    {
        private readonly ProductsContext _context;

        public SqlProductsData(ProductsContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts() => _context.Products;

        public Product GetProductById(int id) => _context.Products.FirstOrDefault(p => p.Id == id);
    }
}
