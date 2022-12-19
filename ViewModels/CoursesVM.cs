using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class CoursesVM
    {
        public IEnumerable<Subscribe> Subscribes { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<CourseMessage> CourseMessages { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public IEnumerable<Social> Socials { get; set; }
        public IEnumerable<Courses> Courses { get; set; }
        public Courses Course { get; set; }
    }
}
