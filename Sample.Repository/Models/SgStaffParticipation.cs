using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SgStaffParticipation
    {
        public decimal SgStaffRecordNo { get; set; }
        public decimal StaffRecordNo { get; set; }
        public decimal StaffRoleCodeRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal SgOfferRecordNo { get; set; }
        public string MainStaffInd { get; set; }
        public byte NumberOfPeriods { get; set; }
        public string SourceSystem { get; set; }
    }
}
