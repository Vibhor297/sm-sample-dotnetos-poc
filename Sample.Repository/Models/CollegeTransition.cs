using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class CollegeTransition
    {
        public decimal CollegeTransRecordNo { get; set; }
        public decimal JuniorCollegeRecordNo { get; set; }
        public string JuniorCollegeCode { get; set; }
        public decimal JuniorCollegeSchYear { get; set; }
        public string JuniorCollegeNm { get; set; }
        public decimal SeniorCollegeRecordNo { get; set; }
        public string SeniorCollegeCode { get; set; }
        public decimal SeniorCollegeSchYear { get; set; }
        public string SeniorCollegeNm { get; set; }
        public decimal DefaultRegistrationStatus { get; set; }
        public decimal DefaultPreferenceNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public string SameYearTransferInd { get; set; }
        public string RiskAssessedInd { get; set; }
        public string NonCensusInd { get; set; }
    }
}
