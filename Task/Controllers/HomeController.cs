using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Task.Data;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }




        public async Task<IActionResult> IndexAsync()
        {

            Slider sliders = await _context.Sliders.FirstOrDefaultAsync();

            List<SlideInfo> sliderInfo = await _context.SlideInfos.Where(m=>!m.SoftDelete).ToListAsync();

            List<Services> services= await _context.Services.Where(m => !m.SoftDelete).ToListAsync();

            

            List<RecentWorks> recentWorks = await _context.RecentWorks.Where(m => !m.SoftDelete).ToListAsync();

            List<RecentWorkImgs> recentWorkImgs = await _context.RecentWorkImgs.Where(m => !m.SoftDelete).ToListAsync();

            List<Category> categories = await _context.Categories.Where(m => !m.SoftDelete).ToListAsync();
            List<Works> works = await _context.Works.Where(m => !m.SoftDelete).ToListAsync();
            List<WorksImg> worksImgs = await _context.WorksImgs.Where(m => !m.SoftDelete).ToListAsync();

            HomeVM model = new()
            {
                SlideInfo = sliderInfo,
                Sliders = sliders,
                Services= services,
                RecentWorks = recentWorks,
                RecentWorkImgs = recentWorkImgs,
                Categories = categories,
                Works = works,
                WorksImgs= worksImgs
            };
            return View(model);
        }
    }
}