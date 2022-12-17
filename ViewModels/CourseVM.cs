using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class CourseVM
    {
        public IEnumerable<Subscribe> Subscribes { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<CourseMessage> CourseMessages { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public IEnumerable<Social> Socials { get; set; }
    }
}
