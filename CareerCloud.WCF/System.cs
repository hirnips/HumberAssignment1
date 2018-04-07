using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "System" in both code and config file together.
    public class System : ISystem
    {
        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            throw new NotImplementedException();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            throw new NotImplementedException();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string Id)
        {
            throw new NotImplementedException();
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string Id)
        {
            throw new NotImplementedException();
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void SystemCountryCode(SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void SystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] items)
        {
            throw new NotImplementedException();
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}
