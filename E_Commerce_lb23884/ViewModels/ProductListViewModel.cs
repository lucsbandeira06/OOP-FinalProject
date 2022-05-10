using System;
using System.Collections.Generic;
using E_Commerce_lb23884.Models;

namespace E_Commerce_lb23884.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
