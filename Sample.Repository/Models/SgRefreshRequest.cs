using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SgRefreshRequest
    {
        public decimal SgRefreshReqRecordNo { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string EmailAddress { get; set; }
        public string RefreshInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
