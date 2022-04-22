using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SymptomData
    {
        public int Id { get; set; }
        public Symptom Symptom { get; set; }
        public int Reading { get; set; }
    }
}
