using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM
            {
                Blogs = _context.Blogs.Where(b => b.IsDeleted == false).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),
            };
            return View(blogVM);
        }
        public IActionResult Detail()
        {
            BlogVM blogVM = new BlogVM
            {
                Blog = _context.Blogs.Where(b => b.IsDeleted == false).FirstOrDefault(),
                Categories = _context.Categories.Where(c => c.IsDeleted == false).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),
                Blogs = _context.Blogs.Where(b => b.IsDeleted == false).ToList(),
            };

            return View(blogVM);
        }
    }
}