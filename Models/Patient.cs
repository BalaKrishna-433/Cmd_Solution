using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public Gender Gender { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DOB { get; set; }
        public ContactDetails ContactDetails { get; set; }
    }
}
