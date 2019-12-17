using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArEsl
    {
        public decimal ArEslRecordNo { get; set; }
        public decimal? EslPerformCommentRecordNo { get; set; }
        public decimal? EslIssueCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? EslIntpretCommentRecordNo { get; set; }
        public decimal? EslRefugeeCommentRecordNo { get; set; }
        public decimal? EslFirstlanCommentRecordNo { get; set; }
        public decimal? EslAdjustCommentRecordNo { get; set; }
    }
}
