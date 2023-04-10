namespace Task.Models
{
    public class PricingOffer : BaseEntity
    {
        public string? OfferName { get; set; }
        public int PricingPacketId { get; set; }
        public PricingPacket PricingPacket { get; set; }
    }
}
