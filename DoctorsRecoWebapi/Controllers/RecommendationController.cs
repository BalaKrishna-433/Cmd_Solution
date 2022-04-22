using DoctorsRecoWebapi.Models.DataLayer;
using DoctorsRecoWebapi.Models.Domain_Layer.Entites;
using DoctorsRecoWebapi.Models.Domain_Layer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoctorsRecoWebapi.Controllers
{
    [RoutePrefix("api/recommendation")]
    public class RecommendationController : ApiController
    {
        private IDoctorReco doctorReco = new DoctorRecommendation();

        [HttpGet]
        [Route("doctor")]
        public List<Doctor> GetDoctorNames() {

            return doctorReco.GetDoctors();
        }

        [HttpPost]

        public IHttpActionResult Addrecom( Recommendation Addrecom)
        {
             var reco = doctorReco.AddRecommendtaion(Addrecom );

            return Created($"api/recommendation/{reco.RecommedationId}", reco);
        }

        [HttpDelete]

        public IHttpActionResult Remove(int id)
        {
            if (!doctorReco.RemoveRecommendation(id))
                return BadRequest();
            return Ok();
            

        }


        [HttpGet]
        [Route("allrecommendations")]
        public ICollection<Recommendation> GetAllRecommendation()
        {

            return doctorReco.GetAllRecommendation();
        }
    }
}
