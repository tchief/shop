using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
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
    public class CustomersControllerTests
    {
        [Fact]
        public async Task GetCustomers_Always_ReturnsOk()
        {
            var customers = new [] { new CustomerDto() { Id = 1, Name = "Elon Musk", Email = "elon.musk@mars.com" } };

            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetCustomersAsync().Returns(customers);

            var controller = new CustomersController(mockRepository);

            var response = await controller.GetCustomers();

            response.Should().NotBeNull();
            response.Result.Should().BeOfType<OkObjectResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.OK);

            var ok = response.Result as OkObjectResult;
            ok.Value.Should().BeAssignableTo<IEnumerable<CustomerDto>>();
            ok.Value.Should().BeEquivalentTo(customers, opt => opt.IgnoringCyclicReferences());

            await mockRepository.Received().GetCustomersAsync();
        }

        [Fact]
        public async Task GetCustomer_ValidId_ReturnsOk()
        {
            var customer = new CustomerDto() { Id = 1, Name = "Elon Musk", Email = "elon.musk@mars.com" };

            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetCustomerAsync(customer.Id).Returns(customer);

            var controller = new CustomersController(mockRepository);

            var response = await controller.GetCustomer(customer.Id);

            response.Should().NotBeNull();
            response.Result.Should().BeOfType<OkObjectResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.OK);

            var ok = response.Result as OkObjectResult;
            ok.Value.Should().BeOfType<CustomerDto>();
            ok.Value.Should().BeEquivalentTo(customer,
                opt => opt.IgnoringCyclicReferences().Excluding(c => c.Orders));

            await mockRepository.Received().GetCustomerAsync(customer.Id);
        }

        [Fact]
        public async Task AddCustomer_ValidParams_ReturnsCreated()
        {
            var customer = new CustomerDto() { Name = "Elon Musk", Email = "elon.musk@mars.com" };
            var customerWithId = new CustomerDto() { Id = 1, Name = "Elon Musk", Email = "elon.musk@mars.com" };

            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.AddCustomerAsync(customer).Returns(customerWithId);

            var controller = new CustomersController(mockRepository);

            var response = await controller.AddCustomer(customer);

            response.Should().NotBeNull();
            response.Result.Should().BeOfType<CreatedAtRouteResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.Created);

            var ok = response.Result as CreatedAtRouteResult;
            ok.RouteValues["Id"].Should().Be(customerWithId.Id);
            ok.Value.Should().BeOfType<CustomerDto>();
            ok.Value.Should().BeEquivalentTo(customerWithId,
                opt => opt.IgnoringCyclicReferences().Excluding(c => c.Orders));

            await mockRepository.Received().AddCustomerAsync(customer);
        }

        [Fact]
        public async Task AddCustomer_InvalidParams_ReturnsBadRequest()
        {
            var customer = new CustomerDto() { Name = "Elon Musk", Email = "elon.musk.mars.com" };

            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.AddCustomerAsync(customer).Throws<ValidationException>();

            var controller = new CustomersController(mockRepository);

            Func<Task<ActionResult<CustomerDto>>> response = async () => await controller.AddCustomer(customer);

            await response.Should().ThrowAsync<ValidationException>();

            await mockRepository.Received().AddCustomerAsync(customer);
        }
    }
}
