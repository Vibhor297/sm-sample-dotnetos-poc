using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArTransferHistory
    {
        public decimal ArTransferHistoryRecordNo { get; set; }
        public decimal ArAccessRequestRecordNo { get; set; }
        public decimal FromArOwnerOuRecordNo { get; set; }
        public decimal ToArOwnerOuRecordNo { get; set; }
        public string TransferDetUserId { get; set; }
        public DateTime TransferDateTime { get; set; }
        public decimal TextCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
