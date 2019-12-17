using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentMedication
    {
        public decimal StudentMedRecordNo { get; set; }
        public decimal StudentMedCondRecordNo { get; set; }
        public decimal MedicationAdminRecordNo { get; set; }
        public decimal MedicationCatRecordNo { get; set; }
        public decimal DossierRecordNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public string HasBeenProvidedInd { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string LastUserUpdate { get; set; }
        public string Guid { get; set; }
        public decimal TransactionNo { get; set; }
        public string Dosage { get; set; }
        public string Name { get; set; }
    }
}
