using System;
using E_Commerce_lb23884.Models;
using E_Commerce_lb23884.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_lb23884.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;


        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
            {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            }


        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "BestSellers";
            //return View(_productRepository.GetAllProduct);

            var productListViewModel = new ProductListViewModel();
            productListViewModel.Products = _productRepository.GetAllProduct;
            productListViewModel.CurrentCategory = "BestSellers";

            return View(productListViewModel);

        }
    }
}
