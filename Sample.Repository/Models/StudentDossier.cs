using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentDossier
    {
        public decimal StudentDossierRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal DossierRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
