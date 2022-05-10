/*Lucas Bandeira*/
/*Student ID: 23884*/

using System;

using System.Collections.Generic;

namespace E_Commerce_lb23884.Models
{
    public class Category
    {
      public int CategoryId { get; set; }
      public string CategoryName { get; set; }
      public string CategoryDescription { get; set; }
      public List<Product> Products { get; set; }
    }
}
