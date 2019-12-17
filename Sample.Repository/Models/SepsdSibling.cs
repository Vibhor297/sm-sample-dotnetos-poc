using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdSibling
    {
        public decimal FamilySiblingRecordNo { get; set; }
        public decimal FamilyRecordNo { get; set; }
        public decimal SiblingSrn { get; set; }
        public string SiblingGuid { get; set; }
        public decimal? Ranking { get; set; }
        public decimal? TotalSiblings { get; set; }
        public DateTime? RecordLastModified { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
