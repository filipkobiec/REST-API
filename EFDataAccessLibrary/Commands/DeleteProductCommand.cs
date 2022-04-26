using EFDataAccessLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Commands
{
    public record DeleteProductCommand(int id) : IRequest<Product>;

}
