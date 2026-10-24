using System.ComponentModel.DataAnnotations;

namespace Practical_7.Model
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        public string CourseName { get; set; }

        public string CourseCode { get; set; }

        public int Credits { get; set; }
    }
}