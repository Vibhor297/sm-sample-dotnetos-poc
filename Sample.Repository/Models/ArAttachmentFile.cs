using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArAttachmentFile
    {
        public decimal ArAttachmentFileRecordNo { get; set; }
        public decimal ArAccessRequestRecordNo { get; set; }
        public string FileNm { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? SupportTypeRecordNo { get; set; }
        public string AttachmentSectionInd { get; set; }
        public string AddedByUsername { get; set; }
    }
}
