using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentPickup
    {
        public decimal StudentPickupRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public string PickupNm { get; set; }
        public decimal? AddressTypeRecordNo { get; set; }
        public decimal? AddressDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
