using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArKindiProfileSummary
    {
        public decimal ArKindiProfSummRecordNo { get; set; }
        public string SignNm { get; set; }
        public string SignPosition { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? ArAttachmentRecordNo { get; set; }
        public string CurrentSettings { get; set; }
    }
}
