using EFDataAccessLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
