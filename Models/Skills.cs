using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Skills: BaseEntity
    {
        public string Name { get; set; }
        [StringLength(2000)]
        public string Percent { get; set; }
        public int TeacherId { get; set; }
    }
}
