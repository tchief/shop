using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.Domain.Entities;
using System.Linq;

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

        public async Task<IEnumerable<Order>> GetOrdersAsync(int customerId)
        {
            var customer = await GetCustomerAsync(customerId);
            if (customer == null) return null;
            return await _context.Orders.Where(o => o.CustomerId == customerId).ToArrayAsync();
        }

        public async Task<Order> GetOrderAsync(int orderId)
            => await _context.Orders.SingleOrDefaultAsync(o => o.Id == orderId);

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            var entity = new Customer
            {
                Name = customer.Name,
                Email = customer.Email
            };

            _context.Customers.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<Order> AddOrderAsync(int customerId, Order order)
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.Id == customerId); 
            if (customer == null) throw new CustomerNotFoundException(customerId);

            var entity = new Order
            {
                Price = order.Price,
                CreatedDate = order.CreatedDate,
                CustomerId = customerId
            };

            _context.Orders.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}