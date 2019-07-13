using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FluentAssertions;
using Shop.Domain.Entities;
using Xunit;

namespace Shop.Tests.Domain
{
    public class CustomerTests
    {
        [Fact]
        public void Validate_AllPropertiesValid_ErrorsListEmpty()
        {
            var customer = new Customer() { Id = 1, Name = "Elon Musk", Email = "elon.musk@mars.com" };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(customer, new ValidationContext(customer), result, true);

            isValid.Should().BeTrue();
            result.Should().BeEmpty();
        }

        [Fact]
        public void Validate_NameMissing_ErrorsListContainsName()
        {
            var customer = new Customer() { Id = 1, Email = "elon.musk@mars.com" };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(customer, new ValidationContext(customer), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Name");
        }

        [Fact]
        public void Validate_EmailMissing_ErrorsListContainsEmail()
        {
            var customer = new Customer() { Id = 1, Name = "Elon Musk" };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(customer, new ValidationContext(customer), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Email");
        }

        [Fact]
        public void Validate_EmailInvalid_ErrorsListContainsEmail()
        {
            var customer = new Customer() { Id = 1, Name = "Elon Musk", Email = "elon.musk_goes_to_mars.com" };
            var result = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(customer, new ValidationContext(customer), result, true);

            isValid.Should().BeFalse();
            result.Should().ContainSingle();
            result[0].MemberNames.FirstOrDefault().Should().Be("Email");
        }
    }
}
