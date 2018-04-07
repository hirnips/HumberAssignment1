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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Company" in both code and config file together.
    public class Company : ICompany
    {
        public void CompanyDescription(CompanyDescriptionPoco[] items)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Add(items);
        }

        public void CompanyJob(CompanyJobPoco[] items)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            logic.Add(items);
        }

        public void CompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Add(items);
        }

        public void CompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Add(items);
        }

        public void CompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Add(items);
        }

        public void CompanyLocation(CompanyLocationPoco[] items)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Add(items);
        }

        public void CompanyProfile(CompanyProfilePoco[] items)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Add(items);
        }


        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            List<CompanyDescriptionPoco> companyDescriptionPoco = new List<CompanyDescriptionPoco>();
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            companyDescriptionPoco = logic.GetAll();
            return companyDescriptionPoco;
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            List<CompanyJobPoco> companyJobPoco = new List<CompanyJobPoco>();
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            companyJobPoco = logic.GetAll();
            return companyJobPoco;
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            List<CompanyJobDescriptionPoco> companyJobDescriptionPoco = new List<CompanyJobDescriptionPoco>();
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            companyJobDescriptionPoco = logic.GetAll();
            return companyJobDescriptionPoco;
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            List<CompanyJobEducationPoco> companyJobEducationPoco = new List<CompanyJobEducationPoco>();
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            companyJobEducationPoco = logic.GetAll();
            return companyJobEducationPoco;
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            List<CompanyJobSkillPoco> companyJobSkillPoco = new List<CompanyJobSkillPoco>();
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            companyJobSkillPoco = logic.GetAll();
            return companyJobSkillPoco;
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            List<CompanyLocationPoco> companyLocationPoco = new List<CompanyLocationPoco>();
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            companyLocationPoco = logic.GetAll();
            return companyLocationPoco;
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            List<CompanyProfilePoco> companyProfilePoco = new List<CompanyProfilePoco>();
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            companyProfilePoco = logic.GetAll();
            return companyProfilePoco;
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string Id)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            CompanyDescriptionPoco companyDescriptionPoco = new CompanyDescriptionPoco();
            companyDescriptionPoco = logic.Get(Guid.Parse(Id));
            return companyDescriptionPoco;
        }

        public CompanyJobPoco GetSingleCompanyJob(string Id)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            CompanyJobPoco companyJobPoco = new CompanyJobPoco();
            companyJobPoco = logic.Get(Guid.Parse(Id));
            return companyJobPoco;
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            CompanyJobDescriptionPoco companyJobDescriptionPoco = new CompanyJobDescriptionPoco();
            companyJobDescriptionPoco = logic.Get(Guid.Parse(Id));
            return companyJobDescriptionPoco;
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            CompanyJobEducationPoco companyJobEducationPoco = new CompanyJobEducationPoco();
            companyJobEducationPoco = logic.Get(Guid.Parse(Id));
            return companyJobEducationPoco;
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            CompanyJobSkillPoco companyJobSkillPoco = new CompanyJobSkillPoco();
            companyJobSkillPoco = logic.Get(Guid.Parse(Id));
            return companyJobSkillPoco;
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string Id)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            CompanyLocationPoco companyLocationPoco = new CompanyLocationPoco();
            companyLocationPoco = logic.Get(Guid.Parse(Id));
            return companyLocationPoco;
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string Id)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            CompanyProfilePoco companyProfilePoco = new CompanyProfilePoco();
            companyProfilePoco = logic.Get(Guid.Parse(Id));
            return companyProfilePoco;
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] items)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJob(CompanyJobPoco[] items)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] items)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] items)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Delete(items);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] items)
        {
            var logic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] items)
        {
            var logic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            var logic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            var logic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            var logic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] items)
        {
            var logic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] items)
        {
            var logic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Update(items);
        }
    }
}
