using System;

namespace EventManagementAPI.DTOs
{
  public class EventDTO
  {
    public Guid EventId { get; set; }  // Unique ID for the event

    public string EventName { get; set; }  // Event Name

    public int AgeLimit { get; set; }  // Age limit for the event

    public DateTime EventDateTime { get; set; }  // Date and time of the event

    public decimal EventPrice { get; set; }  // Price of the event

    public decimal EventDuration { get; set; }  // Duration of the event in hours

    public string EventDetails { get; set; }  // Additional details about the event

    public int CapacityAvailable { get; set; }  // Total capacity available for the event

    // Ticket information
    public int VipTicketCount { get; set; }  // Number of VIP tickets available
    public int GeneralTicketCount { get; set; }  // Number of General tickets available
    public int EconomyTicketCount { get; set; }  // Number of Economy tickets available

    // Foreign key references
    public Guid CategoryId { get; set; }  // The category of the event
    public Guid VenueId { get; set; }  // The venue where the event is held
    
    
  }
}
