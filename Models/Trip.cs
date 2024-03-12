using System.ComponentModel.DataAnnotations;

namespace TripLog.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public string Destination { get; set; } = string.Empty;

        [Required]
        public string Accomodation { get; set; }= string.Empty;

        [Required]
        public DateTime? StartDate { get; set; }

        [Required]
        public DateTime? EndDate { get; set;}

        public string? Phone { get; set; }
        public string? Email { get; set; }

        public string? Thingstodo1 { get; set; }
        public string? Thingstodo2 { get; set; }
        public string? Thingstodo3 { get; set; }

    }
}
