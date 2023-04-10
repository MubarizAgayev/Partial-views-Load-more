using Task.Models;

namespace Task.ViewModels
{
    public class PricingVM
    {
        public List<PricingHeader> PricingHeaders { get; set; }
        public List<PricingPacket> PricingPackets { get; set; }
        public List<PricingOffer> PricingOffers { get; set; }
    }
}
