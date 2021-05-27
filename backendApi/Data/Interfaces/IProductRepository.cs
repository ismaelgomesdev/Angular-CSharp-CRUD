using System;
using System.Collections.Generic;
using backendApi.Models;

namespace backendApi.Data.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);

        void UpdateProduct(Product product);

        IEnumerable<Product> ListProducts();

        Product GetProductById(Guid id);

        void RemoveProduct(Product product);

    }
}