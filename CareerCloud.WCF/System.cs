using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "System" in both code and config file together.
    public class System : ISystem
    {
        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            //EFGenericRepository<SystemCountryCodePoco> systemCountryCode = new EFGenericRepository<SystemCountryCodePoco>(false);
            List<SystemCountryCodePoco> systemCountryCodePocos = logic.GetAll().ToList();
            return systemCountryCodePocos;
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            //EFGenericRepository<SystemCountryCodePoco> systemCountryCode = new EFGenericRepository<SystemCountryCodePoco>(false);
            List<SystemLanguageCodePoco> systemLanguageCodePoco = logic.GetAll().ToList();
            return systemLanguageCodePoco;
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string Id)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            SystemCountryCodePoco systemCountryCodePoco = new SystemCountryCodePoco();
            systemCountryCodePoco = logic.GetSingle(Id);
            return systemCountryCodePoco;
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            SystemLanguageCodePoco systemLanguageCodePoco = new SystemLanguageCodePoco();
            systemLanguageCodePoco = logic.GetSingle(Id);
            return systemLanguageCodePoco;
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Delete(items);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Delete(items);
        }

        public void AddSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Add(items);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Add(items);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic(new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Update(items);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic(new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Update(items);
        }
    }
}
