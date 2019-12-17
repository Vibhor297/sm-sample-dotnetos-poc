using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SalmMigration
    {
        public decimal SalmMigrationRecordNo { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public string MessageType { get; set; }
        public decimal? MigrationCount { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
