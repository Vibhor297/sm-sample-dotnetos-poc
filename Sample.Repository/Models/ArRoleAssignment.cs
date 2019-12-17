using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArRoleAssignment
    {
        public decimal ArRoleAssignRecordNo { get; set; }
        public decimal DisabilityRoleRecordNo { get; set; }
        public decimal ArAccessRequestRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string DetUserId { get; set; }
        public string RoleChanged { get; set; }
    }
}
