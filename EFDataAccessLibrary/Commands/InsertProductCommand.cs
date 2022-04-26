using EFDataAccessLibrary.Models;
using MediatR;

namespace EFDataAccessLibrary.Commands
{
    public record InsertProductCommand(Product product) : IRequest<Product>;
}

