using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArVisionLevel
    {
        public decimal ArVisionLevelRecordNo { get; set; }
        public decimal? VisionLevelValueRecordNo { get; set; }
        public string EyeSideInd { get; set; }
        public string VisualTypeInd { get; set; }
        public decimal? ArVisionDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal VisionLevelRecordNo { get; set; }
        public string DiagnosedLevelOther { get; set; }
    }
}
