using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArHearingLossLevel
    {
        public decimal ArHearLossLevelRecordNo { get; set; }
        public decimal? HearingLevelValueRecordNo { get; set; }
        public decimal? HearingLossLevelRecordNo { get; set; }
        public string EarSideInd { get; set; }
        public decimal ArHearingDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
