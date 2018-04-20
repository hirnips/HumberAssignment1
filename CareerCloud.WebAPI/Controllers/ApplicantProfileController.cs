using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using CareerCloud.EntityFrameworkDataAccess;
using System.Web.Http.Description;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/applicant/v1")]
    public class ApplicantProfileController : ApiController
    {
        private ApplicantProfileLogic _logic;

        public ApplicantProfileController()
        {
            _logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
        }


        [HttpGet]
        [Route("profile/{applicantProfileId}")]
        [ResponseType(typeof(ApplicantProfilePoco))]
        public IHttpActionResult GetApplicantProfile(Guid applicantProfileId)
        {
            ApplicantProfilePoco applicantProfile = _logic.Get(applicantProfileId);
            if (applicantProfile == null)
            {
                return NotFound();
            }
            return Ok(applicantProfile);
        }


        [HttpGet]
        [Route("profile")]
        [ResponseType(typeof(List<ApplicantProfilePoco>))]
        public IHttpActionResult GetAllApplicantProfile()
        {
            List<ApplicantProfilePoco> applicantProfiles = _logic.GetAll();
            if (applicantProfiles == null)
            {
                return NotFound();
            }
            return Ok(applicantProfiles);
        }

        [HttpPost]
        [Route("profile")]
        public IHttpActionResult SaveApplicantProfile(ApplicantProfilePoco[] applicantProfile)
        {
            if (applicantProfile == null)
            {
                return NotFound();
            }
            _logic.Add(applicantProfile);
            return Ok();
        }


        [HttpPut]
        [Route("profile")]
        public IHttpActionResult UpdateApplicantProfile(ApplicantProfilePoco[] applicantProfile)
        {
            if (applicantProfile == null)
            {
                return NotFound();
            }
            _logic.Update(applicantProfile);
            return Ok();
        }

        [HttpDelete]
        [Route("profile")]
        public IHttpActionResult DeleteApplicantProfile(ApplicantProfilePoco[] applicantProfile)
        {
            if (applicantProfile == null)
            {
                return NotFound();
            }
            _logic.Delete(applicantProfile);
            return Ok();
        }
    }
}
