using System;
using System.Collections.Generic;

namespace Sample.Repository.Models
{
    public partial class ArAccessRequest
    {
        public decimal ArAccessRequestRecordNo { get; set; }
        public decimal? ArSchoolDetailRecordNo { get; set; }
        public decimal? ArDisConfirmRecordNo { get; set; }
        public decimal? ArSpecialEquipRecordNo { get; set; }
        public decimal? ArRiskManageRecordNo { get; set; }
        public decimal? ArSupDocumentRecordNo { get; set; }
        public decimal ArStatusRecordNo { get; set; }
        public decimal? ArDisProgRecordNo { get; set; }
        public decimal? ArAccessFacRecordNo { get; set; }
        public decimal? ArEslRecordNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedByUsername { get; set; }
        public decimal OrgUnitRecordNo { get; set; }
        public decimal StudentRegistrationRecordNo { get; set; }
        public decimal TransactionNo { get; set; }
        public string ProvisionRequiredTimeInd { get; set; }
        public string TrimNo { get; set; }
        public string DocReferenceNo { get; set; }
        public DateTime? StatusLastUpdatedDate { get; set; }
        public string ArRaisedByInd { get; set; }
        public string ArReportStatusInd { get; set; }
        public decimal? ArReportFileRecordNo { get; set; }
        public decimal? ArStatusTranRecordNo { get; set; }
        public DateTime? ArSetupLastUpdatedDate { get; set; }
        public string ArSetupVerificationInd { get; set; }
        public decimal? VerificationCommentRecordNo { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public decimal? ArOwnerOrgUnitRecordNo { get; set; }
        public decimal? ReturnedToSchoolCounter { get; set; }
        public string ReturnedToAddAttachmentInd { get; set; }
        public decimal? ArpUploadCommentRecordNo { get; set; }
        public string ReviewedInd { get; set; }
        public DateTime? ReviewedDate { get; set; }
        public string IfsSupportedReviewedInd { get; set; }
        public decimal? ScasRegistrationCounter { get; set; }
        public DateTime? ArFirstSubmissionDate { get; set; }
    }
}
