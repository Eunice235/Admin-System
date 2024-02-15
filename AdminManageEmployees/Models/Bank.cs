using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class Bank : UserActivity
    {
        [Required]
        public int BankId { get; set; }
        [Required]
        public string? BankName { get; set; }
        [Required]
        public string? BranchCode { get; set; }
        [Required]
        public string? Branch { get; set; }
        [Required]
        public string? AccountNumber { get; set; }
    }
}
