using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdSchoolSync
    {
        public decimal AutoId { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public string Status { get; set; }
        public DateTime? RecordCreated { get; set; }
        public DateTime? RecordLastModified { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
