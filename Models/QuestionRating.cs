using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class QuestionRating
    {
        public int Id { get; set; }
        public Question Question { get; set; }
        public int Rating { get; set; }
    }
}
