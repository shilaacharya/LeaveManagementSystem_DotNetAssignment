using System.ComponentModel.DataAnnotations;

namespace Bhuma_Devi_Acharya_Dot_Net_Assignment.Models
{
    public class TeacherLeave
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Leave Start Date")]
        public DateTime LeaveStartDate { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Number of days must be at least 1")]
        [Display(Name = "Number of Days of Leave")]
        public int NumberOfDays { get; set; }

    }
}
