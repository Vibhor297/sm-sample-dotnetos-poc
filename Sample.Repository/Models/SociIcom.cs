using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociIcom
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal SepSgOfferRecordNo { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public string Comcode { get; set; }
        public string Comname { get; set; }
        public int? Comstaff { get; set; }
        public byte? Numperiods { get; set; }
        public string Acperiod { get; set; }
        public decimal TransactionNo { get; set; }
        public string SepOfferingStatusInd { get; set; }
    }
}
