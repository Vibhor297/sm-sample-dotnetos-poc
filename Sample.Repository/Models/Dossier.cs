using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class Dossier
    {
        public decimal DossierRecordNo { get; set; }
        public string DossierNm { get; set; }
        public decimal DossierTypeRecordNo { get; set; }
        public string DossierVisibilityInd { get; set; }
        public string AlertFlagInd { get; set; }
        public DateTime? ReviewDate { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? TextCommentRecordNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ReferenceNo { get; set; }
        public string Guid { get; set; }
        public decimal? TextCommentRecordNo2 { get; set; }
    }
}
