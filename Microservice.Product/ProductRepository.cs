using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservice.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Microservice.Product.Model.Product> products = new List<Microservice.Product.Model.Product>();
        public ProductRepository()
        {
            products.Add(new Microservice.Product.Model.Product
            {
                Id = Guid.NewGuid(),
                Code = "P0001",
                Name = "Lenovo Laptop",
                Quantity_In_Stock = 15,
                Unit_Price = 125000
            });

            products.Add(new Microservice.Product.Model.Product
            {
                Id = Guid.NewGuid(),
                Code = "P0002",
                Name = "DELL Laptop",
                Quantity_In_Stock = 25,
                Unit_Price = 135000
            });

            products.Add(new Microservice.Product.Model.Product
            {
                Id = Guid.NewGuid(),
                Code = "P0003",
                Name = "HP Laptop",
                Quantity_In_Stock = 20,
                Unit_Price = 115000
            });
        }
        public Task<List<Microservice.Product.Model.Product>> GetAllProducts()
        {
            return Task.FromResult(products);
        }
    }
}
