using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ContactDetail
    {
        public decimal ContactDetailRecordNo { get; set; }
        public string ContactValue { get; set; }
        public decimal TransactionNo { get; set; }
        public string ContactComment { get; set; }
        public string ValidationInd { get; set; }
        public DateTime? ValidationDate { get; set; }
    }
}
