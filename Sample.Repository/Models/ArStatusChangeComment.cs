using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArStatusChangeComment
    {
        public decimal ArStatusChangeCmtRecordNo { get; set; }
        public decimal ArAccessRequestRecordNo { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? ArStatusTranRecordNo { get; set; }
        public decimal? TextCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
