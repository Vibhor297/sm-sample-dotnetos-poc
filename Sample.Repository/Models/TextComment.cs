using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class TextComment
    {
        public decimal TextCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string TextCommentValue { get; set; }
    }
}
