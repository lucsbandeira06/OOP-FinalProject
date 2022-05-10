/*Lucas Bandeira*/
/*Student ID: 23884*/
using System;
using System.Collections.Generic;

namespace E_Commerce_lb23884.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
        new Category{CategoryId=1,CategoryName="Electronics",CategoryDescription="Electronic products"},
        new Category{CategoryId=2,CategoryName="Furniture",CategoryDescription="Furniture products"},
        new Category{CategoryId=3,CategoryName="Sports",CategoryDescription="Sports products"}
        };
    }
}
