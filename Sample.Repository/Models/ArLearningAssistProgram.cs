using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArLearningAssistProgram
    {
        public decimal ArLearnAssistProgRecordNo { get; set; }
        public decimal ArSupDocDetailRecordNo { get; set; }
        public decimal? PrevInterCommentRecordNo { get; set; }
        public decimal? NationalAssCommentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
