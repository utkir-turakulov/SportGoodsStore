using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRDesk.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SportStore.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationContext _context;

        public ProductController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Product()
        {
            var products = await _context.Products.ToListAsync();

            return View(products);
        }

        [HttpGet]
        public IActionResult Manage()
        {
            return View();
        }


    }
}