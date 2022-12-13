using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Slider: BaseEntity
    {
        [StringLength(500)]
        public string MainTitle { get; set; }
        [StringLength (500)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Image { get; set; }
        [StringLength(500)]
        public string PageLink { get; set; }
    }
}
