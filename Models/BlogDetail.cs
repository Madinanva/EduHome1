using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class BlogDetail
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string BlogImage { get; set; }
        public string BloggerName { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
