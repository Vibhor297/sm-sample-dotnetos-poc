using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArNonDetSupportAccessItem
    {
        public decimal ArNonDetItemRecordNo { get; set; }
        public string AgencyNm { get; set; }
        public decimal? TextCommentRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? PreferredSequenceNo { get; set; }
        public decimal? ArNonDetSuppAccRecordNo { get; set; }
        public decimal? LastServiceYear { get; set; }
    }
}
