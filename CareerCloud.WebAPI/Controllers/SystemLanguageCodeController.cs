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
    public class SystemLanguageCodeController : ApiController
    {
        private SystemLanguageCodeLogic _logic;
       
        public SystemLanguageCodeController()
        {
            _logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
        }


        [HttpGet]
        [Route("languageCode/{systemLanguageCodeId}")]
        [ResponseType(typeof(SystemLanguageCodePoco))]
        public IHttpActionResult GetLanguageCode(string systemLanguageCodeId)
        {
            SystemLanguageCodePoco languageCode = _logic.GetSingle(systemLanguageCodeId);
            if (languageCode == null)
            {
                return NotFound();
            }
            return Ok(languageCode);
        }


        [HttpGet]
        [Route("languageCode")]
        [ResponseType(typeof(List<SystemLanguageCodePoco>))]
        public IHttpActionResult GetAllLanguageCode()
        {
            List<SystemLanguageCodePoco> languageCode = _logic.GetAll();
            if (languageCode == null)
            {
                return NotFound();
            }
            return Ok(languageCode);
        }

        [HttpPost]
        [Route("languageCode")]
        public IHttpActionResult SaveLanguageCode(SystemLanguageCodePoco[] languageCode)
        {
            if (languageCode == null)
            {
                return NotFound();
            }
            _logic.Add(languageCode);
            return Ok();
        }


        [HttpPut]
        [Route("languageCode")]
        public IHttpActionResult UpdateLanguageCode(SystemLanguageCodePoco[] languageCode)
        {
            if (languageCode == null)
            {
                return NotFound();
            }
            _logic.Update(languageCode);
            return Ok();
        }

        [HttpDelete]
        [Route("languageCode")]
        public IHttpActionResult DeleteLanguageCode(SystemLanguageCodePoco[] languageCode)
        {
            if (languageCode == null)
            {
                return NotFound();
            }
            _logic.Delete(languageCode);
            return Ok();
        }
    }
}
