

using EFDataAccessLibrary.Models;
using MediatR;

namespace EFDataAccessLibrary.Commands
{
    public record UpdateProductCommand(Product Product) : IRequest<Product>;

}
