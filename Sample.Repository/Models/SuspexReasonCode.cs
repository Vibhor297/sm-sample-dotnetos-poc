using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SuspexReasonCode
    {
        public decimal SuspexReasonCodeRecordNo { get; set; }
        public string SuspexReasonCode1 { get; set; }
        public string SuspexReasonNm { get; set; }
        public string FamilyInstitutionInd { get; set; }
        public string ReferenceDataTypeInd { get; set; }
        public string DefaultInd { get; set; }
        public string ActiveInd { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? SuspexReasonRecordNo { get; set; }
        public decimal? ReportsToRecordNo { get; set; }
        public decimal? ReplacesRecordNo { get; set; }
        public decimal? SequenceNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public string SuspexActionInd { get; set; }
    }
}
