using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArMhEdBdDetail
    {
        public decimal ArMhEdBdDetailRecordNo { get; set; }
        public decimal? ArRiskPlanDetailRecordNo { get; set; }
        public decimal? PrevInterCommentRecordNo { get; set; }
        public decimal? ArSupDocDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
