using Microsoft.AspNetCore.Mvc;

namespace FrontEndThemes.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
