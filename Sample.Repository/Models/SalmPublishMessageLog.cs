using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SalmPublishMessageLog
    {
        public decimal LogId { get; set; }
        public string TrackId { get; set; }
        public string RequestBy { get; set; }
        public string Operation { get; set; }
        public string SystemFrom { get; set; }
        public string MessageText { get; set; }
        public DateTime? ProcessTime { get; set; }
    }
}
