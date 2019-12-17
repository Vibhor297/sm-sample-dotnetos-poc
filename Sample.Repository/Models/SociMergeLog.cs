using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociMergeLog
    {
        public decimal SociMergeLogRecordNo { get; set; }
        public decimal LosingSrn { get; set; }
        public decimal WinningSrn { get; set; }
        public DateTime? ErnMergeDate { get; set; }
        public DateTime? OasisMergeDate { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
