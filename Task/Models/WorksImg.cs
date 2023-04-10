namespace Task.Models
{
    public class WorksImg : BaseEntity
    {
        public string? Image { get; set; }
        public int WorksId { get; set; }
        public Works Works { get; set; }
    }
}
