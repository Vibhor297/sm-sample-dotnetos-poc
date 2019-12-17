using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class AddressDetail
    {
        public decimal AddressDetailRecordNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public decimal SuburbCodeRecordNo { get; set; }
        public decimal CountryCodeRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ValidatedInd { get; set; }
        public string HouseholdLevelLat { get; set; }
        public string HouseholdLevelLong { get; set; }
        public string Guid { get; set; }
    }
}
