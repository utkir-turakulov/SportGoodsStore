using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using HRDesk.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HRDesk.Models;
using System;
using System.Linq;

namespace HRDesk.Controllers
{
    public class VacanciesController : Controller
    {
       /* private readonly ApplicationContext _context;

        public VacanciesController(ApplicationContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Vacancies()
        {
            var users = await _context.Vacancies.ToListAsync();
            return View(users);
        }

        public IActionResult CreateVacancy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVacancy(Vacancy model)
        {
            if (ModelState.IsValid)
            {
                Vacancy vacancy = new Vacancy
                {
                    Name = model.Name,
                    OpenDate = model.OpenDate,
                    DesiredClosingDate = model.DesiredClosingDate,
                    ClosedDate = model.ClosedDate
                };

                _context.Vacancies.Add(vacancy);
                _context.SaveChanges();
            }
            return RedirectToAction("Vacancies");
        }

        [HttpPost]
        public IActionResult DeleteVacancy(int? id)
        {
            if (ModelState.IsValid)
            {
                Vacancy vacancy = _context.Vacancies.Where(b => b.Id == id).First();

                if(vacancy != null)
                {
                    vacancy.ClosedDate = DateTime.Today;
                }
                _context.SaveChanges();
            }
            return Redirect("Vacancies");
        }*/
    }
}