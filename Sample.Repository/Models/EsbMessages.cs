using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class EsbMessages
    {
        public decimal EsbMessageRecordNo { get; set; }
        public DateTime? MessageTime { get; set; }
        public string ServiceName { get; set; }
        public decimal TransactionNo { get; set; }
        public string JmsQueue { get; set; }
        public string ServiceParameters { get; set; }
    }
}
