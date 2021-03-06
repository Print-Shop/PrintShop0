﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrintShop0.Models;
using PrintShop0.ViewModels;

namespace PrintShop0.Controllers
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

        //public ViewResult List()
        //{
        //    ProductsListViewModel productsListViewModel = new ProductsListViewModel();
        //    productsListViewModel.Products = _productRepository.AllProducts;
        //    productsListViewModel.CurrentCategory = "Products";
        //    return View(productsListViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.AllProducts.OrderBy(p => p.ProductId);
                currentCategory = "All products";
            }
            else
            {
                products = _productRepository.AllProducts.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ProductId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new ProductsListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if(product == null)
                return NotFound();
            return View(product);
        }
    }
}
