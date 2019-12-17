using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociSclass
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal SepStudentGroupRecordNo { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public string SepMembershipCurrentInd { get; set; }
        public decimal Stucode { get; set; }
        public string Coursecode { get; set; }
        public string Acperiod { get; set; }
        public byte Classnum { get; set; }
        public decimal TransactionNo { get; set; }
        public string Prefname { get; set; }
        public string Surname { get; set; }
    }
}
