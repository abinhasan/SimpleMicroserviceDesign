using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Customer
{
    public interface ICustomerRepository
    {
        public Task<List<Microservice.Customer.Model.Customer>> GetAllCustomers();
    }

}
