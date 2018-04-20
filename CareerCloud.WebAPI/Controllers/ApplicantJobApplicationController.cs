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
    public class ApplicantJobApplicationController : ApiController
    {
        private ApplicantJobApplicationLogic _logic;

        public ApplicantJobApplicationController()
        {
            _logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
        }


        [HttpGet]
        [Route("education/{applicantJobApplicationId}")]
        [ResponseType(typeof(ApplicantJobApplicationPoco))]
        public IHttpActionResult GetApplicantEducation(Guid applicantJobApplicationId)
        {
            ApplicantJobApplicationPoco applicantJobApplication = _logic.Get(applicantJobApplicationId);
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            return Ok(applicantJobApplication);
        }


        [HttpGet]
        [Route("education")]
        [ResponseType(typeof(List<ApplicantJobApplicationPoco>))]
        public IHttpActionResult GetAllApplicantEducation(Guid ApplicantJobApplicationPoco)
        {
            List<ApplicantJobApplicationPoco> applicantJobApplications = _logic.GetAll();
            if (applicantJobApplications == null)
            {
                return NotFound();
            }
            return Ok(applicantJobApplications);
        }

        [HttpPost]
        [Route("education")]
        public IHttpActionResult SaveApplicantEducation(ApplicantJobApplicationPoco[] applicantJobApplication)
        {
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            _logic.Add(applicantJobApplication);
            return Ok();
        }


        [HttpPut]
        [Route("education")]
        public IHttpActionResult UpdateApplicantEducation(ApplicantJobApplicationPoco[] applicantJobApplication)
        {
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            _logic.Update(applicantJobApplication);
            return Ok();
        }

        [HttpDelete]
        [Route("education")]
        public IHttpActionResult DeleteApplicantEducation(ApplicantJobApplicationPoco[] applicantJobApplication)
        {
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            _logic.Delete(applicantJobApplication);
            return Ok();
        }
    }
}
