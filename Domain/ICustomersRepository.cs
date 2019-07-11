using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Domain.Entities;

namespace Shop.Domain
{
    public interface ICustomersRepository
    {
        Task<IEnumerable<Customer>> GetCustomersAsync(bool includeOrders = false);
        Task<Customer> GetCustomerAsync(int id);

        Task<IEnumerable<Order>> GetOrdersAsync(int customerId);

        Task AddCustomerAsync(Customer customer);
        Task AddOrderAsync(Order order);
    }
}