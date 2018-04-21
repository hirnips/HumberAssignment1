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
    public class SecurityLoginsLogController : ApiController
    {
        private SecurityLoginsLogLogic _logic;

        public SecurityLoginsLogController()
        {
            _logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
        }

        [HttpGet]
        [Route("loginLog/{securityLoginLogId}")]
        [ResponseType(typeof(SecurityLoginsLogPoco))]
        public IHttpActionResult GetSecurityLoginLog(Guid securityLoginLogId)
        {
            SecurityLoginsLogPoco securityLoginLog = _logic.Get(securityLoginLogId);
            if (securityLoginLog == null)
            {
                return NotFound();
            }
            return Ok(securityLoginLog);
        }


        [HttpGet]
        [Route("loginLog")]
        [ResponseType(typeof(List<SecurityLoginsLogPoco>))]
        public IHttpActionResult GetAllSecurityLoginLog()
        {
            List<SecurityLoginsLogPoco> securityLoginLog = _logic.GetAll();
            if (securityLoginLog == null)
            {
                return NotFound();
            }
            return Ok(securityLoginLog);
        }

        [HttpPost]
        [Route("loginLog")]
        public IHttpActionResult SaveSecurityLoginLog(SecurityLoginsLogPoco[] securityLoginLog)
        {
            if (securityLoginLog == null)
            {
                return NotFound();
            }
            _logic.Add(securityLoginLog);
            return Ok();
        }


        [HttpPut]
        [Route("loginLog")]
        public IHttpActionResult UpdateSecurityLoginLog(SecurityLoginsLogPoco[] securityLoginLog)
        {
            if (securityLoginLog == null)
            {
                return NotFound();
            }
            _logic.Update(securityLoginLog);
            return Ok();
        }

        [HttpDelete]
        [Route("loginLog")]
        public IHttpActionResult DeleteSecurityLoginLog(SecurityLoginsLogPoco[] securityLoginLog)
        {
            if (securityLoginLog == null)
            {
                return NotFound();
            }
            _logic.Delete(securityLoginLog);
            return Ok();
        }
    }
}
