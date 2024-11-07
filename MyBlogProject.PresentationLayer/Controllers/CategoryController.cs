﻿using Microsoft.AspNetCore.Mvc;
using MyBlogProject.BusinessLayer.Abstract;

namespace MyBlogProject.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values=_categoryService.TGetAll();
            return View(values);
        }
    }
}
