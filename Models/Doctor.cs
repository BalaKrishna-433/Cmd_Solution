using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public int NPINumber { get; set; }
        public string PracticeLocation { get; set; }
        public ICollection<Speciality> Specialities { get; set; }
        public ContactDetails ContactDetails { get; set; }
        public ICollection<DoctorAvailabilitySlot> Slots { get; set; }
        public ICollection<Recommedation> Recommedations { get; set; }
    }
}
