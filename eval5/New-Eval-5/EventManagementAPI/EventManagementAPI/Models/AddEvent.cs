using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;

namespace EventManagementAPI.Models
{
    public class Event
    {
        [Key]
        public Guid EventId { get; set; }

        [Required(ErrorMessage = "Event Name is required.")]
        [StringLength(100, ErrorMessage = "Event Name cannot exceed 100 characters.")]
        public string EventName { get; set; }

        [Required(ErrorMessage = "age limit is required.")]
        public int AgeLimit { get; set; }

        [Required(ErrorMessage = "Event Date and Time is required.")]
        public DateTime EventDateTime { get; set; }

        [Required(ErrorMessage = "Event Price is required.")]
        public decimal EventPrice { get; set; }


        [Required(ErrorMessage = "Event duration is required.")]
        public decimal EventDuration { get; set; }

        [StringLength(500, ErrorMessage = "Event Details cannot exceed 500 characters.")]
        public string EventDetails { get; set; }

       
        public int CapacityAvailable { get; set; }

        // Ticket types
        [Required(ErrorMessage = "VIP ticket count is required.")]
        public int VipTicketCount { get; set; }

        [Required(ErrorMessage = "General ticket count is required.")]
        public int GeneralTicketCount { get; set; }

        [Required(ErrorMessage = "Economy ticket count is required.")]
        public int EconomyTicketCount { get; set; }

        // Foreign keys
        public Guid CategoryId { get; set; }

        [Required(ErrorMessage = "Venue is required.")]
        [ForeignKey("Venue")]
        public Guid VenueId { get; set; }  // Foreign Key to Venue

       



        // Navigation properties
        public Category Category { get; set; }
        
        public Venue Venue { get; set; }
        
    }

}
