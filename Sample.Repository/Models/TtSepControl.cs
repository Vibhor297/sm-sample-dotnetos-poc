using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TtSepControl
    {
        public decimal TtSepControlRecordNo { get; set; }
        public decimal OasisDatabaseRecordNo { get; set; }
        public string Acperiod { get; set; }
        public string TtTableName { get; set; }
        public DateTime? OasisDbChangedStarttime { get; set; }
        public DateTime? OasisDbChangedEndtime { get; set; }
        public DateTime? SepDbChangedStarttime { get; set; }
        public DateTime? SepDbChangedEndtime { get; set; }
        public decimal TransactionNo { get; set; }
        public string SepImportStatus { get; set; }
        public string MigrationLogMessage { get; set; }
    }
}
