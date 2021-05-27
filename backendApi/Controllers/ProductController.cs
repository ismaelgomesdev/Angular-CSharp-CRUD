using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using backendApi.Data.Interfaces;
using backendApi.Models;

namespace backendApi.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _product;

        public ProductController(IProductRepository product)
        {
            _product = product;
        }

        [HttpPost("")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _product.AddProduct(product);
            return Ok();
        }

        [HttpGet("")]
        public IActionResult ListProducts()
        {
            return Ok(_product.ListProducts());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _product.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(Guid id, [FromBody] Product product)
        {
            var oldProduct = _product.GetProductById(id);
            if (oldProduct == null)
            {
                return NotFound();
            }
            oldProduct.Name = product.Name;
            oldProduct.Price = product.Price;
            _product.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(Guid id)
        {
            var product = _product.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            _product.RemoveProduct(product);
            return Ok(product);
        }
    }

}