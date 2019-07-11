using System;

namespace Shop.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public Customer Customer { get; set; }
    }
}