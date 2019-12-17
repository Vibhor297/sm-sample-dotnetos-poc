using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArAttachmentVerification
    {
        public decimal ArAttachVerifRecordNo { get; set; }
        public decimal DisabilityRoleRecordNo { get; set; }
        public string RejectedByPrincipalInd { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal ArAttachmentRecordNo { get; set; }
        public decimal? SupportTypeDisRoleSeqNo { get; set; }
        public decimal? VerificationCommentRecordNo { get; set; }
    }
}
