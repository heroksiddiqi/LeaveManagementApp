using System.ComponentModel.DataAnnotations;

namespace LeaveManagementApp.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }
        [Required]
        [Range(1, 30, ErrorMessage = "Value must be within 1 to 30")]
        [Display(Name = "Default Number Of Days")]
        public int DefaultDays { get; set; }
    }
}