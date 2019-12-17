using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArPlacementPanelMember
    {
        public decimal ArPpMemberRecordNo { get; set; }
        public decimal ArPpRecordNo { get; set; }
        public string MemberTypeInd { get; set; }
        public string DetUserId { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public string EmailAddress { get; set; }
        public string EmailAddressValidInd { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string NotificationSentInd { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
