using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ParentAddress
    {
        public decimal ParentAddressRecordNo { get; set; }
        public decimal ParentRecordNo { get; set; }
        public decimal AddressDetailRecordNo { get; set; }
        public decimal PreferredSequenceNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal AddressTypeRecordNo { get; set; }
    }
}
