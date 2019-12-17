using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class EmergencyContactDetail
    {
        public decimal EcDetailRecordNo { get; set; }
        public decimal EmergencyContactRecordNo { get; set; }
        public decimal PreferredSequenceNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal ContactTypeRecordNo { get; set; }
        public decimal ContactDetailRecordNo { get; set; }
    }
}
