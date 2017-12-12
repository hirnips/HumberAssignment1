using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
   public  class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public Guid Applicant { get; set; }

        [Column("Company_Name")]
        public string CompanyName { get; set; }

        [Column("Country_Code")]
        public string CountryCode { get; set; }

        public string Location { get; set; }

        [Column("Job_Title")]
        public string Job_Title { get; set; }

        [Column("Job_Description")]
        public string JobDescription { get; set; }

        [Column("Start_Month")]
        public Byte Start_Month { get; set; }

        [Column("Start_Year")]
        public int Start_Year { get; set; }

        [Column("End_Month")]
        public Byte End_Month { get; set; }

        [Column("End_Year")]
        public int End_Year { get; set; }

        [Column("Time_Stamp")]
        public Byte[] Time_Stamp { get; set; }
    }
}
