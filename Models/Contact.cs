using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Contact:BaseEntity
    {
        [StringLength(2000)]
        public string Address {get;set;}
        [StringLength(25)]
        public string Phone { get; set; }
        [StringLength(300)]
        public string Website { get; set; }

    }
}
