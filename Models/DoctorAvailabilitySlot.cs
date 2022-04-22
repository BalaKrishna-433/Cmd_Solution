using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DoctorAvailabilitySlot
    {
        [Key]
        public int SlotId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime SlotDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public float SlotDuration { get; set; }
        public string Description { get; set; }
    }
}
