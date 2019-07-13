using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Routing;
using NSubstitute;
using Shop.Controllers;
using Shop.Domain;
using Shop.Domain.Entities;
using Shop.Web.Controllers;
using Shop.Web.Filters;
using Xunit;

namespace Shop.Tests.Web
{
    public class NotFoundFilterTests
    {
        [Fact]
        public async Task GetCustomer_InvalidId_ReturnsNotFound()
        {
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetCustomerAsync(Arg.Any<int>()).Returns((Customer)null);
            var controller = new CustomersController(mockRepository);

            var response = await controller.GetCustomer(1);

            ActAndAssertForNotFoundResponse(response, controller);
        }

        [Fact]
        public async Task GetOrder_InvalidId_ReturnsNotFound()
        {
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetOrderAsync(Arg.Any<int>()).Returns((Order)null);
            var controller = new OrdersController(mockRepository);

            var response = await controller.GetOrder(1);

            ActAndAssertForNotFoundResponse(response, controller);
        }

        [Fact]
        public async Task GetOrders_InvalidCustomerId_ReturnsNotFound()
        {
            var mockRepository = Substitute.For<ICustomersRepository>();
            mockRepository.GetOrdersAsync(Arg.Any<int>()).Returns((IEnumerable<Order>)null);
            var controller = new OrdersController(mockRepository);

            var response = await controller.GetOrders(1);

            ActAndAssertForNotFoundResponse(response, controller);
        }

        private static void ActAndAssertForNotFoundResponse<T>(ActionResult<T> response, object controller)
        {
            var responseResult = ((IConvertToActionResult)response).Convert();
            var actionContext = new ActionContext()
            {
                HttpContext = new DefaultHttpContext(),
                RouteData = new RouteData(),
                ActionDescriptor = new ActionDescriptor()
            };

            var executingContext =
                new ResultExecutingContext(actionContext, new List<IFilterMetadata>(), responseResult, controller);
            var attribute = new NotFoundResultFilterAttribute();

            // Act
            attribute.OnResultExecuting(executingContext);

            var result = (NotFoundResult)executingContext.Result;
            result.Should().NotBeNull();
            result.Should().BeOfType<NotFoundResult>()
                .Which.StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }
    }
}
