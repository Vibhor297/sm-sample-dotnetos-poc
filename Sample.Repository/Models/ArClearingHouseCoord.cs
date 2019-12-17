using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArClearingHouseCoord
    {
        public decimal ArChCoordinatorRecordNo { get; set; }
        public decimal ArChRecordNo { get; set; }
        public string DetUserId { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public decimal SequenceNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
