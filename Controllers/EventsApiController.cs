using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventHanteringUppgift.Data;
using EventHanteringUppgift.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EventHanteringUppgift.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsApiController : Controller
    {
        private readonly EventDbContext _context;

        public EventsApiController(EventDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllEvents()
        {
            // TODO: Lista alla events
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetEvent(Guid id)
        {
            // TODO: Lista ett specifikt event
            return Ok();
        }


        [HttpPost]
        // public IActionResult CreateEvent([FromBody] Event newEvent)
        public async Task<IActionResult> CreateEventAsync([FromBody] Event newEvent)
        {
            // TODO: Skapa ett nytt event

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent", new { id = newEvent.EventId }, newEvent);

            
        }
    
        [HttpPut("{id}")]
        public IActionResult UpdateEvent(Guid id, [FromBody] Event updatedEvent)
        {
            // TODO: Redigera ett event
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEvent(Guid id)
        {
            // TODO: Ta bort ett event
            return Ok();
        }

        [HttpPost("join")]
        public IActionResult JoinEvent([FromBody] JoinEventModel model)
        {
            // TODO: Få en användare att gå med i ett event
            return Ok();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register()
        {
            // TODO: Registrera ett nytt konto
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login()
        {
            // TODO: Logga in på ett konto
            return Ok();
        }
    }
}