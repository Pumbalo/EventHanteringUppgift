using EventHanteringUppgift.Data;
using EventHanteringUppgift.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventHanteringUppgift.Controllers
{
    [Route("events")]
    public class EventController : Controller
    {
        private readonly EventDbContext _context;
        
        public EventController(EventDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var events = await _context.Events.ToListAsync();
            return View("Index", events);
        }
    }
}
