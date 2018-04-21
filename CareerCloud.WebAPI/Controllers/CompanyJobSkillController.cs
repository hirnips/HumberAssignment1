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
    [RoutePrefix("api/careercloud/company/v1")]
    public class CompanyJobSkillController : ApiController
    {
        private CompanyJobSkillLogic _logic;

        public CompanyJobSkillController()
        {
            _logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
        }


        [HttpGet]
        [Route("JobSkill/{companyJobSkillId}")]
        [ResponseType(typeof(CompanyJobSkillPoco))]
        public IHttpActionResult GetCompanyJobSkill(Guid companyJobSkillId)
        {
            CompanyJobSkillPoco companyJobSkill = _logic.Get(companyJobSkillId);
            if (companyJobSkill == null)
            {
                return NotFound();
            }
            return Ok(companyJobSkill);
        }


        [HttpGet]
        [Route("JobSkill")]
        [ResponseType(typeof(List<CompanyJobSkillPoco>))]
        public IHttpActionResult GetAllCompanyJobSkill()
        {
            List<CompanyJobSkillPoco> companyJobSkill = _logic.GetAll();
            if (companyJobSkill == null)
            {
                return NotFound();
            }
            return Ok(companyJobSkill);
        }

        [HttpPost]
        [Route("JobSkill")]
        public IHttpActionResult PostCompanyJobSkill(CompanyJobSkillPoco[] companyJobSkill)
        {
            if (companyJobSkill == null)
            {
                return NotFound();
            }
            _logic.Add(companyJobSkill);
            return Ok();
        }


        [HttpPut]
        [Route("JobSkill")]
        public IHttpActionResult PutCompanyJobSkill(CompanyJobSkillPoco[] companyJobSkill)
        {
            if (companyJobSkill == null)
            {
                return NotFound();
            }
            _logic.Update(companyJobSkill);
            return Ok();
        }

        [HttpDelete]
        [Route("JobSkill")]
        public IHttpActionResult DeleteCompanyJobSkill(CompanyJobSkillPoco[] companyJobSkill)
        {
            if (companyJobSkill == null)
            {
                return NotFound();
            }
            _logic.Delete(companyJobSkill);
            return Ok();
        }
    }
}
