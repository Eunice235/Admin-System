using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class Department : UserActivity
    {
        [Required]
        public int DepartmentId { get; set; }
        [Required]
        public string? DepartmentName { get; set; }

    }
}
