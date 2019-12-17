using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentDetailChangeLog
    {
        public decimal ChangeLogRecordNo { get; set; }
        public DateTime? AuditDate { get; set; }
        public string AuditUsername { get; set; }
        public string AuditTask { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal? ChangeLogCategoryRecordNo { get; set; }
        public decimal ChangedByOrgUnitRecordNo { get; set; }
        public decimal AffectedOrgUnitRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }

        public virtual ChangeLogCategory ChangeLogCategoryRecordNoNavigation { get; set; }
    }
}
