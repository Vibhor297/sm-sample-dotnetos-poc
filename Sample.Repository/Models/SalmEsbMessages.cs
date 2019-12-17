using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SalmEsbMessages
    {
        public decimal SalmEsbMessageRecordNo { get; set; }
        public decimal? MessageTime { get; set; }
        public string ServiceName { get; set; }
        public decimal? SepRecordNo { get; set; }
        public string MessageAuditUserName { get; set; }
        public string MessageAuditTask { get; set; }
        public string MessageType { get; set; }
        public decimal? TransactionNo { get; set; }
        public string JmsHeaders { get; set; }
    }
}
