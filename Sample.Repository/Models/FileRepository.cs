using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class FileRepository
    {
        public decimal FileRepositoryRecordNo { get; set; }
        public string FileRepositoryNm { get; set; }
        public byte[] FileRepositoryData { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
