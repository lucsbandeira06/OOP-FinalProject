/*Lucas Bandeira*/
/*Student ID: 23884*/
using System;
using System.Collections.Generic;

namespace E_Commerce_lb23884.Models
{
  
        public interface IProductRepository
        {
        IEnumerable<Product> GetAllProduct { get; }
        IEnumerable<Product> GetProductOnSale { get; }
        Product GetProductById(int productId);
    }
    
}
