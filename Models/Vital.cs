using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Vital
    {
        [Key]
        public int VitalID { get; set; }
        public string VitalName { get; set; }
        public string Measurement { get; set; }
    }
}
/*
    Add vital master
*/
