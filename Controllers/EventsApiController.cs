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

        [HttpGet("getallevents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAllEvents()
        {
            // TODO: Lista alla events
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetEvent(Guid id)
        {
            // TODO: Lista ett specifikt event
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateEvent([FromBody] Event newEvent)
        {
            // TODO: Skapa ett nytt event
            return Ok();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateEvent(Guid id, [FromBody] Event updatedEvent)
        {
            if (!ModelState.IsValid) return BadRequest("Information saknas");

            var events = await _context.Events.FindAsync(id);
            if (events is null) return BadRequest($"Eventet {updatedEvent.Title} finns inte");

            events.Title = updatedEvent.Title;
            events.StartDate = updatedEvent.StartDate;
            events.Location = updatedEvent.Location;
            events.Description = updatedEvent.Description;

            _context.Events.Update(events);
            if (await _context.SaveChangesAsync() > 0)
            {
                return NoContent();
            }

            return StatusCode(500, "Internal Server Error");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEvent(Guid id)
        {
            var events = await _context.Events.FindAsync(id);
            if (events is null) return NotFound($"Finns inget event med id: {id}");

            _context.Events.Remove(events);
            if (await _context.SaveChangesAsync() > 0)
            {
                return NoContent();
            }

            return StatusCode(500, "Internal Server Error");
        }

        [HttpPost("join")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult JoinEvent([FromBody] JoinEventModel model)
        {
            // TODO: Få en användare att gå med i ett event
            return Ok();
        }

        [HttpPost("register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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