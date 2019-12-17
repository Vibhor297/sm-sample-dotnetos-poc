using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentContactCourtOrder
    {
        public decimal StudentContactCorRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal CorContactRecordNo { get; set; }
        public decimal DossierRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
