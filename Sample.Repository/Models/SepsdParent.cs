using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class SepsdParent
    {
        public SepsdParent()
        {
            SepsdParentRelationship = new HashSet<SepsdParentRelationship>();
        }

        public decimal ParentRecordNo { get; set; }
        public string Guid { get; set; }
        public decimal? FamilyRecordNo { get; set; }
        public string FamilySalutation { get; set; }
        public string FamilyGuid { get; set; }
        public string NameSalutation { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public string OtherNm { get; set; }
        public string PrefFirstNm { get; set; }
        public string PrefFamilyNm { get; set; }
        public string GenderInd { get; set; }
        public string InterpreterRequiredInd { get; set; }
        public string CountryOfBirth { get; set; }
        public string OccupationNm { get; set; }
        public string EnglishAtHomeInd { get; set; }
        public string HomeLanguageCode { get; set; }
        public string HomeLanguageCode2 { get; set; }
        public string OtherLanguageCode { get; set; }
        public string PseCode { get; set; }
        public string PteCode { get; set; }
        public string OgTypeCode { get; set; }
        public string IsAliveInd { get; set; }
        public DateTime IsAliveIndModifiedDate { get; set; }
        public DateTime RecordLastModified { get; set; }
        public DateTime RecordLastResync { get; set; }
        public decimal? TransactionNo { get; set; }
        public string AtsiCodeSrd { get; set; }
        public string AtsiNm { get; set; }
        public string CountryOfBirthNm { get; set; }
        public string HomeLanguageNm { get; set; }
        public string HomeLanguageNm2 { get; set; }
        public string OtherLanguageNm { get; set; }
        public string PseNm { get; set; }
        public string PteNm { get; set; }
        public string OcgTypeNm { get; set; }
        public string CountryOfBirthCodeSrd { get; set; }
        public string HomeLanguageCodeSrd { get; set; }
        public string HomeLanguageCode2Srd { get; set; }
        public string OtherLanguageCodeSrd { get; set; }
        public string PseCodeSrd { get; set; }
        public string PteCodeSrd { get; set; }
        public string OcgTypeCodeSrd { get; set; }
        public string GenderNm { get; set; }

        public virtual ICollection<SepsdParentRelationship> SepsdParentRelationship { get; set; }
    }
}
