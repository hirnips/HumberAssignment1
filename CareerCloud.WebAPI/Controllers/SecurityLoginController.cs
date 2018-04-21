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
    [RoutePrefix("api/careercloud/security/v1")]
    public class SecurityLoginController : ApiController
    {
        private SecurityLoginLogic _logic;

        public SecurityLoginController()
        {
            _logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
        }

        [HttpGet]
        [Route("login/{securityLoginId}")]
        [ResponseType(typeof(SecurityLoginPoco))]
        public IHttpActionResult GetSecurityLogin(Guid securityLoginId)
        {
            SecurityLoginPoco securityLogin = _logic.Get(securityLoginId);
            if (securityLogin == null)
            {
                return NotFound();
            }
            return Ok(securityLogin);
        }


        [HttpGet]
        [Route("login")]
        [ResponseType(typeof(List<SecurityLoginPoco>))]
        public IHttpActionResult GetAllSecurityLogin()
        {
            List<SecurityLoginPoco> securityLogin = _logic.GetAll();
            if (securityLogin == null)
            {
                return NotFound();
            }
            return Ok(securityLogin);
        }

        [HttpPost]
        [Route("login")]
        public IHttpActionResult SaveSecurityLogin(SecurityLoginPoco[] securityLogin)
        {
            if (securityLogin == null)
            {
                return NotFound();
            }
            _logic.Add(securityLogin);
            return Ok();
        }


        [HttpPut]
        [Route("login")]
        public IHttpActionResult UpdateSecurityLogin(SecurityLoginPoco[] securityLogin)
        {
            if (securityLogin == null)
            {
                return NotFound();
            }
            _logic.Update(securityLogin);
            return Ok();
        }

        [HttpDelete]
        [Route("login")]
        public IHttpActionResult DeleteSecurityLogin(SecurityLoginPoco[] securityLogin)
        {
            if (securityLogin == null)
            {
                return NotFound();
            }
            _logic.Delete(securityLogin);
            return Ok();
        }
    }
}
