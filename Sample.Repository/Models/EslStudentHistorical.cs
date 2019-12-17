using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class EslStudentHistorical
    {
        public decimal EslStudentHistRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal EslPhaseRecordNo { get; set; }
        public DateTime? LastEslAssessmentDate { get; set; }
        public string EslAssessmentInd { get; set; }
    }
}
