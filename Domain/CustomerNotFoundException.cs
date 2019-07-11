using System;

namespace Shop.Domain
{
    public class CustomerNotFoundException : Exception
    {
        public CustomerNotFoundException(int id)
            : base($"Customer with Id={id} was not found.")
        {
        }
    }
}