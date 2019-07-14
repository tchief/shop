using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public IList<Order> Orders { get; } = new List<Order>();
    }
}