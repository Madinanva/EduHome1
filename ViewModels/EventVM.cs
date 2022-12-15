using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ComponentViewModels
{
    public class EventVM
    {
        public IEnumerable<Subscribe> Subscribes{ get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Speakers> Speakers { get; set; }
        public IEnumerable<Tags> Tags { get; set; }
        public IEnumerable<EventMessage> EventMessages { get; set; }
    }
}
