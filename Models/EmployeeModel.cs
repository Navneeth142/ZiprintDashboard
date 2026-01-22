using System.ComponentModel.DataAnnotations;

namespace BlazorAssignment.Models
{
    public class EmployeeModel
    {
        [Required]
        public string EmployeeId { get; set; } = string.Empty;

        [Required]
        public string EmployeeName { get; set; } = string.Empty;

        [Required]
        public string EmployeeRole { get; set; } = string.Empty;

        [Required, Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PlantId { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfJoining { get; set; } = DateTime.Today;

        [Required]
        public string Password { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;
    }
}
