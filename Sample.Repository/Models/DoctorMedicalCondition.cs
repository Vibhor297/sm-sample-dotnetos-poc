using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class DoctorMedicalCondition
    {
        public decimal DoctorMedicalCondRecordNo { get; set; }
        public decimal StudentDoctorRecordNo { get; set; }
        public decimal StudentMedCondRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
