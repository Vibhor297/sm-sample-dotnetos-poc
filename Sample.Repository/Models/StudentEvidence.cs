using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentEvidence
    {
        public decimal StudentEvidenceRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal EvidenceTypeRecordNo { get; set; }
        public decimal VerifiedStatusRecordNo { get; set; }
        public DateTime? DateSighted { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? EvidenceCategoryRecordNo { get; set; }
    }
}
