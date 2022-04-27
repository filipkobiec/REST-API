using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using MediatR;


namespace EFDataAccessLibrary.Handlers
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Product>
    {
        private readonly IProductsRepository _data;

        public InsertProductHandler(IProductsRepository data)
        {
            _data = data;
        }
        public Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            var savedProduct = _data.Insert(request.product);
            _data.SaveChanges();
            return Task.FromResult(savedProduct);
        }
    }
}
