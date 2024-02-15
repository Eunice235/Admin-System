using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class SystemCode : UserActivity
    {
        [Required]
        public int SystemCodeId { get; set; }
        [Required]
        public string? Systemcode { get; set; }
        [Required]
        public string? SystemName { get; set; }
        [Required]
        public string? SystemDescription { get; set; }
    }
}
