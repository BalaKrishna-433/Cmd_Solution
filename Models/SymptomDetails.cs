using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SymptomDetails
    {
        public int Id { get; set; }
        public SymptomData SymptomData { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
