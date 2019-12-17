using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class DatOrgCountTmp
    {
        public decimal DatOrgCountTmpRecordNo { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public decimal? SyCodeRecordNo { get; set; }
        public string DerAssignmentTypeInd { get; set; }
        public string DepartureDescription { get; set; }
        public decimal? DatCount { get; set; }
        public decimal? TransactionNo { get; set; }
        public DateTime? LastReportDate { get; set; }
    }
}
