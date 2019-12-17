using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegistrationOfferTemp
    {
        public decimal RegistrationOfferRecordNo { get; set; }
        public string RegistrationOfferNm { get; set; }
        public decimal OfferingStatusRecordNo { get; set; }
        public decimal CalendarYear { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal? DossierRecordNo { get; set; }
        public decimal CurrentPlaces { get; set; }
        public decimal MaxPlaces { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal SyCodeRecordNo { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public string FeedFromThisYearInd { get; set; }
        public decimal? EnrolmentTypeRecordNo { get; set; }
        public decimal? RegistrationOfferFee { get; set; }
        public decimal FundingIntegrationCount { get; set; }
    }
}
