using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentSuspensionOld
    {
        public decimal StudentSuspensionRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal? StudentDossierRecordNo { get; set; }
        public DateTime SuspensionFromDate { get; set; }
        public DateTime SuspensionToDate { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
