using System.ComponentModel.DataAnnotations;

namespace EventManagementAPI.Models
{
    public class TicketType
    {
        [Key]
        public Guid TicketTypeId { get; set; }

        [Required(ErrorMessage = "Ticket Type is required.")]
        [StringLength(50, ErrorMessage = "Ticket Type cannot exceed 50 characters.")]
        public string Tickettype { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative.")]
        public double Price { get; set; }
        
    }

}
