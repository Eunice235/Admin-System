using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class Country : UserActivity
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? CountryCode { get; set; }
        [Required]
        public string? CountryName { get; set; }
        [Required]
        public string? HomeTown { get; set; }
    }
}
