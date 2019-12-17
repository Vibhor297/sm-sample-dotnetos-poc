using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SuspensionIncident
    {
        public decimal SuspensionIncidentRecordNo { get; set; }
        public DateTime SuspensionIncidentDate { get; set; }
        public string SuspensionIncidentDesc { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public string GroupInd { get; set; }
        public decimal? ReportsToRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string SuspensionIncidentNm { get; set; }
        public string Guid { get; set; }
    }
}
