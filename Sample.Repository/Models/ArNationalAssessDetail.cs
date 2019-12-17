using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArNationalAssessDetail
    {
        public decimal ArNationAssDetailRecordNo { get; set; }
        public decimal ArNationalAssessRecordNo { get; set; }
        public decimal AssessmentItemRecordNo { get; set; }
        public decimal? DisabilityResultRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
