using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        [Range(double.Epsilon, 99999.99, ErrorMessage = "We support {0} only from {1} to {2} for now.")]
        public decimal Price { get; set; }

        [Range(typeof(DateTime), "1/1/1900", "1/1/2100", ErrorMessage = "We support {0} only from {1} to {2} for now.")]
        public DateTime CreatedDate { get; set; }

        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}