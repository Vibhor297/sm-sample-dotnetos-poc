using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdChangedStudent
    {
        public decimal StudentRecordNo { get; set; }
        public DateTime RecordChangedDatetime { get; set; }
        public decimal TransactionNo { get; set; }
        public string FamilyNm { get; set; }
        public bool? Deleted { get; set; }
        public bool? Resync { get; set; }
        public byte ErrorCount { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime LastModified { get; set; }

        public virtual Student StudentRecordNoNavigation { get; set; }
    }
}
