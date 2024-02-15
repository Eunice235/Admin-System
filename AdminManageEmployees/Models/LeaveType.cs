using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class LeaveType : UserActivity
    {
        [Required]
        public int LeaveTypeId { get; set; }
        [Required]
        public string? LeaveCode { get; set; }
        [Required]
        public string? LeaveName { get; set; }
    }
}
