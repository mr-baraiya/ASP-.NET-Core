using Microsoft.AspNetCore.Mvc;

namespace FrontEndThemes.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
