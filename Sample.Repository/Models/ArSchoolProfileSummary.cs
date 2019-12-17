using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSchoolProfileSummary
    {
        public decimal ArSchoolProfSummRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? WkPlLnCommentRecordNo { get; set; }
        public decimal? ArAttachmentRecordNo { get; set; }
        public string GenericInd { get; set; }
        public decimal? KlaCommentRecordNo { get; set; }
    }
}
