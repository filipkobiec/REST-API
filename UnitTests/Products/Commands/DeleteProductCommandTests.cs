using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Handlers;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Queries;
using Moq;
using Shouldly;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnitTests.Mocks;
using Xunit;

namespace UnitTests.Products.Commands
{
    public class DeleteProductCommandTests
    {
        private readonly Mock<IProductsRepository> _mockRepository;
        public DeleteProductCommandTests()
        {
            _mockRepository = MockProductsRepository.GetMockProductsRepository();
        }

        [Fact]
        public async Task DeleteCommandTest()
        {
            var deleteProductHandler = new DeleteProductHandler(_mockRepository.Object);
            var productsHandler = new GetAllProductsHandler(_mockRepository.Object);

            var result = await deleteProductHandler.Handle(new DeleteProductCommand(1), CancellationToken.None);
            result.ShouldBeOfType<Product>();

            var products = await productsHandler.Handle(new GetAllProductsQuery(), CancellationToken.None);
            products.ToList().Count.ShouldBe(3);

        }
    }
}
