using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentAssertions;
using Shop.Domain.Entities;
using Xunit;

namespace Shop.Tests.Domain
{
    public class OrderTests
    {
        [Fact]
        public void Validate_AllPropertiesValid_ErrorsListEmpty()
        {
            var order = new Order() { Id = 1, Price = 234.45m, CreatedDate = DateTime.Today, CustomerId = 1 };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeTrue();
            result.Should().BeEmpty();
        }

        [Fact]
        public void Validate_PriceMissing_ErrorsListContainsPrice()
        {
            var order = new Order() { Id = 1, CreatedDate = DateTime.Today, CustomerId = 1 };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Price");
        }

        [Fact]
        public void Validate_PriceLessThanZero_ErrorsListContainsPrice()
        {
            var order = new Order() { Id = 1, Price = -234.45m, CreatedDate = DateTime.Today, CustomerId = 1 };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Price");
        }

        [Fact]
        public void Validate_CreatedDateMissing_ErrorsListContainsCreatedDate()
        {
            var order = new Order() { Id = 1, Price = 234.45m, CustomerId = 1 };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("CreatedDate");
        }

        [Fact]
        public void Validate_CreatedDateLessThan1900_ErrorsListContainsCreatedDate()
        {
            var order = new Order() { Id = 1, Price = 234.45m, CreatedDate = new DateTime(1899, 1, 1), CustomerId = 1 };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(order, new ValidationContext(order), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("CreatedDate");
        }
    }
}
