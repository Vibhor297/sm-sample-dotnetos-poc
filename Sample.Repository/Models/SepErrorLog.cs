using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepErrorLog
    {
        public decimal SepErrorRecordNo { get; set; }
        public DateTime? DateTimeOfError { get; set; }
        public string ServiceName { get; set; }
        public string ServiceParameters { get; set; }
        public decimal TransactionNo { get; set; }
        public string ErrorMessage { get; set; }
    }
}
