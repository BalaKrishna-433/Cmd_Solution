using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }   
        public TestCategory Category { get; set; }
    }
}
