using System;
using System.Linq;

namespace MvvmDemo
{
    public class MockCustomerServiceAgent : ICustomerServiceAgent
    {
        // Create a fake customer
        public Customer CreateCustomer()
        {
            return new Customer
            {
                CustomerId = 1,
                CustomerName = "John Doe",
                City = "Dallas"
            };
        }
    }
}
