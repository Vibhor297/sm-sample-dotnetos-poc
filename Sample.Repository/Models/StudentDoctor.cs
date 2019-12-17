using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentDoctor
    {
        public decimal StudentDoctorRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public string DoctorNm { get; set; }
        public decimal? AddressDetailRecordNo { get; set; }
        public string ContactPermissionInd { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? AddressTypeRecordNo { get; set; }
        public decimal PreferredSequenceNo { get; set; }
        public string Guid { get; set; }
    }
}
