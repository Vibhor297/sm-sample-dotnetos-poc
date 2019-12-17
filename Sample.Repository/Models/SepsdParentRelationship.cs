using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdParentRelationship
    {
        public decimal ParentRelationshipRecordNo { get; set; }
        public string Guid { get; set; }
        public decimal ParentRecordNo { get; set; }
        public decimal Srn { get; set; }
        public string FamilyRelationCode { get; set; }
        public string ReceiveAcademicReportInd { get; set; }
        public string ReceiveInvoiceInd { get; set; }
        public string StatementOfAccTypeRecNo { get; set; }
        public string CustodyInd { get; set; }
        public string EnrolmentOwnerInd { get; set; }
        public string BsaInd { get; set; }
        public decimal? TransactionNo { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }
        public decimal? SequenceNo { get; set; }
        public string FamilyRelationNm { get; set; }
        public string StatementOfAccTypeCode { get; set; }
        public string StatementOfAccTypeNm { get; set; }
        public string AvoIndicator { get; set; }

        public virtual SepsdParent ParentRecordNoNavigation { get; set; }
        public virtual SepsdStudent SrnNavigation { get; set; }
    }
}
