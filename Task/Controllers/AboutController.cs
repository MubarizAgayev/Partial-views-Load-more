using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {


            AboutSlider aboutSlider = await _context.AboutSliders.Where(m=>!m.SoftDelete).FirstAsync();

            AboutSliderInfo aboutSliderInfo = await _context.AboutSliderInfos.Where(m => !m.SoftDelete).FirstAsync();
            List<AboutMembers> aboutMembers = await _context.AboutMembers.Where(m=>!m.SoftDelete).ToListAsync();
            List<AboutMemberInfo> aboutMemberInfos = await _context.AboutMemberInfos.Where(m => !m.SoftDelete).ToListAsync();

            AboutVM model = new AboutVM()
            {
                AboutSlider = aboutSlider,
                AboutSliderInfo = aboutSliderInfo,
                AboutMemberInfos = aboutMemberInfos,
                AboutMembers= aboutMembers
            };

            return View(model);
        }
    }
}
