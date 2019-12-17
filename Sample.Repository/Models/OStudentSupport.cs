using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class OStudentSupport
    {
        public decimal OStudentSupportRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal SupSerCodeRecordNo { get; set; }
        public decimal SupDelCodeRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
