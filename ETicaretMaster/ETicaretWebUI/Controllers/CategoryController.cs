using Business.Abstract;
using Entities.Concrete;
using ETicaretWebUI.Models;
using ETicaretWebUI.Models.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretWebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var categoryModel = new CategoryListViewModel
            {
                Categories = _categoryService.GetList()
            };
            ViewData["CategoryCount"] = categoryModel.Categories.Data.Count().ToString();
            return View(categoryModel);
        }
        [HttpGet]
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View();
            }
            else
            {
                var categoryModel = new CategoryListViewModel
                {
                    Category = _categoryService.GetById(id)
                };
                return View(categoryModel);
            }
        }
        [HttpPost]
        public IActionResult AddOrEdit(CategoryListViewModel categoryListViewModel)
        {
            if (categoryListViewModel.Category.CategoryId > 0)
            {
                _categoryService.Update(categoryListViewModel.Category);
            }
            else
            {
                _categoryService.Add(categoryListViewModel.Category);
            }
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "Index", _categoryService.GetList()) });
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var categoryModel = new CategoryListViewModel
            {
                Category = _categoryService.GetById(id)
            };
            return View(categoryModel);
        }


        [HttpPost]
        public IActionResult Delete(CategoryListViewModel categoryListViewModel)
        {
            _categoryService.Delete(categoryListViewModel.Category.CategoryId);
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "Index", _categoryService.GetList()) });
        }
    }
}
