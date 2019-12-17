using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TtIclass
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public string Subcode { get; set; }
        public string Schyear { get; set; }
        public string Acperiod { get; set; }
        public string Coursecode { get; set; }
        public string Name { get; set; }
        public byte Classnum { get; set; }
        public byte? Mxclassnum { get; set; }
        public byte? Count { get; set; }
        public decimal? Staffid { get; set; }
        public byte? Numperiods { get; set; }
        public string Comcode { get; set; }
        public byte? Comperiods { get; set; }
        public decimal Ernrecno { get; set; }
    }
}
