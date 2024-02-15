using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class Designation : UserActivity
    {
        [Required]
        public int DesignationId { get; set; }
        [Required]
        public string? Designationcode { get; set; }
        [Required]
        public string? DesgName { get; set; }
        [Required]
        public string? DesignationDescription { get; set; }
    }
}
