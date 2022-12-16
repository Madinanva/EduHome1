using Eduhome.DAL;
using Eduhome.Models;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {

                Sliders = _context.Sliders.Where(s => s.IsDeleted == false).ToList(),
                LeftNoticeBoards = _context.LeftNoticeBoards.Where(l => l.IsDeleted == false).ToList(),
                RightNoticeBoards = _context.RightNoticeBoards.Where(r => r.IsDeleted == false).ToList(),
                Courses = _context.Courses.Where(c => !c.IsDeleted).ToList()
            };
            return View(homeVM);
        }
    }
}
