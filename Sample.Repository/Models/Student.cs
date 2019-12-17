using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class Student
    {
        public decimal StudentRecordNo { get; set; }
        public decimal Srn { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public string OtherNm { get; set; }
        public string PrefFirstNm { get; set; }
        public string PrefFamilyNm { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string GenderInd { get; set; }
        public decimal StudentStatusRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? ReligionCodeRecordNo { get; set; }
        public decimal? AtsiCodeRecordNo { get; set; }
        public string EslAssessmentInd { get; set; }
        public decimal? EslPhaseRecordNo { get; set; }
        public decimal? CountryOfBirthRecordNo { get; set; }
        public string EnglishAtHomeInd { get; set; }
        public string StudentAllergyInd { get; set; }
        public string StudentBehaviourInd { get; set; }
        public DateTime? LastEslAssessmentDate { get; set; }
        public string MedicareId { get; set; }
        public string AllowPhotoInd { get; set; }
        public string IspAccessInd { get; set; }
        public string StudentMobilePhoneNo { get; set; }
        public string DerAssignmentTypeInd { get; set; }
        public string DerConsentInd { get; set; }
        public string DerDisabilityFundingInd { get; set; }
        public string DerBarredInd { get; set; }
        public string PickupInd { get; set; }
        public string LboteInd { get; set; }
        public string DerLoanCharterInd { get; set; }
        public decimal? DerConsentDocRecordNo { get; set; }
        public decimal? DerLoanDocRecordNo { get; set; }
        public decimal? DerGraduationDocRecordNo { get; set; }
        public DateTime? LatestCounsellingDate { get; set; }
        public DateTime? LatestLearningPlanDate { get; set; }
        public DateTime? LatestRiskAssessmentDate { get; set; }
        public string AuthorityToPublishInd { get; set; }
        public DateTime? MedicareExpiryDate { get; set; }
        public string StudentReferenceNumber { get; set; }
        public DateTime? FirstAustEnrolDate { get; set; }
        public string OohcInd { get; set; }

        public virtual SepsdChangedStudent SepsdChangedStudent { get; set; }
    }
}
