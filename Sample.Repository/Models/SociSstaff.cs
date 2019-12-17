using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociSstaff
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal Staffcode { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public decimal? SepRowReplacesRecordNo { get; set; }
        public string Serialnum { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string Sex { get; set; }
        public DateTime? Dob { get; set; }
        public decimal TransactionNo { get; set; }
        public string StatusInd { get; set; }
    }
}
