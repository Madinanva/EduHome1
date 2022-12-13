using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class About
    {
        public int Id { get; set; }
        [StringLength(2000)]
        public string Title { get; set; }

    }
}
