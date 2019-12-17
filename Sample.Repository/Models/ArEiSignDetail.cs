using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArEiSignDetail
    {
        public decimal ArEiSignDetailRecordNo { get; set; }
        public decimal? ArSignDetailRecordNo { get; set; }
        public decimal? ArEiProfSummRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
