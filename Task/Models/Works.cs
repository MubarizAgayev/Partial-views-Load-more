namespace Task.Models
{
    public class Works : BaseEntity
    {
        public string? WorkName { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
