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
        [Route("jobApplication/{applicantJobApplicationId}")]
        [ResponseType(typeof(ApplicantJobApplicationPoco))]
        public IHttpActionResult GetApplicantJobApplication(Guid applicantJobApplicationId)
        {
            ApplicantJobApplicationPoco applicantJobApplication = _logic.Get(applicantJobApplicationId);
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            return Ok(applicantJobApplication);
        }


        [HttpGet]
        [Route("jobApplication")]
        [ResponseType(typeof(List<ApplicantJobApplicationPoco>))]
        public IHttpActionResult GetAllApplicantJobApplication()
        {
            List<ApplicantJobApplicationPoco> applicantJobApplications = _logic.GetAll();
            if (applicantJobApplications == null)
            {
                return NotFound();
            }
            return Ok(applicantJobApplications);
        }

        [HttpPost]
        [Route("jobApplication")]
        public IHttpActionResult PostApplicantJobApplication(ApplicantJobApplicationPoco[] applicantJobApplication)
        {
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            _logic.Add(applicantJobApplication);
            return Ok();
        }


        [HttpPut]
        [Route("jobApplication")]
        public IHttpActionResult PutApplicantJobApplication(ApplicantJobApplicationPoco[] applicantJobApplication)
        {
            if (applicantJobApplication == null)
            {
                return NotFound();
            }
            _logic.Update(applicantJobApplication);
            return Ok();
        }

        [HttpDelete]
        [Route("jobApplication")]
        public IHttpActionResult DeleteApplicantJobApplication(ApplicantJobApplicationPoco[] applicantJobApplication)
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
