using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Queries;
using MediatR;

namespace EFDataAccessLibrary.Handlers
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductsData _data;

        public GetAllProductsHandler(IProductsData data)
        {
            _data = data;
        }
        public Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken) => Task.FromResult(_data.GetAllProducts());
    }
}
