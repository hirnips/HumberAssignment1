using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Security" in both code and config file together.
    public class Security : ISecurity
    {
        public List<SecurityLoginPoco> GetAllSecurityLogin()
        {
            List<SecurityLoginPoco> securityLoginPoco = new List<SecurityLoginPoco>();
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            securityLoginPoco = logic.GetAll();
            return securityLoginPoco;
        }

        public List<SecurityLoginsLogPoco> GetAllSecurityLoginsLog()
        {
            List<SecurityLoginsLogPoco> securityLoginsLogPoco = new List<SecurityLoginsLogPoco>();
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            securityLoginsLogPoco = logic.GetAll();
            return securityLoginsLogPoco;
        }

        public List<SecurityLoginsRolePoco> GetAllSecurityLoginsRole()
        {
            List<SecurityLoginsRolePoco> securityLoginsRolePoco = new List<SecurityLoginsRolePoco>();
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            securityLoginsRolePoco = logic.GetAll();
            return securityLoginsRolePoco;
        }

        public List<SecurityRolePoco> GetAllSecurityRole()
        {
            List<SecurityRolePoco> securityRolePoco = new List<SecurityRolePoco>();
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            securityRolePoco = logic.GetAll();
            return securityRolePoco;
        }

        public SecurityLoginPoco GetSingleSecurityLogin(string Id)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            SecurityLoginPoco securityLoginPoco = new SecurityLoginPoco();
            securityLoginPoco = logic.Get(Guid.Parse(Id));
            return securityLoginPoco;
        }

        public SecurityLoginsLogPoco GetSingleSecurityLoginsLog(string Id)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            SecurityLoginsLogPoco securityLoginsLogPoco = new SecurityLoginsLogPoco();
            securityLoginsLogPoco = logic.Get(Guid.Parse(Id));
            return securityLoginsLogPoco;
        }

        public SecurityLoginsRolePoco GetSingleSecurityLoginsRole(string Id)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            SecurityLoginsRolePoco securityLoginsRolePoco = new SecurityLoginsRolePoco();
            securityLoginsRolePoco = logic.Get(Guid.Parse(Id));
            return securityLoginsRolePoco;
        }

        public SecurityRolePoco GetSingleSecurityRole(string Id)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            SecurityRolePoco securityRolePoco = new SecurityRolePoco();
            securityRolePoco = logic.Get(Guid.Parse(Id));
            return securityRolePoco;
        }

        public void RemoveSecurityLogin(SecurityLoginPoco[] items)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Delete(items);
        }

        public void RemoveSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Delete(items);
        }

        public void RemoveSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Delete(items);
        }

        public void RemoveSecurityRole(SecurityRolePoco[] items)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            logic.Delete(items);
        }

        public void SecurityLogin(SecurityLoginPoco[] items)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Add(items);
        }

        public void SecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Add(items);
        }

        public void SecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Add(items);
        }

        public void SecurityRole(SecurityRolePoco[] items)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            logic.Add(items);
        }

        public void UpdateSecurityLogin(SecurityLoginPoco[] items)
        {
            var logic = new SecurityLoginLogic(new EFGenericRepository<SecurityLoginPoco>(false));
            logic.Update(items);
        }

        public void UpdateSecurityLoginsLog(SecurityLoginsLogPoco[] items)
        {
            var logic = new SecurityLoginsLogLogic(new EFGenericRepository<SecurityLoginsLogPoco>(false));
            logic.Update(items);
        }

        public void UpdateSecurityLoginsRole(SecurityLoginsRolePoco[] items)
        {
            var logic = new SecurityLoginsRoleLogic(new EFGenericRepository<SecurityLoginsRolePoco>(false));
            logic.Update(items);
        }

        public void UpdateSecurityRole(SecurityRolePoco[] items)
        {
            var logic = new SecurityRoleLogic(new EFGenericRepository<SecurityRolePoco>(false));
            logic.Update(items);
        }
    }
}
