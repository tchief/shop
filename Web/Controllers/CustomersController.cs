using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain;
using Shop.Domain.Entities;
using Shop.Web.Filters;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [NotFoundResultFilter]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _repository;
        public CustomersController(ICustomersRepository repository) => _repository = repository;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers(bool includeOrders = false)
            => Ok(await _repository.GetCustomersAsync(includeOrders));

        [HttpGet("{id:int}", Name = "GetCustomer")]
        public async Task<ActionResult<Customer>> GetCustomer(int id, bool includeOrders = false)
            => Ok(await _repository.GetCustomerAsync(id, includeOrders));

        [HttpPost]
        public async Task<ActionResult<Customer>> AddCustomer([FromBody] Customer customer)
        {
            var result = await _repository.AddCustomerAsync(customer);
            return CreatedAtRoute("GetCustomer", new { result.Id }, result);
        }
    }
}
