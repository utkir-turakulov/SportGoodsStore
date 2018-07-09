using Microsoft.AspNetCore.Mvc;

namespace HRDesk.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}