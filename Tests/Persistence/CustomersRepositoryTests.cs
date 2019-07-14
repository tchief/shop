using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Dto;
using Shop.Domain.Entities;
using Shop.Persistence;
using Xunit;

namespace Shop.Tests.Persistence
{
    [Collection("DbContextFixtureCollection")]
    public class CustomersRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly IMapper _mapper;
        private readonly DbContextOptions<CustomersDbContext> _options;
        public CustomersRepositoryTests(DbContextFixture fixture)
        {
            _options = fixture.Options;

            var profile = new EntitiesToDtoMappingsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            _mapper = new Mapper(configuration);
        }

        // TODO: Can we eliminate using, via base class or InMemory or Collection or whatever.

        [Fact]
        public async Task GetCustomers_WithoutIncludeOrders_ReturnsCustomersWithoutOrders()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = (await repository.GetCustomersAsync()).ToList();

                result.Should().NotBeEmpty();
                result[0].Orders.Should().BeEmpty();
            }
        }

        [Fact]
        public async Task GetCustomers_WithIncludeOrders_ReturnsCustomersWithOrders()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = (await repository.GetCustomersAsync(true)).ToList();

                result.Should().NotBeEmpty();
                result.SelectMany(c => c.Orders).Should().NotBeEmpty();
            }
        }

        [Fact]
        public async Task GetCustomer_ExistingId_ReturnsCustomerWithoutOrders()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.GetCustomerAsync(1);

                result.Id.Should().Be(1);
                result.Orders.Should().BeEmpty();
            }
        }

        [Fact]
        public async Task GetCustomer_NonExistingId_ReturnsNull()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.GetCustomerAsync(999);

                result.Should().BeNull();
            }
        }

        [Fact]
        public async Task GetCustomer_ExistingIdWithIncludeOrders_ReturnsCustomerWithOrders()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.GetCustomerAsync(1000, true);

                result.Id.Should().Be(1000);
                result.Orders.Should().NotBeEmpty();
            }
        }

        [Fact]
        public async Task AddCustomer_ValidParams_CreatesAndReturns()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var customer = new CustomerDto() {Name = "Elon Musk", Email = "elon.musk@mars.com"};
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.AddCustomerAsync(customer);

                result.Id.Should().BeGreaterThan(0);
                result.Should().BeEquivalentTo(customer, opt => opt.Excluding(c => c.Id));
            }
        }

        [Fact]
        public async Task AddCustomer_InvalidParams_ThrowsException()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var customer = new CustomerDto() {Email = "elon.musk@mars.com"};
                var repository = new CustomersRepository(context, _mapper);
                Func<Task<CustomerDto>> result = async () => await repository.AddCustomerAsync(customer);

                await result.Should().ThrowAsync<Exception>();
            }
        }
    }
}