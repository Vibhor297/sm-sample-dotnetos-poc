using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TtSclass
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal Stucode { get; set; }
        public string Coursecode { get; set; }
        public string Acperiod { get; set; }
        public byte Classnum { get; set; }
    }
}
