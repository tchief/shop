using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Shop.Application.Dto;
using Shop.Domain;
using Shop.Domain.Entities;
using Shop.Web.Controllers;
using Xunit;

namespace Shop.Tests.Web
{
    public class OrdersControllerTests
    {
        [Fact]
        public async Task GetOrders_ValidCustomerId_ReturnsOk()
        {
            var orders = new [] { new OrderDto() { Price = 234.45m, CreatedDate = DateTime.Today } };

            var mapper = Substitute.For<IMapper>();
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetOrdersAsync(1).Returns(orders);

            var controller = new OrdersController(mockRepository);

            var response = await controller.GetOrders(1);

            response.Should().NotBeNull();
            response.Result.Should().BeOfType<OkObjectResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.OK);

            var ok = response.Result as OkObjectResult;
            ok.Value.Should().BeAssignableTo<IEnumerable<OrderDto>>();
            ok.Value.Should().BeEquivalentTo(orders, opt => opt.IgnoringCyclicReferences());

            await mockRepository.Received().GetOrdersAsync(1);
        }

        [Fact]
        public async Task GetOrder_ValidId_ReturnsOk()
        {
            var order = new OrderDto() { Price = 234.45m, CreatedDate = DateTime.Today, Id = 1 };
                
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetOrderAsync(1, 1).Returns(order);

            var controller = new OrdersController(mockRepository);

            var response = await controller.GetOrder(1, 1);

            response.Should().NotBeNull();
            response.Result.Should().BeOfType<OkObjectResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.OK);

            var ok = response.Result as OkObjectResult;
            ok.Value.Should().BeOfType<OrderDto>();
            ok.Value.Should().BeEquivalentTo(order, opt => opt.IgnoringCyclicReferences());

            await mockRepository.Received().GetOrderAsync(1, 1);
        }

        [Fact]
        public async Task AddOrder_ValidParams_ReturnsCreated()
        {
            var order = new OrderDto() { Price = -234.45m, CreatedDate = DateTime.Today };
            var orderWithId = new OrderDto() { Id = 1, Price = -234.45m, CreatedDate = DateTime.Today };

            var mapper = Substitute.For<IMapper>();
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.AddOrderAsync(1, order).Returns(orderWithId);

            var controller = new OrdersController(mockRepository);

            var response = await controller.AddOrder(1, order);

            response.Should().NotBeNull();
            response.Result.Should().BeOfType<CreatedAtRouteResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.Created);

            var ok = response.Result as CreatedAtRouteResult;
            ok.RouteValues["Id"].Should().Be(orderWithId.Id);
            ok.Value.Should().BeOfType<OrderDto>();
            ok.Value.Should().BeEquivalentTo(orderWithId, opt => opt.IgnoringCyclicReferences());

            await mockRepository.Received().AddOrderAsync(1, order);
        }

        [Fact]
        public async Task AddOrder_InvalidParams_ReturnsBadRequest()
        {
            var order = new OrderDto() { Price = -234.45m, CreatedDate = DateTime.Today };

            var mapper = Substitute.For<IMapper>();
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.AddOrderAsync(1, order).Throws<ValidationException>();

            var controller = new OrdersController(mockRepository);

            Func<Task<ActionResult<OrderDto>>> response = async () => await controller.AddOrder(1, order);

            await response.Should().ThrowAsync<ValidationException>();

            await mockRepository.Received().AddOrderAsync(1, order);
        }
    }
}
