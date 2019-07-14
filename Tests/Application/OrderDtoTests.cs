using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentAssertions;
using Shop.Application.Dto;
using Xunit;

namespace Shop.Tests.Application
{
    public class OrderDtoTests
    {
        [Fact]
        public void Validate_AllPropertiesValid_ErrorsListEmpty()
        {
            var order = new OrderDto() { Id = 1, Price = 234.45m, CreatedDate = DateTime.Today };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeTrue();
            result.Should().BeEmpty();
        }

        [Fact]
        public void Validate_PriceMissing_ErrorsListContainsPrice()
        {
            var order = new OrderDto() { Id = 1, CreatedDate = DateTime.Today };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Price");
        }

        [Fact]
        public void Validate_PriceLessThanZero_ErrorsListContainsPrice()
        {
            var order = new OrderDto() { Id = 1, Price = -234.45m, CreatedDate = DateTime.Today };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Price");
        }

        [Fact]
        public void Validate_CreatedDateMissing_ErrorsListContainsCreatedDate()
        {
            var order = new OrderDto() { Id = 1, Price = 234.45m };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("CreatedDate");
        }

        [Fact]
        public void Validate_CreatedDateLessThan1900_ErrorsListContainsCreatedDate()
        {
            var order = new OrderDto() { Id = 1, Price = 234.45m, CreatedDate = new DateTime(1899, 1, 1) };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("CreatedDate");
        }
    }
}
