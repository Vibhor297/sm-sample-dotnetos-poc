using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociSabsence
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal Stucode { get; set; }
        public DateTime Absdate { get; set; }
        public string Absperiod { get; set; }
        public string Reason { get; set; }
        public string Comm { get; set; }
        public decimal? Starttime { get; set; }
        public decimal? Stoptime { get; set; }
    }
}
