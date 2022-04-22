using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string SpecialityName { get; set; }
        public SpecialityCategory SpecialityCategory { get; set; }
    }
}
