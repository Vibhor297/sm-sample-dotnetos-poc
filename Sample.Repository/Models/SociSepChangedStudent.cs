using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociSepChangedStudent
    {
        public decimal StudentRecordNo { get; set; }
        public DateTime StudentChangedDatetime { get; set; }
        public decimal TransactionNo { get; set; }
        public string FamilyNm { get; set; }
    }
}
