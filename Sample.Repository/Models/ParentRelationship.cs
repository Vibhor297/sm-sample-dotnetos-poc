using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ParentRelationship
    {
        public decimal ParentRelationshipRecordNo { get; set; }
        public decimal FamilyRelationCodeRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public string ReceiveAcademicReportInd { get; set; }
        public string CustodyInd { get; set; }
        public string BsaInd { get; set; }
        public string ReceiveInvoiceInd { get; set; }
        public string EnrolmentOwnerInd { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal ParentRecordNo { get; set; }
        public string OnlineAcademicReportInd { get; set; }
        public string OnlineReportNotificationInd { get; set; }
        public decimal? StatementOfAccTypeRecNo { get; set; }
        public DateTime? OasrFirstDeleteWarningDate { get; set; }
        public DateTime? OasrSecndDeleteWarningDate { get; set; }
        public string OohcInd { get; set; }
    }
}
