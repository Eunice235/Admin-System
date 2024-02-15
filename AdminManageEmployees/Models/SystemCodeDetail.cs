using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class SystemCodeDetail : UserActivity
    {
        [Required]
        public int SystemCodeDetailsId { get; set; }
        [Required]
        public string? Detailscode { get; set; }
        [Required]
        public string? DeatilsName { get; set; }
        [Required]
        public string? DeatilsDescription { get; set; }
    }
}
