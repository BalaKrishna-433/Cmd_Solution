using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackID { get; set; }
        public ICollection<QuestionRating> Rating { get; set; } 
        public string AdditionalComments { get; set; }
    }
}
