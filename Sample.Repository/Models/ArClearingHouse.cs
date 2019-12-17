using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArClearingHouse
    {
        public decimal ArChRecordNo { get; set; }
        public string ChNm { get; set; }
        public string ChAbbrevNm { get; set; }
        public decimal ChStatusRecordNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
