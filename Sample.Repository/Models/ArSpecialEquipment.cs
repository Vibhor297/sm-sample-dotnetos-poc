using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSpecialEquipment
    {
        public decimal ArSpecialEquipRecordNo { get; set; }
        public decimal? EquipAccCommentRecordNo { get; set; }
        public decimal? TrackingCommentRecordNo { get; set; }
        public decimal? CurrEquipCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
