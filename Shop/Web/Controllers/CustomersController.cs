using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Dto;
using Shop.Domain;
using Shop.Web.Middleware;

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
        /// Retrieves a customer by name.
        /// </summary>
        /// <param name="name">Name of the customer.</param>
        /// <param name="includeOrders">Set <value>true</value> to include orders in results.</param>
        /// <returns>Customer details.</returns>
        [HttpGet]
        //[ExactQueryParam("name")]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetCustomersByName([RequiredFromQuery]string name, bool includeOrders = false)
            => Ok(await _repository.GetCustomersByNameAsync(name, includeOrders));

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
        [HttpGet("{id:int:min(1)}", Name = "GetCustomer")]
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

        /// <summary>
        /// Deletes existing customer.
        /// </summary>
        /// <param name="id">Customer to delete.</param>
        [HttpDelete("{id:int:min(1)}")]
        public async Task<ActionResult> DeleteCustomer(int id)
        {
            await _repository.DeleteCustomerAsync(id);
            return NoContent();
        }
    }
}
