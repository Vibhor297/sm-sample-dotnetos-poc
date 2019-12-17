using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArAccessFacility
    {
        public decimal ArAccessFacRecordNo { get; set; }
        public decimal? CommentRecordNo { get; set; }
        public string WheelchairIndependInd { get; set; }
        public string WheelchairTypeInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
