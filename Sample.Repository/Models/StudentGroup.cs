using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentGroup
    {
        public decimal StudentGroupRecordNo { get; set; }
        public decimal SgOfferRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string MembershipCurrentInd { get; set; }
    }
}
