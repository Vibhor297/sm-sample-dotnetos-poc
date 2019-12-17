using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArDisabilityItem
    {
        public decimal ArDisabilityItemRecordNo { get; set; }
        public decimal DisabilityItemRecordNo { get; set; }
        public decimal ArDisConfirmRecordNo { get; set; }
        public string DisabilityItemInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
