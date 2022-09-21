using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using ETicaretWebUI.Models;
using ETicaretWebUI.Models.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var listViewModel = new ProductListViewModel
            {
                Products = _productService.GetProductWithCategoryName()
            };
            ViewData["ProductCount"] = listViewModel.Products.Data.Count().ToString();
            return View(listViewModel);
        }
        [HttpGet]
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                var productModel = new ProductListViewModel
                {
                    Categories = _categoryService.GetCategoriesSelect()
                };
                return View(productModel);
            }
            else
            {
                var productModel = new ProductListViewModel
                {
                    Categories = _categoryService.GetCategoriesSelect(),
                    Product = _productService.GetById(id)
                };
                return View(productModel);
            }
        }

        [HttpPost]
        public IActionResult AddOrEdit(ProductListViewModel productListViewModel)
        {
            if (productListViewModel.Product.ProductId > 0)
            {
                _productService.Update(productListViewModel.Product);
            }
            else
            {
                _productService.Add(productListViewModel.Product);
            }
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "Index", _productService.GetProductWithCategoryName()) });
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var productModel = new ProductListViewModel
            {
                Product = _productService.GetById(id)
            };
            return View(productModel);
        }


        [HttpPost]
        public IActionResult Delete(ProductListViewModel productListViewModel)
        {
            _productService.Delete(productListViewModel.Product.ProductId);
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "Index", _productService.GetProductWithCategoryName()) });
        }
    }
}
