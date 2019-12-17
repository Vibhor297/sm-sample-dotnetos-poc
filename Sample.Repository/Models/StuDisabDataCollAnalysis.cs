using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StuDisabDataCollAnalysis
    {
        public decimal StuDisabDataCollAnRecNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? LastReviewDate { get; set; }
        public DateTime? AdjustmentStartDate { get; set; }
        public DateTime? NextReviewDate { get; set; }
        public decimal? StudentRecordNo { get; set; }
        public decimal? LevelOfAdjustmentRecordNo { get; set; }
        public decimal? StuDataCollStatusRecNo { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public string DdaDisabilityInd { get; set; }
        public string DseParentConsultationInd { get; set; }
        public string ParentConsultationInd { get; set; }
        public string EvidenceSightedInd { get; set; }
        public string PrincipalConsentInd { get; set; }
        public string ActiveInd { get; set; }
        public decimal? TransactionNo { get; set; }
        public string LevelOfAdjustmentInd { get; set; }
        public string OngoingAdjustmentInd { get; set; }
    }
}
