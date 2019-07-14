using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain;
using Shop.Domain.Entities;
using System.Linq;
using AutoMapper;
using Shop.Application.Dto;

namespace Shop.Persistence
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly CustomersDbContext _context;
        private readonly IMapper _mapper;

        public CustomersRepository(CustomersDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomerDto> GetCustomerAsync(int id, bool includeOrders = false)
        {
            var result = await _context.Customers
                .IncludeIf(c => c.Orders, includeOrders)
                .SingleOrDefaultAsync(c => c.Id == id);
            return _mapper.Map<CustomerDto>(result);
        }

        public async Task<IEnumerable<CustomerDto>> GetCustomersAsync(string name = null, bool includeOrders = false)
        {
            var query = _context.Customers.IncludeIf(c => c.Orders, includeOrders);

            if (!string.IsNullOrWhiteSpace(name))
            {
                var nameUpper = name.ToUpper();
                query = query.Where(c => c.Name.ToUpper().Contains(nameUpper));
            }

            return await query.Select(o => _mapper.Map<CustomerDto>(o)).ToArrayAsync();
        }

        public async Task<IEnumerable<OrderDto>> GetOrdersAsync(int customerId)
        {
            var customer = await GetCustomerAsync(customerId);
            if (customer == null) return null;
            return await _context.Orders.Where(o => o.CustomerId == customerId)
                .Select(o => _mapper.Map<OrderDto>(o))
                .ToArrayAsync();
        }

        public async Task<OrderDto> GetOrderAsync(int customerId, int orderId)
        {
            var result = await _context.Orders.SingleOrDefaultAsync(o => o.CustomerId == customerId && o.Id == orderId);
            return _mapper.Map<OrderDto>(result);
        }

        public async Task<CustomerDto> AddCustomerAsync(CustomerDto customer)
        {
            var entity = _mapper.Map<Customer>(customer);

            _context.Customers.Add(entity);
            await _context.SaveChangesAsync();

            customer.Id = entity.Id;
            return customer;
        }

        public async Task<OrderDto> AddOrderAsync(int customerId, OrderDto order)
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.Id == customerId); 
            if (customer == null) throw new CustomerNotFoundException(customerId);

            var entity = _mapper.Map<Order>(order);
            entity.CustomerId = customerId;

            _context.Orders.Add(entity);
            await _context.SaveChangesAsync();

            order.Id = entity.Id;
            return order;
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var customer = await _context.Customers.SingleOrDefaultAsync(c => c.Id == id);
            if (customer == null) throw new CustomerNotFoundException(id);

            _context.Customers.Remove(customer);

            await _context.SaveChangesAsync();
        }
    }
}