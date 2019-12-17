using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TtIcom
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public string Comcode { get; set; }
        public string Comname { get; set; }
        public int? Comstaff { get; set; }
        public byte? Numperiods { get; set; }
        public string Acperiod { get; set; }
    }
}
