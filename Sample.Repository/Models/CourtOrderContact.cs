using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class CourtOrderContact
    {
        public decimal CorContactRecordNo { get; set; }
        public decimal? NameSalutationCodeRecordNo { get; set; }
        public string FirstNm { get; set; }
        public string FamilyNm { get; set; }
        public string OtherNm { get; set; }
        public string GenderInd { get; set; }
        public decimal? AddressDetailRecordNo { get; set; }
        public decimal? AddressTypeRecordNo { get; set; }
        public string Guid { get; set; }
        public decimal TransactionNo { get; set; }
        public string SynergyContactType { get; set; }
    }
}
