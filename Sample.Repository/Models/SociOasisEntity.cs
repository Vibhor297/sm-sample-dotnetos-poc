using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociOasisEntity
    {
        public decimal OasisEntityRecordNo { get; set; }
        public string OasisEntityNm { get; set; }
        public decimal OasisDatabaseRecordNo { get; set; }
        public DateTime? SepDataChangedDatetime { get; set; }
        public DateTime? LastExtractConnectDatetime { get; set; }
        public DateTime? LastExtractStartDatetime { get; set; }
        public DateTime? LastExtractEndDatetime { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
