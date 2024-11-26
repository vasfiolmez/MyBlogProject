﻿using Microsoft.AspNetCore.Mvc;
using MyBlogProject.BusinessLayer.Abstract;

namespace MyBlogProject.PresentationLayer.ViewComponents
{
    public class _DefaultArticleListComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            return View(values);
        }
    }
}
