using Microsoft.AspNetCore.Mvc;

namespace FrontEndThemes.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
