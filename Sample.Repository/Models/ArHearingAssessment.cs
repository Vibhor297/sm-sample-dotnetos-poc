using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArHearingAssessment
    {
        public decimal ArHearingAssessRecordNo { get; set; }
        public decimal HearingAssessmentRecordNo { get; set; }
        public string HearingTestUsed { get; set; }
        public decimal? ArHearingDetailRecordNo { get; set; }
        public string AssessmentResult { get; set; }
        public DateTime? GivenDate { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
