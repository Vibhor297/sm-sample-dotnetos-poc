using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArPriorityStatusChgHis
    {
        public decimal ArPsChgHistoryRecordNo { get; set; }
        public decimal ArDisProgItemRecordNo { get; set; }
        public decimal PsTransitionRecordNo { get; set; }
        public string ChangeDetUserId { get; set; }
        public DateTime ChangeDateTime { get; set; }
        public decimal TextCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? RegistrationRecordNo { get; set; }
        public decimal? StatusReasonRecordNo { get; set; }
    }
}
