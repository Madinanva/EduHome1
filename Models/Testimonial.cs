﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Testimonial:BaseEntity
    {
        [StringLength(2000)]
        public string Name { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
        [StringLength(2000)]
        public string Image { get; set; }
        [StringLength(2000)]
        public string Profession { get; set; }
    }
}
