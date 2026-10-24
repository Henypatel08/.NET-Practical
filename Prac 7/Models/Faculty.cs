using System.ComponentModel.DataAnnotations;

namespace Practical_7.Model
{
    public class Faculty
    {
        public int FacultyId { get; set; }

        [Required]
        public string FacultyName { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }
    }
}