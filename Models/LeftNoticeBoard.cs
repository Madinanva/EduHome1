using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class LeftNoticeBoard: BaseEntity
    {
        public DateTime Date { get; set; }
        public string Content { get; set; }
    }
}
