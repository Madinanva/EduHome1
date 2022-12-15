using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class ContactMessage
    {
        [StringLength(2000)]
        public string Name { get; set; }
        [StringLength(2000)]
        public string Email { get; set; }
        [StringLength(2000)]
        public string Subject { get; set; }
        [StringLength(2000)]
        public string Message { get; set; }
    }
}
