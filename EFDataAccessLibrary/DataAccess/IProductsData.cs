﻿using EFDataAccessLibrary.Models;

namespace EFDataAccessLibrary.DataAccess
{
    public interface IProductsData
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProductById(int id);

        Product InsertProduct(Product product);

        int SaveChanges();
    }
}