using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentOutOfHomeCare
    {
        public decimal StudentOohcRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal OohcTypeRecordNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? StudentEvidenceRecordNo { get; set; }
        public string UpdatedBy { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
