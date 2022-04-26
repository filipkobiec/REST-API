using EFDataAccessLibrary.Models;
using MediatR;

namespace EFDataAccessLibrary.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
