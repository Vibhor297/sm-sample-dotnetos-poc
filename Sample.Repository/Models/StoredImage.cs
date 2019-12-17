using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StoredImage
    {
        public decimal StoredImageRecordNo { get; set; }
        public string StoredImageNm { get; set; }
        public string StoredImageType { get; set; }
        public byte[] StoredImageValue { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
