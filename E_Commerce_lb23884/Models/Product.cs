/*Lucas Bandeira*/
/*Student ID: 23884*/
using System;
namespace E_Commerce_lb23884.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
    }

