using Microsoft.AspNetCore.Mvc;

namespace MVC_Project_DEMO.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
