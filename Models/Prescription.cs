using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Prescription
    {  
        [Key]
        public int PrescriptionID { get; set; }
        public Medicine Medicine { get; set; }
        public int Doses { get; set; }
        public string Intake { get; set; }
        public int Span { get; set; }
        public string TimeOfDay { get; set; }
        public string AdditionalComments { get; set; }
    }
}
