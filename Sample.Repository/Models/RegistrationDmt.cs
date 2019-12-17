using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class RegistrationDmt
    {
        public decimal RegistrationRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public decimal RegistrationStatusRecordNo { get; set; }
        public string CensusInd { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime IntendedStartDate { get; set; }
        public decimal RegistrationOfferRecordNo { get; set; }
        public string DistanceEdInd { get; set; }
        public decimal TransactionNo { get; set; }
        public DateTime? LeavingDate { get; set; }
        public decimal? PreferenceNo { get; set; }
        public decimal? RankNo { get; set; }
        public string RiskAssessedInd { get; set; }
        public string PrincipalSignedInd { get; set; }
        public string StudentDeclarationInd { get; set; }
        public DateTime? PrincipalDeclarationDate { get; set; }
        public DateTime? StudentDeclarationDate { get; set; }
        public decimal? FamilyAddressRecordNo { get; set; }
        public string InZoneInd { get; set; }
        public string SecondStudentDeclareInd { get; set; }
        public DateTime? SecondStudentDeclareDate { get; set; }
        public string StudentHistoryAssessedInd { get; set; }
        public string RiskAssessmentRequiredInd { get; set; }
        public string RiskManagementPlanInd { get; set; }
        public string FundingIntegrationInd { get; set; }
        public string ReadingRecoveryInd { get; set; }
        public string PrivateSchoolInd { get; set; }
        public string CentrelinkFundingInd { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal? FactorOfNeedRecordNo { get; set; }
        public DateTime? MissingDate { get; set; }
        public DateTime? FoundDate { get; set; }
        public decimal? EbsPrevRegStatusRecordNo { get; set; }
    }
}
