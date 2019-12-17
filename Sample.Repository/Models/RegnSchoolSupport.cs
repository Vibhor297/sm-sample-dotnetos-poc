using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegnSchoolSupport
    {
        public decimal RegnSchoolSupportRecordNo { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal SchoolSupportRecordNo { get; set; }
        public string SchoolSupportNm { get; set; }
        public string PreviousSchoolSupportInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
