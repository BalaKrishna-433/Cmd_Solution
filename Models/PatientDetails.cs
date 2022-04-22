using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PatientDetails
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public ICollection<VitalReading> VitalReadings { get; set; }
        public ICollection<MedicalProblem> MedicalProblem { get; set; }
        public ICollection<Issue> Issues { get; set; }
        public ICollection<Allergy> Allergies { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<TestReport> TestReports { get; set; }
        public SymptomDetails SymptomDetails { get; set; }
    }
}
