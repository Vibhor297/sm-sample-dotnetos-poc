using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class FamilyEvidence
    {
        public decimal FamilyEvidenceRecordNo { get; set; }
        public decimal FamilyRecordNo { get; set; }
        public decimal EvidenceTypeRecordNo { get; set; }
        public decimal EvidenceCategoryRecordNo { get; set; }
        public decimal VerifiedStatusRecordNo { get; set; }
        public DateTime? DateSighted { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
