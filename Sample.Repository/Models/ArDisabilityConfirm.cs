using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArDisabilityConfirm
    {
        public decimal ArDisConfirmRecordNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string SpecialConsiderInd { get; set; }
        public string DisabilityConfirmInd { get; set; }
        public string ConsultationInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
