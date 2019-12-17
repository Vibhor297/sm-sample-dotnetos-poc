using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArDisabilityProgramItem
    {
        public decimal ArDisProgItemRecordNo { get; set; }
        public decimal? ArDisProgRecordNo { get; set; }
        public decimal? DisabilityProgramRecordNo { get; set; }
        public decimal? DisabilityProgItemRecordNo { get; set; }
        public decimal? EnrolmentTypeRecordNo { get; set; }
        public decimal? Priority { get; set; }
        public decimal TransactionNo { get; set; }
        public string OperatorInd { get; set; }
        public decimal? ArChRecordNo { get; set; }
        public decimal? PriorityStatusRecordNo { get; set; }
        public string RegistrationFlag { get; set; }
        public decimal? RegistrationRecordNo { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public string OperatorindChanged { get; set; }
    }
}
