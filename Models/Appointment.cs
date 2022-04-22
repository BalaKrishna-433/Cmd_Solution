using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }
        public string Comments { get; set; }
        public Feedback Feedback { get; set; }
        [Column(TypeName = "Date")]
        public DateTime AppointmentDate { get; set; } 
        public TimeSpan AppointmentTime { get; set; } 
        public AppointmentStatus AppointmentStatus { get; set; } = AppointmentStatus.Open;
        
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
