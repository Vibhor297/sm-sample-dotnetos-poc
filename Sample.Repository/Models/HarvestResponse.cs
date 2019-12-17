using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class HarvestResponse
    {
        public decimal HarvestResponseRecordNo { get; set; }
        public DateTime HarvestResponseDate { get; set; }
        public decimal HarvestEventRecordNo { get; set; }
        public decimal OrganisationalUnitRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
