using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SlsStaffLocations
    {
        public string StaffGuid { get; set; }
        public string DetUserId { get; set; }
        public string Locations { get; set; }
        public decimal TransactionNo { get; set; }
    }
}
