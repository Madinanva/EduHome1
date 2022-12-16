using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Subscribe: BaseEntity
    {
        [StringLength(2000)]
        public string Email { get; set; }
    }
}
