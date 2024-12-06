using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using EventManagementAPI.Models; // Adjust according to your namespace
using EventManagementAPI.Data;   // Adjust according to your namespace

[Route("api/[controller]")]
[ApiController]
public class EventReportsController : ControllerBase
{
    private readonly EventManagementContext _context;

    public EventReportsController(EventManagementContext context)
    {
        _context = context;
    }

    // 1. Number of registrations per event per ticket category
    [HttpGet("registrations-per-event")]
    public async Task<IActionResult> GetRegistrationsPerEvent()
    {
        var result = await _context.Registrations
            .Include(r => r.Event)
            .Include(r => r.TicketType) // Adjust if TicketType has a different property for type
            .GroupBy(r => new { r.EventId, r.TicketType.Tickettype }) // Adjust if TicketType has a different property for type
            .Select(g => new
            {
                EventId = g.Key.EventId,
                TicketCategory = g.Key.Tickettype,
                RegistrationCount = g.Count()
            })
            .ToListAsync();

        return Ok(result);
    }

    // 2. Number of oversubscribed events per ticket category
    //[HttpGet("oversubscribed-events")]
    //public async Task<IActionResult> GetOversubscribedEvents()
    //{
    //    var result = await _context.Events
    //        .Include(e => e.Registrations) // Include the Registrations collection
    //        .Select(e => new
    //        {
    //            e.EventId,
    //            e.EventName,
    //            e.VipTicketCount,
    //            e.GeneralTicketCount,
    //            e.EconomyTicketCount,
    //            OversubscribedVip = e.VipTicketCount < e.Registrations.Count(r => r.TicketType.Tickettype == "VIP"),
    //            OversubscribedGeneral = e.GeneralTicketCount < e.Registrations.Count(r => r.TicketType.Tickettype == "General"),
    //            OversubscribedEconomy = e.EconomyTicketCount < e.Registrations.Count(r => r.TicketType.Tickettype == "Economy")
    //        })
    //        .Where(e => e.OversubscribedVip || e.OversubscribedGeneral || e.OversubscribedEconomy)
    //        .ToListAsync();

    //    return Ok(result);
    //}


    // 3. Number of registrations per user
    [HttpGet("registrations-per-user")]
    public async Task<IActionResult> GetRegistrationsPerUser()
    {
        var result = await _context.Registrations
            .GroupBy(r => r.UserId)
            .Select(g => new
            {
                UserId = g.Key,
                RegistrationCount = g.Count()
            })
            .ToListAsync();

        return Ok(result);
    }

    //// 4. Number of movements from waitlist to main registration per event per day
    //[HttpGet("waitlist-to-main-registration")]
    //public async Task<IActionResult> GetWaitlistToMainRegistration()
    //{
    //    var result = await _context.Registrations
    //        .Where(r => r.Status == "Moved from Waitlist") // Adjust Status field or logic if different
    //        .GroupBy(r => new { r.EventId, Date = r.CreatedDate.Date }) // Adjust CreatedDate or relevant date field
    //        .Select(g => new
    //        {
    //            EventId = g.Key.EventId,
    //            Date = g.Key.Date,
    //            MovementCount = g.Count()
    //        })
    //        .ToListAsync();

    //    return Ok(result);
    //}

    // 5. List event city-wise which are for children above 5 years
    [HttpGet("events-for-children-above-5")]
    public async Task<IActionResult> GetEventsForChildrenAbove5()
    {
        var result = await _context.Events
            .Where(e => e.AgeLimit > 5)
            .GroupBy(e => e.Venue.City) // Adjust if City is stored differently
            .Select(g => new
            {
                City = g.Key,
                Events = g.Select(e => new
                {
                    e.EventId,
                    e.EventName,
                    e.EventDateTime,
                    e.EventPrice
                }).ToList()
            })
            .ToListAsync();

        return Ok(result);
    }
}
