using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Entities
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Range(double.Epsilon, 99999.99, ErrorMessage = "We support {0} only from {1} to {2} for now.")]
        public decimal Price { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2100", ErrorMessage = "We support {0} only from {1} to {2} for now.")]
        public DateTime CreatedDate { get; set; }

        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}