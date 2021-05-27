using System;
using System.Linq;
using System.Collections.Generic;
using backendApi.Models;
using backendApi.Data.Interfaces;

namespace backendApi.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository() {
            _products = new List<Product>();
        }
        
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var index = _products.FindIndex(0, 1, x=> x.Id == product.Id);
            _products[index] = product;
        }

        public IEnumerable<Product> ListProducts()
        {
            return _products;
        }

        public Product GetProductById(Guid id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }
    }
}