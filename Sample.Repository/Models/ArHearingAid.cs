using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArHearingAid
    {
        public decimal ArHearingAidRecordNo { get; set; }
        public decimal DisAssistAidRecordNo { get; set; }
        public decimal ArHearingDetailRecordNo { get; set; }
        public string FittingAge { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
