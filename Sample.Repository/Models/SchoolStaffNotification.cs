using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SchoolStaffNotification
    {
        public decimal SchoolStaffNotifRecordNo { get; set; }
        public string EmployeeId { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
