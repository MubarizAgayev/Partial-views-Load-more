namespace Task.Models
{
    public class PricingPacket : BaseEntity
    {
        public string? Name { get; set; }
        public int PacketPrice { get; set; }
        public int PricingHeaderId { get; set; }
        public PricingHeader PricingHeader { get; set; }
    }
}
