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
    public class ApplicantResumeController : ApiController
    {
        private ApplicantResumeLogic _logic;

        public ApplicantResumeController()
        {
            _logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
        }


        [HttpGet]
        [Route("resume/{applicantResumeId}")]
        [ResponseType(typeof(ApplicantResumePoco))]
        public IHttpActionResult GetApplicantResume(Guid applicantResumeId)
        {
            ApplicantResumePoco applicantResume = _logic.Get(applicantResumeId);
            if (applicantResume == null)
            {
                return NotFound();
            }
            return Ok(applicantResume);
        }


        [HttpGet]
        [Route("resume")]
        [ResponseType(typeof(List<ApplicantResumePoco>))]
        public IHttpActionResult GetAllApplicantResume()
        {
            List<ApplicantResumePoco> applicantResume = _logic.GetAll();
            if (applicantResume == null)
            {
                return NotFound();
            }
            return Ok(applicantResume);
        }

        [HttpPost]
        [Route("resume")]
        public IHttpActionResult SaveApplicantResume(ApplicantResumePoco[] applicantResume)
        {
            if (applicantResume == null)
            {
                return NotFound();
            }
            _logic.Add(applicantResume);
            return Ok();
        }


        [HttpPut]
        [Route("resume")]
        public IHttpActionResult UpdateApplicantResume(ApplicantResumePoco[] applicantResume)
        {
            if (applicantResume == null)
            {
                return NotFound();
            }
            _logic.Update(applicantResume);
            return Ok();
        }

        [HttpDelete]
        [Route("resume")]
        public IHttpActionResult DeleteApplicantResume(ApplicantResumePoco[] applicantResume)
        {
            if (applicantResume == null)
            {
                return NotFound();
            }
            _logic.Delete(applicantResume);
            return Ok();
        }
    }
}
