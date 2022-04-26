using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using MediatR;


namespace EFDataAccessLibrary.Handlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly IProductsData _data;

        public DeleteProductHandler(IProductsData data)
        {
            _data = data;
        }
        public Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var deletedProduct = Task.FromResult(_data.DeleteProduct(request.id));
            _data.SaveChanges();
            return deletedProduct;
        }
    }
}
