using Task.Models;

namespace Task.ViewModels
{
    public class HomeVM
    {
        public Slider Sliders { get; set; }

        public List<SlideInfo> SlideInfo { get; set; }
        public List<Services> Services { get; set; }
        public List<RecentWorks> RecentWorks { get; set; }
        public List<RecentWorkImgs> RecentWorkImgs { get; set; }
        public List<Category> Categories { get; set; }
        public List<Works> Works { get; set; }
        public List<WorksImg> WorksImgs { get; set; }
    }
}
