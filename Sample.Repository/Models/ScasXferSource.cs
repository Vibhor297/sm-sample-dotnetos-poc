using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ScasXferSource
    {
        public string SourceId { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string GenderInd { get; set; }
        public string XferStatusCode { get; set; }
        public string XferCommentText { get; set; }
        public string ScasLocation { get; set; }
        public string ScasSyCode { get; set; }
        public string ScasEnroltypeCode { get; set; }
    }
}
