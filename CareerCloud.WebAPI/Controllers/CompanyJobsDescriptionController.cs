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
    public class CompanyJobsDescriptionController : ApiController
    {
        private CompanyJobDescriptionLogic _logic;
        public CompanyJobsDescriptionController()
        {
            _logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
        }

        [HttpGet]
        [Route("jobDescription/{companyJobDescriptionId}")]
        [ResponseType(typeof(CompanyJobDescriptionPoco))]
        public IHttpActionResult GetCompanyJobsDescription(Guid companyJobDescriptionId)
        {
            CompanyJobDescriptionPoco companyJobDescription = _logic.Get(companyJobDescriptionId);
            if (companyJobDescription == null)
            {
                return NotFound();
            }
            return Ok(companyJobDescription);
        }


        [HttpGet]
        [Route("jobDescription")]
        [ResponseType(typeof(List<CompanyJobDescriptionPoco>))]
        public IHttpActionResult GetAllCompanyJobDescription()
        {
            List<CompanyJobDescriptionPoco> companyJobDescription = _logic.GetAll();
            if (companyJobDescription == null)
            {
                return NotFound();
            }
            return Ok(companyJobDescription);
        }

        [HttpPost]
        [Route("jobDescription")]
        public IHttpActionResult PostCompanyJobsDescription(CompanyJobDescriptionPoco[] companyJobDescription)
        {
            if (companyJobDescription == null)
            {
                return NotFound();
            }
            _logic.Add(companyJobDescription);
            return Ok();
        }


        [HttpPut]
        [Route("jobDescription")]
        public IHttpActionResult PutCompanyJobsDescription(CompanyJobDescriptionPoco[] companyJobDescription)
        {
            if (companyJobDescription == null)
            {
                return NotFound();
            }
            _logic.Update(companyJobDescription);
            return Ok();
        }

        [HttpDelete]
        [Route("jobDescription")]
        public IHttpActionResult DeleteCompanyJobsDescription(CompanyJobDescriptionPoco[] companyJobDescription)
        {
            if (companyJobDescription == null)
            {
                return NotFound();
            }
            _logic.Delete(companyJobDescription);
            return Ok();
        }
    }
}
