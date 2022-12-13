using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Blog: BaseEntity
    {
        public string Name { get; set; }
        public string BloggerName { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public List<BlogCategory>BlogCategories { get; set; }

    }
}
