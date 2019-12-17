using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociOasisDatabase
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public string OasisDatabaseCode { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public string ActiveInd { get; set; }
        public string MigratedToSepInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
