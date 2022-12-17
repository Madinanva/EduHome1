using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModels
{
    public class TeacherVM
    {
        public IEnumerable<Skills> Skills { get; set; }
        public IEnumerable<Subscribe> Subscribes { get; set; }
        public IEnumerable<Social>Socials { get; set; }
    }
}
