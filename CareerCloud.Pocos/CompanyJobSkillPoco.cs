﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {

        [Key]
        public Guid Id { get; set; }

        public Guid Job { get; set; }

        public string Skill { get; set; }

        [Column("Skill_Level")]
        public string SkillLevel { get; set; }

        public int Importance { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }
        public virtual CompanyJobPoco CompanyJob { get; set; }
    }
}
