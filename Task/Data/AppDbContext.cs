using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<SlideInfo> SlideInfos { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<WorksImg> WorksImgs { get; set; }
        public DbSet<RecentWorks> RecentWorks { get; set; }
        public DbSet<RecentWorkImgs> RecentWorkImgs { get; set; }
        public DbSet<AboutSlider> AboutSliders { get; set; }
        public DbSet<AboutSliderInfo> AboutSliderInfos { get; set; }
        public DbSet<AboutMembers> AboutMembers { get; set; }
        public DbSet<AboutMemberInfo> AboutMemberInfos { get; set; }
        public DbSet<ContactHeader> ContactHeaders { get; set; }
        public DbSet<ContactHeaderImg> ContactHeaderImgs { get; set; }
        public DbSet<PricingHeader> PricingHeaders { get; set; }
        public DbSet<PricingPacket> PricingPackets { get; set; }
        public DbSet<PricingOffer> PricingOffers { get; set; }
    }
}
