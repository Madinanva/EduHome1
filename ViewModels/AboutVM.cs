using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ComponentViewModels
{
    public class AboutVM 
    {
        public IEnumerable<Teacher> Teachers { get; set; }
        public IEnumerable<RightNoticeBoard> RightNoticeBoards { get; set; }
        public IEnumerable<Subscribe> Subscribes { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
