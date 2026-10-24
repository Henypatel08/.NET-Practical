using System.ComponentModel.DataAnnotations;

namespace Practical_7.Model
{
    public class FeedbackCategory
    {
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}