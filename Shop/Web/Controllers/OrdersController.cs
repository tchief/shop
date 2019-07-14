using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Domain;
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

        /// <summary>
        /// Retrieves all orders for the customer.
        /// </summary>
        /// <param name="customerId">Id of customer.</param>
        /// <returns>All available orders for customer.</returns>
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetOrders(int customerId)
            => Ok(await _repository.GetOrdersAsync(customerId));

        /// <summary>
        /// Retrieves specific order for the customer.
        /// </summary>
        /// <param name="customerId">Id of customer.</param>
        /// <param name="id">Id of the order.</param>
        /// <returns>Specific order for the customer.</returns>
        [HttpGet("{id:int}", Name = "GetOrder")]
        public async Task<ActionResult<OrderDto>> GetOrder(int customerId, int id)
            => Ok(await _repository.GetOrderAsync(customerId, id));

        /// <summary>
        /// Places a new order.
        /// </summary>
        [HttpPost]
        public async Task<ActionResult<OrderDto>> AddOrder(int customerId, [FromBody] OrderDto order)
        {
            var result = await _repository.AddOrderAsync(customerId, order);
            return CreatedAtRoute("GetOrder", new { result.Id }, result);
        }
    }
}