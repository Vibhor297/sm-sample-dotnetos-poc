using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class MedicalDocumentation
    {
        public decimal MedDocumentationRecordNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUserUpdate { get; set; }
        public decimal? FileRepositoryRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string Guid { get; set; }
    }
}
