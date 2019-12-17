using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArDisabilitySkill
    {
        public decimal ArDisabilitySkillRecordNo { get; set; }
        public decimal? SkillCommentRecordNo { get; set; }
        public decimal? ArEiProfSummRecordNo { get; set; }
        public decimal DisabilitySkillRecordNo { get; set; }
        public decimal? DisabilityOutcomeRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? ArKindiProfSummRecordNo { get; set; }
    }
}
