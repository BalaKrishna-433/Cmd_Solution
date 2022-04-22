using DoctorsRecoWebapi.Models.Domain_Layer.Entites;
using DoctorsRecoWebapi.Models.Domain_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;

namespace DoctorsRecoWebapi.Models.DataLayer
{
    public class DoctorRecommendation : IDoctorReco
    {

        private DoctorRecoDbContext db= new DoctorRecoDbContext();

        public Recommendation AddRecommendtaion( Recommendation reco)
        {
            
            
            db.Recommendations.Add(reco);
            db.SaveChanges();
            return reco;
            //return Created($"api/recommendation/{reco.id}", reco);

        }


        public ICollection<Recommendation> GetAllRecommendation()
        {

            return db.Recommendations.Include("PatientDetails").Include("RecommendedDoctor").ToList();
        }

        public List<Doctor> GetDoctors()
        {
            return db.Doctors.ToList(); 
        }

        public bool RemoveRecommendation(int id)
        {
            var r = db.Recommendations.Find(id);
            db.Recommendations.Remove(r);
            return db.SaveChanges()>0;

            
        }
    }
}