using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArAutismDetail
    {
        public decimal ArAutismDetailRecordNo { get; set; }
        public decimal? CommuniCommentRecordNo { get; set; }
        public decimal? SocialCompCommentRecordNo { get; set; }
        public decimal? SensoryCommentRecordNo { get; set; }
        public decimal? SafetyCommentRecordNo { get; set; }
        public decimal? ArRiskPlanDetailRecordNo { get; set; }
        public decimal? PrevInterCommentRecordNo { get; set; }
        public decimal? ArSupDocDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
