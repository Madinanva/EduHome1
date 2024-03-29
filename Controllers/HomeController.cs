﻿using Eduhome.DAL;
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
                Courses = _context.Courses.Where(c => !c.IsDeleted).ToList(),
                Settings = _context.Settings.ToDictionary(k=>k.Key, v=>v.Value),
                Events = _context.Events.Where(e => !e.IsDeleted).ToList(),
                Chooses = _context.Chooses.Where(ch => !ch.IsDeleted).ToList(),
                Testimonials = _context.Testimonials.Where(t => !t.IsDeleted).ToList(),
                Blogs = _context.Blogs.Where(b => !b.IsDeleted).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),
                Socials = _context.Socials.Where(sc => !sc.IsDeleted).ToList()
            };
            return View(homeVM);
        }
    }
}
