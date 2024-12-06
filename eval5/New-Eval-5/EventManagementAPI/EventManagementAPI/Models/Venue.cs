using System.ComponentModel.DataAnnotations;

namespace EventManagementAPI.Models
{
    public class Venue
    {
        [Key]
        public Guid VenueId { get; set; }  // GUID for Venue ID

        [Required]
        [MaxLength(100)]
        public string VenueName { get; set; }  // Venue Name

        [Required]
        [MaxLength(200)]
        public string VenueAddress1 { get; set; }  // Address Line 1

        [MaxLength(200)]
        public string VenueAddress2 { get; set; }  // Address Line 2 (optional)

        [Required]
        [MaxLength(100)]
        public string City { get; set; }  // City

        [Required]
        [MaxLength(100)]
        public string State { get; set; }  // State

        [Required]
        [MaxLength(10)]
        public string Pincode { get; set; }  // Pincode

        [Required]
        [Range(0, int.MaxValue)]
        public int MaxCapacity { get; set; }  // Maximum Capacity
    }
}
