using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class HomeVM
    {

        
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<LeftNoticeBoard> LeftNoticeBoards { get; set; }
        public IEnumerable<RightNoticeBoard> RightNoticeBoards { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Subscribe> Subscribes { get; set; }
        public IEnumerable<Choose> Chooses { get; set; }
        public IEnumerable<Social> Socials { get; set; }
        public Dictionary<string, string> Settings { get; set; }
    }
}
