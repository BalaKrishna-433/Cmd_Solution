using DoctorsRecoWebapi.Models.Domain_Layer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace DoctorsRecoWebapi.Models.Domain_Layer.Repositories
{
    internal interface IDoctorReco
    {
        List<Doctor> GetDoctors();

        Recommendation AddRecommendtaion( Recommendation reco);



        bool RemoveRecommendation(int id);


        ICollection<Recommendation> GetAllRecommendation();


    }
}
