using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Domain;
using Shop.Web.Filters;

namespace Shop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [NotFoundResultFilter]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _repository;
        public CustomersController(ICustomersRepository repository) => _repository = repository;

        /// <summary>
        /// Retrieves all the customers.
        /// </summary>
        /// <param name="includeOrders">Set <value>true</value> to include orders in results.</param>
        /// <returns>All the customers.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomers(bool includeOrders = false)
            => Ok(await _repository.GetCustomersAsync(includeOrders));

        /// <summary>
        /// Retrieves a customer by id.
        /// </summary>
        /// <param name="id">Id of the customer.</param>
        /// <param name="includeOrders">Set <value>true</value> to include orders in results.</param>
        /// <returns>Customer details.</returns>
        [HttpGet("{id:int}", Name = "GetCustomer")]
        public async Task<ActionResult<CustomerDto>> GetCustomer(int id, bool includeOrders = false)
            => Ok(await _repository.GetCustomerAsync(id, includeOrders));

        /// <summary>
        /// Registers new customer.
        /// </summary>
        /// <param name="customer">Customer to register.</param>
        /// <returns>Registered customer.</returns>
        [HttpPost]
        public async Task<ActionResult<CustomerDto>> AddCustomer([FromBody] CustomerDto customer)
        {
            var result = await _repository.AddCustomerAsync(customer);
            return CreatedAtRoute("GetCustomer", new { result.Id }, result);
        }
    }
}
