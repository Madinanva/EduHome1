using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class About: BaseEntity
    {
        [StringLength(2000)]
        public string Title { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        public string DescriptionImage { get; set; }
        public string Video { get; set; }
    }
}
