namespace Task.Models
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public bool IsMain { get; set; } = true;
    }
}
