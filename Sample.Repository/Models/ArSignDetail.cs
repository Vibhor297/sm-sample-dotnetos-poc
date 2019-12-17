using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSignDetail
    {
        public decimal ArSignDetailRecordNo { get; set; }
        public decimal? SignCommentRecordNo { get; set; }
        public DateTime? SignDate { get; set; }
        public decimal StSrRecordNo { get; set; }
        public string ConfirmationInd { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal ArAttachmentRecordNo { get; set; }
        public string StudentCommentInd { get; set; }
        public decimal? StudentCommentRecordNo { get; set; }
        public decimal? HoursPerWeek { get; set; }
    }
}
