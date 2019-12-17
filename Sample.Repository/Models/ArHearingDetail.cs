using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArHearingDetail
    {
        public decimal ArHearingDetailRecordNo { get; set; }
        public decimal? HearLevelCommentRecordNo { get; set; }
        public DateTime? DiagnosisDate { get; set; }
        public string AssesserNm { get; set; }
        public string AssesserPosition { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public decimal? LeftThreshold { get; set; }
        public decimal? RightThreshold { get; set; }
        public decimal? SkillCommentRecordNo { get; set; }
        public string CurrentIsthHour { get; set; }
        public string CurrentIsthMonitorInd { get; set; }
        public string RecommendIsthHour { get; set; }
        public string RecommendIsthMonitorInd { get; set; }
        public decimal? HearLossCommentRecordNo { get; set; }
        public decimal? ArSupDocDetailRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string NatureOfHearingLossInd { get; set; }
        public string OtitisMediaInd { get; set; }
        public decimal? DisAidCommentRecordNo { get; set; }
    }
}
