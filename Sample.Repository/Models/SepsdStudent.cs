using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdStudent
    {
        public SepsdStudent()
        {
            SepsdDoctor = new HashSet<SepsdDoctor>();
            SepsdParentRelationship = new HashSet<SepsdParentRelationship>();
            SepsdRegistration = new HashSet<SepsdRegistration>();
            SepsdStudentEmerContact = new HashSet<SepsdStudentEmerContact>();
        }

        public decimal Srn { get; set; }
        public decimal StudentRecordNo { get; set; }
        public string DetUserId { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public string PrefFirstNm { get; set; }
        public string PrefFamilyNm { get; set; }
        public string OtherNm { get; set; }
        public string Aboriginal { get; set; }
        public string GenderInd { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CountryOfBirthRecordNo { get; set; }
        public DateTime? ArrivedInAustrliaDate { get; set; }
        public string LanguageCode { get; set; }
        public string OtherLanguageCode { get; set; }
        public string OtherLanguageCode2 { get; set; }
        public string ReligionCode { get; set; }
        public string ResidencyStatusCode { get; set; }
        public string VisaClassCode { get; set; }
        public string VisaSubclassCode { get; set; }
        public DateTime? VisaExpiryDate { get; set; }
        public DateTime? AteExpiryDate { get; set; }
        public DateTime? AteStartDate { get; set; }
        public string VerifiedStatusInd { get; set; }
        public string MedicareId { get; set; }
        public string StudentMobilePhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string ScholasticYearCode { get; set; }
        public string CensusInd { get; set; }
        public string EslAssessmentInd { get; set; }
        public DateTime? LastEslAssessmentDate { get; set; }
        public DateTime? FirstAustEnrolDate { get; set; }
        public string EslPhaseCode { get; set; }
        public decimal? TransactionNo { get; set; }
        public decimal? FamilyRecordNo { get; set; }
        public string VisaHolderInd { get; set; }
        public string IspAccessInd { get; set; }
        public string AuthorityToPublishInd { get; set; }
        public string PscName { get; set; }
        public string PscType { get; set; }
        public string PscWhours { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }
        public string AtsiCodeSrd { get; set; }
        public string AtsiNm { get; set; }
        public string CountryOfBirthCodeSrd { get; set; }
        public string CountryOfBirthNm { get; set; }
        public string LanguageCodeSrd { get; set; }
        public string LanguageNm { get; set; }
        public string OtherLanguageCodeSrd { get; set; }
        public string OtherLanguageNm { get; set; }
        public string OtherLanguageCode2Srd { get; set; }
        public string OtherLanguageNm2 { get; set; }
        public string ReligionCodeSrd { get; set; }
        public string ReligionNm { get; set; }
        public string ResidencyStatusNm { get; set; }
        public string VisaClassNm { get; set; }
        public string VisaSubclassNm { get; set; }
        public string ScholasticYearNm { get; set; }
        public string EslPhaseCodeSrd { get; set; }
        public string EslPhaseNm { get; set; }
        public string PscTypeCodeSrd { get; set; }
        public string PscTypeNm { get; set; }
        public string PscWhoursCodeSrd { get; set; }
        public string PscWhoursNm { get; set; }
        public string InternationalInd { get; set; }
        public string StudentGuid { get; set; }
        public string StudentStatusCodeSrd { get; set; }
        public string StudentStatusNm { get; set; }
        public string OohcTypeCode { get; set; }
        public string OohcTypeNm { get; set; }
        public DateTime? OohcStartDate { get; set; }
        public DateTime? OohcEndDate { get; set; }
        public string GenderNm { get; set; }

        public virtual ICollection<SepsdDoctor> SepsdDoctor { get; set; }
        public virtual ICollection<SepsdParentRelationship> SepsdParentRelationship { get; set; }
        public virtual ICollection<SepsdRegistration> SepsdRegistration { get; set; }
        public virtual ICollection<SepsdStudentEmerContact> SepsdStudentEmerContact { get; set; }
    }
}
