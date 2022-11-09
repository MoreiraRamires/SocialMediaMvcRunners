using System.ComponentModel.DataAnnotations.Schema;

namespace socialMedia.Models
{
    public class AppUser
    {
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public string? ProfileImageUrl { get; set; }
        public Address? Address { get; set; }
        
        [ForeignKey("Address")]
        public int? AddressId { get; set; }

        public ICollection <Club> Clubs  {get; set; }

        public ICollection <Race> Races  { get; set; }
    }
}