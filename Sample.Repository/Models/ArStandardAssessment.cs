using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArStandardAssessment
    {
        public decimal ArStandardAssessRecordNo { get; set; }
        public decimal AssessmentItemRecordNo { get; set; }
        public decimal ArLearnAssistProgRecordNo { get; set; }
        public decimal? StandardAssCommentRecordNo { get; set; }
        public string AssessorNm { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public string AssessorPosition { get; set; }
        public decimal? AssessmentMethodRecordNo { get; set; }
        public string Result { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
