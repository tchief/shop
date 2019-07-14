using System.Collections.Generic;
using System.Threading.Tasks;
using Shop.Application.Dto;

namespace Shop.Domain
{
    public interface ICustomersRepository
    {
        Task<IEnumerable<CustomerDto>> GetCustomersAsync(bool includeOrders = false);
        Task<CustomerDto> GetCustomerAsync(int id, bool includeOrders = false);
        Task<IEnumerable<CustomerDto>> GetCustomersByNameAsync(string name, bool includeOrders = false);

        Task<IEnumerable<OrderDto>> GetOrdersAsync(int customerId);
        Task<OrderDto> GetOrderAsync(int customerId, int orderId);

        Task<CustomerDto> AddCustomerAsync(CustomerDto customer);
        Task<OrderDto> AddOrderAsync(int customerId, OrderDto order);

        Task DeleteCustomerAsync(int id);
    }
}