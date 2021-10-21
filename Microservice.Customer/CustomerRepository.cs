using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<Microservice.Customer.Model.Customer> customers = new List<Microservice.Customer.Model.Customer>();
        public CustomerRepository()
        {
            customers.Add(new Microservice.Customer.Model.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Joydip",
                LastName = "Kanjilal",
                EmailAddress = "joydipkanjilal@yahoo.com"
            });

            customers.Add(new Microservice.Customer.Model.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Steve",
                LastName = "Smith",
                EmailAddress = "stevesmith@yahoo.com"
            });
        }

        public Task<List<Microservice.Customer.Model.Customer>> GetAllCustomers()
        {
            return Task.FromResult(customers);
        }
    }
}
