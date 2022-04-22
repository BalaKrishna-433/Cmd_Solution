using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Medicine
    {
        [Key]
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
    }
}
