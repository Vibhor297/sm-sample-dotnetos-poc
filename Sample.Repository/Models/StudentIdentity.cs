using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentIdentity
    {
        public decimal StudentRecordNo { get; set; }
        public decimal Srn { get; set; }
        public string Guid { get; set; }
        public string DetUserId { get; set; }
        public string EmailAddress { get; set; }
        public decimal? TransactionNo { get; set; }
    }
}
