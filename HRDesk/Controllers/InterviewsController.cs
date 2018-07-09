using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace HRDesk.Controllers
{
    public class InterviewsController : Controller
    {
        [Authorize(Roles ="admin, master")]
        public IActionResult Interviews()
        {
            return View();
        }
    }
}