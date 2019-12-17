using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentType
    {
        public decimal StudentTypeRecordNo { get; set; }
        public string StudentTypeCode { get; set; }
        public string StudentTypeNm { get; set; }
        public string ReferenceDataTypeInd { get; set; }
        public string ActiveInd { get; set; }
        public string DefaultInd { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public decimal? ReportsToRecordNo { get; set; }
        public decimal? ReplacesRecordNo { get; set; }
        public decimal? SequenceNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
