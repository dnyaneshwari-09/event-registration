using System;
using System.ComponentModel.DataAnnotations;

namespace EventManagementAPI.Models.DTOs
{
    public class RegistrationDto
    {
        public Guid RegistrationId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid EventId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Phone]
        [StringLength(15)]
        public string MobileNo { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [Required]
        public Guid TicketTypeId { get; set; }
    }
}
