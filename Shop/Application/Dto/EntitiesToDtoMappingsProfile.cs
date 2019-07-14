using AutoMapper;
using Shop.Domain.Entities;

namespace Shop.Application.Dto
{
    public class EntitiesToDtoMappingsProfile : Profile
    {
        public EntitiesToDtoMappingsProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            CreateMap<Customer, CustomerDto>().ForMember(c => c.Orders, c => c.MapFrom(d => d.Orders));
            CreateMap<CustomerDto, Customer>().ForMember(c => c.Orders, c => c.MapFrom(d => d.Orders));
        }
    }
}
