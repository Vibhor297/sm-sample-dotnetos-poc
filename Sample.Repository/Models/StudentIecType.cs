using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentIecType
    {
        public decimal StudentIecTypeRecordNo { get; set; }
        public decimal IecTypeRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public DateTime? DateReviewed { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
