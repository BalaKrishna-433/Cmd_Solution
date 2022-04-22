using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VitalReading
    {
        public int Id { get; set; }
        public Vital Vital { get; set; }
        public double Reading { get; set; }
    }
}
