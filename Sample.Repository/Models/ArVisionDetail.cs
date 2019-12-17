using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArVisionDetail
    {
        public decimal ArVisionDetailRecordNo { get; set; }
        public DateTime? DiagnosisDate { get; set; }
        public string NatureOfVisionLossInd { get; set; }
        public string FvaConductedInd { get; set; }
        public DateTime? FvaConductedDate { get; set; }
        public decimal? SkillCommentRecordNo { get; set; }
        public string CurrentIstvHour { get; set; }
        public string CurrentIstvMonitorInd { get; set; }
        public string RecommendIstvHour { get; set; }
        public string RecommendIstvMonitorInd { get; set; }
        public decimal? VisionLossCommentRecordNo { get; set; }
        public decimal? ArSupDocDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? VisionAidCommentRecordNo { get; set; }
        public string AssesserNm { get; set; }
        public string AssesserPosition { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public string VisualfieldCentralInd { get; set; }
        public string VisualfieldPeripheralInd { get; set; }
    }
}
