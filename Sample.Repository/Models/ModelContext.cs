using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sample.Repository.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
            
           //options.UseOracle("DATA SOURCE=du0992vmwd0015.dbs.dev.det.nsw.edu.au:1521/platod.dev.det.nsw.edu.au;PERSIST SECURITY INFO=True;USER ID=SEPDBA;Password=password;");
        }

        public virtual DbSet<AddressDetail> AddressDetail { get; set; }
        public virtual DbSet<AppConfig> AppConfig { get; set; }
        public virtual DbSet<ArAccessFacility> ArAccessFacility { get; set; }
        public virtual DbSet<ArAccessFacilityItem> ArAccessFacilityItem { get; set; }
        public virtual DbSet<ArAccessRequest> ArAccessRequest { get; set; }
        public virtual DbSet<ArAttachment> ArAttachment { get; set; }
        public virtual DbSet<ArAttachmentFile> ArAttachmentFile { get; set; }
        public virtual DbSet<ArAttachmentVerification> ArAttachmentVerification { get; set; }
        public virtual DbSet<ArAutismDetail> ArAutismDetail { get; set; }
        public virtual DbSet<ArClassroomAssessment> ArClassroomAssessment { get; set; }
        public virtual DbSet<ArClearingHouse> ArClearingHouse { get; set; }
        public virtual DbSet<ArClearingHouseCoord> ArClearingHouseCoord { get; set; }
        public virtual DbSet<ArClearingHouseOwner> ArClearingHouseOwner { get; set; }
        public virtual DbSet<ArDetSupportAccess> ArDetSupportAccess { get; set; }
        public virtual DbSet<ArDetSupportAccessItem> ArDetSupportAccessItem { get; set; }
        public virtual DbSet<ArDisCommunicationMode> ArDisCommunicationMode { get; set; }
        public virtual DbSet<ArDisabilityConfirm> ArDisabilityConfirm { get; set; }
        public virtual DbSet<ArDisabilityItem> ArDisabilityItem { get; set; }
        public virtual DbSet<ArDisabilityProgram> ArDisabilityProgram { get; set; }
        public virtual DbSet<ArDisabilityProgramItem> ArDisabilityProgramItem { get; set; }
        public virtual DbSet<ArDisabilitySkill> ArDisabilitySkill { get; set; }
        public virtual DbSet<ArEiAccessDomain> ArEiAccessDomain { get; set; }
        public virtual DbSet<ArEiProSumContact> ArEiProSumContact { get; set; }
        public virtual DbSet<ArEiProfileSummary> ArEiProfileSummary { get; set; }
        public virtual DbSet<ArEiSignDetail> ArEiSignDetail { get; set; }
        public virtual DbSet<ArEsl> ArEsl { get; set; }
        public virtual DbSet<ArEslItem> ArEslItem { get; set; }
        public virtual DbSet<ArEslSignDetail> ArEslSignDetail { get; set; }
        public virtual DbSet<ArHearingAid> ArHearingAid { get; set; }
        public virtual DbSet<ArHearingAssessment> ArHearingAssessment { get; set; }
        public virtual DbSet<ArHearingDetail> ArHearingDetail { get; set; }
        public virtual DbSet<ArHearingLossLevel> ArHearingLossLevel { get; set; }
        public virtual DbSet<ArHearingSupportSkill> ArHearingSupportSkill { get; set; }
        public virtual DbSet<ArKindiAccessDomain> ArKindiAccessDomain { get; set; }
        public virtual DbSet<ArKindiProSumContact> ArKindiProSumContact { get; set; }
        public virtual DbSet<ArKindiProfileSummary> ArKindiProfileSummary { get; set; }
        public virtual DbSet<ArKindiSignDetail> ArKindiSignDetail { get; set; }
        public virtual DbSet<ArKla> ArKla { get; set; }
        public virtual DbSet<ArLearningAssistProgram> ArLearningAssistProgram { get; set; }
        public virtual DbSet<ArMhEdBdDetail> ArMhEdBdDetail { get; set; }
        public virtual DbSet<ArMobilityProgram> ArMobilityProgram { get; set; }
        public virtual DbSet<ArNationalAssessDetail> ArNationalAssessDetail { get; set; }
        public virtual DbSet<ArNationalAssessment> ArNationalAssessment { get; set; }
        public virtual DbSet<ArNatureOfHearingLoss> ArNatureOfHearingLoss { get; set; }
        public virtual DbSet<ArNonDetSupportAccess> ArNonDetSupportAccess { get; set; }
        public virtual DbSet<ArNonDetSupportAccessItem> ArNonDetSupportAccessItem { get; set; }
        public virtual DbSet<ArPlacementPanel> ArPlacementPanel { get; set; }
        public virtual DbSet<ArPlacementPanelConv> ArPlacementPanelConv { get; set; }
        public virtual DbSet<ArPlacementPanelMember> ArPlacementPanelMember { get; set; }
        public virtual DbSet<ArPlacementPanelOutcome> ArPlacementPanelOutcome { get; set; }
        public virtual DbSet<ArPlacementPanelOwner> ArPlacementPanelOwner { get; set; }
        public virtual DbSet<ArPrincipalSignDetail> ArPrincipalSignDetail { get; set; }
        public virtual DbSet<ArPriorityPlacementPnl> ArPriorityPlacementPnl { get; set; }
        public virtual DbSet<ArPriorityStatusChgHis> ArPriorityStatusChgHis { get; set; }
        public virtual DbSet<ArProgAttPlan> ArProgAttPlan { get; set; }
        public virtual DbSet<ArRiskManagement> ArRiskManagement { get; set; }
        public virtual DbSet<ArRiskPlanDetail> ArRiskPlanDetail { get; set; }
        public virtual DbSet<ArRoleAssignment> ArRoleAssignment { get; set; }
        public virtual DbSet<ArSchProSumSignDetail> ArSchProSumSignDetail { get; set; }
        public virtual DbSet<ArSchoolAccessDomain> ArSchoolAccessDomain { get; set; }
        public virtual DbSet<ArSchoolContact> ArSchoolContact { get; set; }
        public virtual DbSet<ArSchoolDetail> ArSchoolDetail { get; set; }
        public virtual DbSet<ArSchoolProfileSummary> ArSchoolProfileSummary { get; set; }
        public virtual DbSet<ArSignDetail> ArSignDetail { get; set; }
        public virtual DbSet<ArSpecialEquipment> ArSpecialEquipment { get; set; }
        public virtual DbSet<ArStandardAssCatResult> ArStandardAssCatResult { get; set; }
        public virtual DbSet<ArStandardAssessment> ArStandardAssessment { get; set; }
        public virtual DbSet<ArStatusChangeComment> ArStatusChangeComment { get; set; }
        public virtual DbSet<ArSubmittingParent> ArSubmittingParent { get; set; }
        public virtual DbSet<ArSupDisabilityProgram> ArSupDisabilityProgram { get; set; }
        public virtual DbSet<ArSupDocDetail> ArSupDocDetail { get; set; }
        public virtual DbSet<ArSupDocDetailSign> ArSupDocDetailSign { get; set; }
        public virtual DbSet<ArSupportDocument> ArSupportDocument { get; set; }
        public virtual DbSet<ArTransferHistory> ArTransferHistory { get; set; }
        public virtual DbSet<ArTravelSupportNeed> ArTravelSupportNeed { get; set; }
        public virtual DbSet<ArVisionAccess> ArVisionAccess { get; set; }
        public virtual DbSet<ArVisionAid> ArVisionAid { get; set; }
        public virtual DbSet<ArVisionDetail> ArVisionDetail { get; set; }
        public virtual DbSet<ArVisionLevel> ArVisionLevel { get; set; }
        public virtual DbSet<ArVisionSupportSkill> ArVisionSupportSkill { get; set; }
        public virtual DbSet<ChangeLogCategory> ChangeLogCategory { get; set; }
        public virtual DbSet<CollegeTransition> CollegeTransition { get; set; }
        public virtual DbSet<ContactDetail> ContactDetail { get; set; }
        public virtual DbSet<CourtOrderContact> CourtOrderContact { get; set; }
        public virtual DbSet<DatOrgCount> DatOrgCount { get; set; }
        public virtual DbSet<DatOrgCountRpt> DatOrgCountRpt { get; set; }
        public virtual DbSet<DatOrgCountTmp> DatOrgCountTmp { get; set; }
        public virtual DbSet<DoctorMedicalCondition> DoctorMedicalCondition { get; set; }
        public virtual DbSet<Dossier> Dossier { get; set; }
        public virtual DbSet<Dummy> Dummy { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContact { get; set; }
        public virtual DbSet<EmergencyContactDetail> EmergencyContactDetail { get; set; }
        public virtual DbSet<EsbMessages> EsbMessages { get; set; }
        public virtual DbSet<EslStudentHistorical> EslStudentHistorical { get; set; }
        public virtual DbSet<FactorOfNeed> FactorOfNeed { get; set; }
        public virtual DbSet<FactorOfNeedTemp> FactorOfNeedTemp { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<FamilyContact> FamilyContact { get; set; }
        public virtual DbSet<FamilyEvidence> FamilyEvidence { get; set; }
        public virtual DbSet<FamilyNamesMaskingTmp> FamilyNamesMaskingTmp { get; set; }
        public virtual DbSet<FileRepository> FileRepository { get; set; }
        public virtual DbSet<FirstNamesMaskingTmp> FirstNamesMaskingTmp { get; set; }
        public virtual DbSet<HarvestEvent> HarvestEvent { get; set; }
        public virtual DbSet<HarvestEventSchool> HarvestEventSchool { get; set; }
        public virtual DbSet<HarvestResponse> HarvestResponse { get; set; }
        public virtual DbSet<MedicalDocumentation> MedicalDocumentation { get; set; }
        public virtual DbSet<OEPositionCode> OEPositionCode { get; set; }
        public virtual DbSet<OEResponsibCode> OEResponsibCode { get; set; }
        public virtual DbSet<OESchRoleCode> OESchRoleCode { get; set; }
        public virtual DbSet<ORCleanareaCode> ORCleanareaCode { get; set; }
        public virtual DbSet<ORFloorcovType> ORFloorcovType { get; set; }
        public virtual DbSet<ORRoomType> ORRoomType { get; set; }
        public virtual DbSet<OStudentSupport> OStudentSupport { get; set; }
        public virtual DbSet<OasisIclassXrefSgo> OasisIclassXrefSgo { get; set; }
        public virtual DbSet<OasisIcourseXrefCo> OasisIcourseXrefCo { get; set; }
        public virtual DbSet<OasisReport> OasisReport { get; set; }
        public virtual DbSet<OasisSchool> OasisSchool { get; set; }
        public virtual DbSet<Parent> Parent { get; set; }
        public virtual DbSet<ParentAddress> ParentAddress { get; set; }
        public virtual DbSet<ParentBkup> ParentBkup { get; set; }
        public virtual DbSet<ParentContact> ParentContact { get; set; }
        public virtual DbSet<ParentEvidence> ParentEvidence { get; set; }
        public virtual DbSet<ParentLanguage> ParentLanguage { get; set; }
        public virtual DbSet<ParentRelationship> ParentRelationship { get; set; }
        public virtual DbSet<ParentStudentDossier> ParentStudentDossier { get; set; }
        public virtual DbSet<PickupContact> PickupContact { get; set; }
        public virtual DbSet<PlaceType> PlaceType { get; set; }
        public virtual DbSet<RegSupportStrategy> RegSupportStrategy { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<RegistrationDmt> RegistrationDmt { get; set; }
        public virtual DbSet<RegistrationIntake> RegistrationIntake { get; set; }
        public virtual DbSet<RegistrationLeavingReasonO> RegistrationLeavingReasonO { get; set; }
        public virtual DbSet<RegistrationOffer> RegistrationOffer { get; set; }
        public virtual DbSet<RegistrationOfferTemp> RegistrationOfferTemp { get; set; }
        public virtual DbSet<RegnEvidence> RegnEvidence { get; set; }
        public virtual DbSet<RegnSchoolSupport> RegnSchoolSupport { get; set; }
        public virtual DbSet<RegnSpecialNeed> RegnSpecialNeed { get; set; }
        public virtual DbSet<RequiredStudentDossierType> RequiredStudentDossierType { get; set; }
        public virtual DbSet<SalmEsbMessages> SalmEsbMessages { get; set; }
        public virtual DbSet<SalmMigration> SalmMigration { get; set; }
        public virtual DbSet<SalmPublishMessageLog> SalmPublishMessageLog { get; set; }
        public virtual DbSet<ScasOfferCreate> ScasOfferCreate { get; set; }
        public virtual DbSet<ScasXferSource> ScasXferSource { get; set; }
        public virtual DbSet<SchoolMedicalStock> SchoolMedicalStock { get; set; }
        public virtual DbSet<SchoolMedication> SchoolMedication { get; set; }
        public virtual DbSet<SchoolStaffNotification> SchoolStaffNotification { get; set; }
        public virtual DbSet<SepErrorLog> SepErrorLog { get; set; }
        public virtual DbSet<SepsdChangedStudent> SepsdChangedStudent { get; set; }
        public virtual DbSet<SepsdDoctor> SepsdDoctor { get; set; }
        public virtual DbSet<SepsdEmergencyContact> SepsdEmergencyContact { get; set; }
        public virtual DbSet<SepsdEmergencyContactDetail> SepsdEmergencyContactDetail { get; set; }
        public virtual DbSet<SepsdEntityDocRel> SepsdEntityDocRel { get; set; }
        public virtual DbSet<SepsdEntityDoctor> SepsdEntityDoctor { get; set; }
        public virtual DbSet<SepsdEntityEmerconrel> SepsdEntityEmerconrel { get; set; }
        public virtual DbSet<SepsdEntityEmercontact> SepsdEntityEmercontact { get; set; }
        public virtual DbSet<SepsdEntityRegistration> SepsdEntityRegistration { get; set; }
        public virtual DbSet<SepsdEntityStuconrel> SepsdEntityStuconrel { get; set; }
        public virtual DbSet<SepsdEntityStucontact> SepsdEntityStucontact { get; set; }
        public virtual DbSet<SepsdEntityStudent> SepsdEntityStudent { get; set; }
        public virtual DbSet<SepsdFamilyAddress> SepsdFamilyAddress { get; set; }
        public virtual DbSet<SepsdFamilyContact> SepsdFamilyContact { get; set; }
        public virtual DbSet<SepsdParent> SepsdParent { get; set; }
        public virtual DbSet<SepsdParentAddress> SepsdParentAddress { get; set; }
        public virtual DbSet<SepsdParentContact> SepsdParentContact { get; set; }
        public virtual DbSet<SepsdParentRelationship> SepsdParentRelationship { get; set; }
        public virtual DbSet<SepsdRegistration> SepsdRegistration { get; set; }
        public virtual DbSet<SepsdSchoolSync> SepsdSchoolSync { get; set; }
        public virtual DbSet<SepsdSibling> SepsdSibling { get; set; }
        public virtual DbSet<SepsdStudent> SepsdStudent { get; set; }
        public virtual DbSet<SepsdStudentEmerContact> SepsdStudentEmerContact { get; set; }
        public virtual DbSet<SgRefreshGroup> SgRefreshGroup { get; set; }
        public virtual DbSet<SgRefreshRequest> SgRefreshRequest { get; set; }
        public virtual DbSet<SgScholasticYears> SgScholasticYears { get; set; }
        public virtual DbSet<SgStaffParticipation> SgStaffParticipation { get; set; }
        public virtual DbSet<SgoeType> SgoeType { get; set; }
        public virtual DbSet<SgoeTypeTemp> SgoeTypeTemp { get; set; }
        public virtual DbSet<SlsStaffLocations> SlsStaffLocations { get; set; }
        public virtual DbSet<Soci2Student> Soci2Student { get; set; }
        public virtual DbSet<SociHouse> SociHouse { get; set; }
        public virtual DbSet<SociIclass> SociIclass { get; set; }
        public virtual DbSet<SociIclteach> SociIclteach { get; set; }
        public virtual DbSet<SociIcom> SociIcom { get; set; }
        public virtual DbSet<SociIcomclas> SociIcomclas { get; set; }
        public virtual DbSet<SociIcourse> SociIcourse { get; set; }
        public virtual DbSet<SociIrolcls> SociIrolcls { get; set; }
        public virtual DbSet<SociIschyear> SociIschyear { get; set; }
        public virtual DbSet<SociMergeLog> SociMergeLog { get; set; }
        public virtual DbSet<SociOasisDatabase> SociOasisDatabase { get; set; }
        public virtual DbSet<SociOasisEntity> SociOasisEntity { get; set; }
        public virtual DbSet<SociOasisEntityOth> SociOasisEntityOth { get; set; }
        public virtual DbSet<SociSabsence> SociSabsence { get; set; }
        public virtual DbSet<SociSclass> SociSclass { get; set; }
        public virtual DbSet<SociSepChangedRegOffer> SociSepChangedRegOffer { get; set; }
        public virtual DbSet<SociSepChangedSg> SociSepChangedSg { get; set; }
        public virtual DbSet<SociSepChangedSgOffer> SociSepChangedSgOffer { get; set; }
        public virtual DbSet<SociSepChangedStaff> SociSepChangedStaff { get; set; }
        public virtual DbSet<SociSepChangedStudent> SociSepChangedStudent { get; set; }
        public virtual DbSet<SociSfamily> SociSfamily { get; set; }
        public virtual DbSet<SociSparent> SociSparent { get; set; }
        public virtual DbSet<SociSstaff> SociSstaff { get; set; }
        public virtual DbSet<SociStudentAll> SociStudentAll { get; set; }
        public virtual DbSet<StoredDocument> StoredDocument { get; set; }
        public virtual DbSet<StoredImage> StoredImage { get; set; }
        public virtual DbSet<StuDisabDataCollAnalysis> StuDisabDataCollAnalysis { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentContactCourtOrder> StudentContactCourtOrder { get; set; }
        public virtual DbSet<StudentDetailChangeLog> StudentDetailChangeLog { get; set; }
        public virtual DbSet<StudentDisabilityType> StudentDisabilityType { get; set; }
        public virtual DbSet<StudentDoctor> StudentDoctor { get; set; }
        public virtual DbSet<StudentDoctorContact> StudentDoctorContact { get; set; }
        public virtual DbSet<StudentDossier> StudentDossier { get; set; }
        public virtual DbSet<StudentEmergencyContact> StudentEmergencyContact { get; set; }
        public virtual DbSet<StudentEvidence> StudentEvidence { get; set; }
        public virtual DbSet<StudentFamilyChangeLog> StudentFamilyChangeLog { get; set; }
        public virtual DbSet<StudentGroup> StudentGroup { get; set; }
        public virtual DbSet<StudentGroupBak081018> StudentGroupBak081018 { get; set; }
        public virtual DbSet<StudentGroupOffer> StudentGroupOffer { get; set; }
        public virtual DbSet<StudentIdentity> StudentIdentity { get; set; }
        public virtual DbSet<StudentIecType> StudentIecType { get; set; }
        public virtual DbSet<StudentLanguage> StudentLanguage { get; set; }
        public virtual DbSet<StudentMedicalDocumentation> StudentMedicalDocumentation { get; set; }
        public virtual DbSet<StudentMedication> StudentMedication { get; set; }
        public virtual DbSet<StudentOutOfHomeCare> StudentOutOfHomeCare { get; set; }
        public virtual DbSet<StudentPickup> StudentPickup { get; set; }
        public virtual DbSet<StudentPlspFile> StudentPlspFile { get; set; }
        public virtual DbSet<StudentPscIntake> StudentPscIntake { get; set; }
        public virtual DbSet<StudentRegistration> StudentRegistration { get; set; }
        public virtual DbSet<StudentResidency> StudentResidency { get; set; }
        public virtual DbSet<StudentSuspension> StudentSuspension { get; set; }
        public virtual DbSet<StudentSuspensionOld> StudentSuspensionOld { get; set; }
        public virtual DbSet<StudentType> StudentType { get; set; }
        public virtual DbSet<SuspensionIncident> SuspensionIncident { get; set; }
        public virtual DbSet<SuspexReasonCode> SuspexReasonCode { get; set; }
        public virtual DbSet<TextComment> TextComment { get; set; }
        public virtual DbSet<TipOfTheDay> TipOfTheDay { get; set; }
        public virtual DbSet<TmpArDossier> TmpArDossier { get; set; }
        public virtual DbSet<TtIclass> TtIclass { get; set; }
        public virtual DbSet<TtIclteach> TtIclteach { get; set; }
        public virtual DbSet<TtIcom> TtIcom { get; set; }
        public virtual DbSet<TtIcomclas> TtIcomclas { get; set; }
        public virtual DbSet<TtSclass> TtSclass { get; set; }
        public virtual DbSet<TtSepControl> TtSepControl { get; set; }

        // Unable to generate entity type for table 'SEPDBA.ADDRESS_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AM_AUDIT_TEST'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.APP_CONFIG_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CONTACT_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DOSSIER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.EMERGENCY_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.EMERGENCY_CONTACT_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FAMILY_ADDRESS'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FAMILY_ADDRESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FAMILY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FAMILY_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FAMILY_EVIDENCE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.HARVEST_EVENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.HARVEST_EVENT_SCHOOL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.HARVEST_RESPONSE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.OASIS_SFAMILY_XREF_FAMILY'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.OASIS_SSTAFF_XREF_STAFF'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.OASIS_STUDENT_ALL_XREF_STUDENT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_ADDRESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_BKUP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_DOSSIER_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_DOSSIER_AUD_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_EVIDENCE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_LANGUAGE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_RELATIONSHIP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PLACE_TYPE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_OFFER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REQUIRED_STUDENT_DOSSIER_T_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SGOE_TYPE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SG_SCHOLASTIC_YEARS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SG_STAFF_PARTICIPATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STAFF'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STAFF_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_DOCTOR_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_DOCTOR_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_DOSSIER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_EVIDENCE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_GROUP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_GROUP_OFFER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_IMMUNISATION'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_IMMUNISATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_LANGUAGE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_RESIDENCY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_AUD_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_TYPE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SUSPEX_REASON_CODE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEXT_COMMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.INTERNAL_TFR_MOD_BACKUP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_BACKUP_FXLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_BACKUP_DBO'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_BACKUP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_MAX_LEAVING_DATES'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_RESIDENCY_REGN_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_REGISTRATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_INTAKE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_LEAVING_REAS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCAS_XFER_MATCHES'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DC_MYC_BOS_YR1112'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.EMERGENCY_CONTACT_BK'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.EMERGENCY_CONTACT_AUD_BK'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_EMERGENCY_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FAMILY_COR_ADDRESS_BACKUP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FIX_REGISTRATION_INTAKE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_FIX_FEEDERS'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_FIX_SGDUPES'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_AUS_ENROLDATE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGN_SCHOOL_SUPPORT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGN_SPECIAL_NEED_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FACTOR_OF_NEED_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_GROUP_BK_270308'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.BAD_ICOURSE_ENTRIES'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.BAD_ICOURSE_ENTRIES2'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_ICLASS_18112008'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_ICOM_18112008'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_ICOMCLAS_18112008'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_ICLTEACH_18112008'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_ICOURSE_18112008'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_SCLASS_18112008'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_CENSUS_SCS_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_NONCENSUS_SCS_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_REG_FUTURES_SCS_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_COLLEGES_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_ENROL_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_INTAKE_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.KZ_CPHS_SGO'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SOCI_SEP_CHANGED_SG_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_LAPSED'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FON_TEMP_TABLE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_OFFER_TEMP_FON'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCAS_ENROLMENTS_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_FON'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.MATCHING_FUNDSUPPSTU_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_REGISTRATION_FON'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCAS_ORG_FACTOR_OF_NEED'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCAS_ORG_FACTOR_OF_NEED_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCAS_ORG_FACTOR_OF_NEED_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SCHOOL_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SCHOOL_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DISABILITY_CONFIRM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DISABILITY_ITEM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ACCESS_FACILITY_ITEM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SPECIAL_EQUIPMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.ADDRESS_DETAIL_TMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_NSSC_UNIT_RECORD_DATA'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_DUPLICATE_ORG'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_DUPLICATE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_DUPLICATE_RPT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ESL_ITEM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PROG_ATT_PLAN_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_EI_ACCESS_DOMAIN_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ESL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ESL_SIGN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_KINDI_ACCESS_DOMAIN_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_LEARNING_ASSIST_PROGRAM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_EI_SIGN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_KINDI_SIGN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_EI_PRO_SUM_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_KINDI_PRO_SUM_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SCH_PRO_SUM_SIGN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SCHOOL_ACCESS_DOMAIN_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_NATIONAL_ASSESS_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_STANDARD_ASS_CAT_RESULT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_NAPLAN_SW'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SUP_DOC_DETAIL_SIGN_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DISABILITY_PROGRAM_ITEM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SUP_DISABILITY_PROGRAM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_NATURE_OF_HEARING_LOSS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DIS_COMMUNICATION_MODE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_HEARING_SUPPORT_SKILL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_VISION_SUPPORT_SKILL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_HEARING_LOSS_LEVEL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DISABILITY_PROGRAM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_RISK_PLAN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_MOBILITY_PROGRAM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ROLE_ASSIGNMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_MH_ED_BD_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SUP_DOC_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_VISION_ACCESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_AUTISM_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_VISION_LEVEL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_VISION_AID_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ATTACHMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_NATIONAL_ASSESSMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_RISK_MANAGEMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_STANDARD_ASSESSMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_CLASSROOM_ASSESSMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_TRAVEL_SUPPORT_NEED_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ACCESS_FACILITY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SIGN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PICKUP_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_PICKUP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGN_EVIDENCE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DAT_ORG_COUNT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DAT_ORG_COUNT_RPT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DAT_ORG_COUNT_TMP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_CENSUS_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_NONCENSUS_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_REG_FUTURES_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_LEAVING_REASON'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_HEARING_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PRINCIPAL_SIGN_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_HEARING_ASSESSMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_HEARING_AID_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_VISION_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SUPPORT_DOCUMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DISABILITY_SKILL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_KINDI_PROFILE_SUMMARY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ACCESS_REQUEST_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_AR_DOSSIER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_EI_PROFILE_SUMMARY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_KLA_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SCHOOL_PROFILE_SUMMARY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REG_SUPPORT_STRATEGY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_SUBMITTING_PARENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_NON_DET_SUPPORT_ACCESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DET_SUPPORT_ACCESS_ITEM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DET_SUPPORT_ACCESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_NON_DET_ITEM_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_FUT_ENR_NON_CENSUS'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ATTACHMENT_VERIFICATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_YING'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_REG_FUTURES_YING'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STU_LL'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SGO_TT_FIX'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_NAPLAN'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_NAPLAN'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_CONTACTS'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_ADDRESSES'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_F_CONTACTS_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SFC_DUP_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_P_CONTACTS_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SPC_DUP_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_ADDRESSES_F_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_ADDRESSES_P_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_NAPLAN_4S'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEST_ENROLLED_SCAS'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_MBH_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_REG_FUTURES_MBH_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_STATUS_CHANGE_COMMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_ACCOUNT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_ACCOUNT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_SR_LEAVERDEST_DEFN'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_STUDENT_DOSSIER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SUBMITTED_AR'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CONTACT_DETAIL_VALIDATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CONTACT_DETAIL_VALIDATION'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PARENT_DOSSIER'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.COLLEGE_TRANSITION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SUSPENSION_INCIDENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CHANGE_LOG_CATEGORY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.OASR_SYNCHRONIZATION'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.OASR_SYNCHRONIZATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_AUD_TEMP_1'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_AUD_TEMP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_TEMP_1'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_OLD_2011'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_AUD_OLD2011'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_SUSPENSION_TEMP_2011'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_AUD_TEMP_2011'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_FIX_DUBBO1_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_REG_FUTURES_DUBBO1_RT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_DUPLICATE_PARENT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_DUPLICATE_PARENT_RECORD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_ORG_UNIT_NO'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SCHOOL_DUPLICATE_PARENT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SCHOOL_DATA'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_ORG_UNIT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_PARENT_RECORD_NO_1'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STORED_DOCUMENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STORED_IMAGE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TIP_OF_THE_DAY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_REPORT_FILE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_REPORT_FILE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ATTACHMENT_FILE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_F_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_F_CONTACTS_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SFC_DUP_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_P_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_P_CONTACTS_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SPC_DUP_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SAF_DUP_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_ERN_FAMILY_DETAILS'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_NAPLAN_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_STUDENT_ADDRESSES_F_ALLSCH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_ORPHAN_ADDRESS_DETAIL'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_PLSP'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_PLSP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_PLSP_FILE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.FILE_REPOSITORY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCHOOL_MEDICATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SALM_SEP_CROSS_REFERENCE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCHOOL_MEDICAL_STOCK_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SCHOOL_STAFF_NOTIFICATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_MEDICAL_DOC_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SALM_MIGRATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_CONTACT_COR_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.COURT_ORDER_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DOCTOR_MEDICAL_CONDITION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.MEDICAL_DOCUMENTATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_MEDICAL_CONDITION'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_MEDICAL_CONDITION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_MEDICATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DOSSIER_COR_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEXT_COMMENT_COR_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DOSSIER_MED_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.DOSSIER_MED_AUD_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEXT_COMMENT_MED_AUD_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEXT_COMMENT_MED_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_DOSSIER_OLD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_DOSSIER_OLD_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_LOAD_MED2'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_LOAD_MED3'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_DISABILITY_TYPE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STU_DISAB_DATA_COLL_ANAL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TEMP_LOAD_MED1'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.PLAN_TABLE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TOAD_PLAN_TABLE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_OUT_OF_HOME_CARE_TYPE'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_PSC_INTAKE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_OOHC_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SG_REFRESH_REQUEST_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SG_REFRESH_GROUP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_PSC_INTAKE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.REGISTRATION_INTAKE_1013_BCK'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_IEC_TYPE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SALM_SEP_CROSS_REF_DELETE_JH'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_TRANSFER_HISTORY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_CLEARING_HOUSE_COORD_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_CLEARING_HOUSE_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_CLEARING_HOUSE_OWNER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PRIORITY_STATUS_CHG_HIS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_PANEL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_PANEL_OWNER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_PANEL_CONV_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PRIORITY_PLACEMENT_PNL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_PANEL_MEMBER_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_PANEL_OUTCOME_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.STUDENT_IDENTITY_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DESU_DETAIL'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_DESU_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEP_CHANGED_SG_OFFER'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_OLD_NEW_PN_MAPPING'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_CLEARING_HOUSE_BP_19032018'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_CLEARING_H_O_BP_19032018'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_PANEL_BP_19032018'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_PLACEMENT_P_O_BP_19032018'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.AR_ACCESS_REQUEST_BP_200318'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_SMART_HIERARCHIES'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.ORG_UNIT_HIER_TEST'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CK_APP_CONFIG'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CK_APP_CONFIG_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.CHAK_ADDRESS_DETAIL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TABLE1'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TESTKAFKA'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_STUDENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_REGISTRATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_PARENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_PARENT_RELATIONSHIP_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_EMERGENCY_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_DOCTOR_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_STUDENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_REGISTRATION_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_STUCONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_STUCONREL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_EMERCONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_EMERCONREL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_DOCTOR_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_ENTITY_DOC_REL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_SCHOOL_SYNC_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_CHANGED_STUDENT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SAITEST'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_STUDENT_EMER_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_FAMILY_ADDRESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_FAMILY_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_PARENT_ADDRESS_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_PARENT_CONTACT_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_SIBLING_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SEPSD_EMERGENCY_CONT_DTL_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SRD_NEW_HIERARCHY'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.QUEST_SL_TEMP_EXPLAIN1'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.ERN_REPLAY_MSG_GTT'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SALM_ESB_MESSAGES_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.ESB_MESSAGES_AUD'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.SALM_ESB_MESSAGES_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'SEPDBA.TMP_TRACKING_ID'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("DATA SOURCE=du0992vmwd0015.dbs.dev.det.nsw.edu.au:1521/platod.dev.det.nsw.edu.au;PERSIST SECURITY INFO=True;USER ID=SEPDBA;Password=password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:DefaultSchema", "SEPDBA");

            modelBuilder.Entity<AddressDetail>(entity =>
            {
                entity.HasKey(e => e.AddressDetailRecordNo);

                entity.ToTable("ADDRESS_DETAIL");

                entity.HasIndex(e => e.AddressDetailRecordNo)
                    .HasName("PK_ADDRESS_DETAIL")
                    .IsUnique();

                entity.Property(e => e.AddressDetailRecordNo)
                    .HasColumnName("ADDRESS_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasColumnName("ADDRESS_LINE1")
                    .HasColumnType("VARCHAR2(264)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("ADDRESS_LINE2")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCodeRecordNo)
                    .HasColumnName("COUNTRY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HouseholdLevelLat)
                    .HasColumnName("HOUSEHOLD_LEVEL_LAT")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HouseholdLevelLong)
                    .HasColumnName("HOUSEHOLD_LEVEL_LONG")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuburbCodeRecordNo)
                    .HasColumnName("SUBURB_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ValidatedInd)
                    .IsRequired()
                    .HasColumnName("VALIDATED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");
            });

            modelBuilder.Entity<AppConfig>(entity =>
            {
                entity.HasKey(e => new { e.Hostname, e.ConfigName })
                    .HasName("APP_CONFOG_PKEY");

                entity.ToTable("APP_CONFIG");

                entity.HasIndex(e => new { e.Hostname, e.ConfigName })
                    .HasName("APP_CONFOG_PKEY")
                    .IsUnique();

                entity.Property(e => e.Hostname)
                    .HasColumnName("HOSTNAME")
                    .HasColumnType("VARCHAR2(255)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigName)
                    .HasColumnName("CONFIG_NAME")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigValue)
                    .HasColumnName("CONFIG_VALUE")
                    .HasColumnType("VARCHAR2(3500)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAccessFacility>(entity =>
            {
                entity.HasKey(e => e.ArAccessFacRecordNo);

                entity.ToTable("AR_ACCESS_FACILITY");

                entity.HasIndex(e => e.ArAccessFacRecordNo)
                    .HasName("PK_AR_ACCESS_FACILITY")
                    .IsUnique();

                entity.Property(e => e.ArAccessFacRecordNo)
                    .HasColumnName("AR_ACCESS_FAC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentRecordNo)
                    .HasColumnName("COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.WheelchairIndependInd)
                    .HasColumnName("WHEELCHAIR_INDEPEND_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.WheelchairTypeInd)
                    .HasColumnName("WHEELCHAIR_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAccessFacilityItem>(entity =>
            {
                entity.HasKey(e => e.ArAccessFacItemRecordNo);

                entity.ToTable("AR_ACCESS_FACILITY_ITEM");

                entity.HasIndex(e => e.ArAccessFacItemRecordNo)
                    .HasName("PK_AR_ACCESS_FACILITY_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.ArAccessFacRecordNo)
                    .HasName("AR_ACCESS_FACILITY_ITEM_IDX1");

                entity.Property(e => e.ArAccessFacItemRecordNo)
                    .HasColumnName("AR_ACCESS_FAC_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessFacilityRecordNo)
                    .HasColumnName("ACCESS_FACILITY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessFacRecordNo)
                    .HasColumnName("AR_ACCESS_FAC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAccessRequest>(entity =>
            {
                entity.HasKey(e => e.ArAccessRequestRecordNo);

                entity.ToTable("AR_ACCESS_REQUEST");

                entity.HasIndex(e => e.ArAccessFacRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX4");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("PK_AR_ACCESS_REQUEST")
                    .IsUnique();

                entity.HasIndex(e => e.ArDisConfirmRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX3");

                entity.HasIndex(e => e.ArDisProgRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX9");

                entity.HasIndex(e => e.ArEslRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX7");

                entity.HasIndex(e => e.ArOwnerOrgUnitRecordNo)
                    .HasName("AR_ACCESS_REQUEST_I10")
                    .HasFilter("EXTRACT(YEAR FROM \"SUBMISSION_DATE\")");

                entity.HasIndex(e => e.ArRiskManageRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX6");

                entity.HasIndex(e => e.ArSchoolDetailRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX2");

                entity.HasIndex(e => e.ArSpecialEquipRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX5");

                entity.HasIndex(e => e.ArStatusRecordNo)
                    .HasName("IDX_AR_STATUS");

                entity.HasIndex(e => e.ArSupDocumentRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX8");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("SK1_AR_ACCESS_REQUEST");

                entity.HasIndex(e => e.StatusLastUpdatedDate)
                    .HasName("IDX_AR_STAT_UP_DATE");

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("AR_ACCESS_REQUEST_IDX1");

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessFacRecordNo)
                    .HasColumnName("AR_ACCESS_FAC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDisConfirmRecordNo)
                    .HasColumnName("AR_DIS_CONFIRM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDisProgRecordNo)
                    .HasColumnName("AR_DIS_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEslRecordNo)
                    .HasColumnName("AR_ESL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArFirstSubmissionDate)
                    .HasColumnName("AR_FIRST_SUBMISSION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArOwnerOrgUnitRecordNo)
                    .HasColumnName("AR_OWNER_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArRaisedByInd)
                    .HasColumnName("AR_RAISED_BY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArReportFileRecordNo)
                    .HasColumnName("AR_REPORT_FILE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArReportStatusInd)
                    .HasColumnName("AR_REPORT_STATUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ArRiskManageRecordNo)
                    .HasColumnName("AR_RISK_MANAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSchoolDetailRecordNo)
                    .HasColumnName("AR_SCHOOL_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSetupLastUpdatedDate)
                    .HasColumnName("AR_SETUP_LAST_UPDATED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSetupVerificationInd)
                    .HasColumnName("AR_SETUP_VERIFICATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSpecialEquipRecordNo)
                    .HasColumnName("AR_SPECIAL_EQUIP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArStatusRecordNo)
                    .HasColumnName("AR_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArStatusTranRecordNo)
                    .HasColumnName("AR_STATUS_TRAN_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocumentRecordNo)
                    .HasColumnName("AR_SUP_DOCUMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArpUploadCommentRecordNo)
                    .HasColumnName("ARP_UPLOAD_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedByUsername)
                    .IsRequired()
                    .HasColumnName("CREATED_BY_USERNAME")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocReferenceNo)
                    .HasColumnName("DOC_REFERENCE_NO")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.IfsSupportedReviewedInd)
                    .HasColumnName("IFS_SUPPORTED_REVIEWED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'  ");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProvisionRequiredTimeInd)
                    .HasColumnName("PROVISION_REQUIRED_TIME_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReturnedToAddAttachmentInd)
                    .HasColumnName("RETURNED_TO_ADD_ATTACHMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql(@"'N'
	");

                entity.Property(e => e.ReturnedToSchoolCounter)
                    .HasColumnName("RETURNED_TO_SCHOOL_COUNTER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql(@"0
	");

                entity.Property(e => e.ReviewedDate)
                    .HasColumnName("REVIEWED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReviewedInd)
                    .HasColumnName("REVIEWED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql(@"'N'
	");

                entity.Property(e => e.ScasRegistrationCounter)
                    .HasColumnName("SCAS_REGISTRATION_COUNTER")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql(@"0
");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusLastUpdatedDate)
                    .HasColumnName("STATUS_LAST_UPDATED_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SubmissionDate)
                    .HasColumnName("SUBMISSION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrimNo)
                    .HasColumnName("TRIM_NO")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerificationCommentRecordNo)
                    .HasColumnName("VERIFICATION_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAttachment>(entity =>
            {
                entity.HasKey(e => e.ArAttachmentRecordNo);

                entity.ToTable("AR_ATTACHMENT");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("SK1_AR_ATTACHMENT");

                entity.HasIndex(e => e.ArAttachmentRecordNo)
                    .HasName("PK_AR_ATTACHMENT")
                    .IsUnique();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModifiedByDetUserId)
                    .HasColumnName("LAST_MODIFIED_BY_DET_USER_ID")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModifiedDate)
                    .HasColumnName("LAST_MODIFIED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportTypeRecordNo)
                    .HasColumnName("SUPPORT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerifiedByPrincipalInd)
                    .HasColumnName("VERIFIED_BY_PRINCIPAL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAttachmentFile>(entity =>
            {
                entity.HasKey(e => e.ArAttachmentFileRecordNo)
                    .HasName("AR_ATTACHMENT_FILE_PK");

                entity.ToTable("AR_ATTACHMENT_FILE");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("AR_ATTACHMENT_FILE_IDX1");

                entity.HasIndex(e => e.ArAttachmentFileRecordNo)
                    .HasName("AR_ATTACHMENT_FILE_PK")
                    .IsUnique();

                entity.Property(e => e.ArAttachmentFileRecordNo)
                    .HasColumnName("AR_ATTACHMENT_FILE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddedByUsername)
                    .IsRequired()
                    .HasColumnName("ADDED_BY_USERNAME")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttachmentSectionInd)
                    .IsRequired()
                    .HasColumnName("ATTACHMENT_SECTION_IND")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileContent)
                    .HasColumnName("FILE_CONTENT")
                    .HasColumnType("BLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileNm)
                    .HasColumnName("FILE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportTypeRecordNo)
                    .HasColumnName("SUPPORT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAttachmentVerification>(entity =>
            {
                entity.HasKey(e => e.ArAttachVerifRecordNo);

                entity.ToTable("AR_ATTACHMENT_VERIFICATION");

                entity.HasIndex(e => e.ArAttachVerifRecordNo)
                    .HasName("PK_AR_ATTACHMENT_VERIFICATION")
                    .IsUnique();

                entity.HasIndex(e => e.ArAttachmentRecordNo)
                    .HasName("SK1_AR_ATTACHMENT_VERIF");

                entity.Property(e => e.ArAttachVerifRecordNo)
                    .HasColumnName("AR_ATTACH_VERIF_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityRoleRecordNo)
                    .HasColumnName("DISABILITY_ROLE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RejectedByPrincipalInd)
                    .HasColumnName("REJECTED_BY_PRINCIPAL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportTypeDisRoleSeqNo)
                    .HasColumnName("SUPPORT_TYPE_DIS_ROLE_SEQ_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerificationCommentRecordNo)
                    .HasColumnName("VERIFICATION_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArAutismDetail>(entity =>
            {
                entity.HasKey(e => e.ArAutismDetailRecordNo);

                entity.ToTable("AR_AUTISM_DETAIL");

                entity.HasIndex(e => e.ArAutismDetailRecordNo)
                    .HasName("PK_AR_AUTISM_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArAutismDetailRecordNo)
                    .HasColumnName("AR_AUTISM_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArRiskPlanDetailRecordNo)
                    .HasColumnName("AR_RISK_PLAN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommuniCommentRecordNo)
                    .HasColumnName("COMMUNI_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrevInterCommentRecordNo)
                    .HasColumnName("PREV_INTER_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SafetyCommentRecordNo)
                    .HasColumnName("SAFETY_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SensoryCommentRecordNo)
                    .HasColumnName("SENSORY_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SocialCompCommentRecordNo)
                    .HasColumnName("SOCIAL_COMP_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArClassroomAssessment>(entity =>
            {
                entity.HasKey(e => e.ArClassroomAssessRecordNo);

                entity.ToTable("AR_CLASSROOM_ASSESSMENT");

                entity.HasIndex(e => e.ArClassroomAssessRecordNo)
                    .HasName("PK_AR_CLASSROOM_ASSESSMENT")
                    .IsUnique();

                entity.HasIndex(e => e.ArLearnAssistProgRecordNo)
                    .HasName("SK1_AR_CLASSROOM_ASSESSMENT");

                entity.Property(e => e.ArClassroomAssessRecordNo)
                    .HasColumnName("AR_CLASSROOM_ASSESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArLearnAssistProgRecordNo)
                    .HasColumnName("AR_LEARN_ASSIST_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentItemRecordNo)
                    .HasColumnName("ASSESSMENT_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassrmAssCommentRecordNo)
                    .HasColumnName("CLASSRM_ASS_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArClearingHouse>(entity =>
            {
                entity.HasKey(e => e.ArChRecordNo);

                entity.ToTable("AR_CLEARING_HOUSE");

                entity.HasIndex(e => e.ArChRecordNo)
                    .HasName("PK_AR_CLEARING_HOUSE")
                    .IsUnique();

                entity.HasIndex(e => e.ChStatusRecordNo)
                    .HasName("AR_CLEARING_HOUSE_I1");

                entity.Property(e => e.ArChRecordNo)
                    .HasColumnName("AR_CH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChAbbrevNm)
                    .IsRequired()
                    .HasColumnName("CH_ABBREV_NM")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChNm)
                    .IsRequired()
                    .HasColumnName("CH_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChStatusRecordNo)
                    .HasColumnName("CH_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArClearingHouseCoord>(entity =>
            {
                entity.HasKey(e => e.ArChCoordinatorRecordNo);

                entity.ToTable("AR_CLEARING_HOUSE_COORD");

                entity.HasIndex(e => e.ArChCoordinatorRecordNo)
                    .HasName("PK_AR_CLEARING_HOUSE_COORD")
                    .IsUnique();

                entity.HasIndex(e => e.ArChRecordNo)
                    .HasName("AR_CLEARING_HOUSE_COORD_I1");

                entity.Property(e => e.ArChCoordinatorRecordNo)
                    .HasColumnName("AR_CH_COORDINATOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArChRecordNo)
                    .HasColumnName("AR_CH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .IsRequired()
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArClearingHouseOwner>(entity =>
            {
                entity.HasKey(e => e.ArChOwnerRecordNo);

                entity.ToTable("AR_CLEARING_HOUSE_OWNER");

                entity.HasIndex(e => e.ArChOwnerRecordNo)
                    .HasName("PK_AR_CLEARING_HOUSE_OWNER")
                    .IsUnique();

                entity.HasIndex(e => e.ArChRecordNo)
                    .HasName("AR_CLEARING_HOUSE_OWNER_I1");

                entity.HasIndex(e => e.OwnerOrgUnitRecordNo)
                    .HasName("AR_CLEARING_HOUSE_OWNER_I2");

                entity.Property(e => e.ArChOwnerRecordNo)
                    .HasColumnName("AR_CH_OWNER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArChRecordNo)
                    .HasColumnName("AR_CH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OwnerOrgUnitRecordNo)
                    .HasColumnName("OWNER_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDetSupportAccess>(entity =>
            {
                entity.HasKey(e => e.ArDetSuppAccRecordNo);

                entity.ToTable("AR_DET_SUPPORT_ACCESS");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("AR_DET_SUPPORT_ACCESS_IDX1");

                entity.HasIndex(e => e.ArDetSuppAccRecordNo)
                    .HasName("PK_AR_DET_SUPPORT_ACCESS")
                    .IsUnique();

                entity.Property(e => e.ArDetSuppAccRecordNo)
                    .HasColumnName("AR_DET_SUPP_ACC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDetSupportAccessItem>(entity =>
            {
                entity.HasKey(e => e.ArDetSuppAccItemRecordNo);

                entity.ToTable("AR_DET_SUPPORT_ACCESS_ITEM");

                entity.HasIndex(e => e.ArDetSuppAccItemRecordNo)
                    .HasName("PK_AR_DET_SUPPORT_ACCESS_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.ArDetSuppAccRecordNo)
                    .HasName("AR_DET_SUP_ACCESS_ITEM_IDX1");

                entity.Property(e => e.ArDetSuppAccItemRecordNo)
                    .HasColumnName("AR_DET_SUPP_ACC_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDetSuppAccRecordNo)
                    .HasColumnName("AR_DET_SUPP_ACC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDetSuppComment)
                    .HasColumnName("AR_DET_SUPP_COMMENT")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentRecordNo)
                    .HasColumnName("COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelOfImportanceRecordNo)
                    .HasColumnName("LEVEL_OF_IMPORTANCE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SupportAccessInd)
                    .HasColumnName("SUPPORT_ACCESS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportServiceRecordNo)
                    .HasColumnName("SUPPORT_SERVICE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDisCommunicationMode>(entity =>
            {
                entity.HasKey(e => e.ArDisCommModeRecordNo);

                entity.ToTable("AR_DIS_COMMUNICATION_MODE");

                entity.HasIndex(e => e.ArDisCommModeRecordNo)
                    .HasName("PK_AR_DIS_COMMUNICATION_MODE")
                    .IsUnique();

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("AR_DIS_COMMUNICATION_MODE_IDX1");

                entity.Property(e => e.ArDisCommModeRecordNo)
                    .HasColumnName("AR_DIS_COMM_MODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityCommModeRecordNo)
                    .HasColumnName("DISABILITY_COMM_MODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDisabilityConfirm>(entity =>
            {
                entity.HasKey(e => e.ArDisConfirmRecordNo);

                entity.ToTable("AR_DISABILITY_CONFIRM");

                entity.HasIndex(e => e.ArDisConfirmRecordNo)
                    .HasName("PK_AR_DISABILITY_CONFIRM")
                    .IsUnique();

                entity.Property(e => e.ArDisConfirmRecordNo)
                    .HasColumnName("AR_DIS_CONFIRM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConsultationInd)
                    .HasColumnName("CONSULTATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityConfirmInd)
                    .HasColumnName("DISABILITY_CONFIRM_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpecialConsiderInd)
                    .HasColumnName("SPECIAL_CONSIDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDisabilityItem>(entity =>
            {
                entity.HasKey(e => e.ArDisabilityItemRecordNo);

                entity.ToTable("AR_DISABILITY_ITEM");

                entity.HasIndex(e => e.ArDisConfirmRecordNo)
                    .HasName("AR_DISABILITY_ITEM_IDX1");

                entity.HasIndex(e => e.ArDisabilityItemRecordNo)
                    .HasName("PK_AR_DISABILITY_ITEM")
                    .IsUnique();

                entity.Property(e => e.ArDisabilityItemRecordNo)
                    .HasColumnName("AR_DISABILITY_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDisConfirmRecordNo)
                    .HasColumnName("AR_DIS_CONFIRM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityItemInd)
                    .HasColumnName("DISABILITY_ITEM_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityItemRecordNo)
                    .HasColumnName("DISABILITY_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDisabilityProgram>(entity =>
            {
                entity.HasKey(e => e.ArDisProgRecordNo);

                entity.ToTable("AR_DISABILITY_PROGRAM");

                entity.HasIndex(e => e.ArDisProgRecordNo)
                    .HasName("PK_AR_DISABILITY_PROGRAM")
                    .IsUnique();

                entity.Property(e => e.ArDisProgRecordNo)
                    .HasColumnName("AR_DIS_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentRecordNo)
                    .HasColumnName("COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDisabilityProgramItem>(entity =>
            {
                entity.HasKey(e => e.ArDisProgItemRecordNo);

                entity.ToTable("AR_DISABILITY_PROGRAM_ITEM");

                entity.HasIndex(e => e.ArChRecordNo)
                    .HasName("AR_DISABILITY_PROGRAM_ITEM_I2");

                entity.HasIndex(e => e.ArDisProgItemRecordNo)
                    .HasName("PK_AR_DISABILITY_PROGRAM_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.ArDisProgRecordNo)
                    .HasName("AR_DISABILITY_PROG_ITEM_IDX1");

                entity.Property(e => e.ArDisProgItemRecordNo)
                    .HasColumnName("AR_DIS_PROG_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArChRecordNo)
                    .HasColumnName("AR_CH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDisProgRecordNo)
                    .HasColumnName("AR_DIS_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityProgItemRecordNo)
                    .HasColumnName("DISABILITY_PROG_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityProgramRecordNo)
                    .HasColumnName("DISABILITY_PROGRAM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OperatorInd)
                    .HasColumnName("OPERATOR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OperatorindChanged)
                    .HasColumnName("OPERATORIND_CHANGED")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PriorityStatusRecordNo)
                    .HasColumnName("PRIORITY_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("REGISTRATION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationFlag)
                    .HasColumnName("REGISTRATION_FLAG")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArDisabilitySkill>(entity =>
            {
                entity.HasKey(e => e.ArDisabilitySkillRecordNo)
                    .HasName("AR_DISABILITY_SKILL_PK");

                entity.ToTable("AR_DISABILITY_SKILL");

                entity.HasIndex(e => e.ArDisabilitySkillRecordNo)
                    .HasName("PK_AR_DISABILITY_SKILL_REC")
                    .IsUnique();

                entity.HasIndex(e => e.ArEiProfSummRecordNo)
                    .HasName("AR_DISABILITY_SKILL_IDX1");

                entity.HasIndex(e => e.ArKindiProfSummRecordNo)
                    .HasName("AR_DISABILITY_SKILL_IDX2");

                entity.Property(e => e.ArDisabilitySkillRecordNo)
                    .HasColumnName("AR_DISABILITY_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEiProfSummRecordNo)
                    .HasColumnName("AR_EI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArKindiProfSummRecordNo)
                    .HasColumnName("AR_KINDI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityOutcomeRecordNo)
                    .HasColumnName("DISABILITY_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilitySkillRecordNo)
                    .HasColumnName("DISABILITY_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkillCommentRecordNo)
                    .HasColumnName("SKILL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEiAccessDomain>(entity =>
            {
                entity.HasKey(e => e.ArEiAccDomRecordNo)
                    .HasName("AR_EI_ACCESS_DOMAIN_PK");

                entity.ToTable("AR_EI_ACCESS_DOMAIN");

                entity.HasIndex(e => e.ArEiAccDomRecordNo)
                    .HasName("PK_AR_EI_ACCESS_DOMAIN_REC")
                    .IsUnique();

                entity.HasIndex(e => e.ArEiProfSummRecordNo)
                    .HasName("AR_EI_ACCESS_DOMAIN_IDX1");

                entity.Property(e => e.ArEiAccDomRecordNo)
                    .HasColumnName("AR_EI_ACC_DOM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArCurriculumRecordNo)
                    .HasColumnName("AR_CURRICULUM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEiProfSummRecordNo)
                    .HasColumnName("AR_EI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentTextRecordNo)
                    .HasColumnName("COMMENT_TEXT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEiProSumContact>(entity =>
            {
                entity.HasKey(e => e.ArEiPsContactRecordNo)
                    .HasName("AR_EI_PRO_SUM_CONTACT_PK");

                entity.ToTable("AR_EI_PRO_SUM_CONTACT");

                entity.HasIndex(e => e.ArEiProfSummRecordNo)
                    .HasName("AR_EI_PRO_SUM_CONTACT_IDX1");

                entity.HasIndex(e => e.ArEiPsContactRecordNo)
                    .HasName("PK_AR_EI_PRO_SUM_CONTACT_REC")
                    .IsUnique();

                entity.Property(e => e.ArEiPsContactRecordNo)
                    .HasColumnName("AR_EI_PS_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEiProfSummRecordNo)
                    .HasColumnName("AR_EI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEiProfileSummary>(entity =>
            {
                entity.HasKey(e => e.ArEiProfSummRecordNo)
                    .HasName("AR_EI_PROFILE_SUMMARY_PK");

                entity.ToTable("AR_EI_PROFILE_SUMMARY");

                entity.HasIndex(e => e.ArEiProfSummRecordNo)
                    .HasName("PK_EI_PROFILE_SUMMARY_REC")
                    .IsUnique();

                entity.Property(e => e.ArEiProfSummRecordNo)
                    .HasColumnName("AR_EI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentSettings)
                    .HasColumnName("CURRENT_SETTINGS")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SignNm)
                    .HasColumnName("SIGN_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SignPosition)
                    .HasColumnName("SIGN_POSITION")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEiSignDetail>(entity =>
            {
                entity.HasKey(e => e.ArEiSignDetailRecordNo)
                    .HasName("AR_EI_SIGN_DETAIL_PK");

                entity.ToTable("AR_EI_SIGN_DETAIL");

                entity.HasIndex(e => e.ArEiProfSummRecordNo)
                    .HasName("AR_EI_SIGN_DETAIL_IDX1");

                entity.HasIndex(e => e.ArEiSignDetailRecordNo)
                    .HasName("PK_AR_EI_SIGN_DETAIL_REC")
                    .IsUnique();

                entity.Property(e => e.ArEiSignDetailRecordNo)
                    .HasColumnName("AR_EI_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEiProfSummRecordNo)
                    .HasColumnName("AR_EI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEsl>(entity =>
            {
                entity.HasKey(e => e.ArEslRecordNo);

                entity.ToTable("AR_ESL");

                entity.HasIndex(e => e.ArEslRecordNo)
                    .HasName("PK_AR_ESL")
                    .IsUnique();

                entity.Property(e => e.ArEslRecordNo)
                    .HasColumnName("AR_ESL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslAdjustCommentRecordNo)
                    .HasColumnName("ESL_ADJUST_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslFirstlanCommentRecordNo)
                    .HasColumnName("ESL_FIRSTLAN_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslIntpretCommentRecordNo)
                    .HasColumnName("ESL_INTPRET_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslIssueCommentRecordNo)
                    .HasColumnName("ESL_ISSUE_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslPerformCommentRecordNo)
                    .HasColumnName("ESL_PERFORM_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslRefugeeCommentRecordNo)
                    .HasColumnName("ESL_REFUGEE_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEslItem>(entity =>
            {
                entity.HasKey(e => e.ArEslItemRecordNo);

                entity.ToTable("AR_ESL_ITEM");

                entity.HasIndex(e => e.ArEslItemRecordNo)
                    .HasName("PK_AR_ESL_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.ArEslRecordNo)
                    .HasName("SK1_AR_ESL_ITEM");

                entity.Property(e => e.ArEslItemRecordNo)
                    .HasColumnName("AR_ESL_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEslRecordNo)
                    .HasColumnName("AR_ESL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslCommentRecordNo)
                    .HasColumnName("ESL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslLevelRecordNo)
                    .HasColumnName("ESL_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslPhaseRecordNo)
                    .HasColumnName("ESL_PHASE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.EslSkillRecordNo)
                    .HasColumnName("ESL_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArEslSignDetail>(entity =>
            {
                entity.HasKey(e => e.ArEslSignDetailRecordNo);

                entity.ToTable("AR_ESL_SIGN_DETAIL");

                entity.HasIndex(e => e.ArEslRecordNo)
                    .HasName("SK1_AR_ESL_SIGN_DETAIL");

                entity.HasIndex(e => e.ArEslSignDetailRecordNo)
                    .HasName("PK_AR_ESL_SIGN_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArEslSignDetailRecordNo)
                    .HasColumnName("AR_ESL_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEslRecordNo)
                    .HasColumnName("AR_ESL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArHearingAid>(entity =>
            {
                entity.HasKey(e => e.ArHearingAidRecordNo);

                entity.ToTable("AR_HEARING_AID");

                entity.HasIndex(e => e.ArHearingAidRecordNo)
                    .HasName("PK_AR_HEARING_AID")
                    .IsUnique();

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("AR_HEARING_AID_IDX1");

                entity.Property(e => e.ArHearingAidRecordNo)
                    .HasColumnName("AR_HEARING_AID_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisAssistAidRecordNo)
                    .HasColumnName("DIS_ASSIST_AID_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FittingAge)
                    .HasColumnName("FITTING_AGE")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArHearingAssessment>(entity =>
            {
                entity.HasKey(e => e.ArHearingAssessRecordNo);

                entity.ToTable("AR_HEARING_ASSESSMENT");

                entity.HasIndex(e => e.ArHearingAssessRecordNo)
                    .HasName("PK_AR_HEARING_ASSESSMENT")
                    .IsUnique();

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("AR_HEARING_ASSESSMENT_IDX1");

                entity.Property(e => e.ArHearingAssessRecordNo)
                    .HasColumnName("AR_HEARING_ASSESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentResult)
                    .HasColumnName("ASSESSMENT_RESULT")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GivenDate)
                    .HasColumnName("GIVEN_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.HearingAssessmentRecordNo)
                    .HasColumnName("HEARING_ASSESSMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HearingTestUsed)
                    .HasColumnName("HEARING_TEST_USED")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArHearingDetail>(entity =>
            {
                entity.HasKey(e => e.ArHearingDetailRecordNo);

                entity.ToTable("AR_HEARING_DETAIL");

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("PK_AR_HEARING_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssesserNm)
                    .HasColumnName("ASSESSER_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssesserPosition)
                    .HasColumnName("ASSESSER_POSITION")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentDate)
                    .HasColumnName("ASSESSMENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentIsthHour)
                    .HasColumnName("CURRENT_ISTH_HOUR")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentIsthMonitorInd)
                    .HasColumnName("CURRENT_ISTH_MONITOR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiagnosisDate)
                    .HasColumnName("DIAGNOSIS_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisAidCommentRecordNo)
                    .HasColumnName("DIS_AID_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HearLevelCommentRecordNo)
                    .HasColumnName("HEAR_LEVEL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HearLossCommentRecordNo)
                    .HasColumnName("HEAR_LOSS_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeftThreshold)
                    .HasColumnName("LEFT_THRESHOLD")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NatureOfHearingLossInd)
                    .HasColumnName("NATURE_OF_HEARING_LOSS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtitisMediaInd)
                    .HasColumnName("OTITIS_MEDIA_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecommendIsthHour)
                    .HasColumnName("RECOMMEND_ISTH_HOUR")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecommendIsthMonitorInd)
                    .HasColumnName("RECOMMEND_ISTH_MONITOR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RightThreshold)
                    .HasColumnName("RIGHT_THRESHOLD")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkillCommentRecordNo)
                    .HasColumnName("SKILL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArHearingLossLevel>(entity =>
            {
                entity.HasKey(e => e.ArHearLossLevelRecordNo);

                entity.ToTable("AR_HEARING_LOSS_LEVEL");

                entity.HasIndex(e => e.ArHearLossLevelRecordNo)
                    .HasName("PK_AR_HEARING_LOSS_LEVEL")
                    .IsUnique();

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("AR_HEARING_LOSS_LEVEL_IDX1");

                entity.Property(e => e.ArHearLossLevelRecordNo)
                    .HasColumnName("AR_HEAR_LOSS_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EarSideInd)
                    .HasColumnName("EAR_SIDE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HearingLevelValueRecordNo)
                    .HasColumnName("HEARING_LEVEL_VALUE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HearingLossLevelRecordNo)
                    .HasColumnName("HEARING_LOSS_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArHearingSupportSkill>(entity =>
            {
                entity.HasKey(e => e.ArHearSuppSkillRecordNo);

                entity.ToTable("AR_HEARING_SUPPORT_SKILL");

                entity.HasIndex(e => e.ArHearSuppSkillRecordNo)
                    .HasName("PK_AR_HEARING_SUPPORT_SKILL")
                    .IsUnique();

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("AR_HEARING_SUPPORT_SKILL_IDX1");

                entity.Property(e => e.ArHearSuppSkillRecordNo)
                    .HasColumnName("AR_HEAR_SUPP_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityOutcomeRecordNo)
                    .HasColumnName("DISABILITY_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportSkillRecordNo)
                    .HasColumnName("SUPPORT_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArKindiAccessDomain>(entity =>
            {
                entity.HasKey(e => e.ArKindiAccDomRecordNo)
                    .HasName("AR_KINDI_ACCESS_DOMAIN_PK");

                entity.ToTable("AR_KINDI_ACCESS_DOMAIN");

                entity.HasIndex(e => e.ArKindiAccDomRecordNo)
                    .HasName("PK_AR_KINDI_ACC_DOM_REC")
                    .IsUnique();

                entity.HasIndex(e => e.ArKindiProfSummRecordNo)
                    .HasName("AR_KINDI_ACCESS_DOMAIN_IDX1");

                entity.Property(e => e.ArKindiAccDomRecordNo)
                    .HasColumnName("AR_KINDI_ACC_DOM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArCurrReportsToRecordNo)
                    .HasColumnName("AR_CURR_REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ArCurriculumRecordNo)
                    .HasColumnName("AR_CURRICULUM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArKindiProfSummRecordNo)
                    .HasColumnName("AR_KINDI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentTextRecordNo)
                    .HasColumnName("COMMENT_TEXT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityLevelRecordNo)
                    .HasColumnName("DISABILITY_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NotApplicableInd)
                    .HasColumnName("NOT_APPLICABLE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArKindiProSumContact>(entity =>
            {
                entity.HasKey(e => e.ArKindiPsContactRecordNo)
                    .HasName("AR_KINDI_PRO_SUM_CONTACT_PK");

                entity.ToTable("AR_KINDI_PRO_SUM_CONTACT");

                entity.HasIndex(e => e.ArKindiProfSummRecordNo)
                    .HasName("AR_KINDI_PRO_SUM_CONTACT_IDX1");

                entity.HasIndex(e => e.ArKindiPsContactRecordNo)
                    .HasName("PK_AR_K_PS_CONTACT__REC")
                    .IsUnique();

                entity.Property(e => e.ArKindiPsContactRecordNo)
                    .HasColumnName("AR_KINDI_PS_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArKindiProfSummRecordNo)
                    .HasColumnName("AR_KINDI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArKindiProfileSummary>(entity =>
            {
                entity.HasKey(e => e.ArKindiProfSummRecordNo)
                    .HasName("AR_KINDI_PROFILE_SUMMARY_PK");

                entity.ToTable("AR_KINDI_PROFILE_SUMMARY");

                entity.HasIndex(e => e.ArKindiProfSummRecordNo)
                    .HasName("PK_AR_KINDI_PROF_SUM_REC")
                    .IsUnique();

                entity.Property(e => e.ArKindiProfSummRecordNo)
                    .HasColumnName("AR_KINDI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentSettings)
                    .HasColumnName("CURRENT_SETTINGS")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SignNm)
                    .HasColumnName("SIGN_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SignPosition)
                    .HasColumnName("SIGN_POSITION")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArKindiSignDetail>(entity =>
            {
                entity.HasKey(e => e.ArKindiSignDetailRecordNo)
                    .HasName("AR_KINDI_SIGN_DETAIL_PK");

                entity.ToTable("AR_KINDI_SIGN_DETAIL");

                entity.HasIndex(e => e.ArKindiProfSummRecordNo)
                    .HasName("AR_KINDI_SIGN_DETAIL_IDX1");

                entity.HasIndex(e => e.ArKindiSignDetailRecordNo)
                    .HasName("PK_AR_KINDI_SIGN_DETAIL_REC")
                    .IsUnique();

                entity.Property(e => e.ArKindiSignDetailRecordNo)
                    .HasColumnName("AR_KINDI_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArKindiProfSummRecordNo)
                    .HasColumnName("AR_KINDI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArKla>(entity =>
            {
                entity.HasKey(e => e.ArKlaRecordNo)
                    .HasName("AR_KLA_PK");

                entity.ToTable("AR_KLA");

                entity.HasIndex(e => e.ArKlaRecordNo)
                    .HasName("PK_AR_KLA_REC")
                    .IsUnique();

                entity.HasIndex(e => e.ArSchoolProfSummRecordNo)
                    .HasName("AR_KLA_IDX1");

                entity.Property(e => e.ArKlaRecordNo)
                    .HasColumnName("AR_KLA_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArKlaTypeInd)
                    .HasColumnName("AR_KLA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSchoolProfSummRecordNo)
                    .HasColumnName("AR_SCHOOL_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentRecordNo)
                    .HasColumnName("COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrReportsToRecordNo)
                    .HasColumnName("CURR_REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurriculumOfferRecordNo)
                    .HasColumnName("CURRICULUM_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurriculumRecordNo)
                    .HasColumnName("CURRICULUM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityOutcomeRecordNo)
                    .HasColumnName("DISABILITY_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityStageRecordNo)
                    .HasColumnName("DISABILITY_STAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenericCurriculumOfferNm)
                    .HasColumnName("GENERIC_CURRICULUM_OFFER_NM")
                    .HasColumnType("VARCHAR2(263)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PersonalLearnPlanInd)
                    .HasColumnName("PERSONAL_LEARN_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuppTypeInd)
                    .HasColumnName("SUPP_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArLearningAssistProgram>(entity =>
            {
                entity.HasKey(e => e.ArLearnAssistProgRecordNo);

                entity.ToTable("AR_LEARNING_ASSIST_PROGRAM");

                entity.HasIndex(e => e.ArLearnAssistProgRecordNo)
                    .HasName("PK_AR_LEARNING_ASSIST_PROGRAM")
                    .IsUnique();

                entity.Property(e => e.ArLearnAssistProgRecordNo)
                    .HasColumnName("AR_LEARN_ASSIST_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NationalAssCommentRecordNo)
                    .HasColumnName("NATIONAL_ASS_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrevInterCommentRecordNo)
                    .HasColumnName("PREV_INTER_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArMhEdBdDetail>(entity =>
            {
                entity.HasKey(e => e.ArMhEdBdDetailRecordNo);

                entity.ToTable("AR_MH_ED_BD_DETAIL");

                entity.HasIndex(e => e.ArMhEdBdDetailRecordNo)
                    .HasName("PK_AR_MH_ED_BD_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArMhEdBdDetailRecordNo)
                    .HasColumnName("AR_MH_ED_BD_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArRiskPlanDetailRecordNo)
                    .HasColumnName("AR_RISK_PLAN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrevInterCommentRecordNo)
                    .HasColumnName("PREV_INTER_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArMobilityProgram>(entity =>
            {
                entity.HasKey(e => e.ArMobilityProgramRecordNo);

                entity.ToTable("AR_MOBILITY_PROGRAM");

                entity.HasIndex(e => e.ArMobilityProgramRecordNo)
                    .HasName("PK_AR_MOBILITY_PROGRAM")
                    .IsUnique();

                entity.HasIndex(e => e.ArVisionDetailRecordNo)
                    .HasName("AR_MOBILITY_PROGRAM_IDX1");

                entity.Property(e => e.ArMobilityProgramRecordNo)
                    .HasColumnName("AR_MOBILITY_PROGRAM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArVisionDetailRecordNo)
                    .HasColumnName("AR_VISION_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportProgramRecordNo)
                    .HasColumnName("SUPPORT_PROGRAM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArNationalAssessDetail>(entity =>
            {
                entity.HasKey(e => e.ArNationAssDetailRecordNo);

                entity.ToTable("AR_NATIONAL_ASSESS_DETAIL");

                entity.HasIndex(e => e.ArNationAssDetailRecordNo)
                    .HasName("PK_AR_NATIONAL_ASSESS_DETAIL")
                    .IsUnique();

                entity.HasIndex(e => e.ArNationalAssessRecordNo)
                    .HasName("SK1_AR_NATIONAL_ASSESS_DETAIL");

                entity.Property(e => e.ArNationAssDetailRecordNo)
                    .HasColumnName("AR_NATION_ASS_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArNationalAssessRecordNo)
                    .HasColumnName("AR_NATIONAL_ASSESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentItemRecordNo)
                    .HasColumnName("ASSESSMENT_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityResultRecordNo)
                    .HasColumnName("DISABILITY_RESULT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArNationalAssessment>(entity =>
            {
                entity.HasKey(e => e.ArNationalAssessRecordNo);

                entity.ToTable("AR_NATIONAL_ASSESSMENT");

                entity.HasIndex(e => e.ArLearnAssistProgRecordNo)
                    .HasName("SK1_AR_NATIONAL_ASSESSMENT");

                entity.HasIndex(e => e.ArNationalAssessRecordNo)
                    .HasName("PK_AR_NATIONAL_ASSESSMENT")
                    .IsUnique();

                entity.Property(e => e.ArNationalAssessRecordNo)
                    .HasColumnName("AR_NATIONAL_ASSESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArLearnAssistProgRecordNo)
                    .HasColumnName("AR_LEARN_ASSIST_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArNatureOfHearingLoss>(entity =>
            {
                entity.HasKey(e => e.ArNohlRecordNo);

                entity.ToTable("AR_NATURE_OF_HEARING_LOSS");

                entity.HasIndex(e => e.ArHearingDetailRecordNo)
                    .HasName("AR_NATURE_OF_HEARING_LOSS_IDX1");

                entity.HasIndex(e => e.ArNohlRecordNo)
                    .HasName("PK_AR_NATURE_OF_HEARING_LOSS")
                    .IsUnique();

                entity.Property(e => e.ArNohlRecordNo)
                    .HasColumnName("AR_NOHL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArHearingDetailRecordNo)
                    .HasColumnName("AR_HEARING_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NatureOfHearLossRecordNo)
                    .HasColumnName("NATURE_OF_HEAR_LOSS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArNonDetSupportAccess>(entity =>
            {
                entity.HasKey(e => e.ArNonDetSuppAccRecordNo);

                entity.ToTable("AR_NON_DET_SUPPORT_ACCESS");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("AR_NON_DET_SUPPORT_ACCESS_IDX1");

                entity.HasIndex(e => e.ArNonDetSuppAccRecordNo)
                    .HasName("PK_AR_NON_DET_SUPPORT_ACCESS")
                    .IsUnique();

                entity.Property(e => e.ArNonDetSuppAccRecordNo)
                    .HasColumnName("AR_NON_DET_SUPP_ACC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgenciesInvolvedInd)
                    .HasColumnName("AGENCIES_INVOLVED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArNonDetSupportAccessItem>(entity =>
            {
                entity.HasKey(e => e.ArNonDetItemRecordNo)
                    .HasName("PK_AR_NON_DET_ITEM");

                entity.ToTable("AR_NON_DET_SUPPORT_ACCESS_ITEM");

                entity.HasIndex(e => e.ArNonDetItemRecordNo)
                    .HasName("PK_AR_NON_DET_ITEM")
                    .IsUnique();

                entity.HasIndex(e => e.ArNonDetSuppAccRecordNo)
                    .HasName("AR_NON_DET_SUP_ACC_ITEM_IDX1");

                entity.Property(e => e.ArNonDetItemRecordNo)
                    .HasColumnName("AR_NON_DET_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgencyNm)
                    .HasColumnName("AGENCY_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArNonDetSuppAccRecordNo)
                    .HasColumnName("AR_NON_DET_SUPP_ACC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastServiceYear)
                    .HasColumnName("LAST_SERVICE_YEAR")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPlacementPanel>(entity =>
            {
                entity.HasKey(e => e.ArPpRecordNo);

                entity.ToTable("AR_PLACEMENT_PANEL");

                entity.HasIndex(e => e.ArPpRecordNo)
                    .HasName("PK_AR_PLACEMENT_PANEL")
                    .IsUnique();

                entity.HasIndex(e => e.PpStatusRecordNo)
                    .HasName("AR_PLACEMENT_PANEL_II");

                entity.Property(e => e.ArPpRecordNo)
                    .HasColumnName("AR_PP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertNumberOfDaysPrior)
                    .HasColumnName("ALERT_NUMBER_OF_DAYS_PRIOR")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Location)
                    .HasColumnName("LOCATION")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MeetingEndDateTime)
                    .HasColumnName("MEETING_END_DATE_TIME")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MeetingStartDateTime)
                    .HasColumnName("MEETING_START_DATE_TIME")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpAbbrevNm)
                    .IsRequired()
                    .HasColumnName("PP_ABBREV_NM")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpEndDate)
                    .HasColumnName("PP_END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpNm)
                    .IsRequired()
                    .HasColumnName("PP_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpStartDate)
                    .HasColumnName("PP_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpStatusRecordNo)
                    .HasColumnName("PP_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpTypeInd)
                    .IsRequired()
                    .HasColumnName("PP_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StateWideInd)
                    .IsRequired()
                    .HasColumnName("STATE_WIDE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPlacementPanelConv>(entity =>
            {
                entity.HasKey(e => e.ArPpConvenorRecordNo);

                entity.ToTable("AR_PLACEMENT_PANEL_CONV");

                entity.HasIndex(e => e.ArPpConvenorRecordNo)
                    .HasName("PK_AR_PLACEMENT_PANEL_CONV")
                    .IsUnique();

                entity.HasIndex(e => e.ArPpRecordNo)
                    .HasName("AR_PLACEMENT_PANEL_CONV_I1");

                entity.Property(e => e.ArPpConvenorRecordNo)
                    .HasColumnName("AR_PP_CONVENOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArPpRecordNo)
                    .HasColumnName("AR_PP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .IsRequired()
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPlacementPanelMember>(entity =>
            {
                entity.HasKey(e => e.ArPpMemberRecordNo);

                entity.ToTable("AR_PLACEMENT_PANEL_MEMBER");

                entity.HasIndex(e => e.ArPpMemberRecordNo)
                    .HasName("PK_AR_PLACEMENT_PANEL_MEMBER")
                    .IsUnique();

                entity.HasIndex(e => e.ArPpRecordNo)
                    .HasName("AR_PLACEMENT_PANEL_MEMBER_I1");

                entity.Property(e => e.ArPpMemberRecordNo)
                    .HasColumnName("AR_PP_MEMBER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArPpRecordNo)
                    .HasColumnName("AR_PP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailAddressValidInd)
                    .IsRequired()
                    .HasColumnName("EMAIL_ADDRESS_VALID_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MemberTypeInd)
                    .IsRequired()
                    .HasColumnName("MEMBER_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("MOBILE_PHONE")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NotificationSentInd)
                    .IsRequired()
                    .HasColumnName("NOTIFICATION_SENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.WorkPhone)
                    .HasColumnName("WORK_PHONE")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPlacementPanelOutcome>(entity =>
            {
                entity.HasKey(e => e.ArPpOutcomeRecordNo);

                entity.ToTable("AR_PLACEMENT_PANEL_OUTCOME");

                entity.HasIndex(e => e.ArPpOutcomeRecordNo)
                    .HasName("PK_AR_PLACEMENT_PANEL_OUTCOME")
                    .IsUnique();

                entity.Property(e => e.ArPpOutcomeRecordNo)
                    .HasColumnName("AR_PP_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseloadPerWkHrs)
                    .HasColumnName("CASELOAD_PER_WK_HRS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseloadPerWkMins)
                    .HasColumnName("CASELOAD_PER_WK_MINS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CensusOrgUnitRecordNo)
                    .HasColumnName("CENSUS_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentSettings)
                    .HasColumnName("CURRENT_SETTINGS")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityProgItemRecordNo)
                    .HasColumnName("DISABILITY_PROG_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FactorOfNeedRecordNo)
                    .HasColumnName("FACTOR_OF_NEED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.GeneralCommentRecordNo)
                    .HasColumnName("GENERAL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.IfsRcmdProceedToSoInd)
                    .HasColumnName("IFS_RCMD_PROCEED_TO_SO_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntendedStartDate)
                    .HasColumnName("INTENDED_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsthPerWkHrs)
                    .HasColumnName("ISTH_PER_WK_HRS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsthPerWkMins)
                    .HasColumnName("ISTH_PER_WK_MINS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.IstvPerWkHrs)
                    .HasColumnName("ISTV_PER_WK_HRS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.IstvPerWkMins)
                    .HasColumnName("ISTV_PER_WK_MINS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MonitorInd)
                    .HasColumnName("MONITOR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumberOfSessions)
                    .HasColumnName("NUMBER_OF_SESSIONS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PervasiveDevelopmentCharInd)
                    .HasColumnName("PERVASIVE_DEVELOPMENT_CHAR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpOutcomeCategoryRecordNo)
                    .HasColumnName("PP_OUTCOME_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PpOutcomeStatusRecordNo)
                    .HasColumnName("PP_OUTCOME_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PriorityStatusRecordNo)
                    .HasColumnName("PRIORITY_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProfileSupportedInd)
                    .HasColumnName("PROFILE_SUPPORTED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Section1CompletedInd)
                    .HasColumnName("SECTION_1_COMPLETED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Section2CompletedInd)
                    .HasColumnName("SECTION_2_COMPLETED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Section3CompletedInd)
                    .HasColumnName("SECTION_3_COMPLETED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SharedEnrolmentInd)
                    .HasColumnName("SHARED_ENROLMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SharedOrgUnitRecordNo)
                    .HasColumnName("SHARED_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusCommentRecordNo)
                    .HasColumnName("STATUS_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusReasonRecordNo)
                    .HasColumnName("STATUS_REASON_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("NULL ");

                entity.Property(e => e.SupplementaryPerWkHrs)
                    .HasColumnName("SUPPLEMENTARY_PER_WK_HRS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupplementaryPerWkMins)
                    .HasColumnName("SUPPLEMENTARY_PER_WK_MINS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportAllocPerWkHrs)
                    .HasColumnName("SUPPORT_ALLOC_PER_WK_HRS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportAllocPerWkMins)
                    .HasColumnName("SUPPORT_ALLOC_PER_WK_MINS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPlacementPanelOwner>(entity =>
            {
                entity.HasKey(e => e.ArPpOwnerRecordNo);

                entity.ToTable("AR_PLACEMENT_PANEL_OWNER");

                entity.HasIndex(e => e.ArPpOwnerRecordNo)
                    .HasName("PK_AR_PLACEMENT_PANEL_OWNER")
                    .IsUnique();

                entity.HasIndex(e => e.ArPpRecordNo)
                    .HasName("AR_PLACEMENT_PANEL_OWNER_I1");

                entity.HasIndex(e => e.OwnerOrgUnitRecordNo)
                    .HasName("AR_PLACEMENT_PANEL_OWNER_I2");

                entity.Property(e => e.ArPpOwnerRecordNo)
                    .HasColumnName("AR_PP_OWNER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArPpRecordNo)
                    .HasColumnName("AR_PP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OwnerOrgUnitRecordNo)
                    .HasColumnName("OWNER_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPrincipalSignDetail>(entity =>
            {
                entity.HasKey(e => e.ArPrincipalSdRecordNo);

                entity.ToTable("AR_PRINCIPAL_SIGN_DETAIL");

                entity.HasIndex(e => e.ArPrincipalSdRecordNo)
                    .HasName("PK_AR_PRINCIPAL_SIGN_DETAIL")
                    .IsUnique();

                entity.HasIndex(e => e.ArSupDocumentRecordNo)
                    .HasName("AR_PRINCIPAL_SIGN_DETAIL_IDX1");

                entity.Property(e => e.ArPrincipalSdRecordNo)
                    .HasColumnName("AR_PRINCIPAL_SD_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocumentRecordNo)
                    .HasColumnName("AR_SUP_DOCUMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPriorityPlacementPnl>(entity =>
            {
                entity.HasKey(e => e.ArPriorityPpRecordNo);

                entity.ToTable("AR_PRIORITY_PLACEMENT_PNL");

                entity.HasIndex(e => e.ArDisProgItemRecordNo)
                    .HasName("AR_PRIORITY_PLACEMENT_PNL_I1");

                entity.HasIndex(e => e.ArPpOutcomeRecordNo)
                    .HasName("AR_PRIORITY_PLACEMENT_PNL_I3");

                entity.HasIndex(e => e.ArPpRecordNo)
                    .HasName("AR_PRIORITY_PLACEMENT_PNL_I2");

                entity.HasIndex(e => e.ArPriorityPpRecordNo)
                    .HasName("PK_AR_PRIORITY_PLACEMENT_PNL")
                    .IsUnique();

                entity.Property(e => e.ArPriorityPpRecordNo)
                    .HasColumnName("AR_PRIORITY_PP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDisProgItemRecordNo)
                    .HasColumnName("AR_DIS_PROG_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArPpOutcomeRecordNo)
                    .HasColumnName("AR_PP_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArPpRecordNo)
                    .HasColumnName("AR_PP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDateTime)
                    .HasColumnName("CREATION_DATE_TIME")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusInd)
                    .IsRequired()
                    .HasColumnName("STATUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArPriorityStatusChgHis>(entity =>
            {
                entity.HasKey(e => e.ArPsChgHistoryRecordNo);

                entity.ToTable("AR_PRIORITY_STATUS_CHG_HIS");

                entity.HasIndex(e => e.ArDisProgItemRecordNo)
                    .HasName("AR_PRIORITY_STATUS_CHG_HIS_I1");

                entity.HasIndex(e => e.ArPsChgHistoryRecordNo)
                    .HasName("PK_AR_PRIORITY_STATUS_CHG_HIS")
                    .IsUnique();

                entity.Property(e => e.ArPsChgHistoryRecordNo)
                    .HasColumnName("AR_PS_CHG_HISTORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArDisProgItemRecordNo)
                    .HasColumnName("AR_DIS_PROG_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeDateTime)
                    .HasColumnName("CHANGE_DATE_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeDetUserId)
                    .IsRequired()
                    .HasColumnName("CHANGE_DET_USER_ID")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PsTransitionRecordNo)
                    .HasColumnName("PS_TRANSITION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusReasonRecordNo)
                    .HasColumnName("STATUS_REASON_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArProgAttPlan>(entity =>
            {
                entity.HasKey(e => e.ArProgAttPlanRecordNo)
                    .HasName("AR_PROG_ATT_PLAN_PK");

                entity.ToTable("AR_PROG_ATT_PLAN");

                entity.HasIndex(e => e.ArProgAttPlanRecordNo)
                    .HasName("PK_AR_PROG_ATTEND_PLAN_REC")
                    .IsUnique();

                entity.Property(e => e.ArProgAttPlanRecordNo)
                    .HasColumnName("AR_PROG_ATT_PLAN_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArEiProfSummRecordNo)
                    .HasColumnName("AR_EI_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DayOfWeek)
                    .HasColumnName("DAY_OF_WEEK")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Period)
                    .HasColumnName("PERIOD")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArRiskManagement>(entity =>
            {
                entity.HasKey(e => e.ArRiskManageRecordNo);

                entity.ToTable("AR_RISK_MANAGEMENT");

                entity.HasIndex(e => e.ArRiskManageRecordNo)
                    .HasName("PK_AR_RISK_MANAGEMENT")
                    .IsUnique();

                entity.Property(e => e.ArRiskManageRecordNo)
                    .HasColumnName("AR_RISK_MANAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HealthPlanDevelopDate)
                    .HasColumnName("HEALTH_PLAN_DEVELOP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.HealthPlanInd)
                    .HasColumnName("HEALTH_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HealthPlanReviewDate)
                    .HasColumnName("HEALTH_PLAN_REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.RiskToOtherInd)
                    .HasColumnName("RISK_TO_OTHER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeperateRiskDevelopDate)
                    .HasColumnName("SEPERATE_RISK_DEVELOP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeperateRiskInd)
                    .HasColumnName("SEPERATE_RISK_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeperateRiskReviewDate)
                    .HasColumnName("SEPERATE_RISK_REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentBehaviourDevelopDate)
                    .HasColumnName("STUDENT_BEHAVIOUR_DEVELOP_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentBehaviourInd)
                    .HasColumnName("STUDENT_BEHAVIOUR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentBehaviourReviewDate)
                    .HasColumnName("STUDENT_BEHAVIOUR_REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArRiskPlanDetail>(entity =>
            {
                entity.HasKey(e => e.ArRiskPlanDetailRecordNo);

                entity.ToTable("AR_RISK_PLAN_DETAIL");

                entity.HasIndex(e => e.ArRiskPlanDetailRecordNo)
                    .HasName("PK_AR_RISK_PLAN_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArRiskPlanDetailRecordNo)
                    .HasColumnName("AR_RISK_PLAN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.BehaviourCommentRecordNo)
                    .HasColumnName("BEHAVIOUR_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FreqCommentRecordNo)
                    .HasColumnName("FREQ_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImplicationCommentRecordNo)
                    .HasColumnName("IMPLICATION_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntensityCommentRecordNo)
                    .HasColumnName("INTENSITY_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LocationCommentRecordNo)
                    .HasColumnName("LOCATION_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArRoleAssignment>(entity =>
            {
                entity.HasKey(e => e.ArRoleAssignRecordNo);

                entity.ToTable("AR_ROLE_ASSIGNMENT");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("AR_ROLE_ASSIGNMENT_IDX1");

                entity.HasIndex(e => e.ArRoleAssignRecordNo)
                    .HasName("PK_AR_ROLE_ASSIGNMENT")
                    .IsUnique();

                entity.HasIndex(e => e.DisabilityRoleRecordNo)
                    .HasName("AR_ROLE_ASSIGNMENT_IDX2");

                entity.Property(e => e.ArRoleAssignRecordNo)
                    .HasColumnName("AR_ROLE_ASSIGN_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityRoleRecordNo)
                    .HasColumnName("DISABILITY_ROLE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoleChanged)
                    .HasColumnName("ROLE_CHANGED")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSchProSumSignDetail>(entity =>
            {
                entity.HasKey(e => e.ArSpsSignDetailRecordNo)
                    .HasName("AR_SCH_PRO_SUM_SIGN_DETAIL_PK");

                entity.ToTable("AR_SCH_PRO_SUM_SIGN_DETAIL");

                entity.HasIndex(e => e.ArSchoolProfSummRecordNo)
                    .HasName("AR_SCH_PRO_SUM_SIGN_DET_IDX1");

                entity.HasIndex(e => e.ArSpsSignDetailRecordNo)
                    .HasName("PK_AR_SCH_PRO_SUM_SIGN_DET_REC")
                    .IsUnique();

                entity.Property(e => e.ArSpsSignDetailRecordNo)
                    .HasColumnName("AR_SPS_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSchoolProfSummRecordNo)
                    .HasColumnName("AR_SCHOOL_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSchoolAccessDomain>(entity =>
            {
                entity.HasKey(e => e.ArSchoolAccDomRecordNo)
                    .HasName("AR_SCHOOL_ACCESS_DOMAIN_PK");

                entity.ToTable("AR_SCHOOL_ACCESS_DOMAIN");

                entity.HasIndex(e => e.ArSchoolAccDomRecordNo)
                    .HasName("PK_AR_SCHOOL_ACCESS_DOMAIN_REC")
                    .IsUnique();

                entity.HasIndex(e => e.ArSchoolProfSummRecordNo)
                    .HasName("AR_SCHOOL_ACCESS_DOMAIN_IDX1");

                entity.Property(e => e.ArSchoolAccDomRecordNo)
                    .HasColumnName("AR_SCHOOL_ACC_DOM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArCurrReportsToRecordNo)
                    .HasColumnName("AR_CURR_REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArCurriculumRecordNo)
                    .HasColumnName("AR_CURRICULUM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSchoolProfSummRecordNo)
                    .HasColumnName("AR_SCHOOL_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommentTextRecordNo)
                    .HasColumnName("COMMENT_TEXT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityLevelRecordNo)
                    .HasColumnName("DISABILITY_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NotApplicableInd)
                    .HasColumnName("NOT_APPLICABLE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSchoolContact>(entity =>
            {
                entity.HasKey(e => e.ArSchoolContactRecordNo);

                entity.ToTable("AR_SCHOOL_CONTACT");

                entity.HasIndex(e => e.ArSchoolContactRecordNo)
                    .HasName("PK_AR_SCHOOL_CONTACT")
                    .IsUnique();

                entity.HasIndex(e => e.ArSchoolDetailRecordNo)
                    .HasName("AR_SCHOOL_CONTACT_IDX1");

                entity.Property(e => e.ArSchoolContactRecordNo)
                    .HasColumnName("AR_SCHOOL_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSchoolDetailRecordNo)
                    .HasColumnName("AR_SCHOOL_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSchoolDetail>(entity =>
            {
                entity.HasKey(e => e.ArSchoolDetailRecordNo)
                    .HasName("AR_SCHOOL_DETAIL_PK");

                entity.ToTable("AR_SCHOOL_DETAIL");

                entity.HasIndex(e => e.ArSchoolDetailRecordNo)
                    .HasName("PK_AR_SCHOOL_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArSchoolDetailRecordNo)
                    .HasColumnName("AR_SCHOOL_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityRoleRecordNo)
                    .HasColumnName("DISABILITY_ROLE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherDisabilityRoleNm)
                    .HasColumnName("OTHER_DISABILITY_ROLE_NM")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherSchoolNm)
                    .HasColumnName("OTHER_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherStaffNm)
                    .HasColumnName("OTHER_STAFF_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PresentClassInd)
                    .HasColumnName("PRESENT_CLASS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolType)
                    .HasColumnName("SCHOOL_TYPE")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StaffRecordNo)
                    .HasColumnName("STAFF_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSchoolProfileSummary>(entity =>
            {
                entity.HasKey(e => e.ArSchoolProfSummRecordNo)
                    .HasName("AR_SCHOOL_PROFILE_SUMMARY_PK");

                entity.ToTable("AR_SCHOOL_PROFILE_SUMMARY");

                entity.HasIndex(e => e.ArAttachmentRecordNo)
                    .HasName("IDX_AR_ATTACHMENT_RECORD_NO")
                    .IsUnique();

                entity.HasIndex(e => e.ArSchoolProfSummRecordNo)
                    .HasName("PK_AR_SCHOOL_PROF_SUM_REC")
                    .IsUnique();

                entity.Property(e => e.ArSchoolProfSummRecordNo)
                    .HasColumnName("AR_SCHOOL_PROF_SUMM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenericInd)
                    .HasColumnName("GENERIC_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.KlaCommentRecordNo)
                    .HasColumnName("KLA_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.WkPlLnCommentRecordNo)
                    .HasColumnName("WK_PL_LN_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSignDetail>(entity =>
            {
                entity.HasKey(e => e.ArSignDetailRecordNo);

                entity.ToTable("AR_SIGN_DETAIL");

                entity.HasIndex(e => e.ArAttachmentRecordNo)
                    .HasName("SK1_AR_SIGN_DETAIL");

                entity.HasIndex(e => e.ArSignDetailRecordNo)
                    .HasName("PK_AR_SIGN_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfirmationInd)
                    .HasColumnName("CONFIRMATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HoursPerWeek)
                    .HasColumnName("HOURS_PER_WEEK")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SignCommentRecordNo)
                    .HasColumnName("SIGN_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SignDate)
                    .HasColumnName("SIGN_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StSrRecordNo)
                    .HasColumnName("ST_SR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentCommentInd)
                    .HasColumnName("STUDENT_COMMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentCommentRecordNo)
                    .HasColumnName("STUDENT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSpecialEquipment>(entity =>
            {
                entity.HasKey(e => e.ArSpecialEquipRecordNo);

                entity.ToTable("AR_SPECIAL_EQUIPMENT");

                entity.HasIndex(e => e.ArSpecialEquipRecordNo)
                    .HasName("PK_AR_SPECIAL_EQUIPMENT")
                    .IsUnique();

                entity.Property(e => e.ArSpecialEquipRecordNo)
                    .HasColumnName("AR_SPECIAL_EQUIP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrEquipCommentRecordNo)
                    .HasColumnName("CURR_EQUIP_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EquipAccCommentRecordNo)
                    .HasColumnName("EQUIP_ACC_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TrackingCommentRecordNo)
                    .HasColumnName("TRACKING_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArStandardAssCatResult>(entity =>
            {
                entity.HasKey(e => e.ArStandAssCatResRecordNo);

                entity.ToTable("AR_STANDARD_ASS_CAT_RESULT");

                entity.HasIndex(e => e.ArStandAssCatResRecordNo)
                    .HasName("PK_AR_STANDARD_ASS_CAT_RESULT")
                    .IsUnique();

                entity.HasIndex(e => e.ArStandardAssessRecordNo)
                    .HasName("AR_STANDARD_ASS_CAT_RES_IDX1");

                entity.Property(e => e.ArStandAssCatResRecordNo)
                    .HasColumnName("AR_STAND_ASS_CAT_RES_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArStandardAssessRecordNo)
                    .HasColumnName("AR_STANDARD_ASSESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentCategoryRecordNo)
                    .HasColumnName("ASSESSMENT_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityResultRecordNo)
                    .HasColumnName("DISABILITY_RESULT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArStandardAssessment>(entity =>
            {
                entity.HasKey(e => e.ArStandardAssessRecordNo);

                entity.ToTable("AR_STANDARD_ASSESSMENT");

                entity.HasIndex(e => e.ArLearnAssistProgRecordNo)
                    .HasName("SK1_AR_STANDARD_ASSESSMENT");

                entity.HasIndex(e => e.ArStandardAssessRecordNo)
                    .HasName("PK_AR_STANDARD_ASSESSMENT")
                    .IsUnique();

                entity.Property(e => e.ArStandardAssessRecordNo)
                    .HasColumnName("AR_STANDARD_ASSESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArLearnAssistProgRecordNo)
                    .HasColumnName("AR_LEARN_ASSIST_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentDate)
                    .HasColumnName("ASSESSMENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentItemRecordNo)
                    .HasColumnName("ASSESSMENT_ITEM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentMethodRecordNo)
                    .HasColumnName("ASSESSMENT_METHOD_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessorNm)
                    .HasColumnName("ASSESSOR_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessorPosition)
                    .HasColumnName("ASSESSOR_POSITION")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Result)
                    .HasColumnName("RESULT")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StandardAssCommentRecordNo)
                    .HasColumnName("STANDARD_ASS_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArStatusChangeComment>(entity =>
            {
                entity.HasKey(e => e.ArStatusChangeCmtRecordNo);

                entity.ToTable("AR_STATUS_CHANGE_COMMENT");

                entity.HasIndex(e => e.ArStatusChangeCmtRecordNo)
                    .HasName("PK_AR_STATUS_CHANGE_COMMENT")
                    .IsUnique();

                entity.HasIndex(e => new { e.ArAccessRequestRecordNo, e.CreationDate })
                    .HasName("SK_AR_STATUS_CHANGE_COMMENT")
                    .IsUnique();

                entity.Property(e => e.ArStatusChangeCmtRecordNo)
                    .HasColumnName("AR_STATUS_CHANGE_CMT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArStatusTranRecordNo)
                    .HasColumnName("AR_STATUS_TRAN_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreationDate)
                    .HasColumnName("CREATION_DATE")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSubmittingParent>(entity =>
            {
                entity.HasKey(e => e.ArSubmittingParentRecordNo);

                entity.ToTable("AR_SUBMITTING_PARENT");

                entity.HasIndex(e => e.ArSubmittingParentRecordNo)
                    .HasName("PK_AR_SUBMITTING_PARENT")
                    .IsUnique();

                entity.HasIndex(e => e.ArSupportDocumentRecordNo)
                    .HasName("AR_SUBMITTING_PARENT_IDX1");

                entity.Property(e => e.ArSubmittingParentRecordNo)
                    .HasColumnName("AR_SUBMITTING_PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupportDocumentRecordNo)
                    .HasColumnName("AR_SUPPORT_DOCUMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSupDisabilityProgram>(entity =>
            {
                entity.HasKey(e => e.ArSupDisProgRecordNo);

                entity.ToTable("AR_SUP_DISABILITY_PROGRAM");

                entity.HasIndex(e => e.ArSupDisProgRecordNo)
                    .HasName("PK_AR_SUP_DISABILITY_PROGRAM")
                    .IsUnique();

                entity.HasIndex(e => e.ArSupDocDetailRecordNo)
                    .HasName("AR_SUP_DISABILITY_PROGRAM_IDX1");

                entity.Property(e => e.ArSupDisProgRecordNo)
                    .HasColumnName("AR_SUP_DIS_PROG_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityProgramRecordNo)
                    .HasColumnName("DISABILITY_PROGRAM_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSupDocDetail>(entity =>
            {
                entity.HasKey(e => e.ArSupDocDetailRecordNo);

                entity.ToTable("AR_SUP_DOC_DETAIL");

                entity.HasIndex(e => e.ArSupDocDetailRecordNo)
                    .HasName("PK_AR_SUP_DOC_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAttachmentRecordNo)
                    .HasColumnName("AR_ATTACHMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSupDocDetailSign>(entity =>
            {
                entity.HasKey(e => e.AsddSignDetailRecordNo);

                entity.ToTable("AR_SUP_DOC_DETAIL_SIGN");

                entity.HasIndex(e => e.ArSupDocDetailRecordNo)
                    .HasName("AR_SUP_DOC_DETAIL_SIGN_IDX1");

                entity.HasIndex(e => e.AsddSignDetailRecordNo)
                    .HasName("PK_AR_SUP_DOC_DETAIL_SIGN")
                    .IsUnique();

                entity.Property(e => e.AsddSignDetailRecordNo)
                    .HasColumnName("ASDD_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSignDetailRecordNo)
                    .HasColumnName("AR_SIGN_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArSupportDocument>(entity =>
            {
                entity.HasKey(e => e.ArSupDocumentRecordNo);

                entity.ToTable("AR_SUPPORT_DOCUMENT");

                entity.HasIndex(e => e.ArSupDocumentRecordNo)
                    .HasName("PK_AR_SUPPORT_DOCUMENT")
                    .IsUnique();

                entity.Property(e => e.ArSupDocumentRecordNo)
                    .HasColumnName("AR_SUP_DOCUMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityConfirmInd)
                    .HasColumnName("DISABILITY_CONFIRM_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntegOrgUnitRecordNo)
                    .HasColumnName("INTEG_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntegPrincipalSupportsInd)
                    .HasColumnName("INTEG_PRINCIPAL_SUPPORTS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentCommentRecordNo)
                    .HasColumnName("PARENT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentSignDate)
                    .HasColumnName("PARENT_SIGN_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrincipalSupportInd)
                    .HasColumnName("PRINCIPAL_SUPPORT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SharedEnrolCommentRecordNo)
                    .HasColumnName("SHARED_ENROL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArTransferHistory>(entity =>
            {
                entity.HasKey(e => e.ArTransferHistoryRecordNo);

                entity.ToTable("AR_TRANSFER_HISTORY");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("AR_TRANSFER_HISTORY_I1");

                entity.HasIndex(e => e.ArTransferHistoryRecordNo)
                    .HasName("PK_AR_TRANSFER_HISTORY")
                    .IsUnique();

                entity.Property(e => e.ArTransferHistoryRecordNo)
                    .HasColumnName("AR_TRANSFER_HISTORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FromArOwnerOuRecordNo)
                    .HasColumnName("FROM_AR_OWNER_OU_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToArOwnerOuRecordNo)
                    .HasColumnName("TO_AR_OWNER_OU_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransferDateTime)
                    .HasColumnName("TRANSFER_DATE_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransferDetUserId)
                    .IsRequired()
                    .HasColumnName("TRANSFER_DET_USER_ID")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArTravelSupportNeed>(entity =>
            {
                entity.HasKey(e => e.ArTravSupportNeedRecordNo);

                entity.ToTable("AR_TRAVEL_SUPPORT_NEED");

                entity.HasIndex(e => e.ArAccessRequestRecordNo)
                    .HasName("AR_TRAVEL_SUPPORT_NEED_IDX1");

                entity.HasIndex(e => e.ArTravSupportNeedRecordNo)
                    .HasName("PK_AR_TRAVEL_SUPPORT_NEED")
                    .IsUnique();

                entity.Property(e => e.ArTravSupportNeedRecordNo)
                    .HasColumnName("AR_TRAV_SUPPORT_NEED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArAccessRequestRecordNo)
                    .HasColumnName("AR_ACCESS_REQUEST_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TravelSupportNeedRecordNo)
                    .HasColumnName("TRAVEL_SUPPORT_NEED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArVisionAccess>(entity =>
            {
                entity.HasKey(e => e.ArVisionAccessRecordNo);

                entity.ToTable("AR_VISION_ACCESS");

                entity.HasIndex(e => e.ArVisionAccessRecordNo)
                    .HasName("PK_AR_VISION_ACCESS")
                    .IsUnique();

                entity.HasIndex(e => e.ArVisionDetailRecordNo)
                    .HasName("AR_VISION_ACCESS_IDX1");

                entity.Property(e => e.ArVisionAccessRecordNo)
                    .HasColumnName("AR_VISION_ACCESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArVisionDetailRecordNo)
                    .HasColumnName("AR_VISION_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisionAccessRecordNo)
                    .HasColumnName("VISION_ACCESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArVisionAid>(entity =>
            {
                entity.HasKey(e => e.ArVisionAidRecordNo);

                entity.ToTable("AR_VISION_AID");

                entity.HasIndex(e => e.ArVisionAidRecordNo)
                    .HasName("PK_AR_VISION_AID")
                    .IsUnique();

                entity.HasIndex(e => e.ArVisionDetailRecordNo)
                    .HasName("AR_VISION_AID_IDX1");

                entity.Property(e => e.ArVisionAidRecordNo)
                    .HasColumnName("AR_VISION_AID_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArVisionDetailRecordNo)
                    .HasColumnName("AR_VISION_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisAssistAidRecordNo)
                    .HasColumnName("DIS_ASSIST_AID_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityOutcomeRecordNo)
                    .HasColumnName("DISABILITY_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArVisionDetail>(entity =>
            {
                entity.HasKey(e => e.ArVisionDetailRecordNo);

                entity.ToTable("AR_VISION_DETAIL");

                entity.HasIndex(e => e.ArVisionDetailRecordNo)
                    .HasName("PK_AR_VISION_DETAIL")
                    .IsUnique();

                entity.Property(e => e.ArVisionDetailRecordNo)
                    .HasColumnName("AR_VISION_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArSupDocDetailRecordNo)
                    .HasColumnName("AR_SUP_DOC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssesserNm)
                    .HasColumnName("ASSESSER_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssesserPosition)
                    .HasColumnName("ASSESSER_POSITION")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssessmentDate)
                    .HasColumnName("ASSESSMENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentIstvHour)
                    .HasColumnName("CURRENT_ISTV_HOUR")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentIstvMonitorInd)
                    .HasColumnName("CURRENT_ISTV_MONITOR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiagnosisDate)
                    .HasColumnName("DIAGNOSIS_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FvaConductedDate)
                    .HasColumnName("FVA_CONDUCTED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FvaConductedInd)
                    .HasColumnName("FVA_CONDUCTED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NatureOfVisionLossInd)
                    .HasColumnName("NATURE_OF_VISION_LOSS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecommendIstvHour)
                    .HasColumnName("RECOMMEND_ISTV_HOUR")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecommendIstvMonitorInd)
                    .HasColumnName("RECOMMEND_ISTV_MONITOR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkillCommentRecordNo)
                    .HasColumnName("SKILL_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisionAidCommentRecordNo)
                    .HasColumnName("VISION_AID_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisionLossCommentRecordNo)
                    .HasColumnName("VISION_LOSS_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisualfieldCentralInd)
                    .HasColumnName("VISUALFIELD_CENTRAL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisualfieldPeripheralInd)
                    .HasColumnName("VISUALFIELD_PERIPHERAL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArVisionLevel>(entity =>
            {
                entity.HasKey(e => e.ArVisionLevelRecordNo);

                entity.ToTable("AR_VISION_LEVEL");

                entity.HasIndex(e => e.ArVisionDetailRecordNo)
                    .HasName("AR_VISION_LEVEL_IDX1");

                entity.HasIndex(e => e.ArVisionLevelRecordNo)
                    .HasName("PK_AR_VISION_LEVEL")
                    .IsUnique();

                entity.Property(e => e.ArVisionLevelRecordNo)
                    .HasColumnName("AR_VISION_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArVisionDetailRecordNo)
                    .HasColumnName("AR_VISION_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DiagnosedLevelOther)
                    .HasColumnName("DIAGNOSED_LEVEL_OTHER")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EyeSideInd)
                    .HasColumnName("EYE_SIDE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisionLevelRecordNo)
                    .HasColumnName("VISION_LEVEL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisionLevelValueRecordNo)
                    .HasColumnName("VISION_LEVEL_VALUE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisualTypeInd)
                    .HasColumnName("VISUAL_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArVisionSupportSkill>(entity =>
            {
                entity.HasKey(e => e.ArVisionSuppSkillRecordNo);

                entity.ToTable("AR_VISION_SUPPORT_SKILL");

                entity.HasIndex(e => e.ArVisionDetailRecordNo)
                    .HasName("AR_VISION_SUPPORT_SKILL_IDX1");

                entity.HasIndex(e => e.ArVisionSuppSkillRecordNo)
                    .HasName("PK_AR_VISION_SUPPORT_SKILL")
                    .IsUnique();

                entity.Property(e => e.ArVisionSuppSkillRecordNo)
                    .HasColumnName("AR_VISION_SUPP_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArVisionDetailRecordNo)
                    .HasColumnName("AR_VISION_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityOutcomeRecordNo)
                    .HasColumnName("DISABILITY_OUTCOME_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportSkillRecordNo)
                    .HasColumnName("SUPPORT_SKILL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ChangeLogCategory>(entity =>
            {
                entity.HasKey(e => e.ChangeLogCategoryRecordNo)
                    .HasName("SYS_C0017024");

                entity.ToTable("CHANGE_LOG_CATEGORY");

                entity.HasIndex(e => e.ChangeLogCategoryRecordNo)
                    .HasName("SYS_C0017024")
                    .IsUnique();

                entity.Property(e => e.ChangeLogCategoryRecordNo)
                    .HasColumnName("CHANGE_LOG_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeLogCategoryCode)
                    .IsRequired()
                    .HasColumnName("CHANGE_LOG_CATEGORY_CODE")
                    .HasColumnType("VARCHAR2(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeLogCategoryMessage)
                    .HasColumnName("CHANGE_LOG_CATEGORY_MESSAGE")
                    .HasColumnType("VARCHAR2(60)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeLogCategoryName)
                    .HasColumnName("CHANGE_LOG_CATEGORY_NAME")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailNotification)
                    .HasColumnName("EMAIL_NOTIFICATION")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.EmailText)
                    .HasColumnName("EMAIL_TEXT")
                    .HasColumnType("VARCHAR2(3000)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NotifyCensus)
                    .HasColumnName("NOTIFY_CENSUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.NotifyNonCensus)
                    .HasColumnName("NOTIFY_NON_CENSUS")
                    .HasColumnType("CHAR(1)")
                    .HasDefaultValueSql("'N'");
            });

            modelBuilder.Entity<CollegeTransition>(entity =>
            {
                entity.HasKey(e => e.CollegeTransRecordNo);

                entity.ToTable("COLLEGE_TRANSITION");

                entity.HasIndex(e => e.CollegeTransRecordNo)
                    .HasName("PK_COLLEGE_TRANSITION")
                    .IsUnique();

                entity.Property(e => e.CollegeTransRecordNo)
                    .HasColumnName("COLLEGE_TRANS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultPreferenceNo)
                    .HasColumnName("DEFAULT_PREFERENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultRegistrationStatus)
                    .HasColumnName("DEFAULT_REGISTRATION_STATUS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.JuniorCollegeCode)
                    .IsRequired()
                    .HasColumnName("JUNIOR_COLLEGE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.JuniorCollegeNm)
                    .IsRequired()
                    .HasColumnName("JUNIOR_COLLEGE_NM")
                    .HasColumnType("VARCHAR2(40)")
                    .ValueGeneratedNever();

                entity.Property(e => e.JuniorCollegeRecordNo)
                    .HasColumnName("JUNIOR_COLLEGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.JuniorCollegeSchYear)
                    .HasColumnName("JUNIOR_COLLEGE_SCH_YEAR")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NonCensusInd)
                    .HasColumnName("NON_CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RiskAssessedInd)
                    .HasColumnName("RISK_ASSESSED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SameYearTransferInd)
                    .HasColumnName("SAME_YEAR_TRANSFER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeniorCollegeCode)
                    .IsRequired()
                    .HasColumnName("SENIOR_COLLEGE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeniorCollegeNm)
                    .IsRequired()
                    .HasColumnName("SENIOR_COLLEGE_NM")
                    .HasColumnType("VARCHAR2(40)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeniorCollegeRecordNo)
                    .HasColumnName("SENIOR_COLLEGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeniorCollegeSchYear)
                    .HasColumnName("SENIOR_COLLEGE_SCH_YEAR")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ContactDetail>(entity =>
            {
                entity.HasKey(e => e.ContactDetailRecordNo);

                entity.ToTable("CONTACT_DETAIL");

                entity.HasIndex(e => e.ContactDetailRecordNo)
                    .HasName("PK_CONTACT_DETAIL")
                    .IsUnique();

                entity.HasIndex(e => e.ContactValue)
                    .HasName("SK_CONTACT_DETAIL");

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactComment)
                    .HasColumnName("CONTACT_COMMENT")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactValue)
                    .IsRequired()
                    .HasColumnName("CONTACT_VALUE")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ValidationDate)
                    .HasColumnName("VALIDATION_DATE")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ValidationInd)
                    .HasColumnName("VALIDATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");
            });

            modelBuilder.Entity<CourtOrderContact>(entity =>
            {
                entity.HasKey(e => e.CorContactRecordNo);

                entity.ToTable("COURT_ORDER_CONTACT");

                entity.HasIndex(e => e.AddressDetailRecordNo)
                    .HasName("FK_ADD_DET_COR_CON");

                entity.HasIndex(e => e.AddressTypeRecordNo)
                    .HasName("FK_ADD_TYP_COR_CON");

                entity.HasIndex(e => e.CorContactRecordNo)
                    .HasName("PK_COURT_ORDER_CONTACT")
                    .IsUnique();

                entity.HasIndex(e => e.NameSalutationCodeRecordNo)
                    .HasName("FK_NAME_SAL_COR_CON");

                entity.Property(e => e.CorContactRecordNo)
                    .HasColumnName("COR_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressDetailRecordNo)
                    .HasColumnName("ADDRESS_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeRecordNo)
                    .HasColumnName("ADDRESS_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderInd)
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameSalutationCodeRecordNo)
                    .HasColumnName("NAME_SALUTATION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SynergyContactType)
                    .HasColumnName("SYNERGY_CONTACT_TYPE")
                    .HasColumnType("VARCHAR2(5)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<DatOrgCount>(entity =>
            {
                entity.HasKey(e => e.DatOrgCountRecordNo);

                entity.ToTable("DAT_ORG_COUNT");

                entity.HasIndex(e => e.DatOrgCountRecordNo)
                    .HasName("PK_DAT_ORG_COUNT")
                    .IsUnique();

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("DAT_ORG_COUNT_SK");

                entity.HasIndex(e => e.SyCodeRecordNo)
                    .HasName("SY_CODE_RECORD_NO_SK");

                entity.Property(e => e.DatOrgCountRecordNo)
                    .HasColumnName("DAT_ORG_COUNT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatCount)
                    .HasColumnName("DAT_COUNT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartureDescription)
                    .HasColumnName("DEPARTURE_DESCRIPTION")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DerAssignmentTypeInd)
                    .HasColumnName("DER_ASSIGNMENT_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<DatOrgCountRpt>(entity =>
            {
                entity.HasKey(e => e.DatOrgCountRptRecordNo);

                entity.ToTable("DAT_ORG_COUNT_RPT");

                entity.HasIndex(e => e.DatOrgCountRptRecordNo)
                    .HasName("PK_DAT_ORG_COUNT_RPT")
                    .IsUnique();

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("DAT_ORG_COUNT_RPT_SK");

                entity.HasIndex(e => e.SyCodeRecordNo)
                    .HasName("SY_CODE_RECORD_NO_RPT_SK");

                entity.Property(e => e.DatOrgCountRptRecordNo)
                    .HasColumnName("DAT_ORG_COUNT_RPT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastReportDate)
                    .HasColumnName("LAST_REPORT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaversAllocatedDatCt)
                    .HasColumnName("LEAVERS_ALLOCATED_DAT_CT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaversAllocatedDatCtChg)
                    .HasColumnName("LEAVERS_ALLOCATED_DAT_CT_CHG")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaversLoanedDatCt)
                    .HasColumnName("LEAVERS_LOANED_DAT_CT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaversLoanedDatCtChg)
                    .HasColumnName("LEAVERS_LOANED_DAT_CT_CHG")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MoversAllocatedDatCt)
                    .HasColumnName("MOVERS_ALLOCATED_DAT_CT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MoversAllocatedDatCtChg)
                    .HasColumnName("MOVERS_ALLOCATED_DAT_CT_CHG")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MoversLoanedDatCt)
                    .HasColumnName("MOVERS_LOANED_DAT_CT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MoversLoanedDatCtChg)
                    .HasColumnName("MOVERS_LOANED_DAT_CT_CHG")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<DatOrgCountTmp>(entity =>
            {
                entity.HasKey(e => e.DatOrgCountTmpRecordNo);

                entity.ToTable("DAT_ORG_COUNT_TMP");

                entity.HasIndex(e => e.DatOrgCountTmpRecordNo)
                    .HasName("PK_DAT_ORG_COUNT_TMP")
                    .IsUnique();

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("DAT_ORG_COUNT_TMP_SK");

                entity.HasIndex(e => e.SyCodeRecordNo)
                    .HasName("SY_CODE_RECORD_NO_TMP_SK");

                entity.Property(e => e.DatOrgCountTmpRecordNo)
                    .HasColumnName("DAT_ORG_COUNT_TMP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatCount)
                    .HasColumnName("DAT_COUNT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartureDescription)
                    .HasColumnName("DEPARTURE_DESCRIPTION")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DerAssignmentTypeInd)
                    .HasColumnName("DER_ASSIGNMENT_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastReportDate)
                    .HasColumnName("LAST_REPORT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<DoctorMedicalCondition>(entity =>
            {
                entity.HasKey(e => e.DoctorMedicalCondRecordNo);

                entity.ToTable("DOCTOR_MEDICAL_CONDITION");

                entity.HasIndex(e => e.DoctorMedicalCondRecordNo)
                    .HasName("PK_DOCTOR_MEDICAL_CONDITION")
                    .IsUnique();

                entity.Property(e => e.DoctorMedicalCondRecordNo)
                    .HasColumnName("DOCTOR_MEDICAL_COND_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentDoctorRecordNo)
                    .HasColumnName("STUDENT_DOCTOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentMedCondRecordNo)
                    .HasColumnName("STUDENT_MED_COND_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Dossier>(entity =>
            {
                entity.HasKey(e => e.DossierRecordNo);

                entity.ToTable("DOSSIER");

                entity.HasIndex(e => e.DossierRecordNo)
                    .HasName("PK_DOSSIER")
                    .IsUnique();

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlertFlagInd)
                    .IsRequired()
                    .HasColumnName("ALERT_FLAG_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierNm)
                    .IsRequired()
                    .HasColumnName("DOSSIER_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierTypeRecordNo)
                    .HasColumnName("DOSSIER_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierVisibilityInd)
                    .IsRequired()
                    .HasColumnName("DOSSIER_VISIBILITY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceNo)
                    .HasColumnName("REFERENCE_NO")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReviewDate)
                    .HasColumnName("REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo2)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO_2")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.HasKey(e => new { e.ObjectName, e.Owner })
                    .HasName("DUMMY_PK");

                entity.ToTable("DUMMY");

                entity.HasIndex(e => new { e.ObjectName, e.Owner })
                    .HasName("DUMMY_PK")
                    .IsUnique();

                entity.Property(e => e.ObjectName)
                    .HasColumnName("OBJECT_NAME")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.Owner)
                    .HasColumnName("OWNER")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("DATE");

                entity.Property(e => e.DataObjectId)
                    .HasColumnName("DATA_OBJECT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EditionName)
                    .HasColumnName("EDITION_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Generated)
                    .HasColumnName("GENERATED")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.LastDdlTime)
                    .HasColumnName("LAST_DDL_TIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Namespace)
                    .HasColumnName("NAMESPACE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("OBJECT_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ObjectType)
                    .HasColumnName("OBJECT_TYPE")
                    .HasColumnType("VARCHAR2(19)");

                entity.Property(e => e.Secondary)
                    .HasColumnName("SECONDARY")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("VARCHAR2(7)");

                entity.Property(e => e.SubobjectName)
                    .HasColumnName("SUBOBJECT_NAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Temporary)
                    .HasColumnName("TEMPORARY")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("VARCHAR2(19)");
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.HasKey(e => e.EmergencyContactRecordNo);

                entity.ToTable("EMERGENCY_CONTACT");

                entity.HasIndex(e => e.EmergencyContactRecordNo)
                    .HasName("PK_EMERGENCY_CONTACT")
                    .IsUnique();

                entity.Property(e => e.EmergencyContactRecordNo)
                    .HasColumnName("EMERGENCY_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmergencyContactRecordNm)
                    .HasColumnName("EMERGENCY_CONTACT_RECORD_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FamilyRelationCodeRecordNo)
                    .HasColumnName("FAMILY_RELATION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EmergencyContactDetail>(entity =>
            {
                entity.HasKey(e => e.EcDetailRecordNo);

                entity.ToTable("EMERGENCY_CONTACT_DETAIL");

                entity.HasIndex(e => e.EcDetailRecordNo)
                    .HasName("PK_EMERGENCY_CONTACT_DETAIL")
                    .IsUnique();

                entity.HasIndex(e => e.EmergencyContactRecordNo)
                    .HasName("SK_EMERGENCY_CONTACT_RECORD_NO");

                entity.Property(e => e.EcDetailRecordNo)
                    .HasColumnName("EC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmergencyContactRecordNo)
                    .HasColumnName("EMERGENCY_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EsbMessages>(entity =>
            {
                entity.HasKey(e => e.EsbMessageRecordNo)
                    .HasName("ESB_MESSAGES_PK");

                entity.ToTable("ESB_MESSAGES");

                entity.HasIndex(e => e.EsbMessageRecordNo)
                    .HasName("ESB_MESSAGES_PK")
                    .IsUnique();

                entity.Property(e => e.EsbMessageRecordNo)
                    .HasColumnName("ESB_MESSAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.JmsQueue)
                    .IsRequired()
                    .HasColumnName("JMS_QUEUE")
                    .HasColumnType("VARCHAR2(128)")
                    .HasDefaultValueSql("'TibcoJMSRASubcontext/Queues/x.esb.queue.xml.pub.ern.event.producer.v1' ");

                entity.Property(e => e.MessageTime)
                    .HasColumnName("MESSAGE_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .HasDefaultValueSql("SYSTIMESTAMP");

                entity.Property(e => e.ServiceName)
                    .HasColumnName("SERVICE_NAME")
                    .HasColumnType("VARCHAR2(255)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ServiceParameters)
                    .HasColumnName("SERVICE_PARAMETERS")
                    .HasColumnType("VARCHAR2(4000)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EslStudentHistorical>(entity =>
            {
                entity.HasKey(e => e.EslStudentHistRecordNo)
                    .HasName("SYS_C0078161");

                entity.ToTable("ESL_STUDENT_HISTORICAL");

                entity.HasIndex(e => e.EslPhaseRecordNo)
                    .HasName("INDEX_2");

                entity.HasIndex(e => e.EslStudentHistRecordNo)
                    .HasName("SYS_C0078161")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("INDEX_1");

                entity.Property(e => e.EslStudentHistRecordNo)
                    .HasColumnName("ESL_STUDENT_HIST_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EslAssessmentInd)
                    .HasColumnName("ESL_ASSESSMENT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EslPhaseRecordNo)
                    .HasColumnName("ESL_PHASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LastEslAssessmentDate)
                    .HasColumnName("LAST_ESL_ASSESSMENT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<FactorOfNeed>(entity =>
            {
                entity.HasKey(e => e.FactorOfNeedRecordNo);

                entity.ToTable("FACTOR_OF_NEED");

                entity.HasIndex(e => e.FactorOfNeedRecordNo)
                    .HasName("PK_FACTOR_OF_NEED")
                    .IsUnique();

                entity.Property(e => e.FactorOfNeedRecordNo)
                    .HasColumnName("FACTOR_OF_NEED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FactorOfNeedValue)
                    .HasColumnName("FACTOR_OF_NEED_VALUE")
                    .HasColumnType("NUMBER(38,3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SspInd)
                    .IsRequired()
                    .HasColumnName("SSP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FactorOfNeedTemp>(entity =>
            {
                entity.HasKey(e => e.FactorOfNeedTempRecordNo);

                entity.ToTable("FACTOR_OF_NEED_TEMP");

                entity.HasIndex(e => e.FactorOfNeedTempRecordNo)
                    .HasName("PK_FACTOR_OF_NEED_TEMP")
                    .IsUnique();

                entity.Property(e => e.FactorOfNeedTempRecordNo)
                    .HasColumnName("FACTOR_OF_NEED_TEMP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CensusInd)
                    .IsRequired()
                    .HasColumnName("CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EnrolmentTypeNm)
                    .IsRequired()
                    .HasColumnName("ENROLMENT_TYPE_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("ERROR_CODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FactorOfNeedValue)
                    .HasColumnName("FACTOR_OF_NEED_VALUE")
                    .HasColumnType("NUMBER(38,3)");

                entity.Property(e => e.SchoolCode)
                    .IsRequired()
                    .HasColumnName("SCHOOL_CODE")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.HasKey(e => e.FamilyRecordNo);

                entity.ToTable("FAMILY");

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("PK_FAMILY")
                    .IsUnique();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilySalutation)
                    .IsRequired()
                    .HasColumnName("FAMILY_SALUTATION")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FamilyContact>(entity =>
            {
                entity.HasKey(e => e.FamilyContactRecordNo);

                entity.ToTable("FAMILY_CONTACT");

                entity.HasIndex(e => e.FamilyContactRecordNo)
                    .HasName("PK_FAMILY_CONTACT")
                    .IsUnique();

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SK_FAMILY_CONTACT");

                entity.Property(e => e.FamilyContactRecordNo)
                    .HasColumnName("FAMILY_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FamilyEvidence>(entity =>
            {
                entity.HasKey(e => e.FamilyEvidenceRecordNo);

                entity.ToTable("FAMILY_EVIDENCE");

                entity.HasIndex(e => e.FamilyEvidenceRecordNo)
                    .HasName("PK_FAMILY_EVIDENCE")
                    .IsUnique();

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SK_FAMILY_EVIDENCE");

                entity.Property(e => e.FamilyEvidenceRecordNo)
                    .HasColumnName("FAMILY_EVIDENCE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateSighted)
                    .HasColumnName("DATE_SIGHTED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceCategoryRecordNo)
                    .HasColumnName("EVIDENCE_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceTypeRecordNo)
                    .HasColumnName("EVIDENCE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerifiedStatusRecordNo)
                    .HasColumnName("VERIFIED_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FamilyNamesMaskingTmp>(entity =>
            {
                entity.HasKey(e => e.FamilyNamesRecNo)
                    .HasName("PK_FM_MASKING");

                entity.ToTable("FAMILY_NAMES_MASKING_TMP");

                entity.HasIndex(e => e.FamilyNamesRecNo)
                    .HasName("IDX_PK_FM_MASKING");

                entity.Property(e => e.FamilyNamesRecNo)
                    .HasColumnName("FAMILY_NAMES_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNamesNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NAMES_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FileRepository>(entity =>
            {
                entity.HasKey(e => e.FileRepositoryRecordNo);

                entity.ToTable("FILE_REPOSITORY");

                entity.HasIndex(e => e.FileRepositoryRecordNo)
                    .HasName("PK_FILE_REPOSITORY")
                    .IsUnique();

                entity.Property(e => e.FileRepositoryRecordNo)
                    .HasColumnName("FILE_REPOSITORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileRepositoryData)
                    .IsRequired()
                    .HasColumnName("FILE_REPOSITORY_DATA")
                    .HasColumnType("BLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileRepositoryNm)
                    .HasColumnName("FILE_REPOSITORY_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<FirstNamesMaskingTmp>(entity =>
            {
                entity.HasKey(e => e.FirstNamesRecNo)
                    .HasName("PK_FN_MASKING");

                entity.ToTable("FIRST_NAMES_MASKING_TMP");

                entity.HasIndex(e => e.FirstNamesRecNo)
                    .HasName("IDX_PK_FN_MASKING");

                entity.Property(e => e.FirstNamesRecNo)
                    .HasColumnName("FIRST_NAMES_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNamesNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NAMES_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<HarvestEvent>(entity =>
            {
                entity.HasKey(e => e.HarvestEventRecordNo)
                    .HasName("PK_HARVEST_EVENT_RECORD_NO");

                entity.ToTable("HARVEST_EVENT");

                entity.HasIndex(e => e.HarvestEventRecordNo)
                    .HasName("PK_HARVEST_EVENT_RECORD_NO")
                    .IsUnique();

                entity.Property(e => e.HarvestEventRecordNo)
                    .HasColumnName("HARVEST_EVENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveInd)
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.EnabledDate)
                    .HasColumnName("ENABLED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestEventCollection)
                    .HasColumnName("HARVEST_EVENT_COLLECTION")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestEventDate)
                    .HasColumnName("HARVEST_EVENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestEventNm)
                    .IsRequired()
                    .HasColumnName("HARVEST_EVENT_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestEventNotification)
                    .HasColumnName("HARVEST_EVENT_NOTIFICATION")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestTypeRecordNo)
                    .HasColumnName("HARVEST_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<HarvestEventSchool>(entity =>
            {
                entity.HasKey(e => e.HarvestEventSchoolRecordNo)
                    .HasName("HARVEST_EVENT_SCHOOL_PK");

                entity.ToTable("HARVEST_EVENT_SCHOOL");

                entity.HasIndex(e => e.HarvestEventSchoolRecordNo)
                    .HasName("HARVEST_EVENT_SCHOOL_PK")
                    .IsUnique();

                entity.Property(e => e.HarvestEventSchoolRecordNo)
                    .HasColumnName("HARVEST_EVENT_SCHOOL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestEventRecordNo)
                    .HasColumnName("HARVEST_EVENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolLevelCodeRecordNo)
                    .HasColumnName("SCHOOL_LEVEL_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<HarvestResponse>(entity =>
            {
                entity.HasKey(e => e.HarvestResponseRecordNo)
                    .HasName("PK_HARVEST_RESPONSE_RECORD_NO");

                entity.ToTable("HARVEST_RESPONSE");

                entity.HasIndex(e => e.HarvestResponseRecordNo)
                    .HasName("PK_HARVEST_RESPONSE_RECORD_NO")
                    .IsUnique();

                entity.HasIndex(e => e.OrganisationalUnitRecordNo)
                    .HasName("SK_HARVEST_RESPONSE");

                entity.Property(e => e.HarvestResponseRecordNo)
                    .HasColumnName("HARVEST_RESPONSE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestEventRecordNo)
                    .HasColumnName("HARVEST_EVENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HarvestResponseDate)
                    .HasColumnName("HARVEST_RESPONSE_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrganisationalUnitRecordNo)
                    .HasColumnName("ORGANISATIONAL_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<MedicalDocumentation>(entity =>
            {
                entity.HasKey(e => e.MedDocumentationRecordNo);

                entity.ToTable("MEDICAL_DOCUMENTATION");

                entity.HasIndex(e => e.FileRepositoryRecordNo)
                    .HasName("FK_MEDICAL_DOC_FILE_BANK");

                entity.HasIndex(e => e.MedDocumentationRecordNo)
                    .HasName("PK_MEDICAL_DOCUMENTATION")
                    .IsUnique();

                entity.Property(e => e.MedDocumentationRecordNo)
                    .HasColumnName("MED_DOCUMENTATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileRepositoryRecordNo)
                    .HasColumnName("FILE_REPOSITORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUserUpdate)
                    .IsRequired()
                    .HasColumnName("LAST_USER_UPDATE")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<OEPositionCode>(entity =>
            {
                entity.HasKey(e => e.OEPositionCodeRecordNo);

                entity.ToTable("O_E_POSITION_CODE");

                entity.HasIndex(e => e.OEPositionCode1)
                    .HasName("SK_O_E_POSITION_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OEPositionCodeRecordNo)
                    .HasName("PK_O_E_POSITION_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisXrefCode)
                    .HasName("IDX_O_E_POSITION_OASIS_XREF");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_O_E_POSITION_REPORTS_TO");

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.OEPositionNm })
                    .HasName("AK_O_E_POSITION_NM_ORG_UNIT")
                    .IsUnique();

                entity.Property(e => e.OEPositionCodeRecordNo)
                    .HasColumnName("O_E_POSITION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.OEPositionCode1)
                    .IsRequired()
                    .HasColumnName("O_E_POSITION_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OEPositionNm)
                    .IsRequired()
                    .HasColumnName("O_E_POSITION_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.OasisXrefCode)
                    .IsRequired()
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("999990 ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<OEResponsibCode>(entity =>
            {
                entity.HasKey(e => e.OEResponsibCodeRecordNo);

                entity.ToTable("O_E_RESPONSIB_CODE");

                entity.HasIndex(e => e.OEResponsibCode1)
                    .HasName("SK_O_E_RESPONSIB_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OEResponsibCodeRecordNo)
                    .HasName("PK_O_E_RESPONSIB_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisXrefCode)
                    .HasName("IDX_O_E_RESPONSIB_OASIS_XREF");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_O_E_RESPONSIB_REPORTS_TO");

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.OEResponsibNm })
                    .HasName("AK_O_E_RESPONSIB_NM_ORG_UNIT")
                    .IsUnique();

                entity.Property(e => e.OEResponsibCodeRecordNo)
                    .HasColumnName("O_E_RESPONSIB_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.OEResponsibCode1)
                    .IsRequired()
                    .HasColumnName("O_E_RESPONSIB_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OEResponsibNm)
                    .IsRequired()
                    .HasColumnName("O_E_RESPONSIB_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.OasisXrefCode)
                    .IsRequired()
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("999990 ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<OESchRoleCode>(entity =>
            {
                entity.HasKey(e => e.OESchRoleCodeRecordNo);

                entity.ToTable("O_E_SCH_ROLE_CODE");

                entity.HasIndex(e => e.OESchRoleCode1)
                    .HasName("SK_O_E_SCH_ROLE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OESchRoleCodeRecordNo)
                    .HasName("PK_O_E_SCH_ROLE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisXrefCode)
                    .HasName("IDX_O_E_SCH_ROLE_OASIS_XREF");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_O_E_SCH_ROLE_REPORTS_TO");

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.OESchRoleNm })
                    .HasName("AK_O_E_SCH_ROLE_NM_ORG_UNIT")
                    .IsUnique();

                entity.Property(e => e.OESchRoleCodeRecordNo)
                    .HasColumnName("O_E_SCH_ROLE_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.OESchRoleCode1)
                    .IsRequired()
                    .HasColumnName("O_E_SCH_ROLE_CODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.OESchRoleNm)
                    .IsRequired()
                    .HasColumnName("O_E_SCH_ROLE_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.OasisXrefCode)
                    .IsRequired()
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("999990 ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<ORCleanareaCode>(entity =>
            {
                entity.HasKey(e => e.ORCleanareaCodeRecordNo);

                entity.ToTable("O_R_CLEANAREA_CODE");

                entity.HasIndex(e => e.ORCleanareaCode1)
                    .HasName("SK_O_R_CLEANAREA_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.ORCleanareaCodeRecordNo)
                    .HasName("PK_O_R_CLEANAREA_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisXrefCode)
                    .HasName("IDX_O_R_CLEANAREA_OASIS_XREF");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_O_R_CLEANAREA_REPORTS_TO");

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.ORCleanareaNm })
                    .HasName("AK_O_R_CLEANAREA_NM_ORG_UNIT")
                    .IsUnique();

                entity.Property(e => e.ORCleanareaCodeRecordNo)
                    .HasColumnName("O_R_CLEANAREA_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.ORCleanareaCode1)
                    .IsRequired()
                    .HasColumnName("O_R_CLEANAREA_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ORCleanareaNm)
                    .IsRequired()
                    .HasColumnName("O_R_CLEANAREA_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.OasisXrefCode)
                    .IsRequired()
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("999990 ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<ORFloorcovType>(entity =>
            {
                entity.HasKey(e => e.ORFloorcovTypeRecordNo);

                entity.ToTable("O_R_FLOORCOV_TYPE");

                entity.HasIndex(e => e.ORFloorcovTypeCode)
                    .HasName("SK_O_R_FLOORCOV_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.ORFloorcovTypeRecordNo)
                    .HasName("PK_O_R_FLOORCOV_TYPE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisXrefCode)
                    .HasName("IDX_O_R_FLOORCOV_OASIS_XREF");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_O_R_FLOORCOV_REPORTS_TO");

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.ORFloorcovTypeNm })
                    .HasName("AK_O_R_FLOORCOV_NM_ORG_UNIT")
                    .IsUnique();

                entity.Property(e => e.ORFloorcovTypeRecordNo)
                    .HasColumnName("O_R_FLOORCOV_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.ORFloorcovTypeCode)
                    .IsRequired()
                    .HasColumnName("O_R_FLOORCOV_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ORFloorcovTypeNm)
                    .IsRequired()
                    .HasColumnName("O_R_FLOORCOV_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.OasisXrefCode)
                    .IsRequired()
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("999990 ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<ORRoomType>(entity =>
            {
                entity.HasKey(e => e.ORRoomTypeRecordNo);

                entity.ToTable("O_R_ROOM_TYPE");

                entity.HasIndex(e => e.ORRoomTypeCode)
                    .HasName("SK_O_R_ROOM_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.ORRoomTypeRecordNo)
                    .HasName("PK_O_R_ROOM_TYPE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisXrefCode)
                    .HasName("IDX_O_R_ROOM_OASIS_XREF");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_O_R_ROOM_REPORTS_TO");

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.ORRoomTypeNm })
                    .HasName("AK_O_R_ROOM_NM_ORG_UNIT")
                    .IsUnique();

                entity.Property(e => e.ORRoomTypeRecordNo)
                    .HasColumnName("O_R_ROOM_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999' ");

                entity.Property(e => e.ORRoomTypeCode)
                    .IsRequired()
                    .HasColumnName("O_R_ROOM_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ORRoomTypeNm)
                    .IsRequired()
                    .HasColumnName("O_R_ROOM_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.OasisXrefCode)
                    .IsRequired()
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'V' ");

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("999990 ");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<OStudentSupport>(entity =>
            {
                entity.HasKey(e => e.OStudentSupportRecordNo);

                entity.ToTable("O_STUDENT_SUPPORT");

                entity.HasIndex(e => e.OStudentSupportRecordNo)
                    .HasName("PK_O_STUDENT_SUPPORT")
                    .IsUnique();

                entity.HasIndex(e => e.SupDelCodeRecordNo)
                    .HasName("FK_O_STUDENT_DELIVERY_CODE");

                entity.HasIndex(e => e.SupSerCodeRecordNo)
                    .HasName("FK_O_STUDENT_SUPPORT_CODE");

                entity.HasIndex(e => new { e.StudentRecordNo, e.OStudentSupportRecordNo })
                    .HasName("SK_O_STUDENT_SUPPORT")
                    .IsUnique();

                entity.Property(e => e.OStudentSupportRecordNo)
                    .HasColumnName("O_STUDENT_SUPPORT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SupDelCodeRecordNo)
                    .HasColumnName("SUP_DEL_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SupSerCodeRecordNo)
                    .HasColumnName("SUP_SER_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<OasisIclassXrefSgo>(entity =>
            {
                entity.HasKey(e => e.SgOfferRecordNo)
                    .HasName("PK_OASIS_ICLASS_XREF_CO");

                entity.ToTable("OASIS_ICLASS_XREF_SGO");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("PK_OASIS_ICLASS_XREF_CO")
                    .IsUnique();

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Orecno).HasColumnName("ORECNO");
            });

            modelBuilder.Entity<OasisIcourseXrefCo>(entity =>
            {
                entity.HasKey(e => e.CurriculumOfferRecordNo);

                entity.ToTable("OASIS_ICOURSE_XREF_CO");

                entity.HasIndex(e => e.CurriculumOfferRecordNo)
                    .HasName("PK_OASIS_ICOURSE_XREF_CO")
                    .IsUnique();

                entity.Property(e => e.CurriculumOfferRecordNo)
                    .HasColumnName("CURRICULUM_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Orecno).HasColumnName("ORECNO");
            });

            modelBuilder.Entity<OasisReport>(entity =>
            {
                entity.HasKey(e => e.OasisReportRecordNo);

                entity.ToTable("OASIS_REPORT");

                entity.HasIndex(e => e.OasisReportRecordNo)
                    .HasName("PK_OASIS_REPORT")
                    .IsUnique();

                entity.Property(e => e.OasisReportRecordNo)
                    .HasColumnName("OASIS_REPORT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReportCommand)
                    .HasColumnName("REPORT_COMMAND")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.ReportHeader)
                    .HasColumnName("REPORT_HEADER")
                    .HasColumnType("VARCHAR2(1000)");

                entity.Property(e => e.ReportName)
                    .HasColumnName("REPORT_NAME")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.ReportQuery)
                    .HasColumnName("REPORT_QUERY")
                    .HasColumnType("VARCHAR2(4000)");

                entity.Property(e => e.ReportTaskId)
                    .HasColumnName("REPORT_TASK_ID")
                    .HasColumnType("VARCHAR2(1000)");
            });

            modelBuilder.Entity<OasisSchool>(entity =>
            {
                entity.HasKey(e => e.Oschoolcode);

                entity.ToTable("OASIS_SCHOOL");

                entity.HasIndex(e => e.Oschoolcode)
                    .HasName("PK_OASIS_SCHOOL")
                    .IsUnique();

                entity.Property(e => e.Oschoolcode)
                    .HasColumnName("OSCHOOLCODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolCode)
                    .HasColumnName("SCHOOL_CODE")
                    .HasColumnType("VARCHAR2(8)");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.HasKey(e => e.ParentRecordNo);

                entity.ToTable("PARENT");

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SK_PARENT");

                entity.HasIndex(e => e.IsAliveInd)
                    .HasName("TMP_IS_ALIVE_IND");

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("PK_PARENT")
                    .IsUnique();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER(16)");

                entity.Property(e => e.AtsiCodeRecordNo)
                    .HasColumnName("ATSI_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CountryOfBirthRecordNo)
                    .HasColumnName("COUNTRY_OF_BIRTH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnglishAtHomeInd)
                    .IsRequired()
                    .HasColumnName("ENGLISH_AT_HOME_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderInd)
                    .IsRequired()
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.InterpreterRequiredInd)
                    .IsRequired()
                    .HasColumnName("INTERPRETER_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAliveInd)
                    .HasColumnName("IS_ALIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.NameSalutationCodeRecordNo)
                    .HasColumnName("NAME_SALUTATION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OccupationNm)
                    .HasColumnName("OCCUPATION_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OgTypeRecordNo)
                    .HasColumnName("OG_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFamilyNm)
                    .IsRequired()
                    .HasColumnName("PREF_FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFirstNm)
                    .IsRequired()
                    .HasColumnName("PREF_FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PseRecordNo)
                    .HasColumnName("PSE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PteRecordNo)
                    .HasColumnName("PTE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentAddress>(entity =>
            {
                entity.HasKey(e => e.ParentAddressRecordNo);

                entity.ToTable("PARENT_ADDRESS");

                entity.HasIndex(e => e.ParentAddressRecordNo)
                    .HasName("PK_PARENT_ADDRESS")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SK_PARENT_ADDRESS");

                entity.Property(e => e.ParentAddressRecordNo)
                    .HasColumnName("PARENT_ADDRESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressDetailRecordNo)
                    .HasColumnName("ADDRESS_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeRecordNo)
                    .HasColumnName("ADDRESS_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentBkup>(entity =>
            {
                entity.HasKey(e => e.ParentRecordNo);

                entity.ToTable("PARENT_BKUP");

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SK_PARENT_BKUP");

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("PK_PARENT_BKUP")
                    .IsUnique();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirthRecordNo)
                    .HasColumnName("COUNTRY_OF_BIRTH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnglishAtHomeInd)
                    .IsRequired()
                    .HasColumnName("ENGLISH_AT_HOME_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderInd)
                    .IsRequired()
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.InterpreterRequiredInd)
                    .IsRequired()
                    .HasColumnName("INTERPRETER_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameSalutationCodeRecordNo)
                    .HasColumnName("NAME_SALUTATION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OccupationNm)
                    .HasColumnName("OCCUPATION_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OgTypeRecordNo)
                    .HasColumnName("OG_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFamilyNm)
                    .IsRequired()
                    .HasColumnName("PREF_FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFirstNm)
                    .IsRequired()
                    .HasColumnName("PREF_FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PseRecordNo)
                    .HasColumnName("PSE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PteRecordNo)
                    .HasColumnName("PTE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentContact>(entity =>
            {
                entity.HasKey(e => e.ParentContactRecordNo);

                entity.ToTable("PARENT_CONTACT");

                entity.HasIndex(e => e.ContactDetailRecordNo)
                    .HasName("CONTACT_DETAIL_RECORD_NO");

                entity.HasIndex(e => e.ParentContactRecordNo)
                    .HasName("PK_PARENT_CONTACT")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SK_PARENT_CONTACT");

                entity.Property(e => e.ParentContactRecordNo)
                    .HasColumnName("PARENT_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentEvidence>(entity =>
            {
                entity.HasKey(e => e.ParentEvidenceRecordNo);

                entity.ToTable("PARENT_EVIDENCE");

                entity.HasIndex(e => e.ParentEvidenceRecordNo)
                    .HasName("PK_PARENT_EVIDENCE")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SK_PARENT_EVIDENCE");

                entity.Property(e => e.ParentEvidenceRecordNo)
                    .HasColumnName("PARENT_EVIDENCE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateSighted)
                    .HasColumnName("DATE_SIGHTED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceCategoryRecordNo)
                    .HasColumnName("EVIDENCE_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceTypeRecordNo)
                    .HasColumnName("EVIDENCE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerifiedStatusRecordNo)
                    .HasColumnName("VERIFIED_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentLanguage>(entity =>
            {
                entity.HasKey(e => e.ParentLanguageRecordNo);

                entity.ToTable("PARENT_LANGUAGE");

                entity.HasIndex(e => e.ParentLanguageRecordNo)
                    .HasName("PK_PARENT_LANGUAGE")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SK_PARENT_LANGUAGE");

                entity.Property(e => e.ParentLanguageRecordNo)
                    .HasColumnName("PARENT_LANGUAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageCodeRecordNo)
                    .HasColumnName("LANGUAGE_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentLanguageCodeInd)
                    .IsRequired()
                    .HasColumnName("PARENT_LANGUAGE_CODE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentRelationship>(entity =>
            {
                entity.HasKey(e => e.ParentRelationshipRecordNo);

                entity.ToTable("PARENT_RELATIONSHIP");

                entity.HasIndex(e => e.EnrolmentOwnerInd)
                    .HasName("TMP_ENROLMENT_OWNER_IND");

                entity.HasIndex(e => e.FamilyRelationCodeRecordNo)
                    .HasName("SK_PARENT_RELATIONSHIP");

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SK2_PARENT_RELATIONSHIP");

                entity.HasIndex(e => e.ParentRelationshipRecordNo)
                    .HasName("PK_PARENT_RELATIONSHIP")
                    .IsUnique();

                entity.HasIndex(e => e.ReceiveInvoiceInd)
                    .HasName("TMP_RECEIVE_INVOICE_IND");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK1_PARENT_RELATIONSHIP");

                entity.Property(e => e.ParentRelationshipRecordNo)
                    .HasColumnName("PARENT_RELATIONSHIP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.BsaInd)
                    .IsRequired()
                    .HasColumnName("BSA_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustodyInd)
                    .IsRequired()
                    .HasColumnName("CUSTODY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentOwnerInd)
                    .IsRequired()
                    .HasColumnName("ENROLMENT_OWNER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRelationCodeRecordNo)
                    .HasColumnName("FAMILY_RELATION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasrFirstDeleteWarningDate)
                    .HasColumnName("OASR_FIRST_DELETE_WARNING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasrSecndDeleteWarningDate)
                    .HasColumnName("OASR_SECND_DELETE_WARNING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OnlineAcademicReportInd)
                    .IsRequired()
                    .HasColumnName("ONLINE_ACADEMIC_REPORT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X' ");

                entity.Property(e => e.OnlineReportNotificationInd)
                    .IsRequired()
                    .HasColumnName("ONLINE_REPORT_NOTIFICATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.OohcInd)
                    .HasColumnName("OOHC_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReceiveAcademicReportInd)
                    .IsRequired()
                    .HasColumnName("RECEIVE_ACADEMIC_REPORT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReceiveInvoiceInd)
                    .HasColumnName("RECEIVE_INVOICE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatementOfAccTypeRecNo)
                    .HasColumnName("STATEMENT_OF_ACC_TYPE_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ParentStudentDossier>(entity =>
            {
                entity.HasKey(e => e.ParentStuDossierRecordNo);

                entity.ToTable("PARENT_STUDENT_DOSSIER");

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SK2_PARENT_STUDENT_DOSSIER");

                entity.HasIndex(e => e.ParentStuDossierRecordNo)
                    .HasName("PK_PARENT_STUDENT_DOSSIER")
                    .IsUnique();

                entity.HasIndex(e => new { e.DossierRecordNo, e.StudentRecordNo })
                    .HasName("INDEX1");

                entity.Property(e => e.ParentStuDossierRecordNo)
                    .HasColumnName("PARENT_STU_DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<PickupContact>(entity =>
            {
                entity.HasKey(e => e.PickupContactRecordNo);

                entity.ToTable("PICKUP_CONTACT");

                entity.HasIndex(e => e.PickupContactRecordNo)
                    .HasName("PK_PICKUP_CONTACT")
                    .IsUnique();

                entity.Property(e => e.PickupContactRecordNo)
                    .HasColumnName("PICKUP_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentPickupRecordNo)
                    .HasColumnName("STUDENT_PICKUP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<PlaceType>(entity =>
            {
                entity.HasKey(e => e.PlaceTypeRecordNo)
                    .HasName("PK_PLACE_TYPES");

                entity.ToTable("PLACE_TYPE");

                entity.HasIndex(e => e.PlaceTypeCode)
                    .HasName("SK_PLACE_TYPES")
                    .IsUnique();

                entity.HasIndex(e => e.PlaceTypeRecordNo)
                    .HasName("PK_PLACE_TYPES")
                    .IsUnique();

                entity.Property(e => e.PlaceTypeRecordNo)
                    .HasColumnName("PLACE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveInd)
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PlaceTypeCode)
                    .IsRequired()
                    .HasColumnName("PLACE_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PlaceTypeNm)
                    .IsRequired()
                    .HasColumnName("PLACE_TYPE_NM")
                    .HasColumnType("VARCHAR2(32)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RegSupportStrategy>(entity =>
            {
                entity.HasKey(e => e.RegSupportStrategyRecordNo);

                entity.ToTable("REG_SUPPORT_STRATEGY");

                entity.HasIndex(e => e.RegSupportStrategyRecordNo)
                    .HasName("PK_REG_SUPPORT_STRATEGY")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("SK_REG_SUPPORT_STRATEGY");

                entity.Property(e => e.RegSupportStrategyRecordNo)
                    .HasColumnName("REG_SUPPORT_STRATEGY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SupportStrategyRecordNo)
                    .HasColumnName("SUPPORT_STRATEGY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegistrationRecordNo);

                entity.ToTable("REGISTRATION");

                entity.HasIndex(e => e.FamilyAddressRecordNo)
                    .HasName("REG_FAM_ADDRE_RE_TEMP");

                entity.HasIndex(e => e.RegistrationOfferRecordNo)
                    .HasName("SK1_REGISTRATION");

                entity.HasIndex(e => e.RegistrationRecordNo)
                    .HasName("PK_REGISTRATION")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_REGISTRATION");

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("SK2_REGISTRATION");

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("ACTUAL_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.BehaviourMgmtPlanOtherInd)
                    .HasColumnName("BEHAVIOUR_MGMT_PLAN_OTHER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.CensusInd)
                    .HasColumnName("CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CentrelinkFundingInd)
                    .HasColumnName("CENTRELINK_FUNDING_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.CommunicationDocmentPlanInd)
                    .HasColumnName("COMMUNICATION_DOCMENT_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.ConsultationParentsCondInd)
                    .HasColumnName("CONSULTATION_PARENTS_COND_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.DistanceEdInd)
                    .HasColumnName("DISTANCE_ED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocumentedPlspInd)
                    .HasColumnName("DOCUMENTED_PLSP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.DocumentedPlspRequiredInd)
                    .HasColumnName("DOCUMENTED_PLSP_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.EbsPrevRegStatusRecordNo)
                    .HasColumnName("EBS_PREV_REG_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmergencyResponsePlanInd)
                    .HasColumnName("EMERGENCY_RESPONSE_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.EnrolInterviewCondInd)
                    .HasColumnName("ENROL_INTERVIEW_COND_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.FactorOfNeedRecordNo)
                    .HasColumnName("FACTOR_OF_NEED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyAddressRecordNo)
                    .HasColumnName("FAMILY_ADDRESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FoundDate)
                    .HasColumnName("FOUND_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FundingIntegrationInd)
                    .HasColumnName("FUNDING_INTEGRATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.InZoneInd)
                    .HasColumnName("IN_ZONE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IndividualHlthCarePlanInd)
                    .HasColumnName("INDIVIDUAL_HLTH_CARE_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.IntendedStartDate)
                    .HasColumnName("INTENDED_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeavingDate)
                    .HasColumnName("LEAVING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissingDate)
                    .HasColumnName("MISSING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferenceNo)
                    .HasColumnName("PREFERENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrincipalDeclarationDate)
                    .HasColumnName("PRINCIPAL_DECLARATION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrincipalSignedInd)
                    .HasColumnName("PRINCIPAL_SIGNED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrivateSchoolInd)
                    .HasColumnName("PRIVATE_SCHOOL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RankNo)
                    .HasColumnName("RANK_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReadingRecoveryInd)
                    .HasColumnName("READING_RECOVERY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RegistrationOfferRecordNo)
                    .HasColumnName("REGISTRATION_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationSource)
                    .HasColumnName("REGISTRATION_SOURCE")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationStatusRecordNo)
                    .HasColumnName("REGISTRATION_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RiskAssessedInd)
                    .HasColumnName("RISK_ASSESSED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RiskAssessmentRequiredInd)
                    .HasColumnName("RISK_ASSESSMENT_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RiskManagementPlanInd)
                    .HasColumnName("RISK_MANAGEMENT_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SecondStudentDeclareDate)
                    .HasColumnName("SECOND_STUDENT_DECLARE_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SecondStudentDeclareInd)
                    .HasColumnName("SECOND_STUDENT_DECLARE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentDeclarationDate)
                    .HasColumnName("STUDENT_DECLARATION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentDeclarationInd)
                    .HasColumnName("STUDENT_DECLARATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentHistoryAssessedInd)
                    .HasColumnName("STUDENT_HISTORY_ASSESSED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RegistrationDmt>(entity =>
            {
                entity.HasKey(e => e.RegistrationRecordNo);

                entity.ToTable("REGISTRATION_DMT");

                entity.HasIndex(e => e.RegistrationRecordNo)
                    .HasName("PK_REGISTRATION_DMT")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_REGISTRATION_DMT");

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("ACTUAL_START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.CensusInd)
                    .HasColumnName("CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.CentrelinkFundingInd)
                    .HasColumnName("CENTRELINK_FUNDING_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DistanceEdInd)
                    .HasColumnName("DISTANCE_ED_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EbsPrevRegStatusRecordNo)
                    .HasColumnName("EBS_PREV_REG_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FactorOfNeedRecordNo)
                    .HasColumnName("FACTOR_OF_NEED_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FamilyAddressRecordNo)
                    .HasColumnName("FAMILY_ADDRESS_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FoundDate)
                    .HasColumnName("FOUND_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.FundingIntegrationInd)
                    .HasColumnName("FUNDING_INTEGRATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.InZoneInd)
                    .HasColumnName("IN_ZONE_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.IntendedStartDate)
                    .HasColumnName("INTENDED_START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.LeavingDate)
                    .HasColumnName("LEAVING_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.MissingDate)
                    .HasColumnName("MISSING_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.PreferenceNo)
                    .HasColumnName("PREFERENCE_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PrincipalDeclarationDate)
                    .HasColumnName("PRINCIPAL_DECLARATION_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.PrincipalSignedInd)
                    .HasColumnName("PRINCIPAL_SIGNED_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.PrivateSchoolInd)
                    .HasColumnName("PRIVATE_SCHOOL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RankNo)
                    .HasColumnName("RANK_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ReadingRecoveryInd)
                    .HasColumnName("READING_RECOVERY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.RegistrationOfferRecordNo)
                    .HasColumnName("REGISTRATION_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RegistrationStatusRecordNo)
                    .HasColumnName("REGISTRATION_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RiskAssessedInd)
                    .HasColumnName("RISK_ASSESSED_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.RiskAssessmentRequiredInd)
                    .HasColumnName("RISK_ASSESSMENT_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.RiskManagementPlanInd)
                    .HasColumnName("RISK_MANAGEMENT_PLAN_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SecondStudentDeclareDate)
                    .HasColumnName("SECOND_STUDENT_DECLARE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.SecondStudentDeclareInd)
                    .HasColumnName("SECOND_STUDENT_DECLARE_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.StudentDeclarationDate)
                    .HasColumnName("STUDENT_DECLARATION_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.StudentDeclarationInd)
                    .HasColumnName("STUDENT_DECLARATION_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.StudentHistoryAssessedInd)
                    .HasColumnName("STUDENT_HISTORY_ASSESSED_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<RegistrationIntake>(entity =>
            {
                entity.HasKey(e => e.RegistrationIntakeRecordNo);

                entity.ToTable("REGISTRATION_INTAKE");

                entity.HasIndex(e => e.RegistrationIntakeRecordNo)
                    .HasName("PK_REGISTRATION_INTAKE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("SK_REGISTRATION_INTAKE")
                    .IsUnique();

                entity.Property(e => e.RegistrationIntakeRecordNo)
                    .HasColumnName("REGISTRATION_INTAKE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstAustEnrolDate)
                    .HasColumnName("FIRST_AUST_ENROL_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntakeTypeInd)
                    .HasColumnName("INTAKE_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousOrgUnitRecordNo)
                    .HasColumnName("PREVIOUS_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousSchoolLocation)
                    .HasColumnName("PREVIOUS_SCHOOL_LOCATION")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousSchoolNm)
                    .HasColumnName("PREVIOUS_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscTypeRecordNo)
                    .HasColumnName("PSC_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscWhoursTypeRecordNo)
                    .HasColumnName("PSC_WHOURS_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolType)
                    .IsRequired()
                    .HasColumnName("SCHOOL_TYPE")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X' ");

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToYearAttendedDesc)
                    .HasColumnName("TO_YEAR_ATTENDED_DESC")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToYearAttendedDescOld)
                    .HasColumnName("TO_YEAR_ATTENDED_DESC_OLD")
                    .HasColumnType("VARCHAR2(64)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.YearAttendedDesc)
                    .HasColumnName("YEAR_ATTENDED_DESC")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.YearAttendedDescOld)
                    .HasColumnName("YEAR_ATTENDED_DESC_OLD")
                    .HasColumnType("VARCHAR2(64)");
            });

            modelBuilder.Entity<RegistrationLeavingReasonO>(entity =>
            {
                entity.HasKey(e => e.RegistrationLeavingRecordNo)
                    .HasName("PK_REGISTRATION_LEAVING_REASON");

                entity.ToTable("REGISTRATION_LEAVING_REASON_O");

                entity.HasIndex(e => e.RegistrationLeavingRecordNo)
                    .HasName("PK_REGISTRATION_LEAVING_REASON")
                    .IsUnique();

                entity.Property(e => e.RegistrationLeavingRecordNo)
                    .HasColumnName("REGISTRATION_LEAVING_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaverReasonNm)
                    .HasColumnName("LEAVER_REASON_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaverReasonRecordNo)
                    .HasColumnName("LEAVER_REASON_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RegistrationOffer>(entity =>
            {
                entity.HasKey(e => e.RegistrationOfferRecordNo);

                entity.ToTable("REGISTRATION_OFFER");

                entity.HasIndex(e => e.CalendarYear)
                    .HasName("REGISTRATION_OFFER_DBAIX1");

                entity.HasIndex(e => e.RegistrationOfferRecordNo)
                    .HasName("PK_REGISTRATION_OFFER")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrgUnitRecordNo, e.CalendarYear, e.SyCodeRecordNo })
                    .HasName("SK_REGISTRATION_OFFER");

                entity.Property(e => e.RegistrationOfferRecordNo)
                    .HasColumnName("REGISTRATION_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalendarYear)
                    .HasColumnName("CALENDAR_YEAR")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentPlaces)
                    .HasColumnName("CURRENT_PLACES")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentPlacesFactorOfNeed)
                    .HasColumnName("CURRENT_PLACES_FACTOR_OF_NEED")
                    .HasColumnType("NUMBER(6,3)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.CurrentPlacesNonCensus)
                    .HasColumnName("CURRENT_PLACES_NON_CENSUS")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FeedFromThisYearInd)
                    .HasColumnName("FEED_FROM_THIS_YEAR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FundingIntegrationCount)
                    .HasColumnName("FUNDING_INTEGRATION_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MaxPlaces)
                    .HasColumnName("MAX_PLACES")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfferingStatusRecordNo)
                    .HasColumnName("OFFERING_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationOfferFee)
                    .HasColumnName("REGISTRATION_OFFER_FEE")
                    .HasColumnType("NUMBER(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.RegistrationOfferNm)
                    .IsRequired()
                    .HasColumnName("REGISTRATION_OFFER_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RegistrationOfferTemp>(entity =>
            {
                entity.HasKey(e => e.RegistrationOfferRecordNo);

                entity.ToTable("REGISTRATION_OFFER_TEMP");

                entity.HasIndex(e => e.RegistrationOfferRecordNo)
                    .HasName("PK_REGISTRATION_OFFER_TEMP")
                    .IsUnique();

                entity.Property(e => e.RegistrationOfferRecordNo)
                    .HasColumnName("REGISTRATION_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CalendarYear)
                    .HasColumnName("CALENDAR_YEAR")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CurrentPlaces)
                    .HasColumnName("CURRENT_PLACES")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FeedFromThisYearInd)
                    .HasColumnName("FEED_FROM_THIS_YEAR_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.FundingIntegrationCount)
                    .HasColumnName("FUNDING_INTEGRATION_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.MaxPlaces)
                    .HasColumnName("MAX_PLACES")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OfferingStatusRecordNo)
                    .HasColumnName("OFFERING_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RegistrationOfferFee)
                    .HasColumnName("REGISTRATION_OFFER_FEE")
                    .HasColumnType("NUMBER(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.RegistrationOfferNm)
                    .IsRequired()
                    .HasColumnName("REGISTRATION_OFFER_NM")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<RegnEvidence>(entity =>
            {
                entity.HasKey(e => e.RegnEvidenceRecordNo);

                entity.ToTable("REGN_EVIDENCE");

                entity.HasIndex(e => e.RegnEvidenceRecordNo)
                    .HasName("PK_REGN_EVIDENCE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("SK_REGN_EVIDENCE")
                    .IsUnique();

                entity.Property(e => e.RegnEvidenceRecordNo)
                    .HasColumnName("REGN_EVIDENCE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateSighted)
                    .HasColumnName("DATE_SIGHTED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceCategoryRecordNo)
                    .HasColumnName("EVIDENCE_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceTypeRecordNo)
                    .HasColumnName("EVIDENCE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerifiedStatusRecordNo)
                    .HasColumnName("VERIFIED_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RegnSchoolSupport>(entity =>
            {
                entity.HasKey(e => e.RegnSchoolSupportRecordNo);

                entity.ToTable("REGN_SCHOOL_SUPPORT");

                entity.HasIndex(e => e.RegnSchoolSupportRecordNo)
                    .HasName("PK_REGN_SCHOOL_SUPPORT")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("SK_REGN_SCHOOL_SUPPORT");

                entity.Property(e => e.RegnSchoolSupportRecordNo)
                    .HasColumnName("REGN_SCHOOL_SUPPORT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousSchoolSupportInd)
                    .IsRequired()
                    .HasColumnName("PREVIOUS_SCHOOL_SUPPORT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolSupportNm)
                    .HasColumnName("SCHOOL_SUPPORT_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolSupportRecordNo)
                    .HasColumnName("SCHOOL_SUPPORT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RegnSpecialNeed>(entity =>
            {
                entity.HasKey(e => e.RegnSpecialNeedRecordNo);

                entity.ToTable("REGN_SPECIAL_NEED");

                entity.HasIndex(e => e.RegnSpecialNeedRecordNo)
                    .HasName("PK_REGN_SPECIAL_NEED")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("SK_REGN_SPECIAL_NEED");

                entity.Property(e => e.RegnSpecialNeedRecordNo)
                    .HasColumnName("REGN_SPECIAL_NEED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityNm)
                    .HasColumnName("DISABILITY_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityRecordNo)
                    .HasColumnName("DISABILITY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<RequiredStudentDossierType>(entity =>
            {
                entity.HasKey(e => e.RsdTypeRecordNo)
                    .HasName("PK_RSD_TYPE");

                entity.ToTable("REQUIRED_STUDENT_DOSSIER_TYPE");

                entity.HasIndex(e => e.RsdTypeRecordNo)
                    .HasName("PK_RSD_TYPE")
                    .IsUnique();

                entity.Property(e => e.RsdTypeRecordNo)
                    .HasColumnName("RSD_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierTypeRecordNo)
                    .HasColumnName("DOSSIER_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SalmEsbMessages>(entity =>
            {
                entity.HasKey(e => e.SalmEsbMessageRecordNo)
                    .HasName("SALM_ESB_MESSAGES_PK");

                entity.ToTable("SALM_ESB_MESSAGES");

                entity.HasIndex(e => e.SalmEsbMessageRecordNo)
                    .HasName("SALM_ESB_MESSAGES_PK")
                    .IsUnique();

                entity.HasIndex(e => e.SepRecordNo)
                    .HasName("SALM_ESB_MESSAGES_IDX_1");

                entity.Property(e => e.SalmEsbMessageRecordNo)
                    .HasColumnName("SALM_ESB_MESSAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.JmsHeaders)
                    .HasColumnName("JMS_HEADERS")
                    .HasColumnType("VARCHAR2(2048)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageAuditTask)
                    .HasColumnName("MESSAGE_AUDIT_TASK")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageAuditUserName)
                    .HasColumnName("MESSAGE_AUDIT_USER_NAME")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageTime)
                    .HasColumnName("MESSAGE_TIME")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageType)
                    .HasColumnName("MESSAGE_TYPE")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SepRecordNo)
                    .HasColumnName("SEP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ServiceName)
                    .HasColumnName("SERVICE_NAME")
                    .HasColumnType("VARCHAR2(255)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SalmMigration>(entity =>
            {
                entity.HasKey(e => e.SalmMigrationRecordNo);

                entity.ToTable("SALM_MIGRATION");

                entity.HasIndex(e => e.SalmMigrationRecordNo)
                    .HasName("PK_SALM_MIGRATION")
                    .IsUnique();

                entity.Property(e => e.SalmMigrationRecordNo)
                    .HasColumnName("SALM_MIGRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageType)
                    .HasColumnName("MESSAGE_TYPE")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MigrationCount)
                    .HasColumnName("MIGRATION_COUNT")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SalmPublishMessageLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("SALM_PUBLISH_MESSAGE_LOG_PK");

                entity.ToTable("SALM_PUBLISH_MESSAGE_LOG");

                entity.HasIndex(e => e.LogId)
                    .HasName("SALM_PUBLISH_MESSAGE_LOG_PK")
                    .IsUnique();

                entity.Property(e => e.LogId)
                    .HasColumnName("LOG_ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.MessageText)
                    .HasColumnName("MESSAGE_TEXT")
                    .HasColumnType("VARCHAR2(4000)");

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.ProcessTime)
                    .HasColumnName("PROCESS_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .HasDefaultValueSql("sysdate");

                entity.Property(e => e.RequestBy)
                    .HasColumnName("REQUEST_BY")
                    .HasColumnType("VARCHAR2(152)");

                entity.Property(e => e.SystemFrom)
                    .HasColumnName("SYSTEM_FROM")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.TrackId)
                    .HasColumnName("TRACK_ID")
                    .HasColumnType("VARCHAR2(36)");
            });

            modelBuilder.Entity<ScasOfferCreate>(entity =>
            {
                entity.HasKey(e => new { e.ScasOrgUnitCode, e.ScasEnrolmentTypeCode })
                    .HasName("SCAS_OFFERCREATE_PK");

                entity.ToTable("SCAS_OFFER_CREATE");

                entity.HasIndex(e => new { e.ScasOrgUnitCode, e.ScasEnrolmentTypeCode })
                    .HasName("SCAS_OFFERCREATE_PK")
                    .IsUnique();

                entity.Property(e => e.ScasOrgUnitCode)
                    .HasColumnName("SCAS_ORG_UNIT_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ScasEnrolmentTypeCode)
                    .HasColumnName("SCAS_ENROLMENT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.MaxPlaces)
                    .HasColumnName("MAX_PLACES")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.ScasEnrolmentTypeCapacity)
                    .HasColumnName("SCAS_ENROLMENT_TYPE_CAPACITY")
                    .HasColumnType("NUMBER(10,2)");

                entity.Property(e => e.ScasNumClass)
                    .HasColumnName("SCAS_NUM_CLASS")
                    .HasColumnType("NUMBER(10,2)");
            });

            modelBuilder.Entity<ScasXferSource>(entity =>
            {
                entity.HasKey(e => e.SourceId)
                    .HasName("SCAS_XFER_SOURCE_PK");

                entity.ToTable("SCAS_XFER_SOURCE");

                entity.HasIndex(e => e.SourceId)
                    .HasName("SCAS_XFER_SOURCE_PK")
                    .IsUnique();

                entity.Property(e => e.SourceId)
                    .HasColumnName("SOURCE_ID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasColumnType("DATE");

                entity.Property(e => e.FamilyNm)
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.FirstNm)
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.GenderInd)
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.ScasEnroltypeCode)
                    .HasColumnName("SCAS_ENROLTYPE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ScasLocation)
                    .HasColumnName("SCAS_LOCATION")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ScasSyCode)
                    .HasColumnName("SCAS_SY_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.XferCommentText)
                    .HasColumnName("XFER_COMMENT_TEXT")
                    .HasColumnType("VARCHAR2(2048)");

                entity.Property(e => e.XferStatusCode)
                    .HasColumnName("XFER_STATUS_CODE")
                    .HasColumnType("VARCHAR2(8)");
            });

            modelBuilder.Entity<SchoolMedicalStock>(entity =>
            {
                entity.HasKey(e => e.SchoolMedicalStockRecordNo);

                entity.ToTable("SCHOOL_MEDICAL_STOCK");

                entity.HasIndex(e => e.SchoolMedicalStockRecordNo)
                    .HasName("PK_SCHOOL_MEDICAL_STOCK")
                    .IsUnique();

                entity.Property(e => e.SchoolMedicalStockRecordNo)
                    .HasColumnName("SCHOOL_MEDICAL_STOCK_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoInjectorAdultMin)
                    .HasColumnName("AUTO_INJECTOR_ADULT_MIN")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("(1)");

                entity.Property(e => e.AutoInjectorJuniorMin)
                    .HasColumnName("AUTO_INJECTOR_JUNIOR_MIN")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SchoolMedication>(entity =>
            {
                entity.HasKey(e => e.SchoolMedicationRecordNo);

                entity.ToTable("SCHOOL_MEDICATION");

                entity.HasIndex(e => e.SchoolMedicationRecordNo)
                    .HasName("PK_SCHOOL_MEDICATION")
                    .IsUnique();

                entity.Property(e => e.SchoolMedicationRecordNo)
                    .HasColumnName("SCHOOL_MEDICATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOfPurchase)
                    .HasColumnName("DATE_OF_PURCHASE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("'31-Dec-2999'         ");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicationRecordNo)
                    .HasColumnName("MEDICATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SchoolStaffNotification>(entity =>
            {
                entity.HasKey(e => e.SchoolStaffNotifRecordNo);

                entity.ToTable("SCHOOL_STAFF_NOTIFICATION");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("FK_SNT_EMPLOYEE_ID");

                entity.HasIndex(e => e.SchoolStaffNotifRecordNo)
                    .HasName("PK_SCH_STAFF_NOTIFICATION")
                    .IsUnique();

                entity.Property(e => e.SchoolStaffNotifRecordNo)
                    .HasColumnName("SCHOOL_STAFF_NOTIF_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EMPLOYEE_ID")
                    .HasColumnType("VARCHAR2(32)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepErrorLog>(entity =>
            {
                entity.HasKey(e => e.SepErrorRecordNo)
                    .HasName("PK_SEP_ERROR_RECORD_NO");

                entity.ToTable("SEP_ERROR_LOG");

                entity.HasIndex(e => e.SepErrorRecordNo)
                    .HasName("SEP_ERROR_RECORD_NO")
                    .IsUnique();

                entity.Property(e => e.SepErrorRecordNo)
                    .HasColumnName("SEP_ERROR_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DateTimeOfError)
                    .HasColumnName("DATE_TIME_OF_ERROR")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("VARCHAR2(1024)");

                entity.Property(e => e.ServiceName)
                    .HasColumnName("SERVICE_NAME")
                    .HasColumnType("VARCHAR2(255)");

                entity.Property(e => e.ServiceParameters)
                    .HasColumnName("SERVICE_PARAMETERS")
                    .HasColumnType("VARCHAR2(4000)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SepsdChangedStudent>(entity =>
            {
                entity.HasKey(e => e.StudentRecordNo)
                    .HasName("PK_SEPSD_CNGD_STU_S_R_NO");

                entity.ToTable("SEPSD_CHANGED_STUDENT");

                entity.HasIndex(e => e.FamilyNm)
                    .HasName("IDX_SEPSD_CHD_STU_FAM");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("PK_SEPSD_CNGD_STU_S_R_NO")
                    .IsUnique();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .IsRequired()
                    .HasColumnName("DELETED")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .HasDefaultValueSql("SYSTIMESTAMP ");

                entity.Property(e => e.RecordChangedDatetime)
                    .HasColumnName("RECORD_CHANGED_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .HasDefaultValueSql("systimestamp ");

                entity.Property(e => e.Resync)
                    .IsRequired()
                    .HasColumnName("RESYNC")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("STATUS")
                    .HasColumnType("VARCHAR2(25)")
                    .HasDefaultValueSql("'PENDING' ");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.StudentRecordNoNavigation)
                    .WithOne(p => p.SepsdChangedStudent)
                    .HasForeignKey<SepsdChangedStudent>(d => d.StudentRecordNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_CNGD_STU_S_R_NO");
            });

            modelBuilder.Entity<SepsdDoctor>(entity =>
            {
                entity.HasKey(e => e.DoctorRecordNo)
                    .HasName("SYS_C00149314");

                entity.ToTable("SEPSD_DOCTOR");

                entity.HasIndex(e => e.DoctorRecordNo)
                    .HasName("SYS_C00149314")
                    .IsUnique();

                entity.HasIndex(e => e.Srn)
                    .HasName("IDX_SEPSD_DOCTOR_SRN");

                entity.Property(e => e.DoctorRecordNo)
                    .HasColumnName("DOCTOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctorNm)
                    .HasColumnName("DOCTOR_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentDoctorRelGuid)
                    .HasColumnName("STUDENT_DOCTOR_REL_GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SrnNavigation)
                    .WithMany(p => p.SepsdDoctor)
                    .HasForeignKey(d => d.Srn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_DOCTOR_SRN");
            });

            modelBuilder.Entity<SepsdEmergencyContact>(entity =>
            {
                entity.HasKey(e => e.EmercontactRecNo)
                    .HasName("SYS_C00149303");

                entity.ToTable("SEPSD_EMERGENCY_CONTACT");

                entity.HasIndex(e => e.EmercontactRecNo)
                    .HasName("SYS_C00149303")
                    .IsUnique();

                entity.Property(e => e.EmercontactRecNo)
                    .HasColumnName("EMERCONTACT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRelationCode)
                    .IsRequired()
                    .HasColumnName("FAMILY_RELATION_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRelationNm)
                    .HasColumnName("FAMILY_RELATION_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEmergencyContactDetail>(entity =>
            {
                entity.HasKey(e => e.EcDetailRecordNo)
                    .HasName("SYS_C00149475");

                entity.ToTable("SEPSD_EMERGENCY_CONTACT_DETAIL");

                entity.HasIndex(e => e.EcDetailRecordNo)
                    .HasName("SYS_C00149475")
                    .IsUnique();

                entity.HasIndex(e => e.EmercontactRecNo)
                    .HasName("SEPSD_EC_DETAIL_I1");

                entity.Property(e => e.EcDetailRecordNo)
                    .HasColumnName("EC_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactComment)
                    .HasColumnName("CONTACT_COMMENT")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeCode)
                    .HasColumnName("CONTACT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeNm)
                    .HasColumnName("CONTACT_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactValue)
                    .HasColumnName("CONTACT_VALUE")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmercontactRecNo)
                    .HasColumnName("EMERCONTACT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityDocRel>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149385");

                entity.ToTable("SEPSD_ENTITY_DOC_REL");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149385")
                    .IsUnique();

                entity.HasIndex(e => e.DoctorRecordNo)
                    .HasName("IDX_SEPSD_ENTITY_DR_DRN");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctorRecordNo)
                    .HasColumnName("DOCTOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityDoctor>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149376");

                entity.ToTable("SEPSD_ENTITY_DOCTOR");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149376")
                    .IsUnique();

                entity.HasIndex(e => e.DoctorRecordNo)
                    .HasName("IDX_SEPSD_ENTITY_DOC_DRN");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctorRecordNo)
                    .HasColumnName("DOCTOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityEmerconrel>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149367");

                entity.ToTable("SEPSD_ENTITY_EMERCONREL");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149367")
                    .IsUnique();

                entity.HasIndex(e => e.EmerconRelationshipRecNo)
                    .HasName("IDX_SEPSD_ENTITY_ECR_ECRRO");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmerconRelationshipRecNo)
                    .HasColumnName("EMERCON_RELATIONSHIP_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmercontactRecNo)
                    .HasColumnName("EMERCONTACT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityEmercontact>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149357");

                entity.ToTable("SEPSD_ENTITY_EMERCONTACT");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149357")
                    .IsUnique();

                entity.HasIndex(e => e.EmercontactRecNo)
                    .HasName("IDX_SEPSD_ENTITY_EC_ECRO");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmercontactRecNo)
                    .HasColumnName("EMERCONTACT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityRegistration>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149331");

                entity.ToTable("SEPSD_ENTITY_REGISTRATION");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149331")
                    .IsUnique();

                entity.HasIndex(e => e.RegistrationRecordNo)
                    .HasName("IDX_SEPSD_ENTITY_REG");

                entity.HasIndex(e => e.Srn)
                    .HasName("IDX_SEPSD_ENTITY_REG_SRN");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityStuconrel>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149349");

                entity.ToTable("SEPSD_ENTITY_STUCONREL");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149349")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRelationshipRecordNo)
                    .HasName("IDX_SEPSD_ENTITY_SCR_PRRN");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRelationshipRecordNo)
                    .HasColumnName("PARENT_RELATIONSHIP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityStucontact>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149339");

                entity.ToTable("SEPSD_ENTITY_STUCONTACT");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149339")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("IDX_SEPSD_ENTITY_SC_PRN");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdEntityStudent>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149322");

                entity.ToTable("SEPSD_ENTITY_STUDENT");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149322")
                    .IsUnique();

                entity.HasIndex(e => e.Srn)
                    .HasName("IDX_SEPSD_ENTITY_STU_SRN");

                entity.HasIndex(e => e.StudentGuid)
                    .HasName("IDX_SEPSD_ENTITY_STU_SG");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Author)
                    .HasColumnName("AUTHOR")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deleted)
                    .HasColumnName("DELETED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorCount)
                    .HasColumnName("ERROR_COUNT")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.ErrorMessage)
                    .HasColumnName("ERROR_MESSAGE")
                    .HasColumnType("CLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorType)
                    .HasColumnName("ERROR_TYPE")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractEndTime)
                    .HasColumnName("EXTRACT_END_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExtractStartTime)
                    .HasColumnName("EXTRACT_START_TIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastErrorDatetime)
                    .HasColumnName("LAST_ERROR_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastModified)
                    .HasColumnName("LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastOperation)
                    .IsRequired()
                    .HasColumnName("LAST_OPERATION")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Resynced)
                    .HasColumnName("RESYNCED")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentGuid)
                    .HasColumnName("STUDENT_GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdFamilyAddress>(entity =>
            {
                entity.HasKey(e => e.FamilyAddressRecordNo)
                    .HasName("SYS_C00149479");

                entity.ToTable("SEPSD_FAMILY_ADDRESS");

                entity.HasIndex(e => e.FamilyAddressRecordNo)
                    .HasName("SYS_C00149479")
                    .IsUnique();

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SEPSD_FAMILY_ADDRESS_I1");

                entity.Property(e => e.FamilyAddressRecordNo)
                    .HasColumnName("FAMILY_ADDRESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("ADDRESS_LINE1")
                    .HasColumnType("VARCHAR2(264)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("ADDRESS_LINE2")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeCode)
                    .HasColumnName("ADDRESS_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeNm)
                    .HasColumnName("ADDRESS_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StateCode)
                    .HasColumnName("STATE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StateNm)
                    .HasColumnName("STATE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuburbNm)
                    .HasColumnName("SUBURB_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdFamilyContact>(entity =>
            {
                entity.HasKey(e => e.FamilyContactRecordNo)
                    .HasName("SYS_C00149477");

                entity.ToTable("SEPSD_FAMILY_CONTACT");

                entity.HasIndex(e => e.FamilyContactRecordNo)
                    .HasName("SYS_C00149477")
                    .IsUnique();

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SEPSD_FAMILY_CONTACT_I1");

                entity.Property(e => e.FamilyContactRecordNo)
                    .HasColumnName("FAMILY_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactComment)
                    .HasColumnName("CONTACT_COMMENT")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeCode)
                    .HasColumnName("CONTACT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeNm)
                    .HasColumnName("CONTACT_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactValue)
                    .HasColumnName("CONTACT_VALUE")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdParent>(entity =>
            {
                entity.HasKey(e => e.ParentRecordNo)
                    .HasName("SYS_C00149291");

                entity.ToTable("SEPSD_PARENT");

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SYS_C00149291")
                    .IsUnique();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtsiCodeSrd)
                    .HasColumnName("ATSI_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtsiNm)
                    .HasColumnName("ATSI_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirth)
                    .HasColumnName("COUNTRY_OF_BIRTH")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirthCodeSrd)
                    .HasColumnName("COUNTRY_OF_BIRTH_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirthNm)
                    .HasColumnName("COUNTRY_OF_BIRTH_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnglishAtHomeInd)
                    .HasColumnName("ENGLISH_AT_HOME_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyGuid)
                    .HasColumnName("FAMILY_GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilySalutation)
                    .HasColumnName("FAMILY_SALUTATION")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderInd)
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderNm)
                    .HasColumnName("GENDER_NM")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeLanguageCode)
                    .HasColumnName("HOME_LANGUAGE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeLanguageCode2)
                    .HasColumnName("HOME_LANGUAGE_CODE2")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeLanguageCode2Srd)
                    .HasColumnName("HOME_LANGUAGE_CODE2_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeLanguageCodeSrd)
                    .HasColumnName("HOME_LANGUAGE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeLanguageNm)
                    .HasColumnName("HOME_LANGUAGE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeLanguageNm2)
                    .HasColumnName("HOME_LANGUAGE_NM2")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.InterpreterRequiredInd)
                    .HasColumnName("INTERPRETER_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAliveInd)
                    .IsRequired()
                    .HasColumnName("IS_ALIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAliveIndModifiedDate)
                    .HasColumnName("IS_ALIVE_IND_MODIFIED_DATE")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NameSalutation)
                    .HasColumnName("NAME_SALUTATION")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OccupationNm)
                    .HasColumnName("OCCUPATION_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OcgTypeCodeSrd)
                    .HasColumnName("OCG_TYPE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OcgTypeNm)
                    .HasColumnName("OCG_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OgTypeCode)
                    .HasColumnName("OG_TYPE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageCode)
                    .HasColumnName("OTHER_LANGUAGE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageCodeSrd)
                    .HasColumnName("OTHER_LANGUAGE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageNm)
                    .HasColumnName("OTHER_LANGUAGE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFamilyNm)
                    .HasColumnName("PREF_FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFirstNm)
                    .HasColumnName("PREF_FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PseCode)
                    .HasColumnName("PSE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PseCodeSrd)
                    .HasColumnName("PSE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PseNm)
                    .HasColumnName("PSE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PteCode)
                    .HasColumnName("PTE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PteCodeSrd)
                    .HasColumnName("PTE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PteNm)
                    .HasColumnName("PTE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdParentAddress>(entity =>
            {
                entity.HasKey(e => e.ParentAddressRecordNo)
                    .HasName("SYS_C00149473");

                entity.ToTable("SEPSD_PARENT_ADDRESS");

                entity.HasIndex(e => e.ParentAddressRecordNo)
                    .HasName("SYS_C00149473")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SEPSD_PARENT_ADDRESS_I1");

                entity.Property(e => e.ParentAddressRecordNo)
                    .HasColumnName("PARENT_ADDRESS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .HasColumnName("ADDRESS_LINE1")
                    .HasColumnType("VARCHAR2(264)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine2)
                    .HasColumnName("ADDRESS_LINE2")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeCode)
                    .HasColumnName("ADDRESS_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeNm)
                    .HasColumnName("ADDRESS_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .HasColumnName("COUNTRY_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryNm)
                    .HasColumnName("COUNTRY_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StateCode)
                    .HasColumnName("STATE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StateNm)
                    .HasColumnName("STATE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuburbNm)
                    .HasColumnName("SUBURB_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdParentContact>(entity =>
            {
                entity.HasKey(e => e.ParentContactRecordNo)
                    .HasName("SYS_C00149471");

                entity.ToTable("SEPSD_PARENT_CONTACT");

                entity.HasIndex(e => e.ParentContactRecordNo)
                    .HasName("SYS_C00149471")
                    .IsUnique();

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("SEPSD_PARENT_CONTACT_I1");

                entity.Property(e => e.ParentContactRecordNo)
                    .HasColumnName("PARENT_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactComment)
                    .HasColumnName("CONTACT_COMMENT")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeCode)
                    .HasColumnName("CONTACT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeNm)
                    .HasColumnName("CONTACT_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactValue)
                    .HasColumnName("CONTACT_VALUE")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdParentRelationship>(entity =>
            {
                entity.HasKey(e => e.ParentRelationshipRecordNo)
                    .HasName("SYS_C00149297");

                entity.ToTable("SEPSD_PARENT_RELATIONSHIP");

                entity.HasIndex(e => e.ParentRecordNo)
                    .HasName("IDX_SEPSD_PARENT_REL_PRN");

                entity.HasIndex(e => e.ParentRelationshipRecordNo)
                    .HasName("SYS_C00149297")
                    .IsUnique();

                entity.HasIndex(e => e.Srn)
                    .HasName("IDX_SEPSD_PARENT_REL_SRN");

                entity.Property(e => e.ParentRelationshipRecordNo)
                    .HasColumnName("PARENT_RELATIONSHIP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AvoIndicator)
                    .HasColumnName("AVO_INDICATOR")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BsaInd)
                    .HasColumnName("BSA_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustodyInd)
                    .HasColumnName("CUSTODY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentOwnerInd)
                    .HasColumnName("ENROLMENT_OWNER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRelationCode)
                    .HasColumnName("FAMILY_RELATION_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRelationNm)
                    .HasColumnName("FAMILY_RELATION_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentRecordNo)
                    .HasColumnName("PARENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReceiveAcademicReportInd)
                    .HasColumnName("RECEIVE_ACADEMIC_REPORT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReceiveInvoiceInd)
                    .HasColumnName("RECEIVE_INVOICE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatementOfAccTypeCode)
                    .HasColumnName("STATEMENT_OF_ACC_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatementOfAccTypeNm)
                    .HasColumnName("STATEMENT_OF_ACC_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatementOfAccTypeRecNo)
                    .HasColumnName("STATEMENT_OF_ACC_TYPE_REC_NO")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.ParentRecordNoNavigation)
                    .WithMany(p => p.SepsdParentRelationship)
                    .HasForeignKey(d => d.ParentRecordNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_STU_REL_PAR_P_R_NO");

                entity.HasOne(d => d.SrnNavigation)
                    .WithMany(p => p.SepsdParentRelationship)
                    .HasForeignKey(d => d.Srn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_STU_REL_STU_SRN");
            });

            modelBuilder.Entity<SepsdRegistration>(entity =>
            {
                entity.HasKey(e => e.RegistrationRecordNo)
                    .HasName("SYS_C00149285");

                entity.ToTable("SEPSD_REGISTRATION");

                entity.HasIndex(e => e.RegistrationRecordNo)
                    .HasName("SYS_C00149285")
                    .IsUnique();

                entity.HasIndex(e => e.Srn)
                    .HasName("IDX_SEPSD_REGISTRATION_SRN");

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualStartDate)
                    .HasColumnName("ACTUAL_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalendarYear)
                    .HasColumnName("CALENDAR_YEAR")
                    .HasColumnType("NUMBER(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CensusInd)
                    .HasColumnName("CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CentrelinkFundingInd)
                    .HasColumnName("CENTRELINK_FUNDING_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DestOrgUnitCode)
                    .HasColumnName("DEST_ORG_UNIT_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DestSchoolNm)
                    .HasColumnName("DEST_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeCode)
                    .HasColumnName("ENROLMENT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeNm)
                    .HasColumnName("ENROLMENT_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HouseSgOfferNm)
                    .HasColumnName("HOUSE_SG_OFFER_NM")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.InZoneInd)
                    .HasColumnName("IN_ZONE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IntendedStartDate)
                    .HasColumnName("INTENDED_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaverToSchoolNm)
                    .HasColumnName("LEAVER_TO_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Leaving)
                    .HasColumnName("LEAVING")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeavingDate)
                    .HasColumnName("LEAVING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitCode)
                    .HasColumnName("ORG_UNIT_CODE")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitNm)
                    .HasColumnName("ORG_UNIT_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousOrgUnitCode)
                    .HasColumnName("PREVIOUS_ORG_UNIT_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousSchoolNm)
                    .HasColumnName("PREVIOUS_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationGuid)
                    .HasColumnName("REGISTRATION_GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationOfferNm)
                    .HasColumnName("REGISTRATION_OFFER_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationOfferRecordNo)
                    .HasColumnName("REGISTRATION_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationStatusCodeSrd)
                    .HasColumnName("REGISTRATION_STATUS_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationStatusNm)
                    .HasColumnName("REGISTRATION_STATUS_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RollClassName)
                    .HasColumnName("ROLL_CLASS_NAME")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RollClassNameErn)
                    .HasColumnName("ROLL_CLASS_NAME_ERN")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScholasticYearCode)
                    .HasColumnName("SCHOLASTIC_YEAR_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScholasticYearNm)
                    .HasColumnName("SCHOLASTIC_YEAR_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolGuid)
                    .HasColumnName("SCHOOL_GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentStatusCode)
                    .HasColumnName("STUDENT_STATUS_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentStatusNm)
                    .HasColumnName("STUDENT_STATUS_NM")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.SrnNavigation)
                    .WithMany(p => p.SepsdRegistration)
                    .HasForeignKey(d => d.Srn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_ENR_STU_SRN");
            });

            modelBuilder.Entity<SepsdSchoolSync>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("SYS_C00149269");

                entity.ToTable("SEPSD_SCHOOL_SYNC");

                entity.HasIndex(e => e.AutoId)
                    .HasName("SYS_C00149269")
                    .IsUnique();

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("IDX_SEPSD_SSYNC_OURN");

                entity.Property(e => e.AutoId)
                    .HasColumnName("AUTO_ID")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordCreated)
                    .HasColumnName("RECORD_CREATED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdSibling>(entity =>
            {
                entity.HasKey(e => e.FamilySiblingRecordNo)
                    .HasName("SYS_C00149469");

                entity.ToTable("SEPSD_SIBLING");

                entity.HasIndex(e => e.FamilyRecordNo)
                    .HasName("SEPSD_SIBLING_I1");

                entity.HasIndex(e => e.FamilySiblingRecordNo)
                    .HasName("SYS_C00149469")
                    .IsUnique();

                entity.Property(e => e.FamilySiblingRecordNo)
                    .HasColumnName("FAMILY_SIBLING_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ranking)
                    .HasColumnName("RANKING")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SiblingGuid)
                    .HasColumnName("SIBLING_GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SiblingSrn)
                    .HasColumnName("SIBLING_SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TotalSiblings)
                    .HasColumnName("TOTAL_SIBLINGS")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdStudent>(entity =>
            {
                entity.HasKey(e => e.Srn)
                    .HasName("SYS_C00149278");

                entity.ToTable("SEPSD_STUDENT");

                entity.HasIndex(e => e.Srn)
                    .HasName("SYS_C00149278")
                    .IsUnique();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aboriginal)
                    .HasColumnName("ABORIGINAL")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArrivedInAustrliaDate)
                    .HasColumnName("ARRIVED_IN_AUSTRLIA_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AteExpiryDate)
                    .HasColumnName("ATE_EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AteStartDate)
                    .HasColumnName("ATE_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtsiCodeSrd)
                    .HasColumnName("ATSI_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtsiNm)
                    .HasColumnName("ATSI_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorityToPublishInd)
                    .HasColumnName("AUTHORITY_TO_PUBLISH_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CensusInd)
                    .IsRequired()
                    .HasColumnName("CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirthCodeSrd)
                    .HasColumnName("COUNTRY_OF_BIRTH_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirthNm)
                    .HasColumnName("COUNTRY_OF_BIRTH_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfBirthRecordNo)
                    .HasColumnName("COUNTRY_OF_BIRTH_RECORD_NO")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(200)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(200)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslAssessmentInd)
                    .HasColumnName("ESL_ASSESSMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslPhaseCode)
                    .HasColumnName("ESL_PHASE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslPhaseCodeSrd)
                    .HasColumnName("ESL_PHASE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslPhaseNm)
                    .HasColumnName("ESL_PHASE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyRecordNo)
                    .HasColumnName("FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstAustEnrolDate)
                    .HasColumnName("FIRST_AUST_ENROL_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderInd)
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderNm)
                    .HasColumnName("GENDER_NM")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedNever();

                entity.Property(e => e.InternationalInd)
                    .HasColumnName("INTERNATIONAL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IspAccessInd)
                    .HasColumnName("ISP_ACCESS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("LANGUAGE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageNm)
                    .HasColumnName("LANGUAGE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageCodeSrd)
                    .HasColumnName("LANGUAGE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastEslAssessmentDate)
                    .HasColumnName("LAST_ESL_ASSESSMENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicareId)
                    .HasColumnName("MEDICARE_ID")
                    .HasColumnType("VARCHAR2(13)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OohcEndDate)
                    .HasColumnName("OOHC_END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OohcStartDate)
                    .HasColumnName("OOHC_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OohcTypeCode)
                    .HasColumnName("OOHC_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OohcTypeNm)
                    .HasColumnName("OOHC_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageCode)
                    .HasColumnName("OTHER_LANGUAGE_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageCode2)
                    .HasColumnName("OTHER_LANGUAGE_CODE2")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageCode2Srd)
                    .HasColumnName("OTHER_LANGUAGE_CODE2_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageCodeSrd)
                    .HasColumnName("OTHER_LANGUAGE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageNm)
                    .HasColumnName("OTHER_LANGUAGE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherLanguageNm2)
                    .HasColumnName("OTHER_LANGUAGE_NM2")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFamilyNm)
                    .HasColumnName("PREF_FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFirstNm)
                    .HasColumnName("PREF_FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscName)
                    .HasColumnName("PSC_NAME")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscType)
                    .HasColumnName("PSC_TYPE")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscTypeCodeSrd)
                    .HasColumnName("PSC_TYPE_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscTypeNm)
                    .HasColumnName("PSC_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscWhours)
                    .HasColumnName("PSC_WHOURS")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscWhoursCodeSrd)
                    .HasColumnName("PSC_WHOURS_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscWhoursNm)
                    .HasColumnName("PSC_WHOURS_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("RELIGION_CODE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReligionCodeSrd)
                    .HasColumnName("RELIGION_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReligionNm)
                    .HasColumnName("RELIGION_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResidencyStatusCode)
                    .HasColumnName("RESIDENCY_STATUS_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResidencyStatusNm)
                    .HasColumnName("RESIDENCY_STATUS_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScholasticYearCode)
                    .IsRequired()
                    .HasColumnName("SCHOLASTIC_YEAR_CODE")
                    .HasColumnType("VARCHAR2(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScholasticYearNm)
                    .HasColumnName("SCHOLASTIC_YEAR_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentGuid)
                    .HasColumnName("STUDENT_GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentMobilePhoneNo)
                    .HasColumnName("STUDENT_MOBILE_PHONE_NO")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentStatusCodeSrd)
                    .HasColumnName("STUDENT_STATUS_CODE_SRD")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentStatusNm)
                    .HasColumnName("STUDENT_STATUS_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerifiedStatusInd)
                    .HasColumnName("VERIFIED_STATUS_IND")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaClassCode)
                    .HasColumnName("VISA_CLASS_CODE")
                    .HasColumnType("VARCHAR2(15)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaClassNm)
                    .HasColumnName("VISA_CLASS_NM")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaExpiryDate)
                    .HasColumnName("VISA_EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaHolderInd)
                    .HasColumnName("VISA_HOLDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaSubclassCode)
                    .HasColumnName("VISA_SUBCLASS_CODE")
                    .HasColumnType("VARCHAR2(15)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaSubclassNm)
                    .HasColumnName("VISA_SUBCLASS_NM")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SepsdStudentEmerContact>(entity =>
            {
                entity.HasKey(e => e.StuEmercontactRecNo)
                    .HasName("SYS_C00149308");

                entity.ToTable("SEPSD_STUDENT_EMER_CONTACT");

                entity.HasIndex(e => e.EmercontactRecNo)
                    .HasName("IDX_SEPSD_SEC_ECRN");

                entity.HasIndex(e => e.Srn)
                    .HasName("IDX_SEPSD_SEC_SRN");

                entity.HasIndex(e => e.StuEmercontactRecNo)
                    .HasName("SYS_C00149308")
                    .IsUnique();

                entity.Property(e => e.StuEmercontactRecNo)
                    .HasColumnName("STU_EMERCONTACT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmercontactRecNo)
                    .HasColumnName("EMERCONTACT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastModified)
                    .HasColumnName("RECORD_LAST_MODIFIED")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecordLastResync)
                    .HasColumnName("RECORD_LAST_RESYNC")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.EmercontactRecNoNavigation)
                    .WithMany(p => p.SepsdStudentEmerContact)
                    .HasForeignKey(d => d.EmercontactRecNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_STU_EC_EC_R_NO");

                entity.HasOne(d => d.SrnNavigation)
                    .WithMany(p => p.SepsdStudentEmerContact)
                    .HasForeignKey(d => d.Srn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEPSD_STU_EC_STU_SRN");
            });

            modelBuilder.Entity<SgRefreshGroup>(entity =>
            {
                entity.HasKey(e => e.SgRefreshGroupRecordNo);

                entity.ToTable("SG_REFRESH_GROUP");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("FK2_SG_REFRESH_GROUP");

                entity.HasIndex(e => e.SgRefreshGroupRecordNo)
                    .HasName("PK_SG_REFRESH_GROUP")
                    .IsUnique();

                entity.HasIndex(e => e.SgRefreshReqRecordNo)
                    .HasName("FK1_SG_REFRESH_GROUP");

                entity.Property(e => e.SgRefreshGroupRecordNo)
                    .HasColumnName("SG_REFRESH_GROUP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SgRefreshReqRecordNo)
                    .HasColumnName("SG_REFRESH_REQ_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SgRefreshRequest>(entity =>
            {
                entity.HasKey(e => e.SgRefreshReqRecordNo);

                entity.ToTable("SG_REFRESH_REQUEST");

                entity.HasIndex(e => e.RefreshInd)
                    .HasName("IDX_REFRESH_REQUEST_1");

                entity.HasIndex(e => e.SgRefreshReqRecordNo)
                    .HasName("PK_SG_REFRESH_REQUEST")
                    .IsUnique();

                entity.Property(e => e.SgRefreshReqRecordNo)
                    .HasColumnName("SG_REFRESH_REQ_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RefreshInd)
                    .HasColumnName("REFRESH_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RequestedDate)
                    .HasColumnName("REQUESTED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SgScholasticYears>(entity =>
            {
                entity.HasKey(e => e.SgSyRecordNo);

                entity.ToTable("SG_SCHOLASTIC_YEARS");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("FK_SG_SCHYEAR_SG_OFFER");

                entity.HasIndex(e => e.SgSyRecordNo)
                    .HasName("PK_SG_SCHOLASTIC_YEARS")
                    .IsUnique();

                entity.HasIndex(e => e.SyCodeRecordNo)
                    .HasName("FK_SG_SCHYEARS_SCHYEAR_CODE");

                entity.Property(e => e.SgSyRecordNo)
                    .HasColumnName("SG_SY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SyCodeRecordNo)
                    .HasColumnName("SY_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SgStaffParticipation>(entity =>
            {
                entity.HasKey(e => e.SgStaffRecordNo);

                entity.ToTable("SG_STAFF_PARTICIPATION");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("FK_SG_STAFF_PARTICIP_SG_OFFER");

                entity.HasIndex(e => e.SgStaffRecordNo)
                    .HasName("PK_SG_STAFF_PARTICIPATION")
                    .IsUnique();

                entity.HasIndex(e => e.StaffRecordNo)
                    .HasName("FK_SG_STAFF_PARTICIP_STAFF");

                entity.Property(e => e.SgStaffRecordNo)
                    .HasColumnName("SG_STAFF_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MainStaffInd)
                    .IsRequired()
                    .HasColumnName("MAIN_STAFF_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.NumberOfPeriods)
                    .HasColumnName("NUMBER_OF_PERIODS")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0 ");

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SourceSystem)
                    .HasColumnName("SOURCE_SYSTEM")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StaffRecordNo)
                    .HasColumnName("STAFF_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StaffRoleCodeRecordNo)
                    .HasColumnName("STAFF_ROLE_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SgoeType>(entity =>
            {
                entity.HasKey(e => e.SgoeTypeRecordNo);

                entity.ToTable("SGOE_TYPE");

                entity.HasIndex(e => e.EnrolmentTypeRecordNo)
                    .HasName("FK_SGOE_TYPE_ET");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("FK_SGOE_TYPE_SGO");

                entity.HasIndex(e => e.SgoeTypeRecordNo)
                    .HasName("PK_SGOE_TYPE")
                    .IsUnique();

                entity.Property(e => e.SgoeTypeRecordNo)
                    .HasColumnName("SGOE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SgoeTypeTemp>(entity =>
            {
                entity.HasKey(e => e.SgoeTypeRecordNo);

                entity.ToTable("SGOE_TYPE_TEMP");

                entity.HasIndex(e => e.SgoeTypeRecordNo)
                    .HasName("PK_SGOE_TYPE_TEMP")
                    .IsUnique();

                entity.Property(e => e.SgoeTypeRecordNo)
                    .HasColumnName("SGOE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.EnrolmentTypeRecordNo)
                    .HasColumnName("ENROLMENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SlsStaffLocations>(entity =>
            {
                entity.HasKey(e => e.StaffGuid)
                    .HasName("SLS_STAFF_LOCATIONS_PK");

                entity.ToTable("SLS_STAFF_LOCATIONS");

                entity.HasIndex(e => e.DetUserId)
                    .HasName("SLS_STAFF_LOCATIONS_USER")
                    .IsUnique();

                entity.HasIndex(e => e.StaffGuid)
                    .HasName("SLS_STAFF_LOCATIONS_GUID")
                    .IsUnique();

                entity.Property(e => e.StaffGuid)
                    .HasColumnName("STAFF_GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .IsRequired()
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Locations)
                    .IsRequired()
                    .HasColumnName("LOCATIONS")
                    .HasColumnType("VARCHAR2(4000)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<Soci2Student>(entity =>
            {
                entity.HasKey(e => e.StudentGuid)
                    .HasName("SYS_C00146185");

                entity.ToTable("SOCI2_STUDENT");

                entity.HasIndex(e => e.StudentGuid)
                    .HasName("SYS_C00146185")
                    .IsUnique();

                entity.Property(e => e.StudentGuid)
                    .HasColumnName("STUDENT_GUID")
                    .HasColumnType("VARCHAR2(256)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aboriginal)
                    .HasColumnName("ABORIGINAL")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.ArrivedInAustrliaDate)
                    .HasColumnName("ARRIVED_IN_AUSTRLIA_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.AteExpiryDate)
                    .HasColumnName("ATE_EXPIRY_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.AteStartDate)
                    .HasColumnName("ATE_START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.CensusInd)
                    .IsRequired()
                    .HasColumnName("CENSUS_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.CountryOfBirthRecordNo)
                    .HasColumnName("COUNTRY_OF_BIRTH_RECORD_NO")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasColumnType("DATE");

                entity.Property(e => e.DetUserId)
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.EslAssessmentInd)
                    .HasColumnName("ESL_ASSESSMENT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.EslPhaseCode)
                    .HasColumnName("ESL_PHASE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.FirstAustEnrolDate)
                    .HasColumnName("FIRST_AUST_ENROL_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.GenderInd)
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.LanguageCode)
                    .HasColumnName("LANGUAGE_CODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.LastEslAssessmentDate)
                    .HasColumnName("LAST_ESL_ASSESSMENT_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.MedicareId)
                    .HasColumnName("MEDICARE_ID")
                    .HasColumnType("VARCHAR2(13)");

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.PrefFamilyNm)
                    .HasColumnName("PREF_FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.PrefFirstNm)
                    .HasColumnName("PREF_FIRST_NM")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.PscType)
                    .HasColumnName("PSC_TYPE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.PscTypeNm)
                    .HasColumnName("PSC_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.PscWhoursTypeCode)
                    .HasColumnName("PSC_WHOURS_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.PscWhoursTypeNm)
                    .HasColumnName("PSC_WHOURS_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)");

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("RELIGION_CODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.ResidencyStatusCode)
                    .HasColumnName("RESIDENCY_STATUS_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.ScholasticYearCode)
                    .IsRequired()
                    .HasColumnName("SCHOLASTIC_YEAR_CODE")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentMobilePhoneNo)
                    .HasColumnName("STUDENT_MOBILE_PHONE_NO")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.VerifiedStatusInd)
                    .HasColumnName("VERIFIED_STATUS_IND")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.VisaClassCode)
                    .HasColumnName("VISA_CLASS_CODE")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.VisaExpiryDate)
                    .HasColumnName("VISA_EXPIRY_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.VisaSubclassCode)
                    .HasColumnName("VISA_SUBCLASS_CODE")
                    .HasColumnType("VARCHAR2(15)");
            });

            modelBuilder.Entity<SociHouse>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo });

                entity.ToTable("SOCI_HOUSE");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo })
                    .HasName("PK_SOCI_HOUSE")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepSgOfferRecordNo)
                    .HasColumnName("SEP_SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.IlucodeCode)
                    .IsRequired()
                    .HasColumnName("ILUCODE_CODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.IlucodeDesc)
                    .IsRequired()
                    .HasColumnName("ILUCODE_DESC")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.IlucodeFlag)
                    .HasColumnName("ILUCODE_FLAG")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.IlucodeType)
                    .IsRequired()
                    .HasColumnName("ILUCODE_TYPE")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'O' ");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepRowReplacesRecordNo)
                    .HasColumnName("SEP_ROW_REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Statusind)
                    .HasColumnName("STATUSIND")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociIclass>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo });

                entity.ToTable("SOCI_ICLASS");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_SOCI_ICLASS_OASIS_DB_CODE");

                entity.HasIndex(e => e.SepSgOfferRecordNo)
                    .HasName("IDX_SOCI_ICLASS_SG_OFFER");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo })
                    .HasName("PK_SOCI_ICLASS")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode, e.Classnum })
                    .HasName("OASIS_ICLASS_PK")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepSgOfferRecordNo)
                    .HasColumnName("SEP_SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Comcode)
                    .HasColumnName("COMCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Comperiods)
                    .HasColumnName("COMPERIODS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Mxclassnum)
                    .HasColumnName("MXCLASSNUM")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.SepOfferingStatusInd)
                    .IsRequired()
                    .HasColumnName("SEP_OFFERING_STATUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepSgStaffRecordNo)
                    .HasColumnName("SEP_SG_STAFF_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Staffid)
                    .HasColumnName("STAFFID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Subcode)
                    .IsRequired()
                    .HasColumnName("SUBCODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociIclteach>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepSgStaffRecordNo });

                entity.ToTable("SOCI_ICLTEACH");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_SOCI_ICLTEACH_ODB_CODE");

                entity.HasIndex(e => e.SepSgOfferRecordNo)
                    .HasName("IDX_SOCI_ICLTEACH_SGO");

                entity.HasIndex(e => e.SepSgStaffRecordNo)
                    .HasName("IDX_SOCI_ICLTEACH_SGSP");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepSgStaffRecordNo })
                    .HasName("PK_SOCI_ICLTEACH")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Staffid, e.Coursecode, e.Classnum })
                    .HasName("OASIS_ICLTEACH_PK")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepSgStaffRecordNo)
                    .HasColumnName("SEP_SG_STAFF_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepSgOfferRecordNo)
                    .HasColumnName("SEP_SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Staffid)
                    .HasColumnName("STAFFID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociIcom>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo });

                entity.ToTable("SOCI_ICOM");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_SOCI_ICOM_ODB_CODE");

                entity.HasIndex(e => e.SepSgOfferRecordNo)
                    .HasName("IDX_SOCI_ICOM_SGO");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo })
                    .HasName("PK_SOCI_ICOM")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Comcode, e.Acperiod })
                    .HasName("SOCI_ICOM_PK")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepSgOfferRecordNo)
                    .HasColumnName("SEP_SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Comcode)
                    .IsRequired()
                    .HasColumnName("COMCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Comname)
                    .HasColumnName("COMNAME")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Comstaff).HasColumnName("COMSTAFF");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.SepOfferingStatusInd)
                    .IsRequired()
                    .HasColumnName("SEP_OFFERING_STATUS_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociIcomclas>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo });

                entity.ToTable("SOCI_ICOMCLAS");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_SOCI_ICOMCLAS_ODB_CODE");

                entity.HasIndex(e => e.SepSgOfferRecordNo)
                    .HasName("IDX_SOCI_ICOMCLAS_SGO");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo })
                    .HasName("PK_SOCI_ICOMCLAS")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Comcode, e.Coursecode, e.Acperiod, e.Classnum })
                    .HasName("SOCI_ICOMCLAS_PK")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepSgOfferRecordNo)
                    .HasColumnName("SEP_SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Comcode)
                    .IsRequired()
                    .HasColumnName("COMCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Schyear)
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.SepOfferingStatusInd)
                    .HasColumnName("SEP_OFFERING_STATUS_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociIcourse>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.CrdCurriculumOfferRecordNo });

                entity.ToTable("SOCI_ICOURSE");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_SOCI_ICOURSE_OASIS_DB_CODE");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.CrdCurriculumOfferRecordNo })
                    .HasName("PK_SOCI_ICOURSE")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode })
                    .HasName("OASIS_ICOURSE_PK")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CrdCurriculumOfferRecordNo)
                    .HasColumnName("CRD_CURRICULUM_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Cfeedesc)
                    .HasColumnName("CFEEDESC")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.CrdActiveInd)
                    .IsRequired()
                    .HasColumnName("CRD_ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.CrdRowChangedDatetime)
                    .HasColumnName("CRD_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Fee)
                    .HasColumnName("FEE")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Hsccode)
                    .HasColumnName("HSCCODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Levdesc)
                    .HasColumnName("LEVDESC")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Levfee)
                    .HasColumnName("LEVFEE")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Levval)
                    .HasColumnName("LEVVAL")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Printname1)
                    .HasColumnName("PRINTNAME1")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.Sccode)
                    .HasColumnName("SCCODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.Subcode)
                    .IsRequired()
                    .HasColumnName("SUBCODE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Subno)
                    .HasColumnName("SUBNO")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Subtype)
                    .HasColumnName("SUBTYPE")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<SociIrolcls>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo });

                entity.ToTable("SOCI_IROLCLS");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepSgOfferRecordNo })
                    .HasName("PK_SOCI_IROLCLS")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepSgOfferRecordNo)
                    .HasColumnName("SEP_SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Oc)
                    .HasColumnName("OC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepRowReplacesRecordNo)
                    .HasColumnName("SEP_ROW_REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Staffid)
                    .HasColumnName("STAFFID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Statusind)
                    .HasColumnName("STATUSIND")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("YEAR")
                    .HasColumnType("VARCHAR2(4)");
            });

            modelBuilder.Entity<SociIschyear>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepRegisterOfferRecordNo });

                entity.ToTable("SOCI_ISCHYEAR");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepRegisterOfferRecordNo })
                    .HasName("PK_SOCI_ISCHYEAR")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepRegisterOfferRecordNo)
                    .HasColumnName("SEP_REGISTER_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.SepCalendarYear)
                    .HasColumnName("SEP_CALENDAR_YEAR")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepRowReplacesRecordNo)
                    .HasColumnName("SEP_ROW_REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stdschyr)
                    .IsRequired()
                    .HasColumnName("STDSCHYR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociMergeLog>(entity =>
            {
                entity.HasKey(e => e.SociMergeLogRecordNo)
                    .HasName("SYS_C0017021");

                entity.ToTable("SOCI_MERGE_LOG");

                entity.HasIndex(e => e.LosingSrn)
                    .HasName("IDX_LOSING_SRN");

                entity.HasIndex(e => e.SociMergeLogRecordNo)
                    .HasName("SYS_C0017021")
                    .IsUnique();

                entity.HasIndex(e => e.WinningSrn)
                    .HasName("IDX_WINING_SRN");

                entity.Property(e => e.SociMergeLogRecordNo)
                    .HasColumnName("SOCI_MERGE_LOG_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ErnMergeDate)
                    .HasColumnName("ERN_MERGE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.LosingSrn)
                    .HasColumnName("LOSING_SRN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OasisMergeDate)
                    .HasColumnName("OASIS_MERGE_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.WinningSrn)
                    .HasColumnName("WINNING_SRN")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociOasisDatabase>(entity =>
            {
                entity.HasKey(e => e.OasisDatabaseRecordNo);

                entity.ToTable("SOCI_OASIS_DATABASE");

                entity.HasIndex(e => e.OasisDatabaseCode)
                    .HasName("SK_SOCI_OASIS_DATABASE_CODE")
                    .IsUnique();

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("PK_SOCI_OASIS_DATABASE")
                    .IsUnique();

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("IDX_SOCI_OASIS_DB_ORG_UNIT");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ActiveInd)
                    .IsRequired()
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A' ");

                entity.Property(e => e.MigratedToSepInd)
                    .IsRequired()
                    .HasColumnName("MIGRATED_TO_SEP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.OasisDatabaseCode)
                    .IsRequired()
                    .HasColumnName("OASIS_DATABASE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociOasisEntity>(entity =>
            {
                entity.HasKey(e => e.OasisEntityRecordNo);

                entity.ToTable("SOCI_OASIS_ENTITY");

                entity.HasIndex(e => e.OasisEntityRecordNo)
                    .HasName("PK_SOCI_OASIS_ENTITY")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.OasisEntityNm })
                    .HasName("SK_SOCI_OASIS_ENTITY")
                    .IsUnique();

                entity.Property(e => e.OasisEntityRecordNo)
                    .HasColumnName("OASIS_ENTITY_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LastExtractConnectDatetime)
                    .HasColumnName("LAST_EXTRACT_CONNECT_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.LastExtractEndDatetime)
                    .HasColumnName("LAST_EXTRACT_END_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.LastExtractStartDatetime)
                    .HasColumnName("LAST_EXTRACT_START_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OasisEntityNm)
                    .IsRequired()
                    .HasColumnName("OASIS_ENTITY_NM")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.SepDataChangedDatetime)
                    .HasColumnName("SEP_DATA_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociOasisEntityOth>(entity =>
            {
                entity.HasKey(e => e.OasisEntityRecordNo);

                entity.ToTable("SOCI_OASIS_ENTITY_OTH");

                entity.HasIndex(e => e.OasisEntityRecordNo)
                    .HasName("PK_SOCI_OASIS_ENTITY_OTH")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.OasisEntityNm })
                    .HasName("SK_SOCI_OASIS_ENTITY_OTH")
                    .IsUnique();

                entity.Property(e => e.OasisEntityRecordNo)
                    .HasColumnName("OASIS_ENTITY_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.LastExtractConnectDatetime)
                    .HasColumnName("LAST_EXTRACT_CONNECT_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.LastExtractEndDatetime)
                    .HasColumnName("LAST_EXTRACT_END_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.LastExtractStartDatetime)
                    .HasColumnName("LAST_EXTRACT_START_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OasisEntityNm)
                    .IsRequired()
                    .HasColumnName("OASIS_ENTITY_NM")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.SepDataChangedDatetime)
                    .HasColumnName("SEP_DATA_CHANGED_DATETIME")
                    .HasColumnType("DATE");
            });

            modelBuilder.Entity<SociSabsence>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Stucode, e.Absdate });

                entity.ToTable("SOCI_SABSENCE");

                entity.HasIndex(e => e.Stucode)
                    .HasName("IDX_SOCI_SABSENCE_SRN");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Stucode, e.Absdate })
                    .HasName("PK_SOCI_SABSENCE")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stucode)
                    .HasColumnName("STUCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Absdate)
                    .HasColumnName("ABSDATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Absperiod)
                    .HasColumnName("ABSPERIOD")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Comm)
                    .HasColumnName("COMM")
                    .HasColumnType("VARCHAR2(4000)");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.Starttime)
                    .HasColumnName("STARTTIME")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stoptime)
                    .HasColumnName("STOPTIME")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSclass>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.SepStudentGroupRecordNo });

                entity.ToTable("SOCI_SCLASS");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_SOCI_SCLASS_OASIS_DB_CODE");

                entity.HasIndex(e => e.SepStudentGroupRecordNo)
                    .HasName("IDX_SOCI_SCLASS_SG_REC_NO");

                entity.HasIndex(e => e.Stucode)
                    .HasName("IDX_SOCI_SCLASS_SRN");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepStudentGroupRecordNo })
                    .HasName("PK_SOCI_SCLASS")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode, e.Classnum, e.Stucode })
                    .HasName("OASIS_SCLASS_PK")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepStudentGroupRecordNo)
                    .HasColumnName("SEP_STUDENT_GROUP_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Coursecode)
                    .IsRequired()
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Prefname)
                    .HasColumnName("PREFNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.SepMembershipCurrentInd)
                    .IsRequired()
                    .HasColumnName("SEP_MEMBERSHIP_CURRENT_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Stucode)
                    .HasColumnName("STUCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSepChangedRegOffer>(entity =>
            {
                entity.HasKey(e => e.RegistrationOfferRecordNo);

                entity.ToTable("SOCI_SEP_CHANGED_REG_OFFER");

                entity.HasIndex(e => e.RegistrationOfferRecordNo)
                    .HasName("PK_SOCI_SEP_CHANGED_REG_OFFER")
                    .IsUnique();

                entity.Property(e => e.RegistrationOfferRecordNo)
                    .HasColumnName("REGISTRATION_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.RegOfferChangedDatetime)
                    .HasColumnName("REG_OFFER_CHANGED_DATETIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSepChangedSg>(entity =>
            {
                entity.HasKey(e => e.StudentGroupRecordNo);

                entity.ToTable("SOCI_SEP_CHANGED_SG");

                entity.HasIndex(e => e.StudentGroupRecordNo)
                    .HasName("PK_SOCI_SEP_CHANGED_SG")
                    .IsUnique();

                entity.Property(e => e.StudentGroupRecordNo)
                    .HasColumnName("STUDENT_GROUP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentGroupChangedDatetime)
                    .HasColumnName("STUDENT_GROUP_CHANGED_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SociSepChangedSgOffer>(entity =>
            {
                entity.HasKey(e => e.SgOfferRecordNo);

                entity.ToTable("SOCI_SEP_CHANGED_SG_OFFER");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("PK_SOCI_SEP_CHANGED_SG_OFFER")
                    .IsUnique();

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SgOfferChangedDatetime)
                    .HasColumnName("SG_OFFER_CHANGED_DATETIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSepChangedStaff>(entity =>
            {
                entity.HasKey(e => e.StaffRecordNo);

                entity.ToTable("SOCI_SEP_CHANGED_STAFF");

                entity.HasIndex(e => e.StaffRecordNo)
                    .HasName("PK_SOCI_SEP_CHANGED_STAFF")
                    .IsUnique();

                entity.Property(e => e.StaffRecordNo)
                    .HasColumnName("STAFF_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StaffChangedDatetime)
                    .HasColumnName("STAFF_CHANGED_DATETIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSepChangedStudent>(entity =>
            {
                entity.HasKey(e => e.StudentRecordNo);

                entity.ToTable("SOCI_SEP_CHANGED_STUDENT");

                entity.HasIndex(e => e.FamilyNm)
                    .HasName("IDX_SOCI_SEPCHDSTU_FAM");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("PK_SOCI_SEP_CHANGED_STUDENT")
                    .IsUnique();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentChangedDatetime)
                    .HasColumnName("STUDENT_CHANGED_DATETIME")
                    .HasColumnType("TIMESTAMP(6)")
                    .HasDefaultValueSql("systimestamp ");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSfamily>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Famcode });

                entity.ToTable("SOCI_SFAMILY");

                entity.HasIndex(e => e.Famcode)
                    .HasName("IDX_SOCI_SFAMILY_FAMCODE");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Famcode })
                    .HasName("PK_SOCI_SFAMILY")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Famcode)
                    .HasColumnName("FAMCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Ecname)
                    .HasColumnName("ECNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Ecname2)
                    .HasColumnName("ECNAME2")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Ecphone)
                    .HasColumnName("ECPHONE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Ecphone2)
                    .HasColumnName("ECPHONE2")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Ecrelatn)
                    .HasColumnName("ECRELATN")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Ecrelatn2)
                    .HasColumnName("ECRELATN2")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasColumnType("VARCHAR2(44)");

                entity.Property(e => e.Emermobil2)
                    .HasColumnName("EMERMOBIL2")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Emermobile)
                    .HasColumnName("EMERMOBILE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Fcob)
                    .HasColumnName("FCOB")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Fdeceased)
                    .HasColumnName("FDECEASED")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fgivenname)
                    .HasColumnName("FGIVENNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Fhomelang)
                    .HasColumnName("FHOMELANG")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Fhomelang2)
                    .HasColumnName("FHOMELANG2")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Finterpret)
                    .HasColumnName("FINTERPRET")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fmobile)
                    .HasColumnName("FMOBILE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Fnscheduc)
                    .HasColumnName("FNSCHEDUC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Foccgrp)
                    .HasColumnName("FOCCGRP")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Foccupatn)
                    .HasColumnName("FOCCUPATN")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Fotherlang)
                    .HasColumnName("FOTHERLANG")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Frecvinv)
                    .HasColumnName("FRECVINV")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fscheduc)
                    .HasColumnName("FSCHEDUC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Fsurname)
                    .HasColumnName("FSURNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Ftitle)
                    .HasColumnName("FTITLE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Fwkphone)
                    .HasColumnName("FWKPHONE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Mcob)
                    .HasColumnName("MCOB")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Mdeceased)
                    .HasColumnName("MDECEASED")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Mgivenname)
                    .HasColumnName("MGIVENNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Mhomelang)
                    .HasColumnName("MHOMELANG")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Mhomelang2)
                    .HasColumnName("MHOMELANG2")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Minterpret)
                    .HasColumnName("MINTERPRET")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Mmobile)
                    .HasColumnName("MMOBILE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Mnscheduc)
                    .HasColumnName("MNSCHEDUC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Moccgrp)
                    .HasColumnName("MOCCGRP")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Moccupatn)
                    .HasColumnName("MOCCUPATN")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Motherlang)
                    .HasColumnName("MOTHERLANG")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Mrecvinv)
                    .HasColumnName("MRECVINV")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Mscheduc)
                    .HasColumnName("MSCHEDUC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Msurname)
                    .HasColumnName("MSURNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Mtitle)
                    .HasColumnName("MTITLE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Mwkphone)
                    .HasColumnName("MWKPHONE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Outarea)
                    .HasColumnName("OUTAREA")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBOX")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Resadd1)
                    .HasColumnName("RESADD1")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Resadd2)
                    .HasColumnName("RESADD2")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Resadd3)
                    .HasColumnName("RESADD3")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Respc)
                    .HasColumnName("RESPC")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepRowReplacesRecordNo)
                    .HasColumnName("SEP_ROW_REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stname)
                    .HasColumnName("STNAME")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Stnum)
                    .HasColumnName("STNUM")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("VARCHAR2(64)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSparent>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Stucode });

                entity.ToTable("SOCI_SPARENT");

                entity.HasIndex(e => e.Stucode)
                    .HasName("IDX_SOCI_SPARENT_SRN");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Stucode })
                    .HasName("PK_SOCI_SPARENT")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stucode)
                    .HasColumnName("STUCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Accesdesc)
                    .HasColumnName("ACCESDESC")
                    .HasColumnType("VARCHAR2(50)");

                entity.Property(e => e.Accessinfo)
                    .HasColumnName("ACCESSINFO")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Deceased)
                    .HasColumnName("DECEASED")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Famtitle)
                    .HasColumnName("FAMTITLE")
                    .HasColumnType("VARCHAR2(64)");

                entity.Property(e => e.Givenname)
                    .IsRequired()
                    .HasColumnName("GIVENNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Pobox)
                    .HasColumnName("POBOX")
                    .HasColumnType("VARCHAR2(40)");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Recvinv)
                    .HasColumnName("RECVINV")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Relatnship)
                    .IsRequired()
                    .HasColumnName("RELATNSHIP")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Report)
                    .HasColumnName("REPORT")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SepParentRecordNo)
                    .HasColumnName("SEP_PARENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.Stname)
                    .HasColumnName("STNAME")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Stnum)
                    .HasColumnName("STNUM")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociSstaff>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Staffcode });

                entity.ToTable("SOCI_SSTAFF");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Staffcode })
                    .HasName("PK_SOCI_SSTAFF")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Staffcode)
                    .HasColumnName("STAFFCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("DATE");

                entity.Property(e => e.Givenname)
                    .IsRequired()
                    .HasColumnName("GIVENNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepRowReplacesRecordNo)
                    .HasColumnName("SEP_ROW_REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Serialnum)
                    .IsRequired()
                    .HasColumnName("SERIALNUM")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.StatusInd)
                    .HasColumnName("STATUS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Title)
                    .HasColumnName("TITLE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<SociStudentAll>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Stucode, e.SepRegOfferCalendarYear });

                entity.ToTable("SOCI_STUDENT_ALL");

                entity.HasIndex(e => e.Stucode)
                    .HasName("IDX_SOCI_STUDENT_ALL_SRN");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Stucode, e.SepRegOfferCalendarYear })
                    .HasName("PK_SOCI_STUDENT_ALL")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.SepEnrolmentStatusInd, e.SepRegOfferCalendarYear, e.SepRowChangedDatetime })
                    .HasName("IDX_SOCI_STUDENT_ALL");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stucode)
                    .HasColumnName("STUCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepRegOfferCalendarYear)
                    .HasColumnName("SEP_REG_OFFER_CALENDAR_YEAR")
                    .HasColumnType("NUMBER(4)");

                entity.Property(e => e.Aboriginal)
                    .HasColumnName("ABORIGINAL")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Addr1)
                    .HasColumnName("ADDR1")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Allergdet)
                    .HasColumnName("ALLERGDET")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Allergies)
                    .HasColumnName("ALLERGIES")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Ate)
                    .HasColumnName("ATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.Austarrivl)
                    .HasColumnName("AUSTARRIVL")
                    .HasColumnType("DATE");

                entity.Property(e => e.Austschool)
                    .HasColumnName("AUSTSCHOOL")
                    .HasColumnType("DATE");

                entity.Property(e => e.AuthorityToPublishInd)
                    .HasColumnName("AUTHORITY_TO_PUBLISH_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Censusrept)
                    .IsRequired()
                    .HasColumnName("CENSUSREPT")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Centreind)
                    .HasColumnName("CENTREIND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Cob)
                    .HasColumnName("COB")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Dassessed)
                    .HasColumnName("DASSESSED")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Dateterm)
                    .HasColumnName("DATETERM")
                    .HasColumnType("DATE");

                entity.Property(e => e.Destsch)
                    .HasColumnName("DESTSCH")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Destschtxt)
                    .HasColumnName("DESTSCHTXT")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.DetUserId)
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("DATE");

                entity.Property(e => e.Docname)
                    .HasColumnName("DOCNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Docphone)
                    .HasColumnName("DOCPHONE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(200)");

                entity.Property(e => e.Enrolled)
                    .HasColumnName("ENROLLED")
                    .HasColumnType("DATE");

                entity.Property(e => e.EnrolmentTypeCode)
                    .HasColumnName("ENROLMENT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)");

                entity.Property(e => e.Famcode)
                    .HasColumnName("FAMCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Fundingind)
                    .HasColumnName("FUNDINGIND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Givenname)
                    .IsRequired()
                    .HasColumnName("GIVENNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Homelang)
                    .HasColumnName("HOMELANG")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Housecode)
                    .HasColumnName("HOUSECODE")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Immuncert)
                    .HasColumnName("IMMUNCERT")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Internst)
                    .HasColumnName("INTERNST")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Ispconsent)
                    .HasColumnName("ISPCONSENT")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Leaving)
                    .HasColumnName("LEAVING")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Medconsent)
                    .HasColumnName("MEDCONSENT")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Medicarenr)
                    .HasColumnName("MEDICARENR")
                    .HasColumnType("VARCHAR2(13)");

                entity.Property(e => e.Medidesc)
                    .HasColumnName("MEDIDESC")
                    .HasColumnType("VARCHAR2(100)");

                entity.Property(e => e.Mediprobs)
                    .HasColumnName("MEDIPROBS")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasColumnType("VARCHAR2(14)");

                entity.Property(e => e.Needaslsup)
                    .HasColumnName("NEEDASLSUP")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Otherlang)
                    .HasColumnName("OTHERLANG")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Otherlang2)
                    .HasColumnName("OTHERLANG2")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Photoapp)
                    .HasColumnName("PHOTOAPP")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Prefname)
                    .IsRequired()
                    .HasColumnName("PREFNAME")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Prevsch)
                    .HasColumnName("PREVSCH")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Prevschtxt)
                    .HasColumnName("PREVSCHTXT")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Privateind)
                    .HasColumnName("PRIVATEIND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PscName)
                    .HasColumnName("PSC_NAME")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PscType)
                    .HasColumnName("PSC_TYPE")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.PscWhours)
                    .HasColumnName("PSC_WHOURS")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Readingind)
                    .HasColumnName("READINGIND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.Refugee)
                    .HasColumnName("REFUGEE")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Religion)
                    .HasColumnName("RELIGION")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Rollclass)
                    .HasColumnName("ROLLCLASS")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Schprev)
                    .HasColumnName("SCHPREV")
                    .HasColumnType("VARCHAR2(20)");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.SepEnrolmentStatusInd)
                    .IsRequired()
                    .HasColumnName("SEP_ENROLMENT_STATUS_IND")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.SepHouseRecordNo)
                    .HasColumnName("SEP_HOUSE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepRegisterOfferRecordNo)
                    .HasColumnName("SEP_REGISTER_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepRollClassRecordNo)
                    .HasColumnName("SEP_ROLL_CLASS_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SepRowChangedDatetime)
                    .HasColumnName("SEP_ROW_CHANGED_DATETIME")
                    .HasColumnType("DATE");

                entity.Property(e => e.SepRowReplacesRecordNo)
                    .HasColumnName("SEP_ROW_REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("SEX")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Stdschyr)
                    .IsRequired()
                    .HasColumnName("STDSCHYR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.Stname)
                    .HasColumnName("STNAME")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Stnum)
                    .HasColumnName("STNUM")
                    .HasColumnType("VARCHAR2(132)");

                entity.Property(e => e.Supportrec)
                    .HasColumnName("SUPPORTREC")
                    .HasColumnType("VARCHAR2(1)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasColumnType("VARCHAR2(30)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Visacls)
                    .HasColumnName("VISACLS")
                    .HasColumnType("VARCHAR2(15)");

                entity.Property(e => e.Visaexpd)
                    .HasColumnName("VISAEXPD")
                    .HasColumnType("DATE");

                entity.Property(e => e.Visasubcls)
                    .HasColumnName("VISASUBCLS")
                    .HasColumnType("VARCHAR2(3)");

                entity.Property(e => e.Visatype)
                    .HasColumnName("VISATYPE")
                    .HasColumnType("VARCHAR2(1)");
            });

            modelBuilder.Entity<StoredDocument>(entity =>
            {
                entity.HasKey(e => e.StoredDocumentRecordNo)
                    .HasName("PK_STORED_DOCUMENTS");

                entity.ToTable("STORED_DOCUMENT");

                entity.HasIndex(e => e.StoredDocumentRecordNo)
                    .HasName("PK_STORED_DOCUMENTS")
                    .IsUnique();

                entity.Property(e => e.StoredDocumentRecordNo)
                    .HasColumnName("STORED_DOCUMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoredDocumentNm)
                    .IsRequired()
                    .HasColumnName("STORED_DOCUMENT_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoredDocumentType)
                    .IsRequired()
                    .HasColumnName("STORED_DOCUMENT_TYPE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoredDocumentValue)
                    .IsRequired()
                    .HasColumnName("STORED_DOCUMENT_VALUE")
                    .HasColumnType("BLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StoredImage>(entity =>
            {
                entity.HasKey(e => e.StoredImageRecordNo)
                    .HasName("PK_STORED_IMAGES");

                entity.ToTable("STORED_IMAGE");

                entity.HasIndex(e => e.StoredImageRecordNo)
                    .HasName("PK_STORED_IMAGES")
                    .IsUnique();

                entity.Property(e => e.StoredImageRecordNo)
                    .HasColumnName("STORED_IMAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoredImageNm)
                    .IsRequired()
                    .HasColumnName("STORED_IMAGE_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoredImageType)
                    .IsRequired()
                    .HasColumnName("STORED_IMAGE_TYPE")
                    .HasColumnType("VARCHAR2(16)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StoredImageValue)
                    .HasColumnName("STORED_IMAGE_VALUE")
                    .HasColumnType("BLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StuDisabDataCollAnalysis>(entity =>
            {
                entity.HasKey(e => e.StuDisabDataCollAnRecNo)
                    .HasName("PK_STU_DISAB_DATA_COLL_AN");

                entity.ToTable("STU_DISAB_DATA_COLL_ANALYSIS");

                entity.HasIndex(e => e.LevelOfAdjustmentRecordNo)
                    .HasName("SK_STU_SDDCA_LOA");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("STU_DISAB_DATA_COLL_ANAL_I5");

                entity.HasIndex(e => e.StuDataCollStatusRecNo)
                    .HasName("SK_STU_SDDCA_STATUS");

                entity.HasIndex(e => e.StuDisabDataCollAnRecNo)
                    .HasName("PK_STU_DISAB_DATA_COLL_AN")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STU_SDDCA_CODE");

                entity.Property(e => e.StuDisabDataCollAnRecNo)
                    .HasColumnName("STU_DISAB_DATA_COLL_AN_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveInd)
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdjustmentStartDate)
                    .HasColumnName("ADJUSTMENT_START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DdaDisabilityInd)
                    .HasColumnName("DDA_DISABILITY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DseParentConsultationInd)
                    .HasColumnName("DSE_PARENT_CONSULTATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceSightedInd)
                    .HasColumnName("EVIDENCE_SIGHTED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastReviewDate)
                    .HasColumnName("LAST_REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelOfAdjustmentInd)
                    .HasColumnName("LEVEL_OF_ADJUSTMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LevelOfAdjustmentRecordNo)
                    .HasColumnName("LEVEL_OF_ADJUSTMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NextReviewDate)
                    .HasColumnName("NEXT_REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OngoingAdjustmentInd)
                    .HasColumnName("ONGOING_ADJUSTMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentConsultationInd)
                    .HasColumnName("PARENT_CONSULTATION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrincipalConsentInd)
                    .HasColumnName("PRINCIPAL_CONSENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StuDataCollStatusRecNo)
                    .HasColumnName("STU_DATA_COLL_STATUS_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudentRecordNo);

                entity.ToTable("STUDENT");

                entity.HasIndex(e => e.DateOfBirth)
                    .HasName("STUDENT_IDX2");

                entity.HasIndex(e => e.GenderInd)
                    .HasName("STUDENT_IDX3")
                    .HasFilter("UPPER(\"FAMILY_NM\")");

                entity.HasIndex(e => e.Srn)
                    .HasName("SK_STUDENT_SRN")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("PK_STUDENT")
                    .IsUnique();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowPhotoInd)
                    .HasColumnName("ALLOW_PHOTO_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtsiCodeRecordNo)
                    .HasColumnName("ATSI_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuthorityToPublishInd)
                    .HasColumnName("AUTHORITY_TO_PUBLISH_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.CountryOfBirthRecordNo)
                    .HasColumnName("COUNTRY_OF_BIRTH_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("DATE_OF_BIRTH")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.DerAssignmentTypeInd)
                    .HasColumnName("DER_ASSIGNMENT_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DerBarredInd)
                    .HasColumnName("DER_BARRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DerConsentDocRecordNo)
                    .HasColumnName("DER_CONSENT_DOC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DerConsentInd)
                    .HasColumnName("DER_CONSENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.DerDisabilityFundingInd)
                    .HasColumnName("DER_DISABILITY_FUNDING_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DerGraduationDocRecordNo)
                    .HasColumnName("DER_GRADUATION_DOC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DerLoanCharterInd)
                    .HasColumnName("DER_LOAN_CHARTER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.DerLoanDocRecordNo)
                    .HasColumnName("DER_LOAN_DOC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnglishAtHomeInd)
                    .HasColumnName("ENGLISH_AT_HOME_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslAssessmentInd)
                    .HasColumnName("ESL_ASSESSMENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EslPhaseRecordNo)
                    .HasColumnName("ESL_PHASE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyNm)
                    .IsRequired()
                    .HasColumnName("FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstAustEnrolDate)
                    .HasColumnName("FIRST_AUST_ENROL_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstNm)
                    .IsRequired()
                    .HasColumnName("FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenderInd)
                    .IsRequired()
                    .HasColumnName("GENDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.IspAccessInd)
                    .HasColumnName("ISP_ACCESS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastEslAssessmentDate)
                    .HasColumnName("LAST_ESL_ASSESSMENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LatestCounsellingDate)
                    .HasColumnName("LATEST_COUNSELLING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LatestLearningPlanDate)
                    .HasColumnName("LATEST_LEARNING_PLAN_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LatestRiskAssessmentDate)
                    .HasColumnName("LATEST_RISK_ASSESSMENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LboteInd)
                    .HasColumnName("LBOTE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.MedicareExpiryDate)
                    .HasColumnName("MEDICARE_EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicareId)
                    .HasColumnName("MEDICARE_ID")
                    .HasColumnType("VARCHAR2(13)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OohcInd)
                    .HasColumnName("OOHC_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.OtherNm)
                    .HasColumnName("OTHER_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PickupInd)
                    .HasColumnName("PICKUP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFamilyNm)
                    .IsRequired()
                    .HasColumnName("PREF_FAMILY_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrefFirstNm)
                    .IsRequired()
                    .HasColumnName("PREF_FIRST_NM")
                    .HasColumnType("VARCHAR2(100)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReligionCodeRecordNo)
                    .HasColumnName("RELIGION_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentAllergyInd)
                    .HasColumnName("STUDENT_ALLERGY_IND")
                    .HasColumnType("VARCHAR2(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentBehaviourInd)
                    .HasColumnName("STUDENT_BEHAVIOUR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentMobilePhoneNo)
                    .HasColumnName("STUDENT_MOBILE_PHONE_NO")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentReferenceNumber)
                    .HasColumnName("STUDENT_REFERENCE_NUMBER")
                    .HasColumnType("VARCHAR2(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentStatusRecordNo)
                    .HasColumnName("STUDENT_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentContactCourtOrder>(entity =>
            {
                entity.HasKey(e => e.StudentContactCorRecordNo);

                entity.ToTable("STUDENT_CONTACT_COURT_ORDER");

                entity.HasIndex(e => e.CorContactRecordNo)
                    .HasName("FK_CONTACT_COURT_ORDER");

                entity.HasIndex(e => e.DossierRecordNo)
                    .HasName("FK_DOS_S_COURT_ORDER");

                entity.HasIndex(e => e.StudentContactCorRecordNo)
                    .HasName("PK_STUDENT_CONTACT_COURT_ORDER")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("FK_ST_CONTACT_COURT_ORDER");

                entity.Property(e => e.StudentContactCorRecordNo)
                    .HasColumnName("STUDENT_CONTACT_COR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorContactRecordNo)
                    .HasColumnName("COR_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentDetailChangeLog>(entity =>
            {
                entity.HasKey(e => e.ChangeLogRecordNo)
                    .HasName("SYS_C0017025");

                entity.ToTable("STUDENT_DETAIL_CHANGE_LOG");

                entity.HasIndex(e => e.ChangeLogRecordNo)
                    .HasName("SYS_C0017025")
                    .IsUnique();

                entity.Property(e => e.ChangeLogRecordNo)
                    .HasColumnName("CHANGE_LOG_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AffectedOrgUnitRecordNo)
                    .HasColumnName("AFFECTED_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AuditDate)
                    .HasColumnName("AUDIT_DATE")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuditTask)
                    .HasColumnName("AUDIT_TASK")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuditUsername)
                    .HasColumnName("AUDIT_USERNAME")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeLogCategoryRecordNo)
                    .HasColumnName("CHANGE_LOG_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ChangedByOrgUnitRecordNo)
                    .HasColumnName("CHANGED_BY_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");

                entity.HasOne(d => d.ChangeLogCategoryRecordNoNavigation)
                    .WithMany(p => p.StudentDetailChangeLog)
                    .HasForeignKey(d => d.ChangeLogCategoryRecordNo)
                    .HasConstraintName("SYS_C0017613");
            });

            modelBuilder.Entity<StudentDisabilityType>(entity =>
            {
                entity.HasKey(e => e.StudentDisabilityTypeRecNo)
                    .HasName("PK_STU_DISAB_TYPE");

                entity.ToTable("STUDENT_DISABILITY_TYPE");

                entity.HasIndex(e => e.DisabilityTypeRecordNo)
                    .HasName("SK_STU_DISAB_TYPE_DTR");

                entity.HasIndex(e => e.StuDisabDataCollAnRecNo)
                    .HasName("SK_STU_DISAB_TYPE_DCA");

                entity.HasIndex(e => e.StudentDisabilityTypeRecNo)
                    .HasName("PK_STU_DISAB_TYPE")
                    .IsUnique();

                entity.Property(e => e.StudentDisabilityTypeRecNo)
                    .HasColumnName("STUDENT_DISABILITY_TYPE_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisabilityTypeRecordNo)
                    .HasColumnName("DISABILITY_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrimaryDisabilityTypeInd)
                    .HasColumnName("PRIMARY_DISABILITY_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StuDisabDataCollAnRecNo)
                    .HasColumnName("STU_DISAB_DATA_COLL_AN_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentDoctor>(entity =>
            {
                entity.HasKey(e => e.StudentDoctorRecordNo);

                entity.ToTable("STUDENT_DOCTOR");

                entity.HasIndex(e => e.StudentDoctorRecordNo)
                    .HasName("PK_STUDENT_DOCTOR")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STUDENT_DOCTOR");

                entity.Property(e => e.StudentDoctorRecordNo)
                    .HasColumnName("STUDENT_DOCTOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressDetailRecordNo)
                    .HasColumnName("ADDRESS_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeRecordNo)
                    .HasColumnName("ADDRESS_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactPermissionInd)
                    .HasColumnName("CONTACT_PERMISSION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DoctorNm)
                    .HasColumnName("DOCTOR_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentDoctorContact>(entity =>
            {
                entity.HasKey(e => e.StudentDocContactRecordNo);

                entity.ToTable("STUDENT_DOCTOR_CONTACT");

                entity.HasIndex(e => e.StudentDocContactRecordNo)
                    .HasName("PK_STUDENT_DOCTOR_CONTACT")
                    .IsUnique();

                entity.HasIndex(e => e.StudentDoctorRecordNo)
                    .HasName("SK_STUDENT_DOCTOR_CONTACT");

                entity.Property(e => e.StudentDocContactRecordNo)
                    .HasColumnName("STUDENT_DOC_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactDetailRecordNo)
                    .HasColumnName("CONTACT_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactTypeRecordNo)
                    .HasColumnName("CONTACT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentDoctorRecordNo)
                    .HasColumnName("STUDENT_DOCTOR_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentDossier>(entity =>
            {
                entity.HasKey(e => e.StudentDossierRecordNo);

                entity.ToTable("STUDENT_DOSSIER");

                entity.HasIndex(e => e.StudentDossierRecordNo)
                    .HasName("PK_STUDENT_DOSSIER")
                    .IsUnique();

                entity.HasIndex(e => new { e.StudentRecordNo, e.StudentDossierRecordNo })
                    .HasName("SK_STUDENT_DOSSIER")
                    .IsUnique();

                entity.Property(e => e.StudentDossierRecordNo)
                    .HasColumnName("STUDENT_DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentEmergencyContact>(entity =>
            {
                entity.HasKey(e => e.StudentEmerContactRecordNo);

                entity.ToTable("STUDENT_EMERGENCY_CONTACT");

                entity.HasIndex(e => e.EmergencyContactRecordNo)
                    .HasName("SK2_STUDENT_EMERGENCY_CONTACT");

                entity.HasIndex(e => e.StudentEmerContactRecordNo)
                    .HasName("PK_STUDENT_EMERGENCY_CONTACT")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STUDENT_EMERGENCY_CONTACT");

                entity.Property(e => e.StudentEmerContactRecordNo)
                    .HasColumnName("STUDENT_EMER_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmergencyContactRecordNo)
                    .HasColumnName("EMERGENCY_CONTACT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreferredSequenceNo)
                    .HasColumnName("PREFERRED_SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentEvidence>(entity =>
            {
                entity.HasKey(e => e.StudentEvidenceRecordNo);

                entity.ToTable("STUDENT_EVIDENCE");

                entity.HasIndex(e => e.StudentEvidenceRecordNo)
                    .HasName("PK_STUDENT_EVIDENCE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STUDENT_EVIDENCE");

                entity.Property(e => e.StudentEvidenceRecordNo)
                    .HasColumnName("STUDENT_EVIDENCE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateSighted)
                    .HasColumnName("DATE_SIGHTED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceCategoryRecordNo)
                    .HasColumnName("EVIDENCE_CATEGORY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvidenceTypeRecordNo)
                    .HasColumnName("EVIDENCE_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerifiedStatusRecordNo)
                    .HasColumnName("VERIFIED_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentFamilyChangeLog>(entity =>
            {
                entity.HasKey(e => e.SfclRecordNo);

                entity.ToTable("STUDENT_FAMILY_CHANGE_LOG");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("STUDENT_FAMILY_CHANGE_LOG_SK1");

                entity.HasIndex(e => e.SfclRecordNo)
                    .HasName("PK_STUDENT_FAMILY_CHANGE_LOG")
                    .IsUnique();

                entity.HasIndex(e => new { e.AuditDate, e.StudentRecordNo })
                    .HasName("STUDENT_FAMILY_CHANGE_LOG_SK");

                entity.Property(e => e.SfclRecordNo)
                    .HasColumnName("SFCL_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.AuditDate)
                    .HasColumnName("AUDIT_DATE")
                    .HasColumnType("TIMESTAMP(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuditTask)
                    .HasColumnName("AUDIT_TASK")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuditUsername)
                    .HasColumnName("AUDIT_USERNAME")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangedByOrgUnitRecordNo)
                    .HasColumnName("CHANGED_BY_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.FromFamilyRecordNo)
                    .HasColumnName("FROM_FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ToFamilyRecordNo)
                    .HasColumnName("TO_FAMILY_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<StudentGroup>(entity =>
            {
                entity.HasKey(e => e.StudentGroupRecordNo);

                entity.ToTable("STUDENT_GROUP");

                entity.HasIndex(e => e.MembershipCurrentInd)
                    .HasName("IDX1_STUDENT_GROUP");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("SK1_STUDENT_GROUP");

                entity.HasIndex(e => e.StudentGroupRecordNo)
                    .HasName("PK_STUDENT_GROUP")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STUDENT_GROUP");

                entity.Property(e => e.StudentGroupRecordNo)
                    .HasColumnName("STUDENT_GROUP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MembershipCurrentInd)
                    .HasColumnName("MEMBERSHIP_CURRENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentGroupBak081018>(entity =>
            {
                entity.HasKey(e => e.StudentGroupRecordNo);

                entity.ToTable("STUDENT_GROUP_BAK_081018");

                entity.HasIndex(e => e.StudentGroupRecordNo)
                    .HasName("PK_STUDENT_GROUP_BAK_081018")
                    .IsUnique();

                entity.Property(e => e.StudentGroupRecordNo)
                    .HasColumnName("STUDENT_GROUP_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.MembershipCurrentInd)
                    .HasColumnName("MEMBERSHIP_CURRENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'Y'");

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<StudentGroupOffer>(entity =>
            {
                entity.HasKey(e => e.SgOfferRecordNo);

                entity.ToTable("STUDENT_GROUP_OFFER");

                entity.HasIndex(e => e.ActivityTypeRecordNo)
                    .HasName("FK_STUDENT_GROUP_OFFER_AT");

                entity.HasIndex(e => e.CurriculumOfferRecordNo)
                    .HasName("FK_STUDENT_GROUP_OFFER_CO");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("FK_STUDENT_GROUP_OFFER");

                entity.HasIndex(e => e.ReportsToRecordNo)
                    .HasName("FK_STUDENT_GROUP_OFFER_RT");

                entity.HasIndex(e => e.SgOfferRecordNo)
                    .HasName("PK_STUDENT_GROUP_OFFER")
                    .IsUnique();

                entity.HasIndex(e => new { e.FromDate, e.ToDate })
                    .HasName("IDX_STUDENT_GROUP_OFFER_FD_TD");

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActivityTypeRecordNo)
                    .HasColumnName("ACTIVITY_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConnectedClassroomInd)
                    .HasColumnName("CONNECTED_CLASSROOM_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrentPlaces)
                    .HasColumnName("CURRENT_PLACES")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurriculumOfferRecordNo)
                    .HasColumnName("CURRICULUM_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultSubgroupInd)
                    .IsRequired()
                    .HasColumnName("DEFAULT_SUBGROUP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.DistanceEdInd)
                    .IsRequired()
                    .HasColumnName("DISTANCE_ED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.FromDate)
                    .HasColumnName("FROM_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastRefreshedDate)
                    .HasColumnName("LAST_REFRESHED_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxPlaces)
                    .HasColumnName("MAX_PLACES")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.NumberOfPeriods)
                    .HasColumnName("NUMBER_OF_PERIODS")
                    .HasColumnType("NUMBER(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasisXrefClassName)
                    .HasColumnName("OASIS_XREF_CLASS_NAME")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasisXrefClassNum)
                    .HasColumnName("OASIS_XREF_CLASS_NUM")
                    .HasColumnType("NUMBER(2)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasisXrefCode)
                    .HasColumnName("OASIS_XREF_CODE")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasisXrefComcode)
                    .HasColumnName("OASIS_XREF_COMCODE")
                    .HasColumnType("VARCHAR2(4)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasisXrefComname)
                    .HasColumnName("OASIS_XREF_COMNAME")
                    .HasColumnType("VARCHAR2(10)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OasisXrefDesc)
                    .HasColumnName("OASIS_XREF_DESC")
                    .HasColumnType("VARCHAR2(20)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfferingStatusRecordNo)
                    .HasColumnName("OFFERING_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RefreshInd)
                    .HasColumnName("REFRESH_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RefreshReqDate)
                    .HasColumnName("REFRESH_REQ_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportingGroupInd)
                    .IsRequired()
                    .HasColumnName("REPORTING_GROUP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N' ");

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.RollClassInd)
                    .HasColumnName("ROLL_CLASS_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.SgOfferNm)
                    .IsRequired()
                    .HasColumnName("SG_OFFER_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SgOfferPrintNm)
                    .HasColumnName("SG_OFFER_PRINT_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentReportingInd)
                    .IsRequired()
                    .HasColumnName("STUDENT_REPORTING_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ToDate)
                    .HasColumnName("TO_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentIdentity>(entity =>
            {
                entity.HasKey(e => e.StudentRecordNo);

                entity.ToTable("STUDENT_IDENTITY");

                entity.HasIndex(e => e.Srn)
                    .HasName("STUDENT_IDENTITY_1");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("PK_STUDENT_IDENTITY")
                    .IsUnique();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetUserId)
                    .HasColumnName("DET_USER_ID")
                    .HasColumnType("VARCHAR2(200)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailAddress)
                    .HasColumnName("EMAIL_ADDRESS")
                    .HasColumnType("VARCHAR2(200)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(50)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Srn)
                    .HasColumnName("SRN")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentIecType>(entity =>
            {
                entity.HasKey(e => e.StudentIecTypeRecordNo);

                entity.ToTable("STUDENT_IEC_TYPE");

                entity.HasIndex(e => e.IecTypeRecordNo)
                    .HasName("STUDENT_IEC_TYPE_I1");

                entity.HasIndex(e => e.StudentIecTypeRecordNo)
                    .HasName("PK_STUDENT_IEC_TYPE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("STUDENT_IEC_TYPE_I2");

                entity.Property(e => e.StudentIecTypeRecordNo)
                    .HasColumnName("STUDENT_IEC_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateReviewed)
                    .HasColumnName("DATE_REVIEWED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.IecTypeRecordNo)
                    .HasColumnName("IEC_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentLanguage>(entity =>
            {
                entity.HasKey(e => e.StudentLanguageRecordNo);

                entity.ToTable("STUDENT_LANGUAGE");

                entity.HasIndex(e => e.StudentLanguageRecordNo)
                    .HasName("PK_STUDENT_LANGUAGE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STUDENT_LANGUAGE");

                entity.Property(e => e.StudentLanguageRecordNo)
                    .HasColumnName("STUDENT_LANGUAGE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageCodeRecordNo)
                    .HasColumnName("LANGUAGE_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentLanguageCodeInd)
                    .IsRequired()
                    .HasColumnName("STUDENT_LANGUAGE_CODE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentMedicalDocumentation>(entity =>
            {
                entity.HasKey(e => e.StudentMedicalDocRecordNo)
                    .HasName("PK_STUDENT_MEDICAL_DOC");

                entity.ToTable("STUDENT_MEDICAL_DOCUMENTATION");

                entity.HasIndex(e => e.DocumentationTypeRecordNo)
                    .HasName("FK_STUDENT_MEDICAL_DOC_TYPE");

                entity.HasIndex(e => e.MedDocumentationRecordNo)
                    .HasName("FK_S_MEDICAL_DOC_RECNO");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("FK_S_MEDICAL_DOC_ORG_UNIT");

                entity.HasIndex(e => e.StudentMedCondRecordNo)
                    .HasName("FK_S_MEDICAL_DOC_MED_COND");

                entity.HasIndex(e => e.StudentMedicalDocRecordNo)
                    .HasName("PK_STUDENT_MEDICAL_DOC")
                    .IsUnique();

                entity.Property(e => e.StudentMedicalDocRecordNo)
                    .HasColumnName("STUDENT_MEDICAL_DOC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocumentationTypeRecordNo)
                    .HasColumnName("DOCUMENTATION_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedDocumentationRecordNo)
                    .HasColumnName("MED_DOCUMENTATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReviewDate)
                    .HasColumnName("REVIEW_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentMedCondRecordNo)
                    .HasColumnName("STUDENT_MED_COND_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentMedicalDocInd)
                    .HasColumnName("STUDENT_MEDICAL_DOC_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentMedication>(entity =>
            {
                entity.HasKey(e => e.StudentMedRecordNo);

                entity.ToTable("STUDENT_MEDICATION");

                entity.HasIndex(e => e.DossierRecordNo)
                    .HasName("FK_STUDENT_MEDICATION_DOSSIER");

                entity.HasIndex(e => e.MedicationAdminRecordNo)
                    .HasName("FK_STUDENT_MEDICATION_MED_ADM");

                entity.HasIndex(e => e.MedicationCatRecordNo)
                    .HasName("FK_STUDENT_MEDICATION_TYPE");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("FK_STUDENT_MEDICATION_ORG");

                entity.HasIndex(e => e.StudentMedCondRecordNo)
                    .HasName("FK_STUDENT_MED_ST_MED_CON");

                entity.HasIndex(e => e.StudentMedRecordNo)
                    .HasName("PK_STUDENT_MEDICATION")
                    .IsUnique();

                entity.Property(e => e.StudentMedRecordNo)
                    .HasColumnName("STUDENT_MED_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dosage)
                    .HasColumnName("DOSAGE")
                    .HasColumnType("VARCHAR2(128)")
                    .HasDefaultValueSql("'unknown/not provided - see notes' ");

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpiryDate)
                    .HasColumnName("EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.HasBeenProvidedInd)
                    .HasColumnName("HAS_BEEN_PROVIDED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LastUserUpdate)
                    .IsRequired()
                    .HasColumnName("LAST_USER_UPDATE")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicationAdminRecordNo)
                    .HasColumnName("MEDICATION_ADMIN_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicationCatRecordNo)
                    .HasColumnName("MEDICATION_CAT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(128)")
                    .HasDefaultValueSql("'unknown/not provided - see notes' ");

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentMedCondRecordNo)
                    .HasColumnName("STUDENT_MED_COND_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentOutOfHomeCare>(entity =>
            {
                entity.HasKey(e => e.StudentOohcRecordNo)
                    .HasName("PK_STUDENT_OOHC");

                entity.ToTable("STUDENT_OUT_OF_HOME_CARE");

                entity.HasIndex(e => e.OohcTypeRecordNo)
                    .HasName("STUDENT_OUT_OF_HOME_CARE_I1");

                entity.HasIndex(e => e.StudentEvidenceRecordNo)
                    .HasName("STUDENT_OUT_OF_HOME_CARE_I2");

                entity.HasIndex(e => e.StudentOohcRecordNo)
                    .HasName("PK_STUDENT_OUT_OF_HOME_CARE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("STUDENT_OUT_OF_HOME_CARE_I3");

                entity.Property(e => e.StudentOohcRecordNo)
                    .HasColumnName("STUDENT_OOHC_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OohcTypeRecordNo)
                    .HasColumnName("OOHC_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentEvidenceRecordNo)
                    .HasColumnName("STUDENT_EVIDENCE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasColumnType("VARCHAR2(152)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentPickup>(entity =>
            {
                entity.HasKey(e => e.StudentPickupRecordNo);

                entity.ToTable("STUDENT_PICKUP");

                entity.HasIndex(e => e.StudentPickupRecordNo)
                    .HasName("PK_STUDENT_PICKUP")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("SK_STUDENT_PICKUP");

                entity.Property(e => e.StudentPickupRecordNo)
                    .HasColumnName("STUDENT_PICKUP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressDetailRecordNo)
                    .HasColumnName("ADDRESS_DETAIL_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressTypeRecordNo)
                    .HasColumnName("ADDRESS_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PickupNm)
                    .IsRequired()
                    .HasColumnName("PICKUP_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentPlspFile>(entity =>
            {
                entity.HasKey(e => e.StudentPlspFileRecordNo)
                    .HasName("STUDENT_PLSP_FILE_PK");

                entity.ToTable("STUDENT_PLSP_FILE");

                entity.HasIndex(e => e.StudentPlspFileRecordNo)
                    .HasName("STUDENT_PLSP_FILE_PK")
                    .IsUnique();

                entity.Property(e => e.StudentPlspFileRecordNo)
                    .HasColumnName("STUDENT_PLSP_FILE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateAdded)
                    .HasColumnName("DATE_ADDED")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileContent)
                    .HasColumnName("FILE_CONTENT")
                    .HasColumnType("BLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.FileNm)
                    .HasColumnName("FILE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentPlspRecordNo)
                    .HasColumnName("STUDENT_PLSP_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentPscIntake>(entity =>
            {
                entity.HasKey(e => e.StudentPscIntakeRecordNo);

                entity.ToTable("STUDENT_PSC_INTAKE");

                entity.HasIndex(e => e.PscTypeRecordNo)
                    .HasName("STUDENT_PSC_INTAKE_I1");

                entity.HasIndex(e => e.PscWhoursTypeRecordNo)
                    .HasName("STUDENT_PSC_INTAKE_I2");

                entity.HasIndex(e => e.StudentPscIntakeRecordNo)
                    .HasName("PK_STUDENT_PSC_INTAKE")
                    .IsUnique();

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("STUDENT_PSC_INTAKE_I3");

                entity.Property(e => e.StudentPscIntakeRecordNo)
                    .HasColumnName("STUDENT_PSC_INTAKE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PostCode)
                    .HasColumnName("POST_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousOrgUnitRecordNo)
                    .HasColumnName("PREVIOUS_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousSchoolNm)
                    .HasColumnName("PREVIOUS_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscTypeRecordNo)
                    .HasColumnName("PSC_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PscWhoursTypeRecordNo)
                    .HasColumnName("PSC_WHOURS_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SchoolType)
                    .HasColumnName("SCHOOL_TYPE")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentRegistration>(entity =>
            {
                entity.HasKey(e => e.StudentRegistrationRecordNo)
                    .HasName("STUDENT_REGISTRATION_PK");

                entity.ToTable("STUDENT_REGISTRATION");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("STUDENT_REGISTRATION_SK");

                entity.HasIndex(e => e.StudentRegistrationRecordNo)
                    .HasName("STUDENT_REGISTRATION_PK")
                    .IsUnique();

                entity.HasIndex(e => new { e.LeaverDestinationRecordNo, e.LeavingDate, e.StudentRegistrationRecordNo, e.StudentRecordNo })
                    .HasName("NDX_STUDENTREGISTRATIONDEST");

                entity.Property(e => e.StudentRegistrationRecordNo)
                    .HasColumnName("STUDENT_REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualViolenceInd)
                    .HasColumnName("ACTUAL_VIOLENCE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnrolmentCommentRecordNo)
                    .HasColumnName("ENROLMENT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.HomeModSchoolRequiredInd)
                    .HasColumnName("HOME_MOD_SCHOOL_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.IllegalDrugInd)
                    .HasColumnName("ILLEGAL_DRUG_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LearningSupportRequiredInd)
                    .HasColumnName("LEARNING_SUPPORT_REQUIRED_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.LeaverDestinationNm)
                    .HasColumnName("LEAVER_DESTINATION_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaverDestinationRecordNo)
                    .HasColumnName("LEAVER_DESTINATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaverToOrgUnitRecordNo)
                    .HasColumnName("LEAVER_TO_ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeaverToSchoolNm)
                    .HasColumnName("LEAVER_TO_SCHOOL_NM")
                    .HasColumnType("VARCHAR2(132)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LeavingDate)
                    .HasColumnName("LEAVING_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.LowIncomeCardNo)
                    .HasColumnName("LOW_INCOME_CARD_NO")
                    .HasColumnType("VARCHAR2(15)")
                    .ValueGeneratedNever();

                entity.Property(e => e.LowIncomeInd)
                    .HasColumnName("LOW_INCOME_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.NonGovHs)
                    .HasColumnName("NON_GOV_HS")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherIncCommentRecordNo)
                    .HasColumnName("OTHER_INC_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.OtherIncidentInd)
                    .HasColumnName("OTHER_INCIDENT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PlspInd)
                    .IsRequired()
                    .HasColumnName("PLSP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'N'");

                entity.Property(e => e.PossessionWeaponInd)
                    .HasColumnName("POSSESSION_WEAPON_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrevContactCommentRecordNo)
                    .HasColumnName("PREV_CONTACT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrevHistCommentRecordNo)
                    .HasColumnName("PREV_HIST_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PrevPlspInd)
                    .HasColumnName("PREV_PLSP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.PrevPlspIndCommentRecNo)
                    .HasColumnName("PREV_PLSP_IND_COMMENT_REC_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousHistoryInd)
                    .HasColumnName("PREVIOUS_HISTORY_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ScriptureGroup)
                    .HasColumnName("SCRIPTURE_GROUP")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SeeInd)
                    .HasColumnName("SEE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.SelectiveHs)
                    .HasColumnName("SELECTIVE_HS")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SgOfferRecordNo)
                    .HasColumnName("SG_OFFER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpecialCircCommentRecordNo)
                    .HasColumnName("SPECIAL_CIRC_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpecialCircumstanceInd)
                    .HasColumnName("SPECIAL_CIRCUMSTANCE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpecialNeedCommentRecordNo)
                    .HasColumnName("SPECIAL_NEED_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SreInd)
                    .HasColumnName("SRE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("'X'");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspendExpellInd)
                    .HasColumnName("SUSPEND_EXPELL_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ThreatViolenceInd)
                    .HasColumnName("THREAT_VIOLENCE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VerbalAdviceInd)
                    .HasColumnName("VERBAL_ADVICE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ViolentBehCommentRecordNo)
                    .HasColumnName("VIOLENT_BEH_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ViolentBehaviourInd)
                    .HasColumnName("VIOLENT_BEHAVIOUR_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentResidency>(entity =>
            {
                entity.HasKey(e => e.StudentResidencyRecordNo);

                entity.ToTable("STUDENT_RESIDENCY");

                entity.HasIndex(e => e.StudentResidencyRecordNo)
                    .HasName("PK_STUDENT_RESIDENCY")
                    .IsUnique();

                entity.HasIndex(e => new { e.StudentRecordNo, e.StudentResidencyRecordNo })
                    .HasName("SK_STUDENT_RESIDENCY")
                    .IsUnique();

                entity.Property(e => e.StudentResidencyRecordNo)
                    .HasColumnName("STUDENT_RESIDENCY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArrivedInAustraliaDate)
                    .HasColumnName("ARRIVED_IN_AUSTRALIA_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AteExpiryDate)
                    .HasColumnName("ATE_EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.AteStartDate)
                    .HasColumnName("ATE_START_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.AuthorityToEnrolNo)
                    .HasColumnName("AUTHORITY_TO_ENROL_NO")
                    .HasColumnType("VARCHAR2(32)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoiCountryRecordNo)
                    .HasColumnName("COI_COUNTRY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnName("EFFECTIVE_END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectiveFromDate)
                    .HasColumnName("EFFECTIVE_FROM_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResidencyStatusRecordNo)
                    .HasColumnName("RESIDENCY_STATUS_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReturnedToAustraliaDate)
                    .HasColumnName("RETURNED_TO_AUSTRALIA_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentEvidenceRecordNo)
                    .HasColumnName("STUDENT_EVIDENCE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TravelDocumentId)
                    .HasColumnName("TRAVEL_DOCUMENT_ID")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaClassCodeRecordNo)
                    .HasColumnName("VISA_CLASS_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaExpiryDate)
                    .HasColumnName("VISA_EXPIRY_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.VisaHolderInd)
                    .HasColumnName("VISA_HOLDER_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<StudentSuspension>(entity =>
            {
                entity.HasKey(e => e.StudentSuspensionRecordNo);

                entity.ToTable("STUDENT_SUSPENSION");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("FK_STUDENT_SUSPENSION");

                entity.HasIndex(e => e.StudentSuspensionRecordNo)
                    .HasName("PK_STUDENT_SUSPENSION")
                    .IsUnique();

                entity.HasIndex(e => e.SuspensionIncidentRecordNo)
                    .HasName("SK2_STUDENT_SUSPENSION");

                entity.HasIndex(e => e.SuspensionReasonRecordNo)
                    .HasName("SK1_STUDENT_SUSPENSION");

                entity.Property(e => e.StudentSuspensionRecordNo)
                    .HasColumnName("STUDENT_SUSPENSION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.RegistrationRecordNo)
                    .HasColumnName("REGISTRATION_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportsToGuid)
                    .HasColumnName("REPORTS_TO_GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResolutionDate)
                    .HasColumnName("RESOLUTION_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentDossierRecordNo)
                    .HasColumnName("STUDENT_DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionDuration)
                    .HasColumnName("SUSPENSION_DURATION")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionFromDate)
                    .HasColumnName("SUSPENSION_FROM_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionIncidentRecordNo)
                    .HasColumnName("SUSPENSION_INCIDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionReasonRecordNo)
                    .HasColumnName("SUSPENSION_REASON_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionToDate)
                    .HasColumnName("SUSPENSION_TO_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<StudentSuspensionOld>(entity =>
            {
                entity.HasKey(e => e.StudentSuspensionRecordNo)
                    .HasName("STUDENT_SUSPENSION_PK");

                entity.ToTable("STUDENT_SUSPENSION_OLD");

                entity.HasIndex(e => e.StudentRecordNo)
                    .HasName("STUDENT_SUSPENSION_FK");

                entity.HasIndex(e => e.StudentSuspensionRecordNo)
                    .HasName("STUDENT_SUSPENSION_PK")
                    .IsUnique();

                entity.Property(e => e.StudentSuspensionRecordNo)
                    .HasColumnName("STUDENT_SUSPENSION_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentDossierRecordNo)
                    .HasColumnName("STUDENT_DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.StudentRecordNo)
                    .HasColumnName("STUDENT_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.SuspensionFromDate)
                    .HasColumnName("SUSPENSION_FROM_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.SuspensionToDate)
                    .HasColumnName("SUSPENSION_TO_DATE")
                    .HasColumnType("DATE");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<StudentType>(entity =>
            {
                entity.HasKey(e => e.StudentTypeRecordNo);

                entity.ToTable("STUDENT_TYPE");

                entity.HasIndex(e => e.StudentTypeRecordNo)
                    .HasName("PK_STUDENT_TYPE")
                    .IsUnique();

                entity.Property(e => e.StudentTypeRecordNo)
                    .HasColumnName("STUDENT_TYPE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveInd)
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentTypeCode)
                    .IsRequired()
                    .HasColumnName("STUDENT_TYPE_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.StudentTypeNm)
                    .IsRequired()
                    .HasColumnName("STUDENT_TYPE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SuspensionIncident>(entity =>
            {
                entity.HasKey(e => e.SuspensionIncidentRecordNo);

                entity.ToTable("SUSPENSION_INCIDENT");

                entity.HasIndex(e => e.OrgUnitRecordNo)
                    .HasName("SK2_SUSPENSION_INCIDENT");

                entity.HasIndex(e => e.SuspensionIncidentRecordNo)
                    .HasName("PK_SUSPENSION_INCIDENT")
                    .IsUnique();

                entity.Property(e => e.SuspensionIncidentRecordNo)
                    .HasColumnName("SUSPENSION_INCIDENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupInd)
                    .HasColumnName("GROUP_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasColumnType("VARCHAR2(36)")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrgUnitRecordNo)
                    .HasColumnName("ORG_UNIT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionIncidentDate)
                    .HasColumnName("SUSPENSION_INCIDENT_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionIncidentDesc)
                    .IsRequired()
                    .HasColumnName("SUSPENSION_INCIDENT_DESC")
                    .HasColumnType("VARCHAR2(1024)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspensionIncidentNm)
                    .HasColumnName("SUSPENSION_INCIDENT_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SuspexReasonCode>(entity =>
            {
                entity.HasKey(e => e.SuspexReasonCodeRecordNo)
                    .HasName("PK_SUSPEX_REASON_CODES");

                entity.ToTable("SUSPEX_REASON_CODE");

                entity.HasIndex(e => e.SuspexReasonCode1)
                    .HasName("SK_SUSPEX_REASON_CODES")
                    .IsUnique();

                entity.HasIndex(e => e.SuspexReasonCodeRecordNo)
                    .HasName("PK_SUSPEX_REASON_CODES")
                    .IsUnique();

                entity.Property(e => e.SuspexReasonCodeRecordNo)
                    .HasColumnName("SUSPEX_REASON_CODE_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiveInd)
                    .HasColumnName("ACTIVE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultInd)
                    .HasColumnName("DEFAULT_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.FamilyInstitutionInd)
                    .IsRequired()
                    .HasColumnName("FAMILY_INSTITUTION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceDataTypeInd)
                    .IsRequired()
                    .HasColumnName("REFERENCE_DATA_TYPE_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReplacesRecordNo)
                    .HasColumnName("REPLACES_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReportsToRecordNo)
                    .HasColumnName("REPORTS_TO_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.SequenceNo)
                    .HasColumnName("SEQUENCE_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("DATE")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspexActionInd)
                    .IsRequired()
                    .HasColumnName("SUSPEX_ACTION_IND")
                    .HasColumnType("VARCHAR2(1)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspexReasonCode1)
                    .IsRequired()
                    .HasColumnName("SUSPEX_REASON_CODE")
                    .HasColumnType("VARCHAR2(8)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspexReasonNm)
                    .IsRequired()
                    .HasColumnName("SUSPEX_REASON_NM")
                    .HasColumnType("VARCHAR2(64)")
                    .ValueGeneratedNever();

                entity.Property(e => e.SuspexReasonRecordNo)
                    .HasColumnName("SUSPEX_REASON_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TextComment>(entity =>
            {
                entity.HasKey(e => e.TextCommentRecordNo)
                    .HasName("PK_TEXTCOMMENTS");

                entity.ToTable("TEXT_COMMENT");

                entity.HasIndex(e => e.TextCommentRecordNo)
                    .HasName("PK_TEXT_COMMENTS")
                    .IsUnique();

                entity.Property(e => e.TextCommentRecordNo)
                    .HasColumnName("TEXT_COMMENT_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.TextCommentValue)
                    .HasColumnName("TEXT_COMMENT_VALUE")
                    .HasColumnType("VARCHAR2(2048)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .HasDefaultValueSql("0 ");
            });

            modelBuilder.Entity<TipOfTheDay>(entity =>
            {
                entity.HasKey(e => e.TipOfTheDayRecordNo);

                entity.ToTable("TIP_OF_THE_DAY");

                entity.HasIndex(e => e.TipOfTheDayRecordNo)
                    .HasName("PK_TIP_OF_THE_DAY")
                    .IsUnique();

                entity.Property(e => e.TipOfTheDayRecordNo)
                    .HasColumnName("TIP_OF_THE_DAY_RECORD_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationTopMenu)
                    .HasColumnName("APPLICATION_TOP_MENU")
                    .HasColumnType("VARCHAR2(30)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Image)
                    .HasColumnName("IMAGE")
                    .HasColumnType("BLOB")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImageNm)
                    .IsRequired()
                    .HasColumnName("IMAGE_NM")
                    .HasColumnType("VARCHAR2(128)")
                    .ValueGeneratedNever();

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TmpArDossier>(entity =>
            {
                entity.HasKey(e => e.ArDossierRecordNo)
                    .HasName("PK_AR_DOSSIER");

                entity.ToTable("TMP_AR_DOSSIER");

                entity.HasIndex(e => e.ArDossierRecordNo)
                    .HasName("PK_AR_DOSSIER")
                    .IsUnique();

                entity.Property(e => e.ArDossierRecordNo)
                    .HasColumnName("AR_DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.ArAccessRecordNo)
                    .HasColumnName("AR_ACCESS_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DossierRecordNo)
                    .HasColumnName("DOSSIER_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");
            });

            modelBuilder.Entity<TtIclass>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode, e.Classnum });

                entity.ToTable("TT_ICLASS");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod })
                    .HasName("IDX_TT_ICLASS");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode, e.Classnum })
                    .HasName("PK_TT_ICLASS")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Coursecode)
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Comcode)
                    .HasColumnName("COMCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Comperiods)
                    .HasColumnName("COMPERIODS")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Count).HasColumnName("COUNT");

                entity.Property(e => e.Ernrecno)
                    .HasColumnName("ERNRECNO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Mxclassnum)
                    .HasColumnName("MXCLASSNUM")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");

                entity.Property(e => e.Staffid)
                    .HasColumnName("STAFFID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Subcode)
                    .HasColumnName("SUBCODE")
                    .HasColumnType("VARCHAR2(3)");
            });

            modelBuilder.Entity<TtIclteach>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode, e.Staffid, e.Classnum });

                entity.ToTable("TT_ICLTEACH");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.Coursecode, e.Staffid, e.Classnum })
                    .HasName("PK_TT_ICLTEACH");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Coursecode)
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Staffid)
                    .HasColumnName("STAFFID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Schyear)
                    .IsRequired()
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");
            });

            modelBuilder.Entity<TtIcom>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Comcode, e.Acperiod });

                entity.ToTable("TT_ICOM");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_TT_ICOM_ODB_CODE");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Comcode, e.Acperiod })
                    .HasName("PK_TT_ICOM");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Comcode)
                    .HasColumnName("COMCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Acperiod)
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Comname)
                    .HasColumnName("COMNAME")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.Comstaff).HasColumnName("COMSTAFF");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<TtIcomclas>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Comcode, e.Coursecode, e.Acperiod, e.Classnum });

                entity.ToTable("TT_ICOMCLAS");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_TT_ICOMCLAS_ODB_CODE");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Comcode, e.Coursecode, e.Acperiod, e.Classnum })
                    .HasName("PK_TT_ICOMCLAS")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Comcode)
                    .HasColumnName("COMCODE")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Coursecode)
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Acperiod)
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Numperiods)
                    .HasColumnName("NUMPERIODS")
                    .HasColumnType("NUMBER(2)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Schyear)
                    .HasColumnName("SCHYEAR")
                    .HasColumnType("VARCHAR2(2)");
            });

            modelBuilder.Entity<TtSclass>(entity =>
            {
                entity.HasKey(e => new { e.OasisDatabaseRecordNo, e.Stucode, e.Coursecode, e.Acperiod, e.Classnum });

                entity.ToTable("TT_SCLASS");

                entity.HasIndex(e => e.OasisDatabaseRecordNo)
                    .HasName("IDX_TT_SCLASS_OASIS_DB_CODE");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Coursecode, e.Acperiod, e.Classnum })
                    .HasName("IDX_TT_SCLASS_SRN");

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Stucode, e.Coursecode, e.Acperiod, e.Classnum })
                    .HasName("PK_TT_SCLASS")
                    .IsUnique();

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Stucode)
                    .HasColumnName("STUCODE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Coursecode)
                    .HasColumnName("COURSECODE")
                    .HasColumnType("VARCHAR2(5)");

                entity.Property(e => e.Acperiod)
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.Classnum)
                    .HasColumnName("CLASSNUM")
                    .HasColumnType("NUMBER(2)");
            });

            modelBuilder.Entity<TtSepControl>(entity =>
            {
                entity.HasKey(e => e.TtSepControlRecordNo);

                entity.ToTable("TT_SEP_CONTROL");

                entity.HasIndex(e => e.TtSepControlRecordNo)
                    .HasName("PK_TT_SEP_CONTROL")
                    .IsUnique();

                entity.HasIndex(e => new { e.OasisDatabaseRecordNo, e.Acperiod, e.TtTableName })
                    .HasName("IDX_TT_DB_ACPERIOD_TABLE")
                    .IsUnique();

                entity.Property(e => e.TtSepControlRecordNo)
                    .HasColumnName("TT_SEP_CONTROL_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Acperiod)
                    .IsRequired()
                    .HasColumnName("ACPERIOD")
                    .HasColumnType("VARCHAR2(4)");

                entity.Property(e => e.MigrationLogMessage)
                    .HasColumnName("MIGRATION_LOG_MESSAGE")
                    .HasColumnType("VARCHAR2(1024)");

                entity.Property(e => e.OasisDatabaseRecordNo)
                    .HasColumnName("OASIS_DATABASE_RECORD_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.OasisDbChangedEndtime)
                    .HasColumnName("OASIS_DB_CHANGED_ENDTIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.OasisDbChangedStarttime)
                    .HasColumnName("OASIS_DB_CHANGED_STARTTIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.SepDbChangedEndtime)
                    .HasColumnName("SEP_DB_CHANGED_ENDTIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.SepDbChangedStarttime)
                    .HasColumnName("SEP_DB_CHANGED_STARTTIME")
                    .HasColumnType("TIMESTAMP(6)");

                entity.Property(e => e.SepImportStatus)
                    .HasColumnName("SEP_IMPORT_STATUS")
                    .HasColumnType("VARCHAR2(10)");

                entity.Property(e => e.TransactionNo)
                    .HasColumnName("TRANSACTION_NO")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TtTableName)
                    .IsRequired()
                    .HasColumnName("TT_TABLE_NAME")
                    .HasColumnType("VARCHAR2(15)");
            });

            modelBuilder.HasSequence("FACTOR_OF_NEED_TEMP_SEQ");

            modelBuilder.HasSequence("NEXTRECORDID");

            modelBuilder.HasSequence("SEQ_FAMILY_NAMES_MASKING_TMP");

            modelBuilder.HasSequence("SEQ_FIRST_NAMES_MASKING_TMP");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_DOC_REL_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_DOCTOR_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_EMERCON_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_EMERCONREL_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_REG_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_STUCONREL_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_STUCONTACT_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_ENTITY_STUDENT_ID");

            modelBuilder.HasSequence("SEQ_SEPSD_SCHOOL_SYNC_AUTO_ID");
        }
    }
}
