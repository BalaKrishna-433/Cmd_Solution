using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MedicalProblem
    {
        [Key]
        public int ProblemID { get; set; }
        public string ProblemName { get; set; } 
    }
}
