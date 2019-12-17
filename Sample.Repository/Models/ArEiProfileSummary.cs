using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArEiProfileSummary
    {
        public decimal ArEiProfSummRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
        public string SignNm { get; set; }
        public string SignPosition { get; set; }
        public decimal? ArAttachmentRecordNo { get; set; }
        public string CurrentSettings { get; set; }
    }
}
