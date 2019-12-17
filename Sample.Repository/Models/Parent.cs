using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class Parent
    {
        public long ParentRecordNo { get; set; }
        public decimal FamilyRecordNo { get; set; }
        public decimal NameSalutationCodeRecordNo { get; set; }
        public string FamilyNm { get; set; }
        public string FirstNm { get; set; }
        public string OtherNm { get; set; }
        public string PrefFirstNm { get; set; }
        public string PrefFamilyNm { get; set; }
        public string GenderInd { get; set; }
        public decimal OgTypeRecordNo { get; set; }
        public decimal PseRecordNo { get; set; }
        public decimal PteRecordNo { get; set; }
        public string InterpreterRequiredInd { get; set; }
        public decimal CountryOfBirthRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string EnglishAtHomeInd { get; set; }
        public string OccupationNm { get; set; }
        public string IsAliveInd { get; set; }
        public decimal? AtsiCodeRecordNo { get; set; }
    }
}
