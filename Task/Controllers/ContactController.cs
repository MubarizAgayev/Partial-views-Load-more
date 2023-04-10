using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {

            ContactHeader contactHeader = await _context.ContactHeaders.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            ContactHeaderImg contactHeaderImg = await _context.ContactHeaderImgs.Where(m => !m.SoftDelete).FirstOrDefaultAsync();

            ContactVM model = new ContactVM()
            {
                ContactHeader = contactHeader,
                ContactHeaderImg = contactHeaderImg
            };
            return View(model);
        }
    }
}
