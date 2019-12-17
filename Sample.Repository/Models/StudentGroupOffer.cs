using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class StudentGroupOffer
    {
        public decimal SgOfferRecordNo { get; set; }
        public string SgOfferNm { get; set; }
        public decimal OfferingStatusRecordNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal? DossierRecordNo { get; set; }
        public decimal CurrentPlaces { get; set; }
        public decimal MaxPlaces { get; set; }
        public string StudentReportingInd { get; set; }
        public string DistanceEdInd { get; set; }
        public decimal ActivityTypeRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public decimal? OrgUnitRecordNo { get; set; }
        public string OasisXrefCode { get; set; }
        public string OasisXrefDesc { get; set; }
        public string RollClassInd { get; set; }
        public decimal? CurriculumOfferRecordNo { get; set; }
        public string ReportingGroupInd { get; set; }
        public decimal? ReportsToRecordNo { get; set; }
        public byte? OasisXrefClassNum { get; set; }
        public string OasisXrefClassName { get; set; }
        public string OasisXrefComcode { get; set; }
        public string OasisXrefComname { get; set; }
        public byte? NumberOfPeriods { get; set; }
        public string DefaultSubgroupInd { get; set; }
        public string ConnectedClassroomInd { get; set; }
        public string Guid { get; set; }
        public string RefreshInd { get; set; }
        public DateTime? LastRefreshedDate { get; set; }
        public DateTime? RefreshReqDate { get; set; }
        public string SgOfferPrintNm { get; set; }
    }
}
