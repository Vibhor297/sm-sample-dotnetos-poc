using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TtIclteach
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public string Schyear { get; set; }
        public string Acperiod { get; set; }
        public string Coursecode { get; set; }
        public decimal Staffid { get; set; }
        public byte? Numperiods { get; set; }
        public byte Classnum { get; set; }
    }
}
