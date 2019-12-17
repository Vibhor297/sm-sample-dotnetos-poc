using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SchoolMedication
    {
        public decimal SchoolMedicationRecordNo { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public decimal MedicationRecordNo { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public decimal? TextCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
