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
    public class CompanyProfileController : ApiController
    {
        private CompanyProfileLogic _logic;

        public CompanyProfileController()
        {
            _logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
        }


        [HttpGet]
        [Route("profile/{companyProfileId}")]
        [ResponseType(typeof(CompanyProfilePoco))]
        public IHttpActionResult GetCompanyProfile(Guid companyProfileId)
        {
            CompanyProfilePoco companyProfile = _logic.Get(companyProfileId);
            if (companyProfile == null)
            {
                return NotFound();
            }
            return Ok(companyProfile);
        }


        [HttpGet]
        [Route("Profile")]
        [ResponseType(typeof(List<CompanyProfilePoco>))]
        public IHttpActionResult GetAllCompanyProfile()
        {
            List<CompanyProfilePoco> companyProfile = _logic.GetAll();
            if (companyProfile == null)
            {
                return NotFound();
            }
            return Ok(companyProfile);
        }

        [HttpPost]
        [Route("Profile")]
        public IHttpActionResult SaveCompanyProfile(CompanyProfilePoco[] companyProfile)
        {
            if (companyProfile == null)
            {
                return NotFound();
            }
            _logic.Add(companyProfile);
            return Ok();
        }


        [HttpPut]
        [Route("Profile")]
        public IHttpActionResult UpdateCompanyProfile(CompanyProfilePoco[] companyProfile)
        {
            if (companyProfile == null)
            {
                return NotFound();
            }
            _logic.Update(companyProfile);
            return Ok();
        }

        [HttpDelete]
        [Route("Profile")]
        public IHttpActionResult DeleteCompanyProfile(CompanyProfilePoco[] companyProfile)
        {
            if (companyProfile == null)
            {
                return NotFound();
            }
            _logic.Delete(companyProfile);
            return Ok();
        }
    }
}
