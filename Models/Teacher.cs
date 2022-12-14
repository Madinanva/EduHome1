using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Teacher: BaseEntity
    {
        [StringLength(2000)]
        public string Fullname { get; set; }
        public string TeachersImage { get; set; }
        [StringLength(2000)]
        public string Profession { get; set; }
        [StringLength(2000)]
        public string AboutTeacher { get; set; }
        [StringLength(2000)]
        public string Degree { get; set; }
        [StringLength(2000)]
        public string Experience { get; set; }
        [StringLength(2000)]
        public string Hobbies { get; set; }
        [StringLength(2000)]
        public string Faculty { get; set; }
        [StringLength(2000)]
        public string Name { get; set; }
        [StringLength(2000)]
        public string Mail { get; set; }
        [StringLength(2000)]
        public string Phone { get; set; }
        [StringLength(2000)]
        public string Skype { get; set; }
        public List<Skills> Skills { get; set; }
        public List<Social> Socials { get; set; }
    }
}
