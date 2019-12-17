using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArRiskPlanDetail
    {
        public decimal ArRiskPlanDetailRecordNo { get; set; }
        public decimal? BehaviourCommentRecordNo { get; set; }
        public decimal? LocationCommentRecordNo { get; set; }
        public decimal? FreqCommentRecordNo { get; set; }
        public decimal? IntensityCommentRecordNo { get; set; }
        public decimal? ImplicationCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
