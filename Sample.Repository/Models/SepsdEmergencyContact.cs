using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdEmergencyContact
    {
        public SepsdEmergencyContact()
        {
            SepsdStudentEmerContact = new HashSet<SepsdStudentEmerContact>();
        }

        public decimal EmercontactRecNo { get; set; }
        public string Guid { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public string FamilyRelationCode { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }
        public decimal? TransactionNo { get; set; }
        public string FamilyRelationNm { get; set; }

        public virtual ICollection<SepsdStudentEmerContact> SepsdStudentEmerContact { get; set; }
    }
}
