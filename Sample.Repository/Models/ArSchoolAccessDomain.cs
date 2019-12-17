using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSchoolAccessDomain
    {
        public decimal ArSchoolAccDomRecordNo { get; set; }
        public decimal? CommentTextRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? ArCurriculumRecordNo { get; set; }
        public string NotApplicableInd { get; set; }
        public decimal? ArSchoolProfSummRecordNo { get; set; }
        public decimal? DisabilityLevelRecordNo { get; set; }
        public decimal? ArCurrReportsToRecordNo { get; set; }
    }
}
