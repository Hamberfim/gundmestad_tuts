using System.ComponentModel.DataAnnotations;

namespace TripsLog.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a destination.")]
        public string Destination { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an accomodation.")]
        public string Accomodation { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a start date.")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an end date.")]
        public DateTime? EndDate { get; set; }

        // optional fields

        public string? AccomodationsPhone { get; set; }
        public string? AccomodationsEmail { get; set; }
        public string? Activity1 { get; set; }
        public string? Activity2 { get; set; }
        public string? Activity3 { get; set; }
    }
}
