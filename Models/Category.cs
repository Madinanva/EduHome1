using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Category:BaseEntity
    {
        [StringLength(200)]
        public string Name { get; set; }
        public List<Blog>Blogs { get; set; }
        public List<Courses> Courses { get; set; }
        public List<Event> Events { get; set; }
    }
}
