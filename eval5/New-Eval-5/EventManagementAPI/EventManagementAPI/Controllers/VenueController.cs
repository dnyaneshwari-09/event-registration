using EventManagementAPI.Data;
using EventManagementAPI.DTOs;
using EventManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class VenueController : ControllerBase
  {
    private readonly EventManagementContext _context;

    public VenueController(EventManagementContext context)
    {
      _context = context;
    }

    // GET: api/venue
    [HttpGet]
    public async Task<ActionResult<IEnumerable<VenueDto>>> GetVenues()
    {
      var venueDtos = await _context.Venues.Select(v => new VenueDto
      {
        VenueId = v.VenueId,
        VenueName = v.VenueName,
        VenueAddress1 = v.VenueAddress1,
        VenueAddress2 = v.VenueAddress2,
        City = v.City,
        State = v.State,
        Pincode = v.Pincode,
        MaxCapacity = v.MaxCapacity
      }).ToListAsync();

      return Ok(venueDtos);
    }

    // GET: api/venue/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<VenueDto>> GetVenueById(Guid id)
    {
      var venue = await _context.Venues.FindAsync(id);

      if (venue == null)
      {
        return NotFound();
      }

      var venueDto = new VenueDto
      {
        VenueId = venue.VenueId,
        VenueName = venue.VenueName,
        VenueAddress1 = venue.VenueAddress1,
        VenueAddress2 = venue.VenueAddress2,
        City = venue.City,
        State = venue.State,
        Pincode = venue.Pincode,
        MaxCapacity = venue.MaxCapacity
      };

      return Ok(venueDto);
    }

    // POST: api/venue
    [HttpPost]
    public async Task<ActionResult<VenueDto>> CreateVenue([FromBody] VenueDto venueDto)
    {
      var venue = new Venue
      {
        VenueId = Guid.NewGuid(),
        VenueName = venueDto.VenueName,
        VenueAddress1 = venueDto.VenueAddress1,
        VenueAddress2 = venueDto.VenueAddress2,
        City = venueDto.City,
        State = venueDto.State,
        Pincode = venueDto.Pincode,
        MaxCapacity = venueDto.MaxCapacity
      };

      _context.Venues.Add(venue);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetVenueById), new { id = venue.VenueId }, venueDto);
    }

    // PUT: api/venue/{id}
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateVenue(Guid id, [FromBody] VenueDto venueDto)
    {
      var venue = await _context.Venues.FindAsync(id);

      if (venue == null)
      {
        return NotFound();
      }

      venue.VenueName = venueDto.VenueName;
      venue.VenueAddress1 = venueDto.VenueAddress1;
      venue.VenueAddress2 = venueDto.VenueAddress2;
      venue.City = venueDto.City;
      venue.State = venueDto.State;
      venue.Pincode = venueDto.Pincode;
      venue.MaxCapacity = venueDto.MaxCapacity;

      _context.Entry(venue).State = EntityState.Modified;
      await _context.SaveChangesAsync();

      return NoContent();
    }

    // DELETE: api/venue/{id}
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteVenue(Guid id)
    {
      var venue = await _context.Venues.FindAsync(id);

      if (venue == null)
      {
        return NotFound();
      }

      _context.Venues.Remove(venue);
      await _context.SaveChangesAsync();

      return NoContent();
    }
  }
}
