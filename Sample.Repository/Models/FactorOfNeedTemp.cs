using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class FactorOfNeedTemp
    {
        public decimal FactorOfNeedTempRecordNo { get; set; }
        public decimal Srn { get; set; }
        public string SchoolCode { get; set; }
        public string EnrolmentTypeNm { get; set; }
        public decimal EnrolmentTypeRecordNo { get; set; }
        public string CensusInd { get; set; }
        public decimal FactorOfNeedValue { get; set; }
        public decimal? ErrorCode { get; set; }
    }
}
