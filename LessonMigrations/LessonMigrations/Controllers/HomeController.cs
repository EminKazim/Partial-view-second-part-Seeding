using LessonMigrations.Data;
using LessonMigrations.Models;
using LessonMigrations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigration.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderDetail detail = await _context.SliderDetails.FirstOrDefaultAsync();
            List<Category> categories = await _context.Categories.Where(m=>m.İsDeleted==false).ToListAsync();
            List<Product> products = await _context.Products.Where(m=>m.İsDeleted==false)
                .Include(m => m.Category)
                .Include(m => m.ProductImages)
                .OrderByDescending(m=>m.Id)
                .Take(8)
                .ToListAsync();
            List<GiftVideo> giftVideos = await _context.GiftVideos.ToListAsync();
            List<GiftHead> giftHeads = await _context.GiftHeads.ToListAsync();
            List<GiftFooter> giftFooters = await _context.GiftFooters.ToListAsync();
            List<Carousel> carousels = await _context.Carousels.ToListAsync();
            List<Expert> experts = await _context.Experts.ToListAsync();
            List<Blog> blogs = await _context.Blogs.ToListAsync();
            List<Instagram> instagrams = await _context.Instagrams.ToListAsync();
            HomeVM homeVM = new HomeVM
            {
                Sliders = sliders,
                Detail = detail,
                Categories= categories,
                Products = products,
                Carousels=carousels,
                GiftVideos=giftVideos,
                GiftHeads=giftHeads,
                GiftFooters=giftFooters,
                Experts=experts,
                Blogs=blogs,
                Instagrams=instagrams
            };

            return View(homeVM);
        }
    }
}
