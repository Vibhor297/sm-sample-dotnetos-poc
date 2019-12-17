using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentPlspFile
    {
        public decimal StudentPlspFileRecordNo { get; set; }
        public decimal StudentPlspRecordNo { get; set; }
        public string FileNm { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
