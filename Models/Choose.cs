using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Choose: BaseEntity
    {
        [StringLength(2000)]
        public string Title { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
    }
}
