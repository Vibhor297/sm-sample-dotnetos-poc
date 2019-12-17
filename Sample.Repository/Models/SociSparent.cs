using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SociSparent
    {
        public decimal OasisDatabaseRecordNo { get; set; }
        public decimal Stucode { get; set; }
        public decimal SepParentRecordNo { get; set; }
        public DateTime SepRowChangedDatetime { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string Givenname { get; set; }
        public string Relatnship { get; set; }
        public string Stnum { get; set; }
        public string Stname { get; set; }
        public string Addr1 { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public decimal TransactionNo { get; set; }
        public string Pobox { get; set; }
        public string Accessinfo { get; set; }
        public string Accesdesc { get; set; }
        public string Report { get; set; }
        public string Famtitle { get; set; }
        public string Recvinv { get; set; }
        public string Deceased { get; set; }
    }
}
