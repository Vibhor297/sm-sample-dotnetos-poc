using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentRegistration
    {
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal StudentRecordNo { get; set; }
        public DateTime? LeavingDate { get; set; }
        public decimal? LeaverDestinationRecordNo { get; set; }
        public string LeaverDestinationNm { get; set; }
        public decimal? LeaverToOrgUnitRecordNo { get; set; }
        public string LeaverToSchoolNm { get; set; }
        public decimal TransactionNo { get; set; }
        public string SuspendExpellInd { get; set; }
        public string ActualViolenceInd { get; set; }
        public string PossessionWeaponInd { get; set; }
        public string ThreatViolenceInd { get; set; }
        public string IllegalDrugInd { get; set; }
        public string ScriptureGroup { get; set; }
        public decimal? EnrolmentCommentRecordNo { get; set; }
        public string SpecialCircumstanceInd { get; set; }
        public string PreviousHistoryInd { get; set; }
        public string ViolentBehaviourInd { get; set; }
        public string OtherIncidentInd { get; set; }
        public decimal? SpecialNeedCommentRecordNo { get; set; }
        public string NonGovHs { get; set; }
        public string SelectiveHs { get; set; }
        public string LowIncomeInd { get; set; }
        public string LowIncomeCardNo { get; set; }
        public string VerbalAdviceInd { get; set; }
        public decimal? SgOfferRecordNo { get; set; }
        public decimal? SpecialCircCommentRecordNo { get; set; }
        public decimal? PrevHistCommentRecordNo { get; set; }
        public decimal? ViolentBehCommentRecordNo { get; set; }
        public decimal? OtherIncCommentRecordNo { get; set; }
        public decimal? PrevContactCommentRecordNo { get; set; }
        public string PlspInd { get; set; }
        public string PrevPlspInd { get; set; }
        public decimal? PrevPlspIndCommentRecNo { get; set; }
        public string LearningSupportRequiredInd { get; set; }
        public string HomeModSchoolRequiredInd { get; set; }
        public string SreInd { get; set; }
        public string SeeInd { get; set; }
    }
}
