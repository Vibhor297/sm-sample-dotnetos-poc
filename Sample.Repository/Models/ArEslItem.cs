using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArEslItem
    {
        public decimal ArEslItemRecordNo { get; set; }
        public decimal EslSkillRecordNo { get; set; }
        public decimal EslLevelRecordNo { get; set; }
        public decimal? EslCommentRecordNo { get; set; }
        public decimal ArEslRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal EslPhaseRecordNo { get; set; }
    }
}
