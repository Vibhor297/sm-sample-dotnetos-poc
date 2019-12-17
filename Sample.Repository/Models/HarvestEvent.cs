using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class HarvestEvent
    {
        public decimal HarvestEventRecordNo { get; set; }
        public string HarvestEventNm { get; set; }
        public DateTime HarvestEventDate { get; set; }
        public decimal HarvestEventNotification { get; set; }
        public decimal HarvestTypeRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? TextCommentRecordNo { get; set; }
        public string ActiveInd { get; set; }
        public decimal? HarvestEventCollection { get; set; }
        public DateTime? EnabledDate { get; set; }
    }
}
