using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class OasisReport
    {
        public decimal OasisReportRecordNo { get; set; }
        public string ReportName { get; set; }
        public string ReportHeader { get; set; }
        public string ReportQuery { get; set; }
        public string ReportTaskId { get; set; }
        public string ReportCommand { get; set; }
    }
}
