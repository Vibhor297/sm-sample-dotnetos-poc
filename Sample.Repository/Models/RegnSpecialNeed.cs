using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegnSpecialNeed
    {
        public decimal RegnSpecialNeedRecordNo { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal DisabilityRecordNo { get; set; }
        public string DisabilityNm { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
