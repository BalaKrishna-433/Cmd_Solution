using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TestReport
    {
        public int Id { get; set; }
        public Test Test { get; set; }
        public string Report { get; set; }
        public double Value { get; set; }
    }
}
