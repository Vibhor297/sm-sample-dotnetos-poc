using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociSepChangedStaff
    {
        public decimal StaffRecordNo { get; set; }
        public DateTime StaffChangedDatetime { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
