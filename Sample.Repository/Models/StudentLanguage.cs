using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentLanguage
    {
        public decimal StudentLanguageRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal LanguageCodeRecordNo { get; set; }
        public string StudentLanguageCodeInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
