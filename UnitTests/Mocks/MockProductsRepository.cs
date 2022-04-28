using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests.Mocks
{
    public static class MockProductsRepository 
    {
        public static Mock<IProductsRepository> GetMockProductsRepository()
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1, Name = "Product1", ShortDescription = "Very cool product1", Price = 1 },
                new Product { Id = 2, Name = "Product2", ShortDescription = "Very cool product2", Price = 2 },
                new Product { Id = 3, Name = "Product3", ShortDescription = "Very cool product3", Price = 3 },
                new Product { Id = 4, Name = "Product4", ShortDescription = "Very cool product4", Price = 4 }
            };

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(r => r.GetAllProducts()).Returns(products);

            mockRepository.Setup(r => r.GetById(It.IsAny<int>())).Returns((int id) =>
            {
                return products.FirstOrDefault(p => p.Id == id);
            });

            mockRepository.Setup(r => r.Insert(It.IsAny<Product>())).Returns((Product product) =>
            {
                products.Add(product);
                return product;
            });

            return mockRepository;
        }
    }
}
