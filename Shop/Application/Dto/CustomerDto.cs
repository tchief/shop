using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Application.Dto
{
    /// <summary>
    /// Customer in our system.
    /// </summary>
    public class CustomerDto
    {
        /// <summary>
        /// Unique identifier of the customer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Full name of the customer.
        /// </summary>
        /// <example>Elon Musk</example>
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        /// <summary>
        /// Customer's email.
        /// </summary>
        /// <example>elon.musk@mars.com</example>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Orders customer has placed.
        /// </summary>
        public IList<OrderDto> Orders { get; } = new List<OrderDto>();
    }
}