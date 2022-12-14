using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Tags: BaseEntity
    {
        [StringLength(2000)]
        public string Name { get; set; }
    }
}
