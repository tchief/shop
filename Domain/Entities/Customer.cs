using System.Collections.Generic;

namespace Shop.Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public IList<Order> Orders { get; private set; } = new List<Order>();
    }
}