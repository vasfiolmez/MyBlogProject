using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.PresentationLayer.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
