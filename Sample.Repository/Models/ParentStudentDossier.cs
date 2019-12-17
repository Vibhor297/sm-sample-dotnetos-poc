using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ParentStudentDossier
    {
        public decimal ParentStuDossierRecordNo { get; set; }
        public decimal ParentRecordNo { get; set; }
        public decimal? StudentRecordNo { get; set; }
        public decimal DossierRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
