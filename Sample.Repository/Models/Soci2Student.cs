using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class Soci2Student
    {
        public string StudentGuid { get; set; }
        public decimal Srn { get; set; }
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
        public string PscTypeNm { get; set; }
        public string PscType { get; set; }
        public DateTime? FirstAustEnrolDate { get; set; }
        public string PscWhoursTypeCode { get; set; }
        public string PscWhoursTypeNm { get; set; }
        public string EslPhaseCode { get; set; }
    }
}
