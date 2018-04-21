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
    public class CompanyDescriptionController : ApiController
    {
        private CompanyDescriptionLogic _logic;

        public CompanyDescriptionController()
        {
            _logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
        }

        [HttpGet]
        [Route("description/{companyDescriptionId}")]
        [ResponseType(typeof(CompanyDescriptionPoco))]
        public IHttpActionResult GetCompanyDescription(Guid companyDescriptionId)
        {
            CompanyDescriptionPoco companyDescription = _logic.Get(companyDescriptionId);
            if (companyDescription == null)
            {
                return NotFound();
            }
            return Ok(companyDescription);
        }


        [HttpGet]
        [Route("description")]
        [ResponseType(typeof(List<CompanyDescriptionPoco>))]
        public IHttpActionResult GetAllCompanyDescription()
        {
            List<CompanyDescriptionPoco> companyDescription = _logic.GetAll();
            if (companyDescription == null)
            {
                return NotFound();
            }
            return Ok(companyDescription);
        }

        [HttpPost]
        [Route("description")]
        public IHttpActionResult PostCompanyDescription(CompanyDescriptionPoco[] companyDescription)
        {
            if (companyDescription == null)
            {
                return NotFound();
            }
            _logic.Add(companyDescription);
            return Ok();
        }


        [HttpPut]
        [Route("description")]
        public IHttpActionResult PutCompanyDescription(CompanyDescriptionPoco[] companyDescription)
        {
            if (companyDescription == null)
            {
                return NotFound();
            }
            _logic.Update(companyDescription);
            return Ok();
        }

        [HttpDelete]
        [Route("description")]
        public IHttpActionResult DeleteCompanyDescription(CompanyDescriptionPoco[] companyDescription)
        {
            if (companyDescription == null)
            {
                return NotFound();
            }
            _logic.Delete(companyDescription);
            return Ok();
        }
    }
}
