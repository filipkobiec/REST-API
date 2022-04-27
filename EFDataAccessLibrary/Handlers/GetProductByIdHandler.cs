using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Queries;
using MediatR;


namespace EFDataAccessLibrary.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductsRepository _data;

        public GetProductByIdHandler(IProductsRepository data)
        {
            _data = data;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return _data.GetById(request.id);
        }
    }
}
