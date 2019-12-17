using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdStudentEmerContact
    {
        public decimal StuEmercontactRecNo { get; set; }
        public string Guid { get; set; }
        public decimal EmercontactRecNo { get; set; }
        public decimal Srn { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? PreferredSequenceNo { get; set; }

        public virtual SepsdEmergencyContact EmercontactRecNoNavigation { get; set; }
        public virtual SepsdStudent SrnNavigation { get; set; }
    }
}
