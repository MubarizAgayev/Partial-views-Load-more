namespace Task.Models
{
    public class AboutMembers : BaseEntity
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Position { get; set; }
        public int AboutMemberInfoId { get; set; }
        public AboutMemberInfo AboutMemberInfo { get; set; }
    }
}
