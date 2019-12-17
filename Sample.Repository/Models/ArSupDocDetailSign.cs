using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSupDocDetailSign
    {
        public decimal AsddSignDetailRecordNo { get; set; }
        public decimal? ArSupDocDetailRecordNo { get; set; }
        public decimal? ArSignDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
