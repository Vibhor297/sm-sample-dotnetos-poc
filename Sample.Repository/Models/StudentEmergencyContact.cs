using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentEmergencyContact
    {
        public decimal StudentEmerContactRecordNo { get; set; }
        public decimal EmergencyContactRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal PreferredSequenceNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
