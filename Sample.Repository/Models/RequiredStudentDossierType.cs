using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RequiredStudentDossierType
    {
        public decimal RsdTypeRecordNo { get; set; }
        public decimal DossierTypeRecordNo { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
