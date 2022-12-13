using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class BlogCategory
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Blog>Blogs { get; set; }
    }
}
