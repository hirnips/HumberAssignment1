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
    public class SecurityLoginsRoleController : ApiController
    {
        private SecurityLoginsRoleLogic _logic;

        public SecurityLoginsRoleController()
        {
            _logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
        }

        [HttpGet]
        [Route("loginRole/{securityLoginRoleId}")]
        [ResponseType(typeof(SecurityLoginsRolePoco))]
        public IHttpActionResult GetSecurityLoginsRole(Guid securityLoginRoleId)
        {
            SecurityLoginsRolePoco securityLoginRole = _logic.Get(securityLoginRoleId);
            if (securityLoginRole == null)
            {
                return NotFound();
            }
            return Ok(securityLoginRole);
        }


        [HttpGet]
        [Route("loginRole")]
        [ResponseType(typeof(List<SecurityLoginsRolePoco>))]
        public IHttpActionResult GetAllSecurityLoginRole()
        {
            List<SecurityLoginsRolePoco> securityLoginRole = _logic.GetAll();
            if (securityLoginRole == null)
            {
                return NotFound();
            }
            return Ok(securityLoginRole);
        }

        [HttpPost]
        [Route("loginRole")]
        public IHttpActionResult PostSecurityLoginRole(SecurityLoginsRolePoco[] securityLoginRole)
        {
            if (securityLoginRole == null)
            {
                return NotFound();
            }
            _logic.Add(securityLoginRole);
            return Ok();
        }


        [HttpPut]
        [Route("loginRole")]
        public IHttpActionResult PutSecurityLoginRole(SecurityLoginsRolePoco[] securityLoginRole)
        {
            if (securityLoginRole == null)
            {
                return NotFound();
            }
            _logic.Update(securityLoginRole);
            return Ok();
        }

        [HttpDelete]
        [Route("loginRole")]
        public IHttpActionResult DeleteSecurityLoginRole(SecurityLoginsRolePoco[] securityLoginRole)
        {
            if (securityLoginRole == null)
            {
                return NotFound();
            }
            _logic.Delete(securityLoginRole);
            return Ok();
        }
    }
}
