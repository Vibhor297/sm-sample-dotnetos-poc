using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArKla
    {
        public decimal ArKlaRecordNo { get; set; }
        public decimal? DisabilityStageRecordNo { get; set; }
        public string PersonalLearnPlanInd { get; set; }
        public decimal? DisabilityOutcomeRecordNo { get; set; }
        public decimal? CommentRecordNo { get; set; }
        public decimal? ArSchoolProfSummRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? CurriculumOfferRecordNo { get; set; }
        public decimal? CurriculumRecordNo { get; set; }
        public decimal? PreferredSequenceNo { get; set; }
        public string GenericCurriculumOfferNm { get; set; }
        public string SuppTypeInd { get; set; }
        public decimal? CurrReportsToRecordNo { get; set; }
        public string ArKlaTypeInd { get; set; }
    }
}
