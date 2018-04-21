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
    public class ApplicantWorkHistoryController : ApiController
    {
        private ApplicantWorkHistoryLogic _logic;

        public ApplicantWorkHistoryController()
        {
            _logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
        }

        [HttpGet]
        [Route("workHistory/{applicantWorkHistoryId}")]
        [ResponseType(typeof(ApplicantWorkHistoryPoco))]
        public IHttpActionResult GetApplicantWorkHistory(Guid applicantWorkHistoryId)
        {
            ApplicantWorkHistoryPoco applicantWorkHistory = _logic.Get(applicantWorkHistoryId);
            if (applicantWorkHistory == null)
            {
                return NotFound();
            }
            return Ok(applicantWorkHistory);
        }


        [HttpGet]
        [Route("workHistory")]
        [ResponseType(typeof(List<ApplicantWorkHistoryPoco>))]
        public IHttpActionResult GetAllApplicantWorkHistory()
        {
            List<ApplicantWorkHistoryPoco> applicantWorkHistory = _logic.GetAll();
            if (applicantWorkHistory == null)
            {
                return NotFound();
            }
            return Ok(applicantWorkHistory);
        }

        [HttpPost]
        [Route("workHistory")]
        public IHttpActionResult PostApplicantWorkHistory(ApplicantWorkHistoryPoco[] applicantWorkHistory)
        {
            if (applicantWorkHistory == null)
            {
                return NotFound();
            }
            _logic.Add(applicantWorkHistory);
            return Ok();
        }


        [HttpPut]
        [Route("workHistory")]
        public IHttpActionResult PutApplicantWorkHistory(ApplicantWorkHistoryPoco[] applicantWorkHistory)
        {
            if (applicantWorkHistory == null)
            {
                return NotFound();
            }
            _logic.Update(applicantWorkHistory);
            return Ok();
        }

        [HttpDelete]
        [Route("workHistory")]
        public IHttpActionResult DeleteApplicantWorkHistory(ApplicantWorkHistoryPoco[] applicantWorkHistory)
        {
            if (applicantWorkHistory == null)
            {
                return NotFound();
            }
            _logic.Delete(applicantWorkHistory);
            return Ok();
        }
    }
}
