using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociHouse
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal SepSgOfferRecordNo { get; set; }
        public string IlucodeType { get; set; }
        public string IlucodeCode { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public decimal? SepRowReplacesRecordNo { get; set; }
        public string IlucodeDesc { get; set; }
        public string IlucodeFlag { get; set; }
        public decimal TransactionNo { get; set; }
        public string Statusind { get; set; }
    }
}
