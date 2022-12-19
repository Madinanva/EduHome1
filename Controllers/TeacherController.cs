using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TeacherVM teacherVM = new TeacherVM
            {
                Teachers = _context.Teachers.Where(t => t.IsDeleted == false).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),
            };
            return View(teacherVM);
        }
        public IActionResult Detail()
        {
            TeacherVM teacherVM = new TeacherVM
            {
                Teacher = _context.Teachers.Where(t => t.IsDeleted == false).FirstOrDefault(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),

            };
            return View(teacherVM);
        }

    }
}