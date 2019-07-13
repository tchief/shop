using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain.Entities;

namespace Shop.Domain
{
    public interface ICustomersRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync(bool includeOrders = false);
        Task<Customer> GetCustomerAsync(int id, bool includeOrders = false);

        Task<IEnumerable<Order>> GetOrdersAsync(int customerId);
        Task<Order> GetOrderAsync(int customerId, int orderId);

        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Order> AddOrderAsync(int customerId, Order order);
    }
}