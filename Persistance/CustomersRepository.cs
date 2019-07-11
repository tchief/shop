using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.Domain.Entities;

namespace Shop.Persistance
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly CustomersDbContext _context;
        public CustomersRepository(CustomersDbContext context) => _context = context;

        public async Task<IEnumerable<Customer>> GetCustomersAsync(bool includeOrders = false) 
            => await _context.Customers.IncludeIf(c => c.Orders, includeOrders).ToArrayAsync();

        public async Task<Customer> GetCustomerAsync(int id, bool includeOrders = false) 
            => await _context.Customers
                .IncludeIf(c => c.Orders, includeOrders)
                .SingleOrDefaultAsync(c => c.Id == id);

        public Task<IEnumerable<Order>> GetOrdersAsync(int customerId)
            => throw new System.NotImplementedException();

        public Task AddCustomerAsync(Customer customer)
            => throw new System.NotImplementedException();

        public Task AddOrderAsync(Order order) 
            => throw new System.NotImplementedException();
    }
}