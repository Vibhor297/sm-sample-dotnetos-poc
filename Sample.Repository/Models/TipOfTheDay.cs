using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TipOfTheDay
    {
        public decimal TipOfTheDayRecordNo { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public string ImageNm { get; set; }
        public decimal TransactionNo { get; set; }
        public string ApplicationTopMenu { get; set; }
    }
}
