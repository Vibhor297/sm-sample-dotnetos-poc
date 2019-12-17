using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdRegistration
    {
        public decimal RegistrationRecordNo { get; set; }
        public string Guid { get; set; }
        public decimal Srn { get; set; }
        public decimal? OrgUnitCode { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime IntendedStartDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? LeavingDate { get; set; }
        public byte CalendarYear { get; set; }
        public string StudentStatusNm { get; set; }
        public string StudentStatusCode { get; set; }
        public string InZoneInd { get; set; }
        public string EnrolmentTypeCode { get; set; }
        public decimal? RegistrationOfferRecordNo { get; set; }
        public string RollClassName { get; set; }
        public string HouseSgOfferNm { get; set; }
        public string SyCodeRecordNo { get; set; }
        public string Leaving { get; set; }
        public string PreviousOrgUnitCode { get; set; }
        public string PreviousSchoolNm { get; set; }
        public string DestOrgUnitCode { get; set; }
        public string DestSchoolNm { get; set; }
        public string CensusInd { get; set; }
        public string LeaverToSchoolNm { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }
        public decimal? TransactionNo { get; set; }
        public string SchoolGuid { get; set; }
        public string RegistrationGuid { get; set; }
        public string CentrelinkFundingInd { get; set; }
        public string OrgUnitNm { get; set; }
        public string EnrolmentTypeNm { get; set; }
        public string ScholasticYearCode { get; set; }
        public string ScholasticYearNm { get; set; }
        public string RegistrationOfferNm { get; set; }
        public string RegistrationStatusCodeSrd { get; set; }
        public string RegistrationStatusNm { get; set; }
        public string RollClassNameErn { get; set; }

        public virtual SepsdStudent SrnNavigation { get; set; }
    }
}
