using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSubmittingParent
    {
        public decimal ArSubmittingParentRecordNo { get; set; }
        public decimal ArSupportDocumentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? ParentRecordNo { get; set; }
    }
}
