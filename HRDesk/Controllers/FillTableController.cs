using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDesk.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportStore.Controllers
{
    /// <summary>
    /// Контроллер для добавления записей в таблицу 
    /// </summary>
    public class FillTableController : Controller
    {
        ApplicationContext _context;

        public FillTableController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var images = await _context.Images.ToListAsync();
            var sizes = await _context.Sizes.ToListAsync();
            var sections = await _context.Sections.ToListAsync();
            var divisions = await _context.Divisions.ToListAsync();

            ViewBag.Images = images;
            ViewBag.Sizes = sizes;
            ViewBag.Sections = sections;
            ViewBag.Divisions = divisions;

            return View("FillTableView");
        }

        [HttpGet]
        public async Task<IActionResult> GetImages()
        {
             var images = await _context.Images.ToListAsync();

            return View();
        }
    }
}
