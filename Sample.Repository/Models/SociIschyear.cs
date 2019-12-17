using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociIschyear
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal SepRegisterOfferRecordNo { get; set; }
        public byte SepCalendarYear { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public decimal? SepRowReplacesRecordNo { get; set; }
        public string Schyear { get; set; }
        public string Stdschyr { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
