using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM
            {

                Teachers = _context.Teachers.Where(t => t.IsDeleted == false).ToList(),
                Abouts = _context.Abouts.Where(a => a.IsDeleted == false).FirstOrDefault(),
                RightNoticeBoards = _context.RightNoticeBoards.Where(r => r.IsDeleted == false).ToList(),
                LeftNoticeBoards = _context.LeftNoticeBoards.Where(r => r.IsDeleted == false).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),
                Testimonials = _context.Testimonials.Where(t => !t.IsDeleted).ToList(),
                Blogs = _context.Blogs.Where(b =>!b. IsDeleted).ToList(),
               
            };

            return View(aboutVM);
        }
    }
}