using DoctorsRecoWebapi.Models.Domain_Layer.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorsRecoWebapi.Models.DataLayer
{
    public class DoctorRecoDbContext :DbContext
    {
       public DoctorRecoDbContext() : base("name=defaultconnection") {
        
        

            
        
        }


        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Recommendation> Recommendations { get; set; }

        public DbSet<PatientDetails> PatientDetails { get; set; }
    }




    
}