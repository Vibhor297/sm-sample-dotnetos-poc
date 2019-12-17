using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegistrationLeavingReasonO
    {
        public decimal RegistrationLeavingRecordNo { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal LeaverReasonRecordNo { get; set; }
        public string LeaverReasonNm { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
