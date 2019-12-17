using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdParentAddress
    {
        public decimal ParentAddressRecordNo { get; set; }
        public decimal ParentRecordNo { get; set; }
        public string AddressTypeCode { get; set; }
        public string AddressTypeNm { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string SuburbNm { get; set; }
        public string Postcode { get; set; }
        public string StateCode { get; set; }
        public string StateNm { get; set; }
        public string CountryCode { get; set; }
        public string CountryNm { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RecordLastModified { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
