using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdParentContact
    {
        public decimal ParentContactRecordNo { get; set; }
        public decimal ParentRecordNo { get; set; }
        public decimal? PreferredSequenceNo { get; set; }
        public string ContactTypeCode { get; set; }
        public string ContactTypeNm { get; set; }
        public string ContactValue { get; set; }
        public string ContactComment { get; set; }
        public DateTime? RecordLastModified { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
