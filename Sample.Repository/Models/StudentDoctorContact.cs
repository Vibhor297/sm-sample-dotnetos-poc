using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentDoctorContact
    {
        public decimal StudentDocContactRecordNo { get; set; }
        public decimal StudentDoctorRecordNo { get; set; }
        public decimal ContactDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal PreferredSequenceNo { get; set; }
        public decimal ContactTypeRecordNo { get; set; }
    }
}
