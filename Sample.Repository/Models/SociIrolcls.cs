using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociIrolcls
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal SepSgOfferRecordNo { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public decimal? SepRowReplacesRecordNo { get; set; }
        public string Name { get; set; }
        public decimal? Staffid { get; set; }
        public string Year { get; set; }
        public string Oc { get; set; }
        public decimal TransactionNo { get; set; }
        public string Statusind { get; set; }
    }
}
