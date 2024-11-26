using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
