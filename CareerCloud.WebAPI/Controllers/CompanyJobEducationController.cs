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
    public class CompanyJobEducationController : ApiController
    {
        private CompanyJobEducationLogic _logic;

        public CompanyJobEducationController()
        {
            _logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
        }

        [HttpGet]
        [Route("jobEducation/{companyjobEducationId}")]
        [ResponseType(typeof(CompanyJobEducationPoco))]
        public IHttpActionResult GetCompanyJobEducation(Guid companyJobEducationId)
        {
            CompanyJobEducationPoco companyJobEducation = _logic.Get(companyJobEducationId);
            if (companyJobEducation == null)
            {
                return NotFound();
            }
            return Ok(companyJobEducation);
        }


        [HttpGet]
        [Route("jobEducation")]
        [ResponseType(typeof(List<CompanyJobEducationPoco>))]
        public IHttpActionResult GetAllCompanyJobEducation()
        {
            List<CompanyJobEducationPoco> companyJobEducation = _logic.GetAll();
            if (companyJobEducation == null)
            {
                return NotFound();
            }
            return Ok(companyJobEducation);
        }

        [HttpPost]
        [Route("jobEducation")]
        public IHttpActionResult PostCompanyJobEducation(CompanyJobEducationPoco[] companyJobEducation)
        {
            if (companyJobEducation == null)
            {
                return NotFound();
            }
            _logic.Add(companyJobEducation);
            return Ok();
        }


        [HttpPut]
        [Route("jobEducation")]
        public IHttpActionResult PutCompanyJobEducation(CompanyJobEducationPoco[] companyJobEducation)
        {
            if (companyJobEducation == null)
            {
                return NotFound();
            }
            _logic.Update(companyJobEducation);
            return Ok();
        }

        [HttpDelete]
        [Route("jobEducation")]
        public IHttpActionResult DeleteCompanyJobEducation(CompanyJobEducationPoco[] companyJobEducation)
        {
            if (companyJobEducation == null)
            {
                return NotFound();
            }
            _logic.Delete(companyJobEducation);
            return Ok();
        }
    }
}
