using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class DatOrgCountRpt
    {
        public decimal DatOrgCountRptRecordNo { get; set; }
        public DateTime? LastReportDate { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public decimal? SyCodeRecordNo { get; set; }
        public decimal? LeaversAllocatedDatCt { get; set; }
        public decimal? LeaversAllocatedDatCtChg { get; set; }
        public decimal? LeaversLoanedDatCt { get; set; }
        public decimal? LeaversLoanedDatCtChg { get; set; }
        public decimal? MoversAllocatedDatCt { get; set; }
        public decimal? MoversAllocatedDatCtChg { get; set; }
        public decimal? MoversLoanedDatCt { get; set; }
        public decimal? MoversLoanedDatCtChg { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
