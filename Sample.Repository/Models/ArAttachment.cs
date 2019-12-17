using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArAttachment
    {
        public decimal ArAttachmentRecordNo { get; set; }
        public decimal SupportTypeRecordNo { get; set; }
        public decimal ArAccessRequestRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string VerifiedByPrincipalInd { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        public string LastModifiedByDetUserId { get; set; }
    }
}
