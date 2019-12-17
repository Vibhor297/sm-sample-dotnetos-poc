using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArPlacementPanelOutcome
    {
        public decimal ArPpOutcomeRecordNo { get; set; }
        public decimal PpOutcomeCategoryRecordNo { get; set; }
        public string Section1CompletedInd { get; set; }
        public string Section2CompletedInd { get; set; }
        public string Section3CompletedInd { get; set; }
        public decimal PpOutcomeStatusRecordNo { get; set; }
        public string CurrentSettings { get; set; }
        public decimal? CensusOrgUnitRecordNo { get; set; }
        public string SharedEnrolmentInd { get; set; }
        public decimal? SharedOrgUnitRecordNo { get; set; }
        public decimal? DisabilityProgItemRecordNo { get; set; }
        public decimal? NumberOfSessions { get; set; }
        public decimal? EnrolmentTypeRecordNo { get; set; }
        public decimal? SyCodeRecordNo { get; set; }
        public decimal? CaseloadPerWkHrs { get; set; }
        public decimal? CaseloadPerWkMins { get; set; }
        public decimal? SupplementaryPerWkHrs { get; set; }
        public decimal? SupplementaryPerWkMins { get; set; }
        public decimal? SupportAllocPerWkHrs { get; set; }
        public decimal? SupportAllocPerWkMins { get; set; }
        public string MonitorInd { get; set; }
        public decimal? IsthPerWkHrs { get; set; }
        public decimal? IsthPerWkMins { get; set; }
        public decimal? IstvPerWkHrs { get; set; }
        public decimal? IstvPerWkMins { get; set; }
        public string ProfileSupportedInd { get; set; }
        public string IfsRcmdProceedToSoInd { get; set; }
        public string PervasiveDevelopmentCharInd { get; set; }
        public decimal? FactorOfNeedRecordNo { get; set; }
        public DateTime? IntendedStartDate { get; set; }
        public decimal? GeneralCommentRecordNo { get; set; }
        public decimal? PriorityStatusRecordNo { get; set; }
        public decimal? StatusCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? StatusReasonRecordNo { get; set; }
    }
}
