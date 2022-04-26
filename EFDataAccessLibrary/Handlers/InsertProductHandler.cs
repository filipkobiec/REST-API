using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.DataAccess;
using EFDataAccessLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.Handlers
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Product>
    {
        private readonly IProductsData _data;

        public InsertProductHandler(IProductsData data)
        {
            _data = data;
        }
        public Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            var savedProduct = _data.InsertProduct(request.product);
            _data.SaveChanges();
            return Task.FromResult(savedProduct);
        }
    }
}
