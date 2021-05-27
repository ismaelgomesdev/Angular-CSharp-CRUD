using System;

namespace backendApi.Models
{
    public class Product
    {
        public Product() {
            Id = Guid.NewGuid();
        }
        
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}