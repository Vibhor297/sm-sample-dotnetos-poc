using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SchoolMedicalStock
    {
        public decimal SchoolMedicalStockRecordNo { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public decimal? AutoInjectorJuniorMin { get; set; }
        public decimal? AutoInjectorAdultMin { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
