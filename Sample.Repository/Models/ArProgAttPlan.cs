using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArProgAttPlan
    {
        public decimal ArProgAttPlanRecordNo { get; set; }
        public decimal? DayOfWeek { get; set; }
        public string Period { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? ArEiProfSummRecordNo { get; set; }
    }
}
