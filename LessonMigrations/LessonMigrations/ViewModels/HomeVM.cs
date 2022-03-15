using LessonMigrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LessonMigrations.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public SliderDetail Detail { get; set; }
        public List<Carousel> Carousels { get; set; }
        public List<GiftVideo> GiftVideos { get; set; }
        public List<GiftHead> GiftHeads { get; set; }
        public List<GiftFooter> GiftFooters { get; set; }
        public List<Expert> Experts { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Instagram> Instagrams { get; set; }
    }
}
