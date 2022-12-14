using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Speakers:BaseEntity
    {
        [StringLength(2000)]
        public string FullName { get; set; }
        [StringLength(2000)]
        public string Profession { get; set; }
    }
}
