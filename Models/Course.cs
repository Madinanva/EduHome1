using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Course:BaseEntity
    {
        [StringLength(50)]
        public string Subject { get; set; }
        public string CourseImage { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(200)]
        public string CourseName { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
        [StringLength(2000)]
        public string AboutCourse { get; set; }
        [StringLength(2000)]
        public string Apply { get; set; }
        [StringLength(2000)]
        public string Certification { get; set; }
        [StringLength(2000)]
        public string FeaturesName { get; set; }
        [StringLength(50)]
        public string Starts { get; set; }
        [StringLength(30)]
        public string Duration { get; set; }
        [StringLength(30)]
        public string ClassDuration { get; set; }
        [StringLength(50)]
        public string SkillLevel { get; set; }
        [StringLength(2000)]
        public string Students { get; set; }
        [StringLength(2000)]
        public string Assesments { get; set; }
        [StringLength(2000)]
        public string Price { get; set; }
        public int CategoryId { get; set; }
    }
}
