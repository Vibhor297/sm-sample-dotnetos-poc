using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArRiskManagement
    {
        public decimal ArRiskManageRecordNo { get; set; }
        public string StudentBehaviourInd { get; set; }
        public DateTime? StudentBehaviourDevelopDate { get; set; }
        public DateTime? StudentBehaviourReviewDate { get; set; }
        public string HealthPlanInd { get; set; }
        public DateTime? HealthPlanDevelopDate { get; set; }
        public DateTime? HealthPlanReviewDate { get; set; }
        public decimal TransactionNo { get; set; }
        public string RiskToOtherInd { get; set; }
        public string SeperateRiskInd { get; set; }
        public DateTime? SeperateRiskDevelopDate { get; set; }
        public DateTime? SeperateRiskReviewDate { get; set; }
    }
}
