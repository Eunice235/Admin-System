using System.ComponentModel.DataAnnotations;

namespace AdminManageEmployees.Models
{
    public class Employee : UserActivity
    {
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First name is required."), StringLength(50, ErrorMessage = "First name cannot exceed 50 characters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required."), StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters.")]
        public string? LastName { get; set; }


        [Required(ErrorMessage = "Email is required."), EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Phone number is required."), Phone(ErrorMessage = "Invalid phone number.")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required"), StringLength(100, ErrorMessage = "Address should not exceed 100 characters")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "City is required"), StringLength(50, ErrorMessage = "City characters should be between 1-50")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Postalcode is required"), StringLength(10, ErrorMessage = " postalcode characters should be between 1-10")]
        public string? PostalCode { get; set; }

        [Required(ErrorMessage = "Hiredate is required")]
        public DateTime HireDate { get; set; }
        [Required, Range(0, double.MaxValue)]
        public decimal Salary { get; set; }

        [Required, StringLength(50)]
        public string? Department { get; set; }

        [Required, StringLength(50)]
        public string? Position { get; set; }

        [Required]
        //[DateOfBirthRange(ErrorMessage = "Date of birth must be between 1975 and 2001.")]
        public DateTime BirthDate { get; set; }

        [Required, StringLength(50)]
        public string? Gender { get; set; }
        [Required, StringLength(50)]
        public string? Nationality { get; set; }

        [Required, StringLength(50)]
        public string? EmergencyContactName { get; set; }

        [Required, Phone]
        public string? EmergencyContactPhone { get; set; }
    }
}
