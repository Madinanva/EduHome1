using Eduhome.DAL;
using Eduhome.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;
        public EventController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            EventVM eventVM = new EventVM
            {

                Events = _context.Events.Where(e => e.IsDeleted == false).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),

            };

            return View(eventVM);
        }
        public IActionResult Detail()
        {
            EventVM eventVM = new EventVM
            {
                Events = _context.Events.Where(e => !e.IsDeleted).ToList(),
                //Speakers = _context.Speakers.Where(e => !e.IsDeleted).ToList(),
                Subscribes = _context.Subscribes.Where(sb => !sb.IsDeleted).ToList(),


            };
            return View(eventVM);
        }

    }
}
