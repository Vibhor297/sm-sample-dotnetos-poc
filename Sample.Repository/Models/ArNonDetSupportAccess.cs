using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArNonDetSupportAccess
    {
        public decimal ArNonDetSuppAccRecordNo { get; set; }
        public decimal? ArAccessRequestRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public string AgenciesInvolvedInd { get; set; }
    }
}
