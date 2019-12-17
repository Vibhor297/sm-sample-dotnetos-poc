using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArPlacementPanel
    {
        public decimal ArPpRecordNo { get; set; }
        public string StateWideInd { get; set; }
        public string PpTypeInd { get; set; }
        public string PpNm { get; set; }
        public string PpAbbrevNm { get; set; }
        public decimal PpStatusRecordNo { get; set; }
        public DateTime PpStartDate { get; set; }
        public DateTime PpEndDate { get; set; }
        public decimal? TextCommentRecordNo { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime? MeetingStartDateTime { get; set; }
        public DateTime? MeetingEndDateTime { get; set; }
        public decimal? AlertNumberOfDaysPrior { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
