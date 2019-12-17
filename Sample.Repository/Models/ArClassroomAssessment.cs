using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArClassroomAssessment
    {
        public decimal ArClassroomAssessRecordNo { get; set; }
        public decimal ArLearnAssistProgRecordNo { get; set; }
        public decimal AssessmentItemRecordNo { get; set; }
        public string Result { get; set; }
        public decimal? ClassrmAssCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
