using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociIclteach
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal SepSgStaffRecordNo { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public decimal SepSgOfferRecordNo { get; set; }
        public string Acperiod { get; set; }
        public string Schyear { get; set; }
        public string Coursecode { get; set; }
        public byte Classnum { get; set; }
        public decimal Staffid { get; set; }
        public decimal TransactionNo { get; set; }
        public byte? Numperiods { get; set; }
    }
}
