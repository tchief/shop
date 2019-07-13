using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain;
using Shop.Domain.Entities;
using Shop.Web.Filters;

namespace Shop.Web.Controllers
{
    [Route("api/customers/{customerId}/[controller]")]
    [ApiController]
    [NotFoundResultFilter]
    public class OrdersController : ControllerBase
    {
        private readonly ICustomersRepository _repository;
        public OrdersController(ICustomersRepository repository) => _repository = repository;

        [HttpGet()]
        public async Task<ActionResult<Order>> GetOrders(int customerId)
            => Ok(await _repository.GetOrdersAsync(customerId));

        [HttpGet("{id:int}", Name = "GetOrder")]
        public async Task<ActionResult<Order>> GetOrder(int customerId, int id)
            => Ok(await _repository.GetOrderAsync(customerId, id));

        [HttpPost]
        public async Task<ActionResult<Order>> AddOrder(int customerId, [FromBody] Order order)
        {
            var result = await _repository.AddOrderAsync(customerId, order);
            return CreatedAtRoute("GetOrder", new { result.Id }, result);
        }
    }
}