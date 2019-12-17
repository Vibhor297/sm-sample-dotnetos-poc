using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegistrationIntake
    {
        public decimal RegistrationIntakeRecordNo { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public string IntakeTypeInd { get; set; }
        public decimal? PscTypeRecordNo { get; set; }
        public decimal? PscWhoursTypeRecordNo { get; set; }
        public string PreviousSchoolNm { get; set; }
        public decimal? PreviousOrgUnitRecordNo { get; set; }
        public string PreviousSchoolLocation { get; set; }
        public string YearAttendedDesc { get; set; }
        public DateTime? FirstAustEnrolDate { get; set; }
        public decimal TransactionNo { get; set; }
        public string SchoolType { get; set; }
        public string ToYearAttendedDesc { get; set; }
        public string YearAttendedDescOld { get; set; }
        public string ToYearAttendedDescOld { get; set; }
    }
}
