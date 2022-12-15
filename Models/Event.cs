using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Event:BaseEntity
    {
        [StringLength(2000)]
        public string Name { get; set; }
        public string  Image { get; set; }
        public DateTime Time { get; set; }
        [StringLength(2000)]
        public string Venue { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
    }
}
