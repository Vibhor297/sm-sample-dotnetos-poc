using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class PickupContact
    {
        public decimal PickupContactRecordNo { get; set; }
        public decimal StudentPickupRecordNo { get; set; }
        public decimal ContactDetailRecordNo { get; set; }
        public decimal ContactTypeRecordNo { get; set; }
        public decimal PreferredSequenceNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
