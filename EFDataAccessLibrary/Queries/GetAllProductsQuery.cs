using EFDataAccessLibrary.Models;
using MediatR;

namespace EFDataAccessLibrary.Queries
{
    public record GetAllProductsQuery : IRequest<IEnumerable<Product>>;

}
