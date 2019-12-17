using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentPscIntake
    {
        public decimal StudentPscIntakeRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal PscTypeRecordNo { get; set; }
        public decimal PscWhoursTypeRecordNo { get; set; }
        public string PostCode { get; set; }
        public decimal TransactionNo { get; set; }
        public string PreviousSchoolNm { get; set; }
        public string SchoolType { get; set; }
        public decimal? PreviousOrgUnitRecordNo { get; set; }
    }
}
