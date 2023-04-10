namespace Task.Models
{
    public class RecentWorkImgs : BaseEntity
    {
        public string? Image { get; set; }
        public int RecentWorksId { get; set; }
        public RecentWorks RecentWorks { get; set; }
    }
}
