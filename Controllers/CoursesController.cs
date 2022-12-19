using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class CoursesController : Controller
    {
        public class CourseController : Controller
        {
            private readonly AppDbContext _context;
            public CourseController(AppDbContext context)
            {
                _context = context;
            }
            public IActionResult Index()
            {
                CoursesVM courseVM = new CoursesVM
                {
                    Courses = _context.Courses.Where(c => c.IsDeleted == false).ToList()
                };

                return View(courseVM);
            }
            public IActionResult Detail()
            {
                CoursesVM courseVM = new CoursesVM
                {
                    Categories = _context.Categories.Where(ct => ct.IsDeleted == false).ToList(),
                    Courses = _context.Courses.Where(c => c.IsDeleted == false).ToList()
                };
                return View(courseVM);
            }
        }
    }
}
