using EFDataAccessLibrary.Commands;
using EFDataAccessLibrary.Models;
using EFDataAccessLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _mediator.Send(new GetAllProductsQuery());
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _mediator.Send(new GetProductByIdQuery(id));
        }

        [HttpPost()]
        public async Task<Product> Post([FromBody] Product product)
        {
            return await _mediator.Send(new InsertProductCommand(product));
        }

        [HttpPut()]
        public async Task<Product> Put([FromBody] Product product)
        {
            return await _mediator.Send(new UpdateProductCommand(product));
        }

        [HttpDelete()]
        public async Task<Product> Delete(int id)
        {
            return await _mediator.Send(new DeleteProductCommand(id));
        }
    }
}
