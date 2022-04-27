using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Queries;
using MediatR;

namespace EFDataAccessLibrary.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductsRepository _data;

        public GetAllProductsHandler(IProductsRepository data)
        {
            _data = data;
        }
        public Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken) => Task.FromResult(_data.GetAllProducts());
    }
}
