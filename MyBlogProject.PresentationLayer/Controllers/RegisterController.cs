using Microsoft.AspNetCore.Mvc;

namespace MyBlogProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
