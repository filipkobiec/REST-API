using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Handlers;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Queries;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;
using System.Linq;


namespace UnitTests.Products.Queries
{
    public class GetProductsTests
    {
        private readonly Mock<IProductsRepository> _mockRepository;
        public GetProductsTests()
        {
            _mockRepository = MockProductsRepository.GetMockProductsRepository();
        }

        [Fact]
        public async Task GetAllProductsTest()
        {
            var handler = new GetAllProductsHandler(_mockRepository.Object);
            var result = await handler.Handle(new GetAllProductsQuery(), CancellationToken.None);

            result.ShouldBeAssignableTo<IEnumerable<Product>>();

            result.ToList().Count.ShouldBe(4);
        }

        [Fact]
        public async Task GetProductByIdTest()
        {
            var handler = new GetProductByIdHandler(_mockRepository.Object);
            var result = await handler.Handle(new GetProductByIdQuery(1), CancellationToken.None);

            result.ShouldBeOfType<Product>();

            result.Id.ShouldBe(1);
        }
    }
}
