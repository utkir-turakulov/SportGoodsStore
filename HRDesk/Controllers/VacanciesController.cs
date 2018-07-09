using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace HRDesk.Controllers
{
    public class VacanciesController : Controller
    {
        [AllowAnonymous]
        public IActionResult Vacancies()
        {
            return View();
        }
    }
}