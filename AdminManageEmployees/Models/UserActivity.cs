using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class UserActivity
    {
        [Key]
        public string? Id { get; set; }
        [Required]
        public DateTime CreateeOn { get; set; }
        [Required]
        public string? ModifiedBy { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
    }
}
