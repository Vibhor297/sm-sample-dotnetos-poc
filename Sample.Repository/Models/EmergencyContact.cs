using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class EmergencyContact
    {
        public decimal EmergencyContactRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string EmergencyContactRecordNm { get; set; }
        public decimal FamilyRelationCodeRecordNo { get; set; }
        public string FirstNm { get; set; }
        public string FamilyNm { get; set; }
    }
}
