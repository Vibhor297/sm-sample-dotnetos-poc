using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArSchoolDetail
    {
        public decimal ArSchoolDetailRecordNo { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public decimal? StaffRecordNo { get; set; }
        public string PresentClassInd { get; set; }
        public decimal? EnrolmentTypeRecordNo { get; set; }
        public string SchoolType { get; set; }
        public string OtherSchoolNm { get; set; }
        public string OtherStaffNm { get; set; }
        public string OtherDisabilityRoleNm { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? DisabilityRoleRecordNo { get; set; }
    }
}
