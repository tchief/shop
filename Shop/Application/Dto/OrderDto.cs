using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    /// <summary>
    /// Order someone placed in our system.
    /// </summary>
    public class OrderDto
    {
        /// <summary>
        /// Unique identifier of the order.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Price for the order.
        /// </summary>
        /// <example>450.45</example>
        [Required]
        [Range(double.Epsilon, 99999.99, ErrorMessage = "We support {0} only from {1} to {2} for now.")]
        public decimal Price { get; set; }

        /// <summary>
        /// Date order was made.
        /// </summary>
        /// <example>2019-02-13</example>
        [Required]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2100", ErrorMessage = "We support {0} only from {1} to {2} for now.")]
        public DateTime CreatedDate { get; set; }
    }
}
