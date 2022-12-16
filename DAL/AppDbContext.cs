using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eduhome.Models;

namespace Eduhome.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<About> Abouts { get; set; }
        //public DbSet<Home> Homes { get; set; }
        public DbSet<LeftNoticeBoard> LeftNoticeBoards { get; set; }
        public DbSet<RightNoticeBoard> RightNoticeBoards { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Event> Events { get; set; }
        //public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Choose> Chooses { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
