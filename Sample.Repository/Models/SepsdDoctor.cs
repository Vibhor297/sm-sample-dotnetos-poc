using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdDoctor
    {
        public decimal DoctorRecordNo { get; set; }
        public decimal Srn { get; set; }
        public string DoctorNm { get; set; }
        public string Guid { get; set; }
        public string StudentDoctorRelGuid { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? PreferredSequenceNo { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }

        public virtual SepsdStudent SrnNavigation { get; set; }
    }
}
