using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Handlers;
using EFDataAccessLibrary.Models;
using FluentAssertions;
using Moq;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.Products.Commands
{
    public class UpdateCommandTests
    {
        private readonly Mock<IProductsRepository> _mockRepository;
        private readonly Product _updatedProduct;
        public UpdateCommandTests()
        {
            _mockRepository = MockProductsRepository.GetMockProductsRepository();
            _updatedProduct = new Product()
            {
                Id = 1,
                Name = "test product1",
                Price = 1,
                ShortDescription = "Hello1"
            };
        }

        [Fact]
        public async Task UpdateProductCommandTest()
        {
            var handler = new UpdateProductHandler(_mockRepository.Object);

            var result = await handler.Handle(new UpdateProductCommand(_updatedProduct), CancellationToken.None);

            result.Should().BeEquivalentTo(_updatedProduct, options =>
            {
                options.Using<DateTime>(ctx => ctx.Subject.Should().BeCloseTo(ctx.Expectation, TimeSpan.FromMinutes(2))).WhenTypeIs<DateTime>();
                return options;
            });
        }
    }
}
