﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Dto;
using Shop.Domain;
using Shop.Domain.Entities;
using Shop.Persistence;
using Xunit;

namespace Shop.Tests.Persistence
{
    [Collection("DbContextFixtureCollection")]
    public class OrdersRepositoryTests : IClassFixture<DbContextFixture>
    {
        private readonly IMapper _mapper;
        private readonly DbContextOptions<CustomersDbContext> _options;
        public OrdersRepositoryTests(DbContextFixture fixture)
        {
            _options = fixture.Options;

            var profile = new EntitiesToDtoMappingsProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(profile));
            _mapper = new Mapper(configuration);
        }

        [Fact]
        public async Task GetOrders_ExistingCustomerId_ReturnsOrders()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = (await repository.GetOrdersAsync(1111)).ToList();

                result.Should().NotBeEmpty();
                result.First().Id.Should().BeGreaterThan(0);
            }
        }

        [Fact]
        public async Task GetOrders_NonExistingCustomerId_ReturnsNull()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.GetOrdersAsync(999);

                result.Should().BeNull();
            }
        }

        [Fact]
        public async Task GetOrder_ExistingOrderId_ReturnsOrder()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.GetOrderAsync(1111, 1234);

                result.Should().NotBeNull();
                result.Id.Should().Be(1234);
            }
        }

        [Fact]
        public async Task GetOrder_NonExistingOrderId_ReturnsNull()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.GetOrderAsync(1000, 999);

                result.Should().BeNull();
            }
        }

        [Fact]
        public async Task AddOrder_ExistingCustomerValidParams_CreatesAndReturns()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var order = new OrderDto() {Price = 234.45m, CreatedDate = DateTime.Today};
                var repository = new CustomersRepository(context, _mapper);
                var result = await repository.AddOrderAsync(1, order);

                result.Id.Should().BeGreaterThan(0);
                result.Should().BeEquivalentTo(order, opt => opt.Excluding(o => o.Id));
            }
        }

        [Fact]
        public async Task AddOrder_ExistingCustomerInvalidParams_ThrowsException()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var order = new OrderDto() {Price = -234.45m, CreatedDate = DateTime.Today};
                var repository = new CustomersRepository(context, _mapper);
                Func<Task<OrderDto>> result = async () => await repository.AddOrderAsync(1, order);

                await result.Should().ThrowAsync<ValidationException>();
            }
        }

        [Fact]
        public async Task AddOrder_NonExistingCustomerValidParams_ThrowsException()
        {
            using (var context = new CustomersDbContext(_options))
            {
                var order = new OrderDto() {Price = 234.45m, CreatedDate = DateTime.Today};
                var repository = new CustomersRepository(context, _mapper);
                Func<Task<OrderDto>> result = async () => await repository.AddOrderAsync(999, order);

                await result.Should().ThrowAsync<CustomerNotFoundException>();
            }
        }
    }
}