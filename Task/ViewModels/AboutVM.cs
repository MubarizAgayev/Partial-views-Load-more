using Task.Models;

namespace Task.ViewModels
{
    public class AboutVM
    {
        public AboutSlider AboutSlider { get; set; }
        public AboutSliderInfo AboutSliderInfo { get; set; }
        public List<AboutMembers> AboutMembers { get; set; }
        public List<AboutMemberInfo> AboutMemberInfos { get; set; }
    }
}
