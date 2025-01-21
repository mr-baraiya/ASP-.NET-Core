using Microsoft.AspNetCore.Mvc;

namespace FrontEndThemes.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Elements()
        {
            return View();
        }
    }
}
