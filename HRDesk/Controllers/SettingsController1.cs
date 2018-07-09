using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRDesk.Controllers
{
    [Authorize(Roles ="admin, master")]
    public class SettingsController : Controller
    {
        // GET: /<controller>/
        public IActionResult AdminSettings()
        {
            return View();
        }
    }
}
