using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSupDisabilityProgram
    {
        public decimal ArSupDisProgRecordNo { get; set; }
        public decimal? DisabilityProgramRecordNo { get; set; }
        public decimal? ArSupDocDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
