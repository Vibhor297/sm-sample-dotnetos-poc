using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ChangeLogCategory
    {
        public ChangeLogCategory()
        {
            StudentDetailChangeLog = new HashSet<StudentDetailChangeLog>();
        }

        public decimal ChangeLogCategoryRecordNo { get; set; }
        public string ChangeLogCategoryCode { get; set; }
        public string ChangeLogCategoryName { get; set; }
        public string ChangeLogCategoryMessage { get; set; }
        public string NotifyNonCensus { get; set; }
        public string NotifyCensus { get; set; }
        public string EmailNotification { get; set; }
        public string EmailText { get; set; }

        public virtual ICollection<StudentDetailChangeLog> StudentDetailChangeLog { get; set; }
    }
}
