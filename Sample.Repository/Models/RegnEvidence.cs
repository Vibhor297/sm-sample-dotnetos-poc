using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegnEvidence
    {
        public decimal RegnEvidenceRecordNo { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal EvidenceTypeRecordNo { get; set; }
        public decimal EvidenceCategoryRecordNo { get; set; }
        public decimal VerifiedStatusRecordNo { get; set; }
        public DateTime DateSighted { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
