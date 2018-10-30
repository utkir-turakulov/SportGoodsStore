using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HRDesk.Data;
using HRDesk.Models;
using System.Linq;

namespace HRDesk.Controllers
{
    public class InterviewsController : Controller
    {
      /*  private ApplicationContext _context;

        public InterviewsController(ApplicationContext context)
        {
            _context = context;
        }

        [Authorize(Roles ="admin, master")]
        public IActionResult Interviews()
        {
            ViewBag.Vacancies = _context.Vacancies;

            return View(_context.Interviews);
        }

        public IActionResult AddInterview()
        {
            ViewBag.Vacancies = (from c in _context.Vacancies where c.ClosedDate < c.OpenDate select c);
            return View();
        }

        [HttpPost]
        public IActionResult AddInterview(Interview model)
        {
            if (ModelState.IsValid)
            {
                Interview interview = new Interview()
                {
                    BirthDate = model.BirthDate,
                    PersonName = model.PersonName,
                    PersonPatronymic = model.PersonPatronymic,
                    PersonSername = model.PersonSername,
                    InterviewDate = model.InterviewDate,
                    VacancyId = model.VacancyId
                };

                interview.Vacancy = (from c in _context.Vacancies where c.Id == model.VacancyId select c).Single();

                _context.Interviews.Add(model);
                _context.SaveChanges();
                return Redirect("Interviews");
            }
            return View(model);
        }
        */
    }
}