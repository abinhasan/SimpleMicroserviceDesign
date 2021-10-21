using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Product
{
    public interface IProductRepository
    {
        public Task<List<Microservice.Product.Model.Product>> GetAllProducts();
    }
}
