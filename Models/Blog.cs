using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Blog : BaseEntity
    {
        [StringLength(50)]
        public string Author { get; set; }
        public DateTime Date { get; set; }
        [StringLength(2000)]
        public string Comment { get; set; }
        public string BlogImage { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
