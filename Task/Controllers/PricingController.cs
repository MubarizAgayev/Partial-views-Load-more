using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class PricingController : Controller
    {

        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<PricingHeader> pricingHeaders = await _context.PricingHeaders.Where(m => !m.SoftDelete).ToListAsync();

            List<PricingPacket> pricingPackets = await _context.PricingPackets.Where(m => !m.SoftDelete).ToListAsync();

            List<PricingOffer> pricingOffers = await _context.PricingOffers.Where(m => !m.SoftDelete).ToListAsync();

            PricingVM model = new PricingVM()
            {
                PricingOffers= pricingOffers,
                PricingHeaders= pricingHeaders,
                PricingPackets= pricingPackets
            };
            return View(model);
        }
    }
}
