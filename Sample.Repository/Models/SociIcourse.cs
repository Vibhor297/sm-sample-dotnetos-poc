using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociIcourse
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal CrdCurriculumOfferRecordNo { get; set; }
        public string Subcode { get; set; }
        public string Sccode { get; set; }
        public string Schyear { get; set; }
        public string Hsccode { get; set; }
        public string Type { get; set; }
        public string Printname1 { get; set; }
        public string Levval { get; set; }
        public string Levdesc { get; set; }
        public string Cfeedesc { get; set; }
        public decimal? Levfee { get; set; }
        public string Coursecode { get; set; }
        public string Acperiod { get; set; }
        public decimal? Fee { get; set; }
        public string Subtype { get; set; }
        public byte? Subno { get; set; }
        public decimal TransactionNo { get; set; }
        public DateTime CrdRowChangedDatetime { get; set; }
        public string CrdActiveInd { get; set; }
    }
}
