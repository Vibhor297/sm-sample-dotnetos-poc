using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ParentLanguage
    {
        public decimal ParentLanguageRecordNo { get; set; }
        public decimal ParentRecordNo { get; set; }
        public decimal LanguageCodeRecordNo { get; set; }
        public string ParentLanguageCodeInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
