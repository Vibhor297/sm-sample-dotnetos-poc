using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentDisabilityType
    {
        public decimal StudentDisabilityTypeRecNo { get; set; }
        public decimal StuDisabDataCollAnRecNo { get; set; }
        public decimal DisabilityTypeRecordNo { get; set; }
        public string PrimaryDisabilityTypeInd { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
