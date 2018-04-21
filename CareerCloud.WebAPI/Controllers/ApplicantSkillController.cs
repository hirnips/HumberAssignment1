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
    public class ApplicantSkillController : ApiController
    {
        private ApplicantSkillLogic _logic;

        public ApplicantSkillController()
        {
            _logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
        }

        [HttpGet]
        [Route("skill/{applicantSkillId}")]
        [ResponseType(typeof(ApplicantSkillPoco))]
        public IHttpActionResult GetApplicantSkill(Guid applicantSkillId)
        {
            ApplicantSkillPoco applicantSkill = _logic.Get(applicantSkillId);
            if (applicantSkill == null)
            {
                return NotFound();
            }
            return Ok(applicantSkill);
        }


        [HttpGet]
        [Route("skill")]
        [ResponseType(typeof(List<ApplicantSkillPoco>))]
        public IHttpActionResult GetAllApplicantSkill()
        {
            List<ApplicantSkillPoco> applicantSkill = _logic.GetAll();
            if (applicantSkill == null)
            {
                return NotFound();
            }
            return Ok(applicantSkill);
        }

        [HttpPost]
        [Route("skill")]
        public IHttpActionResult PostApplicantSkill(ApplicantSkillPoco[] applicantSkill)
        {
            if (applicantSkill == null)
            {
                return NotFound();
            }
            _logic.Add(applicantSkill);
            return Ok();
        }


        [HttpPut]
        [Route("skill")]
        public IHttpActionResult PutApplicantSkill(ApplicantSkillPoco[] applicantSkill)
        {
            if (applicantSkill == null)
            {
                return NotFound();
            }
            _logic.Update(applicantSkill);
            return Ok();
        }

        [HttpDelete]
        [Route("skill")]
        public IHttpActionResult DeleteApplicantSkill(ApplicantSkillPoco[] applicantSkill)
        {
            if (applicantSkill == null)
            {
                return NotFound();
            }
            _logic.Delete(applicantSkill);
            return Ok();
        }
    }
}
