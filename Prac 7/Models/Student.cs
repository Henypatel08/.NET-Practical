using System.ComponentModel.DataAnnotations;

namespace Practical_7.Model
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string StudentName { get; set; }

        [Required]
        public string EnrollmentNo { get; set; }

        public string Department { get; set; }
    }
}