using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoctorsRecoWebapi.Models.Domain_Layer.Entites
{
    public class Recommendation
    {
        [Key]
        public int RecommedationId { get; set; }
        [ForeignKey("PatientDetails")]
        public int PatientDetialId { get; set; }
        public PatientDetails PatientDetails { get; set; }
        [ForeignKey("RecommendedDoctor")]
        public int RecommendedDoctorId { get; set; }
        public Doctor RecommendedDoctor { get; set; }


    }
}