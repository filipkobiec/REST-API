using EFDataAccessLibrary.Models;

namespace EFDataAccessLibrary.DataAccess
{
    public interface IProductsData
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProductById(int id);

        Product InsertProduct(Product product);

        Product DeleteProduct(int id);

        int SaveChanges();
    }
}