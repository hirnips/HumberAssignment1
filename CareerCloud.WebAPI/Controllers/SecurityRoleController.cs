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
    public class SecurityRoleController : ApiController
    {
        private SecurityRoleLogic _logic;

        public SecurityRoleController()
        {
            _logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
        }


        [HttpGet]
        [Route("role/{securityRoleId}")]
        [ResponseType(typeof(SecurityRolePoco))]
        public IHttpActionResult GetSecurityRole(Guid securityRoleId)
        {
            SecurityRolePoco securityRole = _logic.Get(securityRoleId);
            if (securityRole == null)
            {
                return NotFound();
            }
            return Ok(securityRole);
        }


        [HttpGet]
        [Route("role")]
        [ResponseType(typeof(List<SecurityRolePoco>))]
        public IHttpActionResult GetAllSecurityRole()
        {
            List<SecurityRolePoco> securityRole = _logic.GetAll();
            if (securityRole == null)
            {
                return NotFound();
            }
            return Ok(securityRole);
        }

        [HttpPost]
        [Route("role")]
        public IHttpActionResult SaveSecurityRole(SecurityRolePoco[] securityRole)
        {
            if (securityRole == null)
            {
                return NotFound();
            }
            _logic.Add(securityRole);
            return Ok();
        }


        [HttpPut]
        [Route("role")]
        public IHttpActionResult UpdateSecurityRole(SecurityRolePoco[] securityRole)
        {
            if (securityRole == null)
            {
                return NotFound();
            }
            _logic.Update(securityRole);
            return Ok();
        }

        [HttpDelete]
        [Route("role")]
        public IHttpActionResult DeleteSecurityRole(SecurityRolePoco[] securityRole)
        {
            if (securityRole == null)
            {
                return NotFound();
            }
            _logic.Delete(securityRole);
            return Ok();
        }
    }
}
