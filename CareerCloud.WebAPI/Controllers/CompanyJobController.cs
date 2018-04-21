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
    public class CompanyJobController : ApiController
    {
        private CompanyJobLogic _logic;

        public CompanyJobController()
        {
            _logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
        }

        [HttpGet]
        [Route("companyJob/{companyJobId}")]
        [ResponseType(typeof(CompanyJobPoco))]
        public IHttpActionResult GetCompanyJob(Guid companyJobId)
        {
            CompanyJobPoco companyJob = _logic.Get(companyJobId);
            if (companyJob == null)
            {
                return NotFound();
            }
            return Ok(companyJob);
        }


        [HttpGet]
        [Route("companyJob")]
        [ResponseType(typeof(List<CompanyJobPoco>))]
        public IHttpActionResult GetAllCompanyJob()
        {
            List<CompanyJobPoco> companyJob = _logic.GetAll();
            if (companyJob == null)
            {
                return NotFound();
            }
            return Ok(companyJob);
        }

        [HttpPost]
        [Route("companyJob")]
        public IHttpActionResult PostCompanyJob(CompanyJobPoco[] companyJob)
        {
            if (companyJob == null)
            {
                return NotFound();
            }
            _logic.Add(companyJob);
            return Ok();
        }


        [HttpPut]
        [Route("companyJob")]
        public IHttpActionResult PutCompanyJob(CompanyJobPoco[] companyJob)
        {
            if (companyJob == null)
            {
                return NotFound();
            }
            _logic.Update(companyJob);
            return Ok();
        }

        [HttpDelete]
        [Route("companyJob")]
        public IHttpActionResult DeleteCompanyJob(CompanyJobPoco[] companyJob)
        {
            if (companyJob == null)
            {
                return NotFound();
            }
            _logic.Delete(companyJob);
            return Ok();
        }
    }
}
