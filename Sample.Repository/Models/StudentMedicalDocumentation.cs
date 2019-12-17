using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentMedicalDocumentation
    {
        public decimal StudentMedicalDocRecordNo { get; set; }
        public decimal StudentMedCondRecordNo { get; set; }
        public string StudentMedicalDocInd { get; set; }
        public decimal? MedDocumentationRecordNo { get; set; }
        public decimal DocumentationTypeRecordNo { get; set; }
        public DateTime? ReviewDate { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public string Guid { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
