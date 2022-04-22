using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Symptom
    {
        [Key]
        public int SymptomID { get; set; }
        public string SymptomName { get; set; }
    }
}
