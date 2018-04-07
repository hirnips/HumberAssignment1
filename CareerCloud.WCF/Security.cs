using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Security" in both code and config file together.
    public class Security : ISecurity
    {
        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            throw new NotImplementedException();
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            throw new NotImplementedException();
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            throw new NotImplementedException();
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            throw new NotImplementedException();
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveSecurityRole(SecurityRolePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void SecurityLogin(SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void SecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void SecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void SecurityRole(SecurityRolePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSecurityRole(SecurityRolePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
