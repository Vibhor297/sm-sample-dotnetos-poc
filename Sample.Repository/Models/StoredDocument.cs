using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StoredDocument
    {
        public decimal StoredDocumentRecordNo { get; set; }
        public string StoredDocumentNm { get; set; }
        public string StoredDocumentType { get; set; }
        public byte[] StoredDocumentValue { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
