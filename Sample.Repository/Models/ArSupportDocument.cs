using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSupportDocument
    {
        public decimal ArSupDocumentRecordNo { get; set; }
        public decimal? ParentCommentRecordNo { get; set; }
        public string PrincipalSupportInd { get; set; }
        public string DisabilityConfirmInd { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? SharedEnrolCommentRecordNo { get; set; }
        public string IntegPrincipalSupportsInd { get; set; }
        public decimal? IntegOrgUnitRecordNo { get; set; }
        public DateTime? ParentSignDate { get; set; }
    }
}
