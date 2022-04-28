using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Handlers;
using EFDataAccessLibrary.Models;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.Products.Commands
{
    public class InsertProductCommandTests
    {
        private readonly Mock<IProductsRepository> _mockRepository;
        private readonly Product _product;
        public InsertProductCommandTests()
        {
            _mockRepository = MockProductsRepository.GetMockProductsRepository();
            _product = new Product()
            {
                Id = 5,
                Name = "test product",
                Price = 3,
                ShortDescription = "Hello"
            };
        }

        [Fact]
        public async Task InsertProductTest()
        {
            var handler = new InsertProductHandler(_mockRepository.Object);

            var result = await handler.Handle(new InsertProductCommand(_product), CancellationToken.None);

            var products = _mockRepository.Object.GetAllProducts();

            result.ShouldBeOfType<Product>();

            products.ToList().Count.ShouldBe(5);
        }
    }
}
