
using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using MediatR;

namespace EFDataAccessLibrary.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly IProductsData _data;

        public UpdateProductHandler(IProductsData data)
        {
            _data = data;
        }
        public Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var updatedProduct = _data.Update(request.Product);
            _data.SaveChanges();
            return Task.FromResult(updatedProduct);
        }
    }
}
