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
    public class CompanyLocationController : ApiController
    {
        private CompanyLocationLogic _logic;

        public CompanyLocationController()
        {
            _logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
        }


        [HttpGet]
        [Route("location/{companyLocationId}")]
        [ResponseType(typeof(CompanyLocationPoco))]
        public IHttpActionResult GetCompanyLocation(Guid companyLocationId)
        {
            CompanyLocationPoco companyLocation = _logic.Get(companyLocationId);
            if (companyLocation == null)
            {
                return NotFound();
            }
            return Ok(companyLocation);
        }


        [HttpGet]
        [Route("Location")]
        [ResponseType(typeof(List<CompanyLocationPoco>))]
        public IHttpActionResult GetAllCompanyLocation()
        {
            List<CompanyLocationPoco> companyLocation = _logic.GetAll();
            if (companyLocation == null)
            {
                return NotFound();
            }
            return Ok(companyLocation);
        }

        [HttpPost]
        [Route("Location")]
        public IHttpActionResult SaveCompanyLocation(CompanyLocationPoco[] companyLocation)
        {
            if (companyLocation == null)
            {
                return NotFound();
            }
            _logic.Add(companyLocation);
            return Ok();
        }


        [HttpPut]
        [Route("Location")]
        public IHttpActionResult UpdateCompanyLocation(CompanyLocationPoco[] companyLocation)
        {
            if (companyLocation == null)
            {
                return NotFound();
            }
            _logic.Update(companyLocation);
            return Ok();
        }

        [HttpDelete]
        [Route("Location")]
        public IHttpActionResult DeleteCompanyLocation(CompanyLocationPoco[] companyLocation)
        {
            if (companyLocation == null)
            {
                return NotFound();
            }
            _logic.Delete(companyLocation);
            return Ok();
        }
    }
}
