/*Lucas Bandeira*/
/*Student ID: 23884*/
using System;
using System.Collections.Generic;

namespace E_Commerce_lb23884.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
