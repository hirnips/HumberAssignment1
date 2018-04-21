using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.DataAccessLayer;
using System.Web.Http.Description;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/system/v1")]
    public class SystemCountryCodeController : ApiController
    {
        private SystemCountryCodeLogic _logic;
        
        public SystemCountryCodeController()
        {            
            _logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
        }

        [HttpGet]
        [Route("code/{systemCountryCodeId}")]
        [ResponseType(typeof(SystemCountryCodePoco))]
        public IHttpActionResult GetCountryCode(string systemCountryCodeId)
        {
            SystemCountryCodePoco countryCode = _logic.GetSingle(systemCountryCodeId);
            if (countryCode == null)
            {
                return NotFound();
            }
            return Ok(countryCode);
        }


        [HttpGet]
        [Route("code")]
        [ResponseType(typeof(List<SystemCountryCodePoco>))]
        public IHttpActionResult GetAllCountryCode()
        {
            List<SystemCountryCodePoco> countryCode = _logic.GetAll();
            if (countryCode == null)
            {
                return NotFound();
            }
            return Ok(countryCode);
        }

        [HttpPost]
        [Route("code")]
        public IHttpActionResult SaveCountryCode(SystemCountryCodePoco[] countryCode)
        {
            if (countryCode == null)
            {
                return NotFound();
            }
            _logic.Add(countryCode);
            return Ok();
        }


        [HttpPut]
        [Route("code")]
        public IHttpActionResult UpdateCountryCode(SystemCountryCodePoco[] countryCode)
        {
            if (countryCode == null)
            {
                return NotFound();
            }
            _logic.Update(countryCode);
            return Ok();
        }

        [HttpDelete]
        [Route("code")]
        public IHttpActionResult DeleteCountryCode(SystemCountryCodePoco[] countryCode)
        {
            if (countryCode == null)
            {
                return NotFound();
            }
            _logic.Delete(countryCode);
            return Ok();
        }
    }
}
