using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentFamilyChangeLog
    {
        public DateTime? AuditDate { get; set; }
        public string AuditUsername { get; set; }
        public string AuditTask { get; set; }
        public decimal SfclRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal FromFamilyRecordNo { get; set; }
        public decimal ToFamilyRecordNo { get; set; }
        public decimal ChangedByOrgUnitRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public decimal? Srn { get; set; }
    }
}
