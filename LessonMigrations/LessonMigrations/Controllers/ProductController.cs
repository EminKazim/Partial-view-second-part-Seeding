using LessonMigrations.Data;
using LessonMigrations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.ProductCount =  _context.Products.Where(p => p.İsDeleted == false).Count();
            List<Product> products = await _context.Products.Where(m => m.İsDeleted == false)
                  .Include(m => m.Category)
                  .Include(m => m.ProductImages)
                  .OrderByDescending(m => m.Id)
                  .Take(8)
                  .ToListAsync();
            return View(products);
        }
        public async  Task<IActionResult> LoadMore(int  skip)
        {
            List<Product> products = await _context.Products.Where(m => m.İsDeleted == false)
                 .Include(m => m.Category)
                 .Include(m => m.ProductImages)
                 .OrderByDescending(m => m.Id)
                 .Skip(skip)
                 .Take(4)
                 .ToListAsync();
            return PartialView("_ProductsPartial", products);
        }

    }
}
