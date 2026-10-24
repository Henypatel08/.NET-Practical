using System.ComponentModel.DataAnnotations;

namespace Practical_7.Model
{
    public class Feedback
    {
        public int FeedbackId { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Faculty name is required")]
        [Display(Name = "Faculty Name")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Please select rating")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(200, ErrorMessage = "Comments cannot exceed 200 characters")]
        public string Comments { get; set; }
    }
}