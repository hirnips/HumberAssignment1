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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Applicant" in both code and config file together.
    public class Applicant : IApplicant
    {
        public void AddApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Add(items);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Add(items);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Add(items);
        }

        public void AddApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Add(items);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Add(items);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Add(items);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            List<ApplicantEducationPoco> applicantEducationPocos = new List<ApplicantEducationPoco>();
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            applicantEducationPocos =  logic.GetAll();
            return applicantEducationPocos;
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            List<ApplicantJobApplicationPoco> applicantJobApplicationPocos = new List<ApplicantJobApplicationPoco>();
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            applicantJobApplicationPocos = logic.GetAll();
            return applicantJobApplicationPocos;
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            List<ApplicantProfilePoco> applicantProfilePocos = new List<ApplicantProfilePoco>();
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            applicantProfilePocos = logic.GetAll();
            return applicantProfilePocos;
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            List<ApplicantResumePoco> applicantResumePocos = new List<ApplicantResumePoco>();
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            applicantResumePocos = logic.GetAll();
            return applicantResumePocos;
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            List<ApplicantSkillPoco> applicantSkillPocos = new List<ApplicantSkillPoco>();
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            applicantSkillPocos = logic.GetAll();
            return applicantSkillPocos;
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            List<ApplicantWorkHistoryPoco> applicantWorkHistoryPoco = new List<ApplicantWorkHistoryPoco>();
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            applicantWorkHistoryPoco = logic.GetAll();
            return applicantWorkHistoryPoco;
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            ApplicantEducationPoco applicantEducationPoco = new ApplicantEducationPoco();
            applicantEducationPoco = logic.Get(Guid.Parse(Id));
            return applicantEducationPoco;
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            ApplicantJobApplicationPoco applicantJobApplicationPoco = new ApplicantJobApplicationPoco();
            applicantJobApplicationPoco = logic.Get(Guid.Parse(Id));
            return applicantJobApplicationPoco;
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            ApplicantProfilePoco applicantProfilePoco = new ApplicantProfilePoco();
            applicantProfilePoco = logic.Get(Guid.Parse(Id));
            return applicantProfilePoco;
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            ApplicantResumePoco applicantResumePoco = new ApplicantResumePoco();
            applicantResumePoco = logic.Get(Guid.Parse(Id));
            return applicantResumePoco;
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            ApplicantSkillPoco applicantSkillPoco = new ApplicantSkillPoco();
            applicantSkillPoco = logic.Get(Guid.Parse(Id));
            return applicantSkillPoco;
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            ApplicantWorkHistoryPoco applicantWorkHistoryPoco = new ApplicantWorkHistoryPoco();
            applicantWorkHistoryPoco = logic.Get(Guid.Parse(Id));
            return applicantWorkHistoryPoco;
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Delete(items);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Update(items);
        }
    }
}
