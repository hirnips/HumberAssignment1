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
    public class ApplicantEducationController : ApiController
    {
        private ApplicantEducationLogic _logic;

        public ApplicantEducationController()
        {
            _logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
        }

        [HttpGet]
        [Route("education/{applicantEducationId}")]
        [ResponseType(typeof(ApplicantEducationPoco))]
        public IHttpActionResult GetApplicantEducation(Guid applicantEducationId)
        {
            ApplicantEducationPoco applicantEducation = _logic.Get(applicantEducationId);
            if(applicantEducation == null)
            {
                return NotFound();
            }
            return Ok(applicantEducation);
        }


        [HttpGet]
        [Route("education")]
        [ResponseType(typeof(List<ApplicantEducationPoco>))]
        public IHttpActionResult GetAllApplicantEducation()
        {
            List<ApplicantEducationPoco> applicantEducations = _logic.GetAll();
            if (applicantEducations == null)
            {
                return NotFound();
            }
            return Ok(applicantEducations);
        }

        [HttpPost]
        [Route("education")]
        public IHttpActionResult PostApplicantEducation(ApplicantEducationPoco[] applicantEducations)
        {
            if(applicantEducations == null)
            {
                return NotFound();
            }
            _logic.Add(applicantEducations);
            return Ok();
        }


        [HttpPut]
        [Route("education")]
        public IHttpActionResult PutApplicantEducation(ApplicantEducationPoco[] applicantEducations)
        {
            if (applicantEducations == null)
            {
                return NotFound();
            }
            _logic.Update(applicantEducations);
            return Ok();
        }

        [HttpDelete]
        [Route("education")]
        public IHttpActionResult DeleteApplicantEducation(ApplicantEducationPoco[] applicantEducations)
        {
            if (applicantEducations == null)
            {
                return NotFound();
            }
            _logic.Delete(applicantEducations);
            return Ok();
        }
    }
}
