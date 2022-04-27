using EFDataAccessLibrary.Models;

namespace EFDataAccessLibrary.DataAccess
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetAllProducts();

        Product GetById(int id);

        Product Insert(Product product);

        Product Update(Product product);

        Product Delete(int id);

        int SaveChanges();
    }
}