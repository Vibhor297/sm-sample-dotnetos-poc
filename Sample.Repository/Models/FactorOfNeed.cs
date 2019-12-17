using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class FactorOfNeed
    {
        public decimal FactorOfNeedRecordNo { get; set; }
        public decimal EnrolmentTypeRecordNo { get; set; }
        public string SspInd { get; set; }
        public decimal FactorOfNeedValue { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
