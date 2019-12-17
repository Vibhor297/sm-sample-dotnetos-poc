using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TtIcomclas
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public string Acperiod { get; set; }
        public string Comcode { get; set; }
        public string Coursecode { get; set; }
        public byte Classnum { get; set; }
        public string Schyear { get; set; }
        public byte? Numperiods { get; set; }
    }
}
