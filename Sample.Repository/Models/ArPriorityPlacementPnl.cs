using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArPriorityPlacementPnl
    {
        public decimal ArPriorityPpRecordNo { get; set; }
        public decimal ArDisProgItemRecordNo { get; set; }
        public decimal ArPpRecordNo { get; set; }
        public decimal? ArPpOutcomeRecordNo { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string StatusInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
