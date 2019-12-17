using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentResidency
    {
        public decimal StudentResidencyRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal ResidencyStatusRecordNo { get; set; }
        public DateTime? EffectiveFromDate { get; set; }
        public DateTime? EffectiveEndDate { get; set; }
        public decimal CoiCountryRecordNo { get; set; }
        public decimal VisaClassCodeRecordNo { get; set; }
        public string AuthorityToEnrolNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string TravelDocumentId { get; set; }
        public DateTime? ArrivedInAustraliaDate { get; set; }
        public DateTime? AteExpiryDate { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public string VisaHolderInd { get; set; }
        public decimal? StudentEvidenceRecordNo { get; set; }
        public DateTime? ReturnedToAustraliaDate { get; set; }
        public DateTime? AteStartDate { get; set; }
    }
}
