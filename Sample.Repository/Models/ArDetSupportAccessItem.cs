using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArDetSupportAccessItem
    {
        public decimal ArDetSuppAccItemRecordNo { get; set; }
        public decimal? SupportServiceRecordNo { get; set; }
        public string SupportAccessInd { get; set; }
        public decimal? CommentRecordNo { get; set; }
        public decimal? ArDetSuppAccRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public string ArDetSuppComment { get; set; }
        public decimal? LevelOfImportanceRecordNo { get; set; }
    }
}
