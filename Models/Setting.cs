using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Eduhome.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(2000)]
        public string Key { get; set; }
        [StringLength(2000)]
        public string Value { get; set; }
        [StringLength(2000)]
        public string Address { get; set; }
        [StringLength(2000)]
        public string Phone1 { get; set; }
        [StringLength(2000)]
        public string Phone2 { get; set; }
        [StringLength(2000)]
        public string Website { get; set; }
    }
}
