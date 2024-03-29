﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Courses:BaseEntity
    {
        [StringLength(50)]
        public string Subject { get; set; }
        public string CourseImage { get; set; }
        [StringLength(2000)]
        public string Description { get; set; }
        [StringLength(2000)]
        public string AboutCourse { get; set; }
        [StringLength(2000)]
        public string Apply { get; set; }
        [StringLength(2000)]
        public string Certification { get; set; }
        [StringLength(2000)]
        public string FeaturesName { get; set; }
        public DateTime Start { get; set; }
        [StringLength(30)]
        public string Duration { get; set; }
        [StringLength(30)]
        public string ClassDuration { get; set; }
        [StringLength(50)]
        public string SkillLevel { get; set; }
        [StringLength(2000)]
        public int Students { get; set; }
        [StringLength(2000)]
        public String Languages { get; set; }
        [StringLength(2000)]
        public string Assesments { get; set; }
        [StringLength(2000)]
        public int Price { get; set; }
        //public int CategoryId { get; set; }
    }
}
