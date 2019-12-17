using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentSuspension
    {
        public decimal StudentSuspensionRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal SuspensionIncidentRecordNo { get; set; }
        public decimal SuspensionReasonRecordNo { get; set; }
        public decimal StudentDossierRecordNo { get; set; }
        public DateTime SuspensionFromDate { get; set; }
        public DateTime SuspensionToDate { get; set; }
        public decimal SuspensionDuration { get; set; }
        public decimal RegistrationRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public DateTime? ResolutionDate { get; set; }
        public string Guid { get; set; }
        public string ReportsToGuid { get; set; }
    }
}
