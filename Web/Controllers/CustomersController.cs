using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain;
using Shop.Domain.Entities;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersRepository _repository;
        public CustomersController(ICustomersRepository repository) => _repository = repository;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers(bool includeOrders = false)
            => Ok(await _repository.GetCustomersAsync(includeOrders));
    }
}
