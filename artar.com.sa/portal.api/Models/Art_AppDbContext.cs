using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace portal.api.Models
{
    public partial class Art_AppDbContext : DbContext
    {
        public Art_AppDbContext()
        {
        }

        public Art_AppDbContext(DbContextOptions<Art_AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccItUnitsofmeasure> AccItUnitsofmeasures { get; set; }
        public virtual DbSet<AcctItCategorieswithsub> AcctItCategorieswithsubs { get; set; }
        public virtual DbSet<AcctItCategory> AcctItCategories { get; set; }
        public virtual DbSet<AcctItCategorydetail> AcctItCategorydetails { get; set; }
        public virtual DbSet<AcctItCompany> AcctItCompanies { get; set; }
        public virtual DbSet<AcctItInvoicedetail> AcctItInvoicedetails { get; set; }
        public virtual DbSet<AcctItInvoiceheader> AcctItInvoiceheaders { get; set; }
        public virtual DbSet<AcctItSupplier> AcctItSuppliers { get; set; }
        public virtual DbSet<AcctItTempInvoicedetail> AcctItTempInvoicedetails { get; set; }
        public virtual DbSet<AcctItTempInvoicedetailsItemcategoryUnitcode> AcctItTempInvoicedetailsItemcategoryUnitcodes { get; set; }
        public virtual DbSet<ActiveNavUser> ActiveNavUsers { get; set; }
        public virtual DbSet<AssetAccountability> AssetAccountabilities { get; set; }
        public virtual DbSet<AssetAttachment> AssetAttachments { get; set; }
        public virtual DbSet<AssetCategory> AssetCategories { get; set; }
        public virtual DbSet<AssetSupplier> AssetSuppliers { get; set; }
        public virtual DbSet<AssetTransferHistory> AssetTransferHistories { get; set; }
        public virtual DbSet<Assetlastno> Assetlastnos { get; set; }
        public virtual DbSet<AuthLogin> AuthLogins { get; set; }
        public virtual DbSet<BfAttachment> BfAttachments { get; set; }
        public virtual DbSet<BfBank> BfBanks { get; set; }
        public virtual DbSet<BfBankList> BfBankLists { get; set; }
        public virtual DbSet<BfBankListview> BfBankListviews { get; set; }
        public virtual DbSet<BfBankOverDraft> BfBankOverDrafts { get; set; }
        public virtual DbSet<BfBeneficiarySector> BfBeneficiarySectors { get; set; }
        public virtual DbSet<BfBusinessUnit> BfBusinessUnits { get; set; }
        public virtual DbSet<BfBusinessUnitPermission> BfBusinessUnitPermissions { get; set; }
        public virtual DbSet<BfCategory> BfCategories { get; set; }
        public virtual DbSet<BfCompanySn> BfCompanySns { get; set; }
        public virtual DbSet<BfCompanySnLc> BfCompanySnLcs { get; set; }
        public virtual DbSet<BfCostCenter> BfCostCenters { get; set; }
        public virtual DbSet<BfCurrency> BfCurrencies { get; set; }
        public virtual DbSet<BfDraftfrom> BfDraftfroms { get; set; }
        public virtual DbSet<BfFacilityCard> BfFacilityCards { get; set; }
        public virtual DbSet<BfFacilityCardGeneralLineReport> BfFacilityCardGeneralLineReports { get; set; }
        public virtual DbSet<BfFacilityCardGeneralLineView> BfFacilityCardGeneralLineViews { get; set; }
        public virtual DbSet<BfFacilityCardMaster> BfFacilityCardMasters { get; set; }
        public virtual DbSet<BfFacilityCardOld> BfFacilityCardOlds { get; set; }
        public virtual DbSet<BfFacilityCardSummaryView> BfFacilityCardSummaryViews { get; set; }
        public virtual DbSet<BfFacilityCardView> BfFacilityCardViews { get; set; }
        public virtual DbSet<BfFacilityCardView2> BfFacilityCardView2s { get; set; }
        public virtual DbSet<BfFcSectorEntry> BfFcSectorEntries { get; set; }
        public virtual DbSet<BfFinalApproval> BfFinalApprovals { get; set; }
        public virtual DbSet<BfFinalApprovalEmail> BfFinalApprovalEmails { get; set; }
        public virtual DbSet<BfFinancePersonel> BfFinancePersonels { get; set; }
        public virtual DbSet<BfFinancePersonelView> BfFinancePersonelViews { get; set; }
        public virtual DbSet<BfFinancePurposeMaster> BfFinancePurposeMasters { get; set; }
        public virtual DbSet<BfFinancePurposeView> BfFinancePurposeViews { get; set; }
        public virtual DbSet<BfFinanceRequest> BfFinanceRequests { get; set; }
        public virtual DbSet<BfFinanceRequestPurpose> BfFinanceRequestPurposes { get; set; }
        public virtual DbSet<BfFinanceRequestView> BfFinanceRequestViews { get; set; }
        public virtual DbSet<BfFrSpecify> BfFrSpecifies { get; set; }
        public virtual DbSet<BfGeneralLine> BfGeneralLines { get; set; }
        public virtual DbSet<BfGeneralLineTemp> BfGeneralLineTemps { get; set; }
        public virtual DbSet<BfGeneralLineUnion> BfGeneralLineUnions { get; set; }
        public virtual DbSet<BfGeneralLineUnion2> BfGeneralLineUnion2s { get; set; }
        public virtual DbSet<BfGeneralLineView> BfGeneralLineViews { get; set; }
        public virtual DbSet<BfGeneralLineView2> BfGeneralLineView2s { get; set; }
        public virtual DbSet<BfGuaranteeType> BfGuaranteeTypes { get; set; }
        public virtual DbSet<BfIncoterm> BfIncoterms { get; set; }
        public virtual DbSet<BfLcExtension> BfLcExtensions { get; set; }
        public virtual DbSet<BfLcGoodsinTransit> BfLcGoodsinTransits { get; set; }
        public virtual DbSet<BfLcGoodsinTransitView> BfLcGoodsinTransitViews { get; set; }
        public virtual DbSet<BfLcListofGood> BfLcListofGoods { get; set; }
        public virtual DbSet<BfLcListofGoodsView> BfLcListofGoodsViews { get; set; }
        public virtual DbSet<BfLcMaster> BfLcMasters { get; set; }
        public virtual DbSet<BfLcMasterView> BfLcMasterViews { get; set; }
        public virtual DbSet<BfLcReceivedGood> BfLcReceivedGoods { get; set; }
        public virtual DbSet<BfLcReceivedGoodsView> BfLcReceivedGoodsViews { get; set; }
        public virtual DbSet<BfLcTransaction> BfLcTransactions { get; set; }
        public virtual DbSet<BfLcType> BfLcTypes { get; set; }
        public virtual DbSet<BfLcapplicantbank> BfLcapplicantbanks { get; set; }
        public virtual DbSet<BfLcbeneficiaryBank> BfLcbeneficiaryBanks { get; set; }
        public virtual DbSet<BfLcinourfavor> BfLcinourfavors { get; set; }
        public virtual DbSet<BfLcinourfavorView> BfLcinourfavorViews { get; set; }
        public virtual DbSet<BfLcproject> BfLcprojects { get; set; }
        public virtual DbSet<BfLcreceivedTransaction> BfLcreceivedTransactions { get; set; }
        public virtual DbSet<BfLcsector> BfLcsectors { get; set; }
        public virtual DbSet<BfLgExtension> BfLgExtensions { get; set; }
        public virtual DbSet<BfLgMaster> BfLgMasters { get; set; }
        public virtual DbSet<BfLgMasterView> BfLgMasterViews { get; set; }
        public virtual DbSet<BfLgTransaction> BfLgTransactions { get; set; }
        public virtual DbSet<BfLgType> BfLgTypes { get; set; }
        public virtual DbSet<BfLgbank> BfLgbanks { get; set; }
        public virtual DbSet<BfLgcategory> BfLgcategories { get; set; }
        public virtual DbSet<BfLginourFavor> BfLginourFavors { get; set; }
        public virtual DbSet<BfLginourFavorView> BfLginourFavorViews { get; set; }
        public virtual DbSet<BfLgproject> BfLgprojects { get; set; }
        public virtual DbSet<BfLoanAmountAdjustment> BfLoanAmountAdjustments { get; set; }
        public virtual DbSet<BfLoanBeneficiaryEntry> BfLoanBeneficiaryEntries { get; set; }
        public virtual DbSet<BfLoanDictionary> BfLoanDictionaries { get; set; }
        public virtual DbSet<BfLoanEmail> BfLoanEmails { get; set; }
        public virtual DbSet<BfLoanMaster> BfLoanMasters { get; set; }
        public virtual DbSet<BfLoanPremium> BfLoanPremiums { get; set; }
        public virtual DbSet<BfLoanPremiumsView> BfLoanPremiumsViews { get; set; }
        public virtual DbSet<BfLoanPurpose> BfLoanPurposes { get; set; }
        public virtual DbSet<BfLoanPurposeEntry> BfLoanPurposeEntries { get; set; }
        public virtual DbSet<BfLoanPurposeEntryView> BfLoanPurposeEntryViews { get; set; }
        public virtual DbSet<BfLoanReductionView> BfLoanReductionViews { get; set; }
        public virtual DbSet<BfLoanTransaction> BfLoanTransactions { get; set; }
        public virtual DbSet<BfManageSector> BfManageSectors { get; set; }
        public virtual DbSet<BfManageSectorView> BfManageSectorViews { get; set; }
        public virtual DbSet<BfNavisionSectorBalance> BfNavisionSectorBalances { get; set; }
        public virtual DbSet<BfNewSummary> BfNewSummaries { get; set; }
        public virtual DbSet<BfOperatingNo> BfOperatingNos { get; set; }
        public virtual DbSet<BfOverDraftPurpose> BfOverDraftPurposes { get; set; }
        public virtual DbSet<BfPaymentSourceEntry> BfPaymentSourceEntries { get; set; }
        public virtual DbSet<BfPaymentSourceEntryV> BfPaymentSourceEntryVs { get; set; }
        public virtual DbSet<BfPaymentSummary> BfPaymentSummaries { get; set; }
        public virtual DbSet<BfPaymentTransaction> BfPaymentTransactions { get; set; }
        public virtual DbSet<BfPfsHeaderV> BfPfsHeaderVs { get; set; }
        public virtual DbSet<BfPfsLctrx1> BfPfsLctrx1s { get; set; }
        public virtual DbSet<BfPfsLctrx2> BfPfsLctrx2s { get; set; }
        public virtual DbSet<BfPfsLgtrx1> BfPfsLgtrx1s { get; set; }
        public virtual DbSet<BfPfsLgtrx2> BfPfsLgtrx2s { get; set; }
        public virtual DbSet<BfPfsListV> BfPfsListVs { get; set; }
        public virtual DbSet<BfPfsLoanTrx1> BfPfsLoanTrx1s { get; set; }
        public virtual DbSet<BfPfsLoanTrx2> BfPfsLoanTrx2s { get; set; }
        public virtual DbSet<BfPfsV> BfPfsVs { get; set; }
        public virtual DbSet<BfPosition> BfPositions { get; set; }
        public virtual DbSet<BfProject> BfProjects { get; set; }
        public virtual DbSet<BfReductionSourceEntry> BfReductionSourceEntries { get; set; }
        public virtual DbSet<BfReductionSourceEntryV> BfReductionSourceEntryVs { get; set; }
        public virtual DbSet<BfReductionTransaction> BfReductionTransactions { get; set; }
        public virtual DbSet<BfRenewSummary> BfRenewSummaries { get; set; }
        public virtual DbSet<BfRenewTransaction> BfRenewTransactions { get; set; }
        public virtual DbSet<BfReqApprovalView> BfReqApprovalViews { get; set; }
        public virtual DbSet<BfSector> BfSectors { get; set; }
        public virtual DbSet<BfSectorAccountNo> BfSectorAccountNos { get; set; }
        public virtual DbSet<BfSectorManagerEmail> BfSectorManagerEmails { get; set; }
        public virtual DbSet<BfSectorManagerEmailView> BfSectorManagerEmailViews { get; set; }
        public virtual DbSet<BfSource> BfSources { get; set; }
        public virtual DbSet<BfSpecificLine> BfSpecificLines { get; set; }
        public virtual DbSet<BfSpecificLineView> BfSpecificLineViews { get; set; }
        public virtual DbSet<BfSpecificLineView2> BfSpecificLineView2s { get; set; }
        public virtual DbSet<BfTransferHistory> BfTransferHistories { get; set; }
        public virtual DbSet<BfTransferHistoryView> BfTransferHistoryViews { get; set; }
        public virtual DbSet<BfTransferSummary> BfTransferSummaries { get; set; }
        public virtual DbSet<BfUserAccessPermissionV> BfUserAccessPermissionVs { get; set; }
        public virtual DbSet<BfUserGroupPermission> BfUserGroupPermissions { get; set; }
        public virtual DbSet<BfUtilizationLctransactionV> BfUtilizationLctransactionVs { get; set; }
        public virtual DbSet<BfUtilizationLgV> BfUtilizationLgVs { get; set; }
        public virtual DbSet<BfUtilizationLgtransactionsV> BfUtilizationLgtransactionsVs { get; set; }
        public virtual DbSet<BfUtilizationLoanAmountAdjustmentV> BfUtilizationLoanAmountAdjustmentVs { get; set; }
        public virtual DbSet<BfUtilizationLoanV> BfUtilizationLoanVs { get; set; }
        public virtual DbSet<BfUtilizationLoanpaymentV> BfUtilizationLoanpaymentVs { get; set; }
        public virtual DbSet<BfUtilizationLoanpremiumsV> BfUtilizationLoanpremiumsVs { get; set; }
        public virtual DbSet<BfUtilizationLoanreductionV> BfUtilizationLoanreductionVs { get; set; }
        public virtual DbSet<BfsSl> BfsSls { get; set; }
        public virtual DbSet<BlockedSiteurl> BlockedSiteurls { get; set; }
        public virtual DbSet<BravoPackage> BravoPackages { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyList> CompanyLists { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<DeptGroup> DeptGroups { get; set; }
        public virtual DbSet<DeptGroupList> DeptGroupLists { get; set; }
        public virtual DbSet<DirectManager> DirectManagers { get; set; }
        public virtual DbSet<EmailNotificationSetting> EmailNotificationSettings { get; set; }
        public virtual DbSet<EmployeeDimensionsvalue2> EmployeeDimensionsvalue2s { get; set; }
        public virtual DbSet<EmployeesInformation> EmployeesInformations { get; set; }
        public virtual DbSet<Expirationreminder> Expirationreminders { get; set; }
        public virtual DbSet<ExpirationreminderCategory> ExpirationreminderCategories { get; set; }
        public virtual DbSet<ExpirationreminderDayinterval> ExpirationreminderDayintervals { get; set; }
        public virtual DbSet<ExpirationreminderEventlog> ExpirationreminderEventlogs { get; set; }
        public virtual DbSet<ExpirationreminderSmsSetup> ExpirationreminderSmsSetups { get; set; }
        public virtual DbSet<ExpirationreminderSmsSetupView> ExpirationreminderSmsSetupViews { get; set; }
        public virtual DbSet<ExpirationreminderSmsSetupView2> ExpirationreminderSmsSetupView2s { get; set; }
        public virtual DbSet<ExtensionDirectory> ExtensionDirectories { get; set; }
        public virtual DbSet<GatePassAll> GatePassAlls { get; set; }
        public virtual DbSet<GatePassMaster> GatePassMasters { get; set; }
        public virtual DbSet<GatePassTransaction> GatePassTransactions { get; set; }
        public virtual DbSet<GetAllTicket> GetAllTickets { get; set; }
        public virtual DbSet<HaratEmployee> HaratEmployees { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<InvAccounting> InvAccountings { get; set; }
        public virtual DbSet<InvMainTable> InvMainTables { get; set; }
        public virtual DbSet<InvMainTable2> InvMainTable2s { get; set; }
        public virtual DbSet<InvRequest> InvRequests { get; set; }
        public virtual DbSet<InvStatus> InvStatuses { get; set; }
        public virtual DbSet<InvSupplier> InvSuppliers { get; set; }
        public virtual DbSet<InvSuppliers1> InvSuppliers1s { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<ItCode> ItCodes { get; set; }
        public virtual DbSet<ItDelivery> ItDeliveries { get; set; }
        public virtual DbSet<ItDeliveryDummy> ItDeliveryDummies { get; set; }
        public virtual DbSet<ItDeliveryList> ItDeliveryLists { get; set; }
        public virtual DbSet<ItTask> ItTasks { get; set; }
        public virtual DbSet<ItTaskSummary> ItTaskSummaries { get; set; }
        public virtual DbSet<JobcardBlockedsiteTicket> JobcardBlockedsiteTickets { get; set; }
        public virtual DbSet<JobcardCompany> JobcardCompanies { get; set; }
        public virtual DbSet<JobcardEmailRx> JobcardEmailRxes { get; set; }
        public virtual DbSet<JobcardEmployeeInfo> JobcardEmployeeInfos { get; set; }
        public virtual DbSet<JobcardFeedbackV> JobcardFeedbackVs { get; set; }
        public virtual DbSet<JobcardGroupcountticket> JobcardGroupcounttickets { get; set; }
        public virtual DbSet<JobcardGroupticket> JobcardGrouptickets { get; set; }
        public virtual DbSet<JobcardOracleCategory> JobcardOracleCategories { get; set; }
        public virtual DbSet<JobcardOracleCategoryUser> JobcardOracleCategoryUsers { get; set; }
        public virtual DbSet<JobcardOracleCategoryUserV> JobcardOracleCategoryUserVs { get; set; }
        public virtual DbSet<JobcardOracleSupportMessage> JobcardOracleSupportMessages { get; set; }
        public virtual DbSet<JobcardOraclesubCategory> JobcardOraclesubCategories { get; set; }
        public virtual DbSet<JobcardProblemrecordn> JobcardProblemrecordns { get; set; }
        public virtual DbSet<JobcardProblemrecordnView> JobcardProblemrecordnViews { get; set; }
        public virtual DbSet<JobcardProblemtype> JobcardProblemtypes { get; set; }
        public virtual DbSet<JobcardRate> JobcardRates { get; set; }
        public virtual DbSet<JobcardRecordHistorylog> JobcardRecordHistorylogs { get; set; }
        public virtual DbSet<JobcardRecordTaskassignmentlog> JobcardRecordTaskassignmentlogs { get; set; }
        public virtual DbSet<JobcardRequeststatus> JobcardRequeststatuses { get; set; }
        public virtual DbSet<JobcardTaskAssignmentLog> JobcardTaskAssignmentLogs { get; set; }
        public virtual DbSet<JobcardTicketdate> JobcardTicketdates { get; set; }
        public virtual DbSet<Late> Lates { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Maintenance> Maintenances { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Misplace> Misplaces { get; set; }
        public virtual DbSet<ModuleAndPrivilege> ModuleAndPrivileges { get; set; }
        public virtual DbSet<ModulesType> ModulesTypes { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<NewMobile> NewMobiles { get; set; }
        public virtual DbSet<NumberSeries> NumberSeries { get; set; }
        public virtual DbSet<OApprovalEntry> OApprovalEntries { get; set; }
        public virtual DbSet<OApprovalHistoryV> OApprovalHistoryVs { get; set; }
        public virtual DbSet<OApprovalList> OApprovalLists { get; set; }
        public virtual DbSet<OAttachment> OAttachments { get; set; }
        public virtual DbSet<OBusinessUnit> OBusinessUnits { get; set; }
        public virtual DbSet<OLevel> OLevels { get; set; }
        public virtual DbSet<OManagement> OManagements { get; set; }
        public virtual DbSet<OModule> OModules { get; set; }
        public virtual DbSet<OParameter> OParameters { get; set; }
        public virtual DbSet<OParameterTemp> OParameterTemps { get; set; }
        public virtual DbSet<OProcessStep> OProcessSteps { get; set; }
        public virtual DbSet<ORemark> ORemarks { get; set; }
        public virtual DbSet<OReport> OReports { get; set; }
        public virtual DbSet<ORequestor> ORequestors { get; set; }
        public virtual DbSet<OResponsibility> OResponsibilities { get; set; }
        public virtual DbSet<OSecurityProfileV> OSecurityProfileVs { get; set; }
        public virtual DbSet<OTemplate> OTemplates { get; set; }
        public virtual DbSet<OTemplateEntry> OTemplateEntries { get; set; }
        public virtual DbSet<OUserAccess> OUserAccesses { get; set; }
        public virtual DbSet<OUserAccessV> OUserAccessVs { get; set; }
        public virtual DbSet<OWorkflow> OWorkflows { get; set; }
        public virtual DbSet<OracleSqlIntegrationLog> OracleSqlIntegrationLogs { get; set; }
        public virtual DbSet<OracleUser> OracleUsers { get; set; }
        public virtual DbSet<OracleUsersList> OracleUsersLists { get; set; }
        public virtual DbSet<PoBank> PoBanks { get; set; }
        public virtual DbSet<PoDummy> PoDummies { get; set; }
        public virtual DbSet<PoListView> PoListViews { get; set; }
        public virtual DbSet<PoMaster> PoMasters { get; set; }
        public virtual DbSet<PoMasterV> PoMasterVs { get; set; }
        public virtual DbSet<PoPrePayment> PoPrePayments { get; set; }
        public virtual DbSet<PoPrepaymentV> PoPrepaymentVs { get; set; }
        public virtual DbSet<PoSector> PoSectors { get; set; }
        public virtual DbSet<PoSupplier> PoSuppliers { get; set; }
        public virtual DbSet<PoUnitPermission> PoUnitPermissions { get; set; }
        public virtual DbSet<PoView> PoViews { get; set; }
        public virtual DbSet<PrivilegesType> PrivilegesTypes { get; set; }
        public virtual DbSet<ProjectSetupTable> ProjectSetupTables { get; set; }
        public virtual DbSet<ProjectTable> ProjectTables { get; set; }
        public virtual DbSet<Requisition> Requisitions { get; set; }
        public virtual DbSet<RequisitionApprovalCommittee> RequisitionApprovalCommittees { get; set; }
        public virtual DbSet<RequisitionApprovalOrder> RequisitionApprovalOrders { get; set; }
        public virtual DbSet<RequisitionApprover> RequisitionApprovers { get; set; }
        public virtual DbSet<RequisitionAuditLog> RequisitionAuditLogs { get; set; }
        public virtual DbSet<RequisitionDataEntryPersonnel> RequisitionDataEntryPersonnel { get; set; }
        public virtual DbSet<RequisitionItemCategory> RequisitionItemCategories { get; set; }
        public virtual DbSet<RequisitionItemDetail> RequisitionItemDetails { get; set; }
        public virtual DbSet<RequisitionItpersonel> RequisitionItpersonels { get; set; }
        public virtual DbSet<RequisitionSerial> RequisitionSerials { get; set; }
        public virtual DbSet<RequisitionWorkflowLog> RequisitionWorkflowLogs { get; set; }
        public virtual DbSet<RequisitionWorkflowSetup> RequisitionWorkflowSetups { get; set; }
        public virtual DbSet<RequisitionWorkflowtype> RequisitionWorkflowtypes { get; set; }
        public virtual DbSet<Sim> Sims { get; set; }
        public virtual DbSet<SimAssetTransferHistory> SimAssetTransferHistories { get; set; }
        public virtual DbSet<SimDepartment> SimDepartments { get; set; }
        public virtual DbSet<SimIdsetting> SimIdsettings { get; set; }
        public virtual DbSet<Simdepartment1> Simdepartments1 { get; set; }
        public virtual DbSet<Simservicetype> Simservicetypes { get; set; }
        public virtual DbSet<SiteAccessPermissionV> SiteAccessPermissionVs { get; set; }
        public virtual DbSet<SiteAttendanceLog> SiteAttendanceLogs { get; set; }
        public virtual DbSet<SiteAttendanceMode> SiteAttendanceModes { get; set; }
        public virtual DbSet<SiteBioTime> SiteBioTimes { get; set; }
        public virtual DbSet<SiteDayOff> SiteDayOffs { get; set; }
        public virtual DbSet<SiteDepartment> SiteDepartments { get; set; }
        public virtual DbSet<SiteDepartmentGroupDirectmanager> SiteDepartmentGroupDirectmanagers { get; set; }
        public virtual DbSet<SiteDepartmentsGroup> SiteDepartmentsGroups { get; set; }
        public virtual DbSet<SiteDutiesSched> SiteDutiesScheds { get; set; }
        public virtual DbSet<SiteDuty> SiteDuties { get; set; }
        public virtual DbSet<SiteEmailScheduling> SiteEmailSchedulings { get; set; }
        public virtual DbSet<SiteEmailSchedulingV> SiteEmailSchedulingVs { get; set; }
        public virtual DbSet<SiteEmployeeInfo> SiteEmployeeInfos { get; set; }
        public virtual DbSet<SiteHoliday> SiteHolidays { get; set; }
        public virtual DbSet<SiteNotificationErrorLog> SiteNotificationErrorLogs { get; set; }
        public virtual DbSet<SiteRamadan> SiteRamadans { get; set; }
        public virtual DbSet<SiteRamadanV> SiteRamadanVs { get; set; }
        public virtual DbSet<SiteSitePermission> SiteSitePermissions { get; set; }
        public virtual DbSet<SiteTbl> SiteTbls { get; set; }
        public virtual DbSet<SubModulesType> SubModulesTypes { get; set; }
        public virtual DbSet<TempBonyanNewCode> TempBonyanNewCodes { get; set; }
        public virtual DbSet<TestOldCode> TestOldCodes { get; set; }
        public virtual DbSet<TransCarsTbl> TransCarsTbls { get; set; }
        public virtual DbSet<TransDriver> TransDrivers { get; set; }
        public virtual DbSet<TransRegionTbl> TransRegionTbls { get; set; }
        public virtual DbSet<TransTrack> TransTracks { get; set; }
        public virtual DbSet<TransTransTbl> TransTransTbls { get; set; }
        public virtual DbSet<TransView> TransViews { get; set; }
        public virtual DbSet<TransportTracking> TransportTrackings { get; set; }
        public virtual DbSet<Transtrack1> Transtracks1 { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroupsPermission> UserGroupsPermissions { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<VUserGroupsPermission> VUserGroupsPermissions { get; set; }
        public virtual DbSet<VisaCountryTbl> VisaCountryTbls { get; set; }
        public virtual DbSet<VisaDetail> VisaDetails { get; set; }
        public virtual DbSet<VisaEnjaz> VisaEnjazs { get; set; }
        public virtual DbSet<VisaOffice> VisaOffices { get; set; }
        public virtual DbSet<VisaProfession> VisaProfessions { get; set; }
        public virtual DbSet<VisaProfessionsCountry> VisaProfessionsCountries { get; set; }
        public virtual DbSet<VisaStatus> VisaStatuses { get; set; }
        public virtual DbSet<VisaTbl> VisaTbls { get; set; }
        public virtual DbSet<VisaTbl1> VisaTbl1s { get; set; }
        public virtual DbSet<VisaTblold> VisaTblolds { get; set; }
        public virtual DbSet<VisaWork> VisaWorks { get; set; }
        public virtual DbSet<VisaWorkStatus> VisaWorkStatuses { get; set; }
        public virtual DbSet<WorkflowDept> WorkflowDepts { get; set; }
        public virtual DbSet<WorkflowEeClearance> WorkflowEeClearances { get; set; }
        public virtual DbSet<WorkflowEeDept> WorkflowEeDepts { get; set; }
        public virtual DbSet<WorkflowEeDeptList> WorkflowEeDeptLists { get; set; }
        public virtual DbSet<XattIp> XattIps { get; set; }
        public virtual DbSet<ZkPersonnel> ZkPersonnel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Art_AppDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_100_CI_AI");

            modelBuilder.Entity<AccItUnitsofmeasure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Acc_IT_unitsofmeasure");

                entity.Property(e => e.AcctItUnits)
                    .HasMaxLength(20)
                    .HasColumnName("Acct_IT_Units");

                entity.Property(e => e.IdCategorydetails).HasColumnName("ID_categorydetails");

                entity.Property(e => e.IdSorting)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_Sorting");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(10)
                    .HasColumnName("Unit_Code");
            });

            modelBuilder.Entity<AcctItCategorieswithsub>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Acct_IT_categorieswithsub");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IdCategory).HasColumnName("ID_category");

                entity.Property(e => e.IdCd).HasColumnName("ID_cd");

                entity.Property(e => e.SubcategoryDesc)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<AcctItCategory>(entity =>
            {
                entity.HasKey(e => e.Description);

                entity.ToTable("Acct_IT_category");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.IdCat)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_cat");
            });

            modelBuilder.Entity<AcctItCategorydetail>(entity =>
            {
                entity.HasKey(e => e.Description);

                entity.ToTable("Acct_IT_categorydetails");

                entity.Property(e => e.Description).HasMaxLength(30);

                entity.Property(e => e.IdCategory).HasColumnName("ID_category");

                entity.Property(e => e.IdCd)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_cd");
            });

            modelBuilder.Entity<AcctItCompany>(entity =>
            {
                entity.HasKey(e => e.Company);

                entity.ToTable("Acct_IT_company");

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<AcctItInvoicedetail>(entity =>
            {
                entity.HasKey(e => e.Idsorting);

                entity.ToTable("Acct_IT_invoicedetails");

                entity.Property(e => e.Idsorting).HasColumnName("IDsorting");

                entity.Property(e => e.Category).HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemAmount).HasColumnType("money");

                entity.Property(e => e.ItemCode).HasMaxLength(25);

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AcctItInvoiceheader>(entity =>
            {
                entity.HasKey(e => new { e.RefNo, e.Supplier });

                entity.ToTable("Acct_IT_invoiceheader");

                entity.Property(e => e.RefNo).HasMaxLength(30);

                entity.Property(e => e.Supplier).HasMaxLength(50);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Attachments).HasMaxLength(200);

                entity.Property(e => e.Company).HasMaxLength(30);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("EntryID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvCategory).HasMaxLength(30);

                entity.Property(e => e.InvDate).HasColumnType("date");

                entity.Property(e => e.InvDiscount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.InvType).HasComment("Cash/Credit");

                entity.Property(e => e.NetAmount).HasColumnType("money");

                entity.Property(e => e.Note).HasMaxLength(200);
            });

            modelBuilder.Entity<AcctItSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierName);

                entity.ToTable("Acct_IT_supplier");

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.IdSn)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID_SN");
            });

            modelBuilder.Entity<AcctItTempInvoicedetail>(entity =>
            {
                entity.HasKey(e => e.Idsorting)
                    .HasName("PK__Acct_IT___AEB821EC6BAEFA67");

                entity.ToTable("Acct_IT_temp_invoicedetails");

                entity.Property(e => e.Idsorting).HasColumnName("IDsorting");

                entity.Property(e => e.Category).HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemAmount).HasColumnType("money");

                entity.Property(e => e.ItemCode).HasMaxLength(25);

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AcctItTempInvoicedetailsItemcategoryUnitcode>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Acct_IT_temp_invoicedetails_itemcategory_unitcode");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Discount).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.IdsortingTemp).HasColumnName("IDsorting_temp");

                entity.Property(e => e.ItemAmount).HasColumnType("money");

                entity.Property(e => e.ItemCode).HasMaxLength(25);

                entity.Property(e => e.Note).HasMaxLength(150);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<ActiveNavUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("active_nav_user");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.ForVerification)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("For Verification");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("source");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.Status1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Status?");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AssetAccountability>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("AssetAccountability");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.AssetStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssetStatusNotes).HasMaxLength(300);

                entity.Property(e => e.AssignedFrom)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Attachment).HasMaxLength(300);

                entity.Property(e => e.BravoGroup)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BravoNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BravoPackage)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.BravoScode)
                    .HasMaxLength(10)
                    .HasColumnName("BravoSCode")
                    .IsFixedLength(true);

                entity.Property(e => e.Category)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Condition).HasMaxLength(30);

                entity.Property(e => e.CostAmount).HasColumnType("money");

                entity.Property(e => e.Cpu)
                    .HasMaxLength(15)
                    .HasColumnName("CPU")
                    .IsFixedLength(true);

                entity.Property(e => e.DateAssigned).HasColumnType("date");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.GraphicCard).HasMaxLength(20);

                entity.Property(e => e.Hdd)
                    .HasMaxLength(10)
                    .HasColumnName("HDD")
                    .IsFixedLength(true);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Itnotes)
                    .HasMaxLength(250)
                    .HasColumnName("ITNotes");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.Manufacturer).HasMaxLength(20);

                entity.Property(e => e.Model).HasMaxLength(30);

                entity.Property(e => e.Notes).HasMaxLength(60);

                entity.Property(e => e.Oos)
                    .HasColumnName("OOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchaseDate).HasColumnType("date");

                entity.Property(e => e.Ram)
                    .HasMaxLength(10)
                    .HasColumnName("RAM")
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).HasMaxLength(30);

                entity.Property(e => e.SerialNo).HasMaxLength(25);

                entity.Property(e => e.Supplier).HasMaxLength(30);

                entity.Property(e => e.TransferDateFrom).HasColumnType("date");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.BravoPackageNavigation)
                    .WithMany(p => p.AssetAccountabilities)
                    .HasForeignKey(d => d.BravoPackage)
                    .HasConstraintName("FK_AssetAccountability_BRAVO_Package");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.AssetAccountabilities)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_AssetAccountability_AssetCategory");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.AssetAccountabilities)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_AssetAccountability_SIM_department");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.AssetAccountabilities)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK_AssetAccountability_Location");

                entity.HasOne(d => d.SupplierNavigation)
                    .WithMany(p => p.AssetAccountabilities)
                    .HasForeignKey(d => d.Supplier)
                    .HasConstraintName("FK_AssetAccountability_AssetSupplier");
            });

            modelBuilder.Entity<AssetAttachment>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Filename });

                entity.ToTable("AssetAttachment");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.Filename)
                    .HasMaxLength(350)
                    .HasColumnName("filename");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<AssetCategory>(entity =>
            {
                entity.HasKey(e => e.Description);

                entity.ToTable("AssetCategory");

                entity.Property(e => e.Description)
                    .HasMaxLength(15)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AssetSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierName);

                entity.ToTable("AssetSupplier");

                entity.Property(e => e.SupplierName).HasMaxLength(30);

                entity.Property(e => e.ContactNo).HasMaxLength(60);

                entity.Property(e => e.ContactPerson).HasMaxLength(60);

                entity.Property(e => e.Note).HasMaxLength(60);
            });

            modelBuilder.Entity<AssetTransferHistory>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.AssignedTo, e.TransferDate, e.Department, e.Location, e.Company });

                entity.ToTable("AssetTransferHistory");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.AssignedTo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.TransferDate).HasColumnType("date");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.AssignedFrom)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("alias Transferred by:{username}");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.TransferDateFrom).HasColumnType("date");

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.AssetTransferHistories)
                    .HasForeignKey(d => d.Company)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetTransferHistory_Company");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.AssetTransferHistories)
                    .HasForeignKey(d => d.Department)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetTransferHistory_SIM_department");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.AssetTransferHistories)
                    .HasForeignKey(d => d.Location)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssetTransferHistory_Location");
            });

            modelBuilder.Entity<Assetlastno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ASSETlastno");

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AuthLogin>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Authname)
                    .HasMaxLength(150)
                    .HasColumnName("authname");

                entity.Property(e => e.Authpass)
                    .HasMaxLength(250)
                    .HasColumnName("authpass");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ip)
                    .HasMaxLength(150)
                    .HasColumnName("ip");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BfAttachment>(entity =>
            {
                entity.HasKey(e => new { e.Tbl, e.Linkedkey, e.Filename });

                entity.ToTable("BF_Attachments");

                entity.Property(e => e.Tbl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tbl");

                entity.Property(e => e.Linkedkey)
                    .HasMaxLength(50)
                    .HasColumnName("linkedkey");

                entity.Property(e => e.Filename)
                    .HasMaxLength(350)
                    .HasColumnName("filename");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("date")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .HasColumnName("path");
            });

            modelBuilder.Entity<BfBank>(entity =>
            {
                entity.HasKey(e => e.AccNo)
                    .HasName("PK_BF_Banks_1");

                entity.ToTable("BF_Banks");

                entity.Property(e => e.AccNo).HasMaxLength(150);

                entity.Property(e => e.Accountname).HasMaxLength(20);

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankNames).HasMaxLength(100);

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasMaxLength(150)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Isarchived).HasColumnName("isarchived");

                entity.Property(e => e.SwiftCode).HasMaxLength(25);
            });

            modelBuilder.Entity<BfBankList>(entity =>
            {
                entity.HasKey(e => e.BankLetters);

                entity.ToTable("BF_BankList");

                entity.Property(e => e.BankLetters).HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Tenure)
                    .HasColumnName("tenure")
                    .HasComment("Tenure= Usually used in LC/LC+Refinance Category that used on computing the repayment date");
            });

            modelBuilder.Entity<BfBankListview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_BankListview");

                entity.Property(e => e.AccNo).HasMaxLength(150);

                entity.Property(e => e.Accountname).HasMaxLength(20);

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasMaxLength(150)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isarchived).HasColumnName("isarchived");

                entity.Property(e => e.SwiftCode).HasMaxLength(25);
            });

            modelBuilder.Entity<BfBankOverDraft>(entity =>
            {
                entity.HasKey(e => new { e.Bankid, e.Categoryid, e.Date, e.OverDraftPurposeid, e.Sectorid });

                entity.ToTable("BF_BankOverDraft");

                entity.Property(e => e.Bankid).HasMaxLength(150);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.Projectid)
                    .HasColumnName("projectid")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BfBeneficiarySector>(entity =>
            {
                entity.HasKey(e => e.Beneficiarysector);

                entity.ToTable("BF_BeneficiarySector");

                entity.Property(e => e.Beneficiarysector)
                    .HasMaxLength(250)
                    .HasColumnName("beneficiarysector");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.Businessunit);

                entity.ToTable("BF_BusinessUnit");

                entity.Property(e => e.Businessunit)
                    .HasMaxLength(250)
                    .HasColumnName("businessunit");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfBusinessUnitPermission>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.BuId, e.Usergroupid });

                entity.ToTable("BF_BusinessUnit_Permissions");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .HasColumnName("username");

                entity.Property(e => e.BuId)
                    .HasColumnName("BU_ID")
                    .HasComment("Business Unit ID");

                entity.Property(e => e.Usergroupid)
                    .HasColumnName("usergroupid")
                    .HasComment("this will be connected to  dbo.UserGroups {ID} which define which modules are accessible");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("modifiedby");
            });

            modelBuilder.Entity<BfCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryName);

                entity.ToTable("BF_Categories");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfCompanySn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_CompanySN");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfCompanySnLc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_CompanySnLC");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfCostCenter>(entity =>
            {
                entity.HasKey(e => e.CostCenter);

                entity.ToTable("BF_CostCenter");

                entity.Property(e => e.CostCenter).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfCurrency>(entity =>
            {
                entity.HasKey(e => e.Currencycode);

                entity.ToTable("BF_Currency");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(50)
                    .HasColumnName("currencycode");

                entity.Property(e => e.Currencyfull)
                    .HasMaxLength(150)
                    .HasColumnName("currencyfull");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfDraftfrom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_Draftfrom");

                entity.Property(e => e.Draftdesc)
                    .HasMaxLength(150)
                    .HasColumnName("draftdesc");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfFacilityCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Facility_Card");

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Facilityrate).HasColumnName("facilityrate");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfFacilityCardGeneralLineReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_FacilityCard_GeneralLine_Report");

                entity.Property(e => e.BankLetters)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankNames).HasMaxLength(100);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("date");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby).HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfFacilityCardGeneralLineView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_FacilityCard_GeneralLine_view");

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("date");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby).HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfFacilityCardMaster>(entity =>
            {
                entity.HasKey(e => new { e.Validfrom, e.Validto, e.BankLetters });

                entity.ToTable("BF_FacilityCard_master");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");

                entity.Property(e => e.BankLetters).HasMaxLength(50);

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("date");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby).HasMaxLength(50);
            });

            modelBuilder.Entity<BfFacilityCardOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_Facility_Card_old");

                entity.Property(e => e.AttachmentFacility).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ValidityFrom)
                    .HasColumnType("date")
                    .HasColumnName("Validity_from");

                entity.Property(e => e.ValidityTo)
                    .HasColumnType("date")
                    .HasColumnName("Validity_to");
            });

            modelBuilder.Entity<BfFacilityCardSummaryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_FacilityCard_Summary_View");

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TotalGlcreditLimit).HasColumnName("TotalGLCreditLimit");

                entity.Property(e => e.TotalSlcreditLimit).HasColumnName("TotalSLCreditLimit");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfFacilityCardView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Facility_Card_view");

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Facilityrate).HasColumnName("facilityrate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfFacilityCardView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Facility_Card_view2");

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfFcSectorEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_FC_Sector_Entries");

                entity.Property(e => e.BuId)
                    .HasColumnName("bu_id")
                    .HasComment("Business Unit/ Sector");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Tbl)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tbl");
            });

            modelBuilder.Entity<BfFinalApproval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_FinalApproval");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfFinalApprovalEmail>(entity =>
            {
                entity.HasKey(e => new { e.Position, e.Username });

                entity.ToTable("BF_FinalApprovalEmail");

                entity.Property(e => e.Position)
                    .HasMaxLength(20)
                    .HasColumnName("position");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Emailaddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfFinancePersonel>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Sectorid })
                    .HasName("PK_BF_FinancePersonel_1");

                entity.ToTable("BF_FinancePersonel");

                entity.Property(e => e.Username)
                    .HasMaxLength(250)
                    .HasColumnName("username");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Position)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("position");
            });

            modelBuilder.Entity<BfFinancePersonelView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_FinancePersonel_view");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Openlimit).HasColumnName("openlimit");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.Positioncode)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("positioncode");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("username");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("validfrom");

                entity.Property(e => e.Validto)
                    .HasColumnType("datetime")
                    .HasColumnName("validto");
            });

            modelBuilder.Entity<BfFinancePurposeMaster>(entity =>
            {
                entity.HasKey(e => e.Purpose);

                entity.ToTable("BF_FinancePurposeMaster");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(250)
                    .HasColumnName("purpose");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Orderid).HasColumnName("orderid");
            });

            modelBuilder.Entity<BfFinancePurposeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_FinancePurpose_view");

                entity.Property(e => e.Dateofrequest)
                    .HasColumnType("date")
                    .HasColumnName("dateofrequest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("purpose");

                entity.Property(e => e.Purposeid).HasColumnName("purposeid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Specify).HasColumnName("specify");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BfFinanceRequest>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Dateofrequest, e.Sectorid, e.Createdby });

                entity.ToTable("BF_FinanceRequest");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Dateofrequest)
                    .HasColumnType("date")
                    .HasColumnName("dateofrequest")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Amountrequest).HasColumnName("amountrequest");

                entity.Property(e => e.CeoRemarks)
                    .HasMaxLength(250)
                    .HasColumnName("CEO_Remarks");

                entity.Property(e => e.Dateofrepayment)
                    .HasColumnType("date")
                    .HasColumnName("dateofrepayment");

                entity.Property(e => e.Dateseen)
                    .HasColumnType("datetime")
                    .HasColumnName("dateseen");

                entity.Property(e => e.Datewithdraw)
                    .HasColumnType("datetime")
                    .HasColumnName("datewithdraw");

                entity.Property(e => e.FmApproval)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FM_Approval");

                entity.Property(e => e.FmApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("FM_ApprovalUA");

                entity.Property(e => e.FmDatelog)
                    .HasColumnType("datetime")
                    .HasColumnName("FM_datelog");

                entity.Property(e => e.FmRemarks)
                    .HasMaxLength(250)
                    .HasColumnName("FM_Remarks");

                entity.Property(e => e.HoldingApproval)
                    .HasMaxLength(50)
                    .HasColumnName("Holding_Approval");

                entity.Property(e => e.HoldingApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("Holding_ApprovalUA");

                entity.Property(e => e.HoldingPaydate)
                    .HasColumnType("date")
                    .HasColumnName("Holding_Paydate");

                entity.Property(e => e.HoldingRemarks)
                    .HasMaxLength(250)
                    .HasColumnName("Holding_Remarks");

                entity.Property(e => e.LastApproval)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.LastApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("LastApprovalUA");

                entity.Property(e => e.Overlimitamount).HasColumnName("overlimitamount");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Seen)
                    .HasMaxLength(50)
                    .HasColumnName("seen");

                entity.Property(e => e.SgmApproval)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SGM_Approval");

                entity.Property(e => e.SgmApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("SGM_ApprovalUA");

                entity.Property(e => e.SgmDatelog)
                    .HasColumnType("datetime")
                    .HasColumnName("SGM_datelog");

                entity.Property(e => e.SmRemarks)
                    .HasMaxLength(250)
                    .HasColumnName("SM_Remarks");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Withdraw).HasColumnName("withdraw");

                entity.Property(e => e.WithdrawUa)
                    .HasMaxLength(50)
                    .HasColumnName("withdraw_UA");
            });

            modelBuilder.Entity<BfFinanceRequestPurpose>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_FinanceRequestPurpose");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dateofrequest)
                    .HasColumnType("date")
                    .HasColumnName("dateofrequest")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Purposeid).HasColumnName("purposeid");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Specify).HasColumnName("specify");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BfFinanceRequestView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_FinanceRequest_view");

                entity.Property(e => e.Amountrequest).HasColumnName("amountrequest");

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Dateofrepayment)
                    .HasColumnType("date")
                    .HasColumnName("dateofrepayment");

                entity.Property(e => e.Dateofrequest)
                    .HasColumnType("date")
                    .HasColumnName("dateofrequest");

                entity.Property(e => e.Datewithdraw)
                    .HasColumnType("datetime")
                    .HasColumnName("datewithdraw");

                entity.Property(e => e.FmApproval)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FM_Approval");

                entity.Property(e => e.FmApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("FM_ApprovalUA");

                entity.Property(e => e.FmDatelog)
                    .HasColumnType("datetime")
                    .HasColumnName("FM_datelog");

                entity.Property(e => e.HoldingApproval)
                    .HasMaxLength(50)
                    .HasColumnName("Holding_Approval");

                entity.Property(e => e.HoldingApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("Holding_ApprovalUA");

                entity.Property(e => e.HoldingPaydate)
                    .HasColumnType("date")
                    .HasColumnName("Holding_Paydate");

                entity.Property(e => e.HoldingRemarks)
                    .HasMaxLength(250)
                    .HasColumnName("Holding_Remarks");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastApproval)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.LastApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("LastApprovalUA");

                entity.Property(e => e.Limitstatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("limitstatus");

                entity.Property(e => e.Overlimitamount).HasColumnName("overlimitamount");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.SgmApprovalUa)
                    .HasMaxLength(50)
                    .HasColumnName("SGM_ApprovalUA");

                entity.Property(e => e.SgmDatelog)
                    .HasColumnType("datetime")
                    .HasColumnName("SGM_datelog");

                entity.Property(e => e.SmApproval)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SM_Approval");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Withdraw).HasColumnName("withdraw");

                entity.Property(e => e.WithdrawUa)
                    .HasMaxLength(50)
                    .HasColumnName("withdraw_UA");
            });

            modelBuilder.Entity<BfFrSpecify>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_FrSpecify");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Purposeid)
                    .HasColumnName("purposeid")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Specifypurpose).HasColumnName("specifypurpose");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BfGeneralLine>(entity =>
            {
                entity.HasKey(e => new { e.MasterId, e.Categoryid, e.AccountNoid, e.Lgcategoryid })
                    .HasName("PK_BF_GeneralLine_1");

                entity.ToTable("BF_GeneralLine");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Bankletters)
                    .HasMaxLength(50)
                    .HasColumnName("bankletters");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified).HasColumnType("datetime");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lccreditlimit).HasColumnName("lccreditlimit");

                entity.Property(e => e.Lifetimedays).HasColumnName("lifetimedays");

                entity.Property(e => e.Loancreditlimit).HasColumnName("loancreditlimit");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector")
                    .HasComment("value from this column are represent by array, to split them use TVF: dbo.Split function");

                entity.Property(e => e.Subcreditlimit).HasColumnName("subcreditlimit");

                entity.Property(e => e.Utilized).HasColumnName("utilized");
            });

            modelBuilder.Entity<BfGeneralLineTemp>(entity =>
            {
                entity.HasKey(e => new { e.Bankid, e.Categoryid })
                    .HasName("PK_BF_GeneralLine_temp_1");

                entity.ToTable("BF_GeneralLine_temp");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");
            });

            modelBuilder.Entity<BfGeneralLineUnion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_GeneralLine_Union");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");
            });

            modelBuilder.Entity<BfGeneralLineUnion2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_GeneralLine_Union2");

                entity.Property(e => e.BankNames).HasMaxLength(100);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");
            });

            modelBuilder.Entity<BfGeneralLineView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_GeneralLine_view");

                entity.Property(e => e.AccountNo).HasMaxLength(150);

                entity.Property(e => e.AccountNoold).HasMaxLength(50);

                entity.Property(e => e.Accountname).HasMaxLength(20);

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Datecreated).HasColumnType("datetime");

                entity.Property(e => e.Datemodified).HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lccreditlimit).HasColumnName("lccreditlimit");

                entity.Property(e => e.Lgcategory)
                    .HasMaxLength(50)
                    .HasColumnName("LGCategory");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Lifetimedays).HasColumnName("lifetimedays");

                entity.Property(e => e.Loancreditlimit).HasColumnName("loancreditlimit");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector");

                entity.Property(e => e.Subcreditlimit).HasColumnName("subcreditlimit");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfGeneralLineView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_GeneralLine_view2");

                entity.Property(e => e.AccountNo).HasMaxLength(150);

                entity.Property(e => e.AccountNoold).HasMaxLength(50);

                entity.Property(e => e.Accountname).HasMaxLength(20);

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Datecreated).HasColumnType("datetime");

                entity.Property(e => e.Datemodified).HasColumnType("datetime");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lccreditlimit).HasColumnName("lccreditlimit");

                entity.Property(e => e.Lgcategory)
                    .HasMaxLength(50)
                    .HasColumnName("LGCategory");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Lifetimedays).HasColumnName("lifetimedays");

                entity.Property(e => e.Loancreditlimit).HasColumnName("loancreditlimit");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector");

                entity.Property(e => e.Subcreditlimit).HasColumnName("subcreditlimit");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfGuaranteeType>(entity =>
            {
                entity.HasKey(e => e.Guaranteetype);

                entity.ToTable("BF_GuaranteeTypes");

                entity.Property(e => e.Guaranteetype)
                    .HasMaxLength(150)
                    .HasColumnName("guaranteetype");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfIncoterm>(entity =>
            {
                entity.HasKey(e => e.Description);

                entity.ToTable("BF_Incoterms");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLcExtension>(entity =>
            {
                entity.HasKey(e => new { e.MasterKey, e.IssuancedateNew, e.EndingdateNew, e.ShippingdateNew });

                entity.ToTable("BF_LC_Extension");

                entity.Property(e => e.MasterKey).HasColumnName("master_key");

                entity.Property(e => e.IssuancedateNew)
                    .HasColumnType("date")
                    .HasColumnName("issuancedate_new");

                entity.Property(e => e.EndingdateNew)
                    .HasColumnType("date")
                    .HasColumnName("endingdate_new");

                entity.Property(e => e.ShippingdateNew)
                    .HasColumnType("date")
                    .HasColumnName("shippingdate_new");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(50)
                    .HasColumnName("companysn");

                entity.Property(e => e.ContractnoPono)
                    .HasMaxLength(50)
                    .HasColumnName("contractno_pono");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Endingdate)
                    .HasColumnType("date")
                    .HasColumnName("endingdate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Issuancedate)
                    .HasColumnType("date")
                    .HasColumnName("issuancedate");

                entity.Property(e => e.LcNo)
                    .HasMaxLength(50)
                    .HasColumnName("lc_no");

                entity.Property(e => e.Lcfullamount).HasColumnName("lcfullamount");

                entity.Property(e => e.Lctypeid).HasColumnName("lctypeid");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .HasColumnName("notes");

                entity.Property(e => e.Purposeid).HasColumnName("purposeid");

                entity.Property(e => e.Remainingamount).HasColumnName("remainingamount");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Shippingdate)
                    .HasColumnType("date")
                    .HasColumnName("shippingdate");

                entity.Property(e => e.Swiftcopy)
                    .HasMaxLength(200)
                    .HasColumnName("swiftcopy");
            });

            modelBuilder.Entity<BfLcGoodsinTransit>(entity =>
            {
                entity.HasKey(e => new { e.Lcno, e.Shipno, e.Goodsid, e.Shipmentdate });

                entity.ToTable("BF_LC_GoodsinTransit");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Shipno).HasColumnName("shipno");

                entity.Property(e => e.Goodsid).HasColumnName("goodsid");

                entity.Property(e => e.Shipmentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("shipmentdate");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Draft)
                    .HasColumnName("draft")
                    .HasComment("(draft)number of days plus the receive or shipment date");

                entity.Property(e => e.Draftfromid)
                    .HasColumnName("draftfromid")
                    .HasComment("after shipping date or after receiving date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .HasColumnName("unit");
            });

            modelBuilder.Entity<BfLcGoodsinTransitView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LC_GoodsinTransit_view");

                entity.Property(e => e.Descriptionofgoods)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("descriptionofgoods");

                entity.Property(e => e.Goodsid).HasColumnName("goodsid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lcno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Shipmentdate)
                    .HasColumnType("datetime")
                    .HasColumnName("shipmentdate");

                entity.Property(e => e.Shipno).HasColumnName("shipno");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.Property(e => e.Unitcode)
                    .HasMaxLength(100)
                    .HasColumnName("unitcode");
            });

            modelBuilder.Entity<BfLcListofGood>(entity =>
            {
                entity.HasKey(e => new { e.Descriptionofgoods, e.Lcno })
                    .HasName("PK_BF_LC_ListofGoods_1");

                entity.ToTable("BF_LC_ListofGoods");

                entity.Property(e => e.Descriptionofgoods)
                    .HasMaxLength(250)
                    .HasColumnName("descriptionofgoods");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Companysn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("companysn");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Priceperunit).HasColumnName("priceperunit");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Unitcode)
                    .HasMaxLength(100)
                    .HasColumnName("unitcode");
            });

            modelBuilder.Entity<BfLcListofGoodsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LC_ListofGoods_view");

                entity.Property(e => e.Descriptionofgoods)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("descriptionofgoods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lcno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Priceperunit).HasColumnName("priceperunit");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Receivedqty).HasColumnName("receivedqty");

                entity.Property(e => e.Remainingamount).HasColumnName("remainingamount");

                entity.Property(e => e.Remainingqty).HasColumnName("remainingqty");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.Property(e => e.Totalpricereceived).HasColumnName("totalpricereceived");

                entity.Property(e => e.Unitcode)
                    .HasMaxLength(100)
                    .HasColumnName("unitcode");
            });

            modelBuilder.Entity<BfLcMaster>(entity =>
            {
                entity.HasKey(e => e.LcNo);

                entity.ToTable("BF_LC_Master");

                entity.Property(e => e.LcNo)
                    .HasMaxLength(100)
                    .HasColumnName("LC_No");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.BeneficiaryName).HasMaxLength(150);

                entity.Property(e => e.CompanySn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractNoPono)
                    .HasMaxLength(100)
                    .HasColumnName("ContractNo_PONo");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(50)
                    .HasColumnName("currencycode");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateofExpiry).HasColumnType("date");

                entity.Property(e => e.Draftfromid).HasColumnName("draftfromid");

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.FinalDestination)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Forcestatus)
                    .HasColumnName("forcestatus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GoodsDescription).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Incoterms).HasMaxLength(150);

                entity.Property(e => e.IncotermsId).HasColumnName("IncotermsID");

                entity.Property(e => e.IssuanceDate).HasColumnType("date");

                entity.Property(e => e.IssuingBankid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastDateofShip).HasColumnType("date");

                entity.Property(e => e.LcfullAmount).HasColumnName("LCFullAmount");

                entity.Property(e => e.Lctype).HasColumnName("LCType");

                entity.Property(e => e.Modifiedby).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.ShippingDate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SwiftCopy).HasMaxLength(200);
            });

            modelBuilder.Entity<BfLcMasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LC_MasterView");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.BankLetters).HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Bankid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BeneficiaryName).HasMaxLength(150);

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CompanySn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContractNoPono)
                    .HasMaxLength(100)
                    .HasColumnName("ContractNo_PONo");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(50)
                    .HasColumnName("currencycode");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateofExpiry).HasColumnType("date");

                entity.Property(e => e.Draftfromid).HasColumnName("draftfromid");

                entity.Property(e => e.Duedate)
                    .HasColumnType("date")
                    .HasColumnName("duedate");

                entity.Property(e => e.Endingdate)
                    .HasColumnType("date")
                    .HasColumnName("endingdate");

                entity.Property(e => e.FinalDestination).HasMaxLength(150);

                entity.Property(e => e.Forcestatus).HasColumnName("forcestatus");

                entity.Property(e => e.GoodsDescription).HasMaxLength(150);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Incoterms).HasMaxLength(150);

                entity.Property(e => e.Incotermsid).HasColumnName("incotermsid");

                entity.Property(e => e.Issuancedate)
                    .HasColumnType("date")
                    .HasColumnName("issuancedate");

                entity.Property(e => e.LastDateofShip).HasColumnType("date");

                entity.Property(e => e.LcNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("LC_No");

                entity.Property(e => e.LcfullAmount).HasColumnName("LCFullAmount");

                entity.Property(e => e.Lctypeid).HasColumnName("LCTypeid");

                entity.Property(e => e.Lctypes)
                    .HasMaxLength(150)
                    .HasColumnName("LCTypes");

                entity.Property(e => e.Modifiedby).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName).HasMaxLength(150);

                entity.Property(e => e.Purpose).HasMaxLength(100);

                entity.Property(e => e.Sector).HasMaxLength(150);

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.Shippingdate)
                    .HasColumnType("date")
                    .HasColumnName("shippingdate");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SwiftCopy).HasMaxLength(200);

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");
            });

            modelBuilder.Entity<BfLcReceivedGood>(entity =>
            {
                entity.HasKey(e => new { e.Masterid, e.GoodsMasterkey, e.Receivedate, e.Invoiceno })
                    .HasName("PK_BF_LC_ReceivedGoods_1");

                entity.ToTable("BF_LC_ReceivedGoods");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.GoodsMasterkey).HasColumnName("goods_masterkey");

                entity.Property(e => e.Receivedate)
                    .HasColumnType("date")
                    .HasColumnName("receivedate");

                entity.Property(e => e.Invoiceno)
                    .HasMaxLength(50)
                    .HasColumnName("invoiceno");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Qtyreceive).HasColumnName("qtyreceive");

                entity.Property(e => e.Shipno)
                    .HasColumnName("shipno")
                    .HasComment("Shipment No");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");
            });

            modelBuilder.Entity<BfLcReceivedGoodsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LC_ReceivedGoods_view");

                entity.Property(e => e.Companysn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("companysn");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Descriptionofgoods)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("descriptionofgoods");

                entity.Property(e => e.Descriptionofgoodsid).HasColumnName("descriptionofgoodsid");

                entity.Property(e => e.GoodsMasterkey).HasColumnName("goods_masterkey");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Invoiceno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoiceno");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Priceperunit).HasColumnName("priceperunit");

                entity.Property(e => e.Qtyreceive).HasColumnName("qtyreceive");

                entity.Property(e => e.Receivedate)
                    .HasColumnType("date")
                    .HasColumnName("receivedate");

                entity.Property(e => e.Totalpricereceived).HasColumnName("totalpricereceived");

                entity.Property(e => e.Transactionid).HasColumnName("transactionid");

                entity.Property(e => e.Unitcode)
                    .HasMaxLength(100)
                    .HasColumnName("unitcode");
            });

            modelBuilder.Entity<BfLcTransaction>(entity =>
            {
                entity.HasKey(e => new { e.CompanySn, e.Lcno, e.PartialPaymentDate })
                    .HasName("PK_BF_LC_Transactions_1");

                entity.ToTable("BF_LC_Transactions");

                entity.Property(e => e.CompanySn).HasMaxLength(50);

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("LCNo");

                entity.Property(e => e.PartialPaymentDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Invoiceno).HasMaxLength(50);

                entity.Property(e => e.MasterKey).HasColumnName("Master_key");

                entity.Property(e => e.ModifieDate).HasColumnType("datetime");

                entity.Property(e => e.Modifyby).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.Receivedate)
                    .HasColumnType("date")
                    .HasColumnName("receivedate");

                entity.Property(e => e.SwiftCopy).HasMaxLength(250);

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BfLcType>(entity =>
            {
                entity.HasKey(e => e.Descriptions);

                entity.ToTable("BF_LC_Types");

                entity.Property(e => e.Descriptions).HasMaxLength(150);

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfLcapplicantbank>(entity =>
            {
                entity.HasKey(e => e.Bankcode);

                entity.ToTable("BF_LCApplicantbank");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(250)
                    .HasColumnName("bankname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLcbeneficiaryBank>(entity =>
            {
                entity.HasKey(e => e.Bankcode);

                entity.ToTable("BF_LCBeneficiaryBank");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Bankname)
                    .HasMaxLength(250)
                    .HasColumnName("bankname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLcinourfavor>(entity =>
            {
                entity.HasKey(e => e.Lcno);

                entity.ToTable("BF_LCinourfavor");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("LCNo");

                entity.Property(e => e.Applicantbankcode)
                    .HasMaxLength(50)
                    .HasColumnName("applicantbankcode");

                entity.Property(e => e.Attachments)
                    .HasMaxLength(350)
                    .HasColumnName("attachments");

                entity.Property(e => e.Beneficiarybankcode)
                    .HasMaxLength(50)
                    .HasColumnName("beneficiarybankcode");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Customer)
                    .HasMaxLength(50)
                    .HasColumnName("customer");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Invoiceamount).HasColumnName("invoiceamount");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("date")
                    .HasColumnName("invoicedate");

                entity.Property(e => e.Lcextensionvalue).HasColumnName("lcextensionvalue");

                entity.Property(e => e.Lcvalue).HasColumnName("lcvalue");

                entity.Property(e => e.Maturitydate)
                    .HasColumnType("date")
                    .HasColumnName("maturitydate");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Paymentterm)
                    .HasMaxLength(250)
                    .HasColumnName("paymentterm");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .HasColumnName("remarks");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");
            });

            modelBuilder.Entity<BfLcinourfavorView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LCinourfavor_view");

                entity.Property(e => e.Applicantbankcode)
                    .HasMaxLength(50)
                    .HasColumnName("applicantbankcode");

                entity.Property(e => e.Applicantbankname)
                    .HasMaxLength(250)
                    .HasColumnName("applicantbankname");

                entity.Property(e => e.Attachments)
                    .HasMaxLength(350)
                    .HasColumnName("attachments");

                entity.Property(e => e.Beneficiarybankcode)
                    .HasMaxLength(50)
                    .HasColumnName("beneficiarybankcode");

                entity.Property(e => e.Beneficiarybankname)
                    .HasMaxLength(250)
                    .HasColumnName("beneficiarybankname");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Customer)
                    .HasMaxLength(50)
                    .HasColumnName("customer");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Invoiceamount).HasColumnName("invoiceamount");

                entity.Property(e => e.Invoicedate)
                    .HasColumnType("date")
                    .HasColumnName("invoicedate");

                entity.Property(e => e.Lcextensionvalue).HasColumnName("lcextensionvalue");

                entity.Property(e => e.Lcno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LCNo");

                entity.Property(e => e.Lcvalue).HasColumnName("lcvalue");

                entity.Property(e => e.Maturitydate)
                    .HasColumnType("date")
                    .HasColumnName("maturitydate");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Paymentterm)
                    .HasMaxLength(250)
                    .HasColumnName("paymentterm");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Projects)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("projects");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .HasColumnName("remarks");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("sector");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");
            });

            modelBuilder.Entity<BfLcproject>(entity =>
            {
                entity.HasKey(e => e.Projects);

                entity.ToTable("BF_LCProjects");

                entity.Property(e => e.Projects)
                    .HasMaxLength(250)
                    .HasColumnName("projects");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLcreceivedTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LCReceivedTransactions");

                entity.Property(e => e.Datecreated)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("datecreated");

                entity.Property(e => e.Invoiceno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoiceno");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("lcno");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Receivedate)
                    .HasColumnType("date")
                    .HasColumnName("receivedate");
            });

            modelBuilder.Entity<BfLcsector>(entity =>
            {
                entity.HasKey(e => e.Sector);

                entity.ToTable("BF_LCSector");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLgExtension>(entity =>
            {
                entity.HasKey(e => new { e.Issuancedate, e.Expirydate, e.Lgmasterid });

                entity.ToTable("BF_LG_Extension");

                entity.Property(e => e.Issuancedate)
                    .HasColumnType("date")
                    .HasColumnName("issuancedate");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("date")
                    .HasColumnName("expirydate");

                entity.Property(e => e.Lgmasterid).HasColumnName("lgmasterid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lgamount).HasColumnName("lgamount");

                entity.Property(e => e.Lgno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lgno");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.Swiftcopy)
                    .HasMaxLength(250)
                    .HasColumnName("swiftcopy");
            });

            modelBuilder.Entity<BfLgMaster>(entity =>
            {
                entity.HasKey(e => new { e.LgNo, e.Issuingbankid, e.IssuanceDate, e.LgAmount });

                entity.ToTable("BF_LG_master");

                entity.Property(e => e.LgNo)
                    .HasMaxLength(150)
                    .HasColumnName("LG_No");

                entity.Property(e => e.IssuanceDate).HasColumnType("datetime");

                entity.Property(e => e.LgAmount).HasColumnName("LG_Amount");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.BeneficiaryName).HasMaxLength(150);

                entity.Property(e => e.Companysn)
                    .HasMaxLength(50)
                    .HasColumnName("companysn");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LgCopy)
                    .HasMaxLength(150)
                    .HasColumnName("LG_Copy");

                entity.Property(e => e.LgPurposeid).HasColumnName("LG_Purposeid");

                entity.Property(e => e.LgTypeid).HasColumnName("LG_Typeid");

                entity.Property(e => e.Lgcategoryid).HasColumnName("LGcategoryid");

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("mdate");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Msetstatusby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("msetstatusby");

                entity.Property(e => e.Mstatus).HasColumnName("mstatus");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.ScanSwift).HasMaxLength(150);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BfLgMasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LG_Master_view");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.BeneficiaryName).HasMaxLength(150);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .HasColumnName("category");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Expirydate).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Issuancedate).HasColumnType("date");

                entity.Property(e => e.LgAmount).HasColumnName("LG_Amount");

                entity.Property(e => e.LgBalance).HasColumnName("LG_Balance");

                entity.Property(e => e.LgCopy)
                    .HasMaxLength(150)
                    .HasColumnName("LG_Copy");

                entity.Property(e => e.LgNo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("LG_No");

                entity.Property(e => e.LgType)
                    .HasMaxLength(150)
                    .HasColumnName("LG_Type");

                entity.Property(e => e.LgTypeid).HasColumnName("LG_Typeid");

                entity.Property(e => e.Lgcategoryid).HasColumnName("LGcategoryid");

                entity.Property(e => e.Msetstatusby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("msetstatusby");

                entity.Property(e => e.Mstatus).HasColumnName("mstatus");

                entity.Property(e => e.Mstatustext)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("mstatustext");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.Operatingno)
                    .HasMaxLength(150)
                    .HasColumnName("operatingno");

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.ProjectName).HasMaxLength(150);

                entity.Property(e => e.ScanSwift).HasMaxLength(150);

                entity.Property(e => e.Sector).HasMaxLength(150);
            });

            modelBuilder.Entity<BfLgTransaction>(entity =>
            {
                entity.HasKey(e => new { e.Transactionname, e.Bankletter, e.DateRir, e.Lgmasterid });

                entity.ToTable("BF_LG_Transactions");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Bankletter)
                    .HasMaxLength(50)
                    .HasColumnName("bankletter");

                entity.Property(e => e.DateRir)
                    .HasColumnType("date")
                    .HasColumnName("date_RIR")
                    .HasComment("Reduction/Increase/Retirement");

                entity.Property(e => e.Lgmasterid).HasColumnName("lgmasterid");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.AmountofRir)
                    .HasColumnName("amountof_RIR")
                    .HasComment("Amount of Reduction or Increase Amount");

                entity.Property(e => e.Beneficiaryname)
                    .HasMaxLength(250)
                    .HasColumnName("beneficiaryname");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(20)
                    .HasColumnName("companysn");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(25)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("date")
                    .HasColumnName("expirydate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Issuancedate)
                    .HasColumnType("date")
                    .HasColumnName("issuancedate");

                entity.Property(e => e.Lgbalance).HasColumnName("lgbalance");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Lgno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lgno");

                entity.Property(e => e.Lgtypeid).HasColumnName("lgtypeid");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.Projectamount).HasColumnName("projectamount");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Swiftcopy)
                    .HasMaxLength(250)
                    .HasColumnName("swiftcopy");
            });

            modelBuilder.Entity<BfLgType>(entity =>
            {
                entity.HasKey(e => e.Description)
                    .HasName("PK_BF_LGtypes");

                entity.ToTable("BF_LG_types");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfLgbank>(entity =>
            {
                entity.HasKey(e => e.Bankcode);

                entity.ToTable("BF_LGBanks");

                entity.Property(e => e.Bankcode).HasMaxLength(20);

                entity.Property(e => e.Bankname).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLgcategory>(entity =>
            {
                entity.HasKey(e => e.Lgcategory);

                entity.ToTable("BF_LGCategory");

                entity.Property(e => e.Lgcategory)
                    .HasMaxLength(50)
                    .HasColumnName("LGCategory");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLginourFavor>(entity =>
            {
                entity.HasKey(e => e.Lgno);

                entity.ToTable("BF_LGinourFavor");

                entity.Property(e => e.Lgno)
                    .HasMaxLength(50)
                    .HasColumnName("LGNo");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .HasColumnName("applicant");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.BusinessunitId).HasColumnName("businessunit_id");

                entity.Property(e => e.Costcenterid).HasColumnName("costcenterid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Dateofexpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofexpiry");

                entity.Property(e => e.Datetoestab)
                    .HasColumnType("date")
                    .HasColumnName("datetoestab");

                entity.Property(e => e.Guaranteetypeid).HasColumnName("guaranteetypeid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Respectof)
                    .HasMaxLength(250)
                    .HasColumnName("respectof");
            });

            modelBuilder.Entity<BfLginourFavorView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LGinourFavor_view");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Applicant)
                    .HasMaxLength(50)
                    .HasColumnName("applicant");

                entity.Property(e => e.Bankcode).HasMaxLength(20);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Bankname).HasMaxLength(50);

                entity.Property(e => e.Businessunit)
                    .HasMaxLength(250)
                    .HasColumnName("businessunit");

                entity.Property(e => e.BusinessunitId).HasColumnName("businessunit_id");

                entity.Property(e => e.CostCenter).HasMaxLength(250);

                entity.Property(e => e.Costcenterid).HasColumnName("costcenterid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Dateofexpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofexpiry");

                entity.Property(e => e.Datetoestab)
                    .HasColumnType("date")
                    .HasColumnName("datetoestab");

                entity.Property(e => e.Guaranteetype)
                    .HasMaxLength(150)
                    .HasColumnName("guaranteetype");

                entity.Property(e => e.Guaranteetypeid).HasColumnName("guaranteetypeid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lgno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LGNo");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Projects)
                    .HasMaxLength(250)
                    .HasColumnName("projects");

                entity.Property(e => e.Respectof)
                    .HasMaxLength(250)
                    .HasColumnName("respectof");
            });

            modelBuilder.Entity<BfLgproject>(entity =>
            {
                entity.HasKey(e => e.Projects);

                entity.ToTable("BF_LGProjects");

                entity.Property(e => e.Projects)
                    .HasMaxLength(250)
                    .HasColumnName("projects");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLoanAmountAdjustment>(entity =>
            {
                entity.HasKey(e => new { e.BuId, e.LoanmasterId, e.LoanamountOld, e.LoanamountNew, e.Dateofchange });

                entity.ToTable("BF_LoanAmount_Adjustments");

                entity.Property(e => e.BuId).HasColumnName("BU_ID");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.LoanamountOld)
                    .HasColumnName("loanamount_old")
                    .HasComment("this will log the original amount");

                entity.Property(e => e.LoanamountNew).HasColumnName("loanamount_new");

                entity.Property(e => e.Dateofchange)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofchange");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(150)
                    .HasColumnName("attachment");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(15)
                    .HasColumnName("companysn");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Interestexp).HasColumnName("interestexp");

                entity.Property(e => e.Loanno)
                    .HasMaxLength(50)
                    .HasColumnName("loanno");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("modifieddate")
                    .HasComment("only last modified date, since trigger is not yet implemented here");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Siborrate).HasColumnName("siborrate");

                entity.Property(e => e.Totalinterest).HasColumnName("totalinterest");
            });

            modelBuilder.Entity<BfLoanBeneficiaryEntry>(entity =>
            {
                entity.HasKey(e => new { e.Companysn, e.Bankid, e.Loanbeneficiaryid });

                entity.ToTable("BF_LoanBeneficiaryEntry");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(10)
                    .HasColumnName("companysn");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Loanbeneficiaryid).HasColumnName("loanbeneficiaryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLoanDictionary>(entity =>
            {
                entity.HasKey(e => e.Action);

                entity.ToTable("BF_Loan_Dictionary");

                entity.Property(e => e.Action).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfLoanEmail>(entity =>
            {
                entity.HasKey(e => e.Emailaddress);

                entity.ToTable("BF_Loan_Email");

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(50)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Cc)
                    .HasMaxLength(250)
                    .HasColumnName("cc");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasMaxLength(350)
                    .HasColumnName("link");

                entity.Property(e => e.Mailbody)
                    .HasMaxLength(350)
                    .HasColumnName("mailbody");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .HasColumnName("module");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Subject)
                    .HasMaxLength(250)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<BfLoanMaster>(entity =>
            {
                entity.HasKey(e => new { e.CompanySn, e.LoanCategoryId, e.ProjectNameId, e.AccountNo });

                entity.ToTable("BF_Loan_Master");

                entity.Property(e => e.CompanySn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompanySN")
                    .IsFixedLength(true);

                entity.Property(e => e.LoanCategoryId).HasColumnName("LoanCategoryID");

                entity.Property(e => e.ProjectNameId).HasColumnName("ProjectNameID");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Bankletters)
                    .HasMaxLength(50)
                    .HasColumnName("bankletters");

                entity.Property(e => e.Beneficiarysectorid)
                    .HasColumnName("beneficiarysectorid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.FacilityCardKey).HasColumnName("FacilityCard_key");

                entity.Property(e => e.GrandtingDate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("lcno")
                    .HasComment("This is the LC NO key from LC CARD");

                entity.Property(e => e.LetterCopy).HasMaxLength(150);

                entity.Property(e => e.LoanNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LoanPurposeId).HasColumnName("LoanPurposeID");

                entity.Property(e => e.Modify).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.Operatingnoid).HasColumnName("operatingnoid");

                entity.Property(e => e.Repaymentdate).HasColumnType("date");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.Startingdate).HasColumnType("date");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('New')");
            });

            modelBuilder.Entity<BfLoanPremium>(entity =>
            {
                entity.HasKey(e => new { e.LoanmasterId, e.Premdate });

                entity.ToTable("BF_Loan_Premiums");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Premdate)
                    .HasColumnType("date")
                    .HasColumnName("premdate");

                entity.Property(e => e.Alertdays).HasColumnName("alertdays");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Dateofpayment)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofpayment");

                entity.Property(e => e.Datepaid)
                    .HasColumnType("datetime")
                    .HasColumnName("datepaid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Paidbyuser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("paidbyuser");

                entity.Property(e => e.Premamount).HasColumnName("premamount");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<BfLoanPremiumsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Loan_PremiumsView");

                entity.Property(e => e.Alertdays).HasColumnName("alertdays");

                entity.Property(e => e.CompanySn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompanySN")
                    .IsFixedLength(true);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Dateofpayment)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofpayment");

                entity.Property(e => e.Datepaid)
                    .HasColumnType("datetime")
                    .HasColumnName("datepaid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Loanbalance).HasColumnName("loanbalance");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Premamount).HasColumnName("premamount");

                entity.Property(e => e.Premdate)
                    .HasColumnType("date")
                    .HasColumnName("premdate");

                entity.Property(e => e.ProjectName).HasMaxLength(150);

                entity.Property(e => e.ProjectNameId).HasColumnName("ProjectNameID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<BfLoanPurpose>(entity =>
            {
                entity.HasKey(e => e.Description)
                    .HasName("PK_BF_LoadPurpose");

                entity.ToTable("BF_LoanPurpose");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfLoanPurposeEntry>(entity =>
            {
                entity.HasKey(e => new { e.Companysn, e.Bankid, e.Loanpurposeid });

                entity.ToTable("BF_LoanPurposeEntry");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(10)
                    .HasColumnName("companysn");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Loanpurposeid).HasColumnName("loanpurposeid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Beneficiarysectorid).HasColumnName("beneficiarysectorid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");
            });

            modelBuilder.Entity<BfLoanPurposeEntryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LoanPurposeEntry_View");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Companysn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("companysn");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LoanCategory).HasMaxLength(100);

                entity.Property(e => e.LoanCategoryId).HasColumnName("LoanCategoryID");

                entity.Property(e => e.Loanpurposeid).HasColumnName("loanpurposeid");
            });

            modelBuilder.Entity<BfLoanReductionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_LoanReduction_view");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateofReduction).HasColumnType("date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.LoanCategoryId).HasColumnName("LoanCategoryID");

                entity.Property(e => e.ProjectNameId).HasColumnName("ProjectNameID");

                entity.Property(e => e.Transactionname)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");
            });

            modelBuilder.Entity<BfLoanTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BF_Loan_Transactions");

                entity.Property(e => e.CompanySn)
                    .HasMaxLength(50)
                    .HasColumnName("CompanySN");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified).HasColumnType("datetime");

                entity.Property(e => e.DateofReduction).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LettercopyReduction)
                    .HasMaxLength(150)
                    .HasColumnName("Lettercopy_reduction");

                entity.Property(e => e.LoanMasterId).HasColumnName("LoanMaster_id");

                entity.Property(e => e.Modifyby).HasMaxLength(20);

                entity.Property(e => e.NotesReduction)
                    .HasMaxLength(250)
                    .HasColumnName("Notes_Reduction");
            });

            modelBuilder.Entity<BfManageSector>(entity =>
            {
                entity.HasKey(e => e.Sectorid);

                entity.ToTable("BF_ManageSector");

                entity.Property(e => e.Sectorid)
                    .ValueGeneratedNever()
                    .HasColumnName("sectorid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Openlimit).HasColumnName("openlimit");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Validfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("validfrom");

                entity.Property(e => e.Validto)
                    .HasColumnType("datetime")
                    .HasColumnName("validto");
            });

            modelBuilder.Entity<BfManageSectorView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_ManageSectorView");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Openlimit).HasColumnName("openlimit");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("validfrom");

                entity.Property(e => e.Validto)
                    .HasColumnType("datetime")
                    .HasColumnName("validto");
            });

            modelBuilder.Entity<BfNavisionSectorBalance>(entity =>
            {
                entity.HasKey(e => new { e.Sector, e.Currentdate });

                entity.ToTable("BF_NavisionSectorBalance");

                entity.Property(e => e.Sector)
                    .HasMaxLength(150)
                    .HasColumnName("sector");

                entity.Property(e => e.Currentdate)
                    .HasColumnType("date")
                    .HasColumnName("currentdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(38, 20)")
                    .HasColumnName("balance");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rtble)
                    .HasMaxLength(150)
                    .HasComment("(Rtble) Retrieving Table from Navision database =Treasury GL/Bank Account");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");
            });

            modelBuilder.Entity<BfNewSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_NewSummary");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Endingdate).HasColumnType("date");

                entity.Property(e => e.Endingdate2).HasColumnType("date");

                entity.Property(e => e.GrandtingDate).HasColumnType("date");

                entity.Property(e => e.LoanMasterId).HasColumnName("LoanMaster_id");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Startingdate).HasColumnType("date");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BfOperatingNo>(entity =>
            {
                entity.HasKey(e => e.Operatingno);

                entity.ToTable("BF_OperatingNo");

                entity.Property(e => e.Operatingno)
                    .HasMaxLength(150)
                    .HasColumnName("operatingno");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfOverDraftPurpose>(entity =>
            {
                entity.HasKey(e => e.Description);

                entity.ToTable("BF_OverDraftPurpose");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfPaymentSourceEntry>(entity =>
            {
                entity.HasKey(e => new { e.LoanmasterId, e.Sourceid, e.Dateofpayment });

                entity.ToTable("BF_PaymentSourceEntry");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Dateofpayment)
                    .HasColumnType("date")
                    .HasColumnName("dateofpayment");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Paymentamount).HasColumnName("paymentamount");
            });

            modelBuilder.Entity<BfPaymentSourceEntryV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PaymentSourceEntry_V");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Loancategoryid).HasColumnName("loancategoryid");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Sourcename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("sourcename");
            });

            modelBuilder.Entity<BfPaymentSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PaymentSummary");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Endingdate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Loanamount).HasColumnName("loanamount");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Sector)
                    .HasMaxLength(150)
                    .HasColumnName("sector");

                entity.Property(e => e.Startingdate).HasColumnType("date");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");
            });

            modelBuilder.Entity<BfPaymentTransaction>(entity =>
            {
                entity.HasKey(e => new { e.LoanmasterId, e.Dateofpayment, e.Sourceid });

                entity.ToTable("BF_Payment_Transactions");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Dateofpayment)
                    .HasColumnType("date")
                    .HasColumnName("dateofpayment");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Chargedcostsector).HasColumnName("chargedcostsector");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("companysn");

                entity.Property(e => e.Creator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Grantingdate)
                    .HasColumnType("date")
                    .HasColumnName("grantingdate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lettercopy)
                    .HasMaxLength(250)
                    .HasColumnName("lettercopy");

                entity.Property(e => e.Lifetime).HasColumnName("lifetime");

                entity.Property(e => e.Lifetimebankinterest).HasColumnName("lifetimebankinterest");

                entity.Property(e => e.Lifetimechargesector).HasColumnName("lifetimechargesector");

                entity.Property(e => e.Lifetimeprofit).HasColumnName("lifetimeprofit");

                entity.Property(e => e.Loanamount).HasColumnName("loanamount");

                entity.Property(e => e.Loancategory)
                    .HasMaxLength(150)
                    .HasColumnName("loancategory");

                entity.Property(e => e.Loancategoryid).HasColumnName("loancategoryid");

                entity.Property(e => e.Loanpurpose)
                    .HasMaxLength(150)
                    .HasColumnName("loanpurpose");

                entity.Property(e => e.Loanpurposeid).HasColumnName("loanpurposeid");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.Projectname)
                    .HasMaxLength(150)
                    .HasColumnName("projectname");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(10)
                    .HasColumnName("projectnameid")
                    .IsFixedLength(true);

                entity.Property(e => e.Repaymentdate)
                    .HasColumnType("date")
                    .HasColumnName("repaymentdate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(150)
                    .HasColumnName("sector");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Totalinterestexp).HasColumnName("totalinterestexp");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Treasurymargin).HasColumnName("treasurymargin");

                entity.Property(e => e.Treasuryprofitloan).HasColumnName("treasuryprofitloan");
            });

            modelBuilder.Entity<BfPfsHeaderV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_Header_V");

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(152)
                    .HasColumnName("category");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Project)
                    .HasMaxLength(150)
                    .HasColumnName("project");

                entity.Property(e => e.Projectid).HasColumnName("projectid");
            });

            modelBuilder.Entity<BfPfsLctrx1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_LCTrx_1");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.IssuingBankid)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Lcamount).HasColumnName("lcamount");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(53)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("date")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsLctrx2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_LCTrx_2");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Issuingbankid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("issuingbankid");

                entity.Property(e => e.Lcamount).HasColumnName("lcamount");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(53)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("date")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsLgtrx1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_LGTrx_1");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.LgAmount).HasColumnName("LG_Amount");

                entity.Property(e => e.Transactionname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("date")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsLgtrx2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_LGTrx_2");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.LgAmount).HasColumnName("lg_amount");

                entity.Property(e => e.Projectnameid).HasColumnName("projectnameid");

                entity.Property(e => e.Transactionname)
                    .IsRequired()
                    .HasMaxLength(23)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("datetime")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsListV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_List_V");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Originalamount).HasColumnName("originalamount");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("datetime")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsLoanTrx1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_LoanTrx_1");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.LoanMasterId).HasColumnName("LoanMaster_id");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("date")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsLoanTrx2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_LoanTrx_2");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.ProjectNameId).HasColumnName("ProjectNameID");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("date")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPfsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_PFS_V");

                entity.Property(e => e.BankLetters).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Category)
                    .HasMaxLength(152)
                    .HasColumnName("category");

                entity.Property(e => e.Categoryid)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("categoryid");

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Originalamount).HasColumnName("originalamount");

                entity.Property(e => e.Project)
                    .HasMaxLength(150)
                    .HasColumnName("project");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("transactionname");

                entity.Property(e => e.Xamount).HasColumnName("xamount");

                entity.Property(e => e.Xdate)
                    .HasColumnType("datetime")
                    .HasColumnName("xdate");
            });

            modelBuilder.Entity<BfPosition>(entity =>
            {
                entity.HasKey(e => e.Positioncode);

                entity.ToTable("BF_Positions");

                entity.Property(e => e.Positioncode)
                    .HasMaxLength(20)
                    .HasColumnName("positioncode");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");
            });

            modelBuilder.Entity<BfProject>(entity =>
            {
                entity.HasKey(e => e.ProjectName);

                entity.ToTable("BF_Projects");

                entity.Property(e => e.ProjectName).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfReductionSourceEntry>(entity =>
            {
                entity.HasKey(e => new { e.LoanmasterId, e.Sourceid, e.Dateofreduction });

                entity.ToTable("BF_ReductionSourceEntry");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Dateofreduction)
                    .HasColumnType("date")
                    .HasColumnName("dateofreduction");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(20)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Reductionamount).HasColumnName("reductionamount");
            });

            modelBuilder.Entity<BfReductionSourceEntryV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_ReductionSourceEntry_V");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Dateofreduction)
                    .HasColumnType("date")
                    .HasColumnName("dateofreduction");

                entity.Property(e => e.LoanCategoryId).HasColumnName("LoanCategoryID");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Sourcename)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("sourcename");
            });

            modelBuilder.Entity<BfReductionTransaction>(entity =>
            {
                entity.HasKey(e => new { e.LoanMasterId, e.ReductionAmount, e.DateofReduction, e.NotesReduction });

                entity.ToTable("BF_Reduction_Transactions");

                entity.Property(e => e.LoanMasterId).HasColumnName("LoanMaster_id");

                entity.Property(e => e.DateofReduction).HasColumnType("date");

                entity.Property(e => e.NotesReduction)
                    .HasMaxLength(250)
                    .HasColumnName("Notes_Reduction");

                entity.Property(e => e.CompanySn)
                    .HasMaxLength(50)
                    .HasColumnName("CompanySN");

                entity.Property(e => e.Creator).HasMaxLength(50);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified).HasColumnType("datetime");

                entity.Property(e => e.Endingdate).HasColumnType("date");

                entity.Property(e => e.Facilityrate).HasColumnName("facilityrate");

                entity.Property(e => e.Grantingdate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LettercopyReduction)
                    .HasMaxLength(150)
                    .HasColumnName("Lettercopy_reduction");

                entity.Property(e => e.Modifyby).HasMaxLength(20);

                entity.Property(e => e.Repaymentdate).HasColumnType("date");

                entity.Property(e => e.Sector).HasMaxLength(100);

                entity.Property(e => e.Siborrate).HasColumnName("siborrate");

                entity.Property(e => e.Sourceid).HasColumnName("sourceid");

                entity.Property(e => e.Transaction)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Reduction')");
            });

            modelBuilder.Entity<BfRenewSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_RenewSummary");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Endingdate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.InterestexpMaster).HasColumnName("Interestexp_master");

                entity.Property(e => e.LoanmasterId).HasColumnName("Loanmaster_id");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.TransactionName)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BfRenewTransaction>(entity =>
            {
                entity.HasKey(e => new { e.LoanmasterId, e.StartingDate, e.EndingDate });

                entity.ToTable("BF_Renew_Transactions");

                entity.Property(e => e.LoanmasterId).HasColumnName("Loanmaster_id");

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.Companysn)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreation)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndingdateTemp)
                    .HasColumnType("date")
                    .HasColumnName("Endingdate_temp");

                entity.Property(e => e.GrantingDate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LetterCopy).HasMaxLength(150);

                entity.Property(e => e.LoanNoNew)
                    .HasMaxLength(50)
                    .HasColumnName("LoanNo_New");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.RepaymentDate).HasColumnType("date");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.Transaction)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Renew')");
            });

            modelBuilder.Entity<BfReqApprovalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_ReqApproval_view");

                entity.Property(e => e.Amountrequest).HasColumnName("amountrequest");

                entity.Property(e => e.Approvalusername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("approvalusername");

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.Createdby)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Dateofrepayment)
                    .HasColumnType("date")
                    .HasColumnName("dateofrepayment");

                entity.Property(e => e.Dateofrequest)
                    .HasColumnType("date")
                    .HasColumnName("dateofrequest");

                entity.Property(e => e.FmApproval)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FM_Approval");

                entity.Property(e => e.FmDatelog)
                    .HasColumnType("datetime")
                    .HasColumnName("FM_datelog");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Limitstatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("limitstatus");

                entity.Property(e => e.Overlimitamount).HasColumnName("overlimitamount");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Remarks).HasColumnName("remarks");

                entity.Property(e => e.Requestid).HasColumnName("requestid");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Sectorlimit).HasColumnName("sectorlimit");

                entity.Property(e => e.SgmDatelog)
                    .HasColumnType("datetime")
                    .HasColumnName("SGM_datelog");

                entity.Property(e => e.SmApproval)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SM_Approval");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Utilized).HasColumnName("utilized");
            });

            modelBuilder.Entity<BfSector>(entity =>
            {
                entity.HasKey(e => e.Sector);

                entity.ToTable("BF_Sectors");

                entity.Property(e => e.Sector).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<BfSectorAccountNo>(entity =>
            {
                entity.HasKey(e => new { e.SectorFkey, e.Accountno });

                entity.ToTable("BF_SectorAccountNo");

                entity.Property(e => e.SectorFkey).HasColumnName("sector_fkey");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .HasColumnName("accountno");

                entity.Property(e => e.Accountname)
                    .HasMaxLength(150)
                    .HasColumnName("accountname");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Rtble)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RTble");
            });

            modelBuilder.Entity<BfSectorManagerEmail>(entity =>
            {
                entity.HasKey(e => new { e.Sectorid, e.Username, e.Position })
                    .HasName("PK_BF_SectorManagerEmail_1");

                entity.ToTable("BF_SectorManagerEmail");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("position");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodifed)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodifed");

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(150)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");
            });

            modelBuilder.Entity<BfSectorManagerEmailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_SectorManagerEmail_view");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Datemodifed)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodifed");

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(150)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.Positionval)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("positionval");

                entity.Property(e => e.Sector)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("sector");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BfSource>(entity =>
            {
                entity.HasKey(e => e.Sourcename);

                entity.ToTable("BF_Source");

                entity.Property(e => e.Sourcename)
                    .HasMaxLength(250)
                    .HasColumnName("sourcename");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<BfSpecificLine>(entity =>
            {
                entity.HasKey(e => new { e.Masterid, e.Projectid, e.Categoryid, e.Lgcategoryid, e.Accountnoid })
                    .HasName("PK_BF_SpecificLine_1");

                entity.ToTable("BF_SpecificLine");

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit)
                    .HasColumnName("creditlimit")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lccreditlimit).HasColumnName("lccreditlimit");

                entity.Property(e => e.Lifetimedays).HasColumnName("lifetimedays");

                entity.Property(e => e.Loancreditlimit).HasColumnName("loancreditlimit");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector")
                    .HasComment("To display the corresponding sector name use dbo.Split function(TVF)");

                entity.Property(e => e.Subcreditlimit).HasColumnName("subcreditlimit");

                entity.Property(e => e.Utilized).HasColumnName("utilized");
            });

            modelBuilder.Entity<BfSpecificLineView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_SpecificLine_view");

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("category");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lccreditlimit).HasColumnName("lccreditlimit");

                entity.Property(e => e.Lgcategory)
                    .HasMaxLength(50)
                    .HasColumnName("LGCategory");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Lifetimedays).HasColumnName("lifetimedays");

                entity.Property(e => e.Loancreditlimit).HasColumnName("loancreditlimit");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Project)
                    .HasMaxLength(150)
                    .HasColumnName("project");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector");

                entity.Property(e => e.Subcreditlimit).HasColumnName("subcreditlimit");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfSpecificLineView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_SpecificLine_view2");

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.BankLetters)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankNames).HasMaxLength(50);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("category");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lccreditlimit).HasColumnName("lccreditlimit");

                entity.Property(e => e.Lgcategory)
                    .HasMaxLength(50)
                    .HasColumnName("LGCategory");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Lifetimedays).HasColumnName("lifetimedays");

                entity.Property(e => e.Loancreditlimit).HasColumnName("loancreditlimit");

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.Project)
                    .HasMaxLength(150)
                    .HasColumnName("project");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Sector)
                    .HasMaxLength(250)
                    .HasColumnName("sector");

                entity.Property(e => e.Subcreditlimit).HasColumnName("subcreditlimit");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BfTransferHistory>(entity =>
            {
                entity.HasKey(e => new { e.LoanmasterId, e.DateofTransfer, e.LoanPurposeId, e.TransfertoSectorid, e.ProjectNameid });

                entity.ToTable("BF_Transfer_History");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.DateofTransfer).HasColumnType("date");

                entity.Property(e => e.LoanPurposeId).HasColumnName("LoanPurposeID");

                entity.Property(e => e.CompanySn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompanySN");

                entity.Property(e => e.Creator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.FromSector).HasMaxLength(50);

                entity.Property(e => e.GrantingDate).HasColumnType("date");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LoanPurpose).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.RepaymentDate).HasColumnType("date");

                entity.Property(e => e.Transactionname)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'Transfer')");

                entity.Property(e => e.TransfertoSector).HasMaxLength(50);
            });

            modelBuilder.Entity<BfTransferHistoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Transfer_History_view");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.CompanySn)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompanySN")
                    .IsFixedLength(true);

                entity.Property(e => e.Creator)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateofTransfer).HasColumnType("date");

                entity.Property(e => e.FromSector).HasMaxLength(50);

                entity.Property(e => e.GrantingDate).HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LoanNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LoanPurpose).HasMaxLength(100);

                entity.Property(e => e.LoanPurposeId).HasColumnName("LoanPurposeID");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Notes).HasMaxLength(150);

                entity.Property(e => e.ProjectName).HasMaxLength(100);

                entity.Property(e => e.RepaymentDate).HasColumnType("date");

                entity.Property(e => e.TransfertoSector).HasMaxLength(50);
            });

            modelBuilder.Entity<BfTransferSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_TransferSummary");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.EndingDate).HasColumnType("date");

                entity.Property(e => e.LoanmasterId).HasColumnName("loanmaster_id");

                entity.Property(e => e.Sector).HasMaxLength(50);

                entity.Property(e => e.Startingdate).HasColumnType("date");

                entity.Property(e => e.Transactionname).HasMaxLength(20);
            });

            modelBuilder.Entity<BfUserAccessPermissionV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_UserAccessPermission_V");

                entity.Property(e => e.BuId).HasColumnName("BU_ID");

                entity.Property(e => e.Businessunit)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("businessunit");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Priviledge)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PrivilegeId).HasColumnName("PrivilegeID");

                entity.Property(e => e.SubModule)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.Property(e => e.UserGroup)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Usergroupid).HasColumnName("usergroupid");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BfUserGroupPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_UserGroupPermission");

                entity.Property(e => e.GroupDescEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GroupDescEN");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleDescEn)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ModuleDescEN")
                    .IsFixedLength(true);

                entity.Property(e => e.ModuleDescriptionEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ModuleDescriptionEN");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PrivilegeDescriptionEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PrivilegeDescriptionEN");

                entity.Property(e => e.PrivilegeId).HasColumnName("PrivilegeID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");
            });

            modelBuilder.Entity<BfUtilizationLctransactionV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_LCTransaction_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.EntryNo).HasColumnName("entry_no");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxCard)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("trx_card");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("date")
                    .HasColumnName("trx_date");

                entity.Property(e => e.TrxName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("trx_name");
            });

            modelBuilder.Entity<BfUtilizationLgV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_LG_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxCard)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("trx_card");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trx_date");

                entity.Property(e => e.TrxName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trx_name");
            });

            modelBuilder.Entity<BfUtilizationLgtransactionsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_LGTransactions_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Lgcategoryid).HasColumnName("lgcategoryid");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxCard)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("trx_card");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("date")
                    .HasColumnName("trx_date");

                entity.Property(e => e.TrxName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("trx_name");
            });

            modelBuilder.Entity<BfUtilizationLoanAmountAdjustmentV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_LoanAmountAdjustment_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trx_date");
            });

            modelBuilder.Entity<BfUtilizationLoanV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_Loan_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxCard)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("trx_card");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("date")
                    .HasColumnName("trx_date");

                entity.Property(e => e.TrxName)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("trx_name");
            });

            modelBuilder.Entity<BfUtilizationLoanpaymentV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_Loanpayment_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.Sectorid).HasColumnName("sectorid");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("date")
                    .HasColumnName("trx_date");
            });

            modelBuilder.Entity<BfUtilizationLoanpremiumsV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_Loanpremiums_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Datepaid)
                    .HasColumnType("datetime")
                    .HasColumnName("datepaid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("date")
                    .HasColumnName("trx_date");
            });

            modelBuilder.Entity<BfUtilizationLoanreductionV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BF_Utilization_Loanreduction_V");

                entity.Property(e => e.Accountnoid).HasColumnName("accountnoid");

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("entry_date");

                entity.Property(e => e.Entryno).HasColumnName("entryno");

                entity.Property(e => e.Projectid).HasColumnName("projectid");

                entity.Property(e => e.SectorId).HasColumnName("SectorID");

                entity.Property(e => e.TrxAmount).HasColumnName("trx_amount");

                entity.Property(e => e.TrxDate)
                    .HasColumnType("date")
                    .HasColumnName("trx_date");
            });

            modelBuilder.Entity<BfsSl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BFS_SL");

                entity.Property(e => e.AccNo)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Availableforuse).HasColumnName("availableforuse");

                entity.Property(e => e.BankNames).HasMaxLength(100);

                entity.Property(e => e.Bankid).HasColumnName("bankid");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("category");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Creditlimit).HasColumnName("creditlimit");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Line)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MasterId).HasColumnName("master_id");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Percentage).HasColumnName("percentage");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Utilized).HasColumnName("utilized");

                entity.Property(e => e.Validfrom).HasColumnType("date");

                entity.Property(e => e.Validto).HasColumnType("date");
            });

            modelBuilder.Entity<BlockedSiteurl>(entity =>
            {
                entity.HasKey(e => new { e.Datevisit, e.Url, e.Ip });

                entity.ToTable("blocked_siteurl");

                entity.Property(e => e.Datevisit)
                    .HasMaxLength(50)
                    .HasColumnName("datevisit");

                entity.Property(e => e.Url)
                    .HasMaxLength(350)
                    .HasColumnName("url");

                entity.Property(e => e.Ip)
                    .HasMaxLength(25)
                    .HasColumnName("ip");

                entity.Property(e => e.Host)
                    .HasMaxLength(50)
                    .HasColumnName("host");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<BravoPackage>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("BRAVO_Package");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CoName);

                entity.ToTable("Company");

                entity.Property(e => e.CoName).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(25);
            });

            modelBuilder.Entity<CompanyList>(entity =>
            {
                entity.HasKey(e => e.Company);

                entity.ToTable("CompanyList");

                entity.Property(e => e.Company).HasMaxLength(150);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DepId).HasColumnName("DepID");

                entity.Property(e => e.DepNameDesc).HasMaxLength(1000);
            });

            modelBuilder.Entity<DeptGroup>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.DirectManagerId });

                entity.ToTable("DeptGroup");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DirectManagerId)
                    .HasMaxLength(10)
                    .HasColumnName("DirectManagerID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DeptGroupList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DeptGroupList");

                entity.Property(e => e.DirectManagerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("DirectManagerID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DirectManager>(entity =>
            {
                entity.HasKey(e => new { e.DirectManagerId, e.DepartmentId })
                    .HasName("pk_directmanagerid");

                entity.ToTable("Direct_Manager");

                entity.Property(e => e.DirectManagerId)
                    .HasMaxLength(10)
                    .HasColumnName("DirectManagerID")
                    .IsFixedLength(true);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.ArabicFullname).HasMaxLength(50);

                entity.Property(e => e.EmailAdd)
                    .HasMaxLength(30)
                    .HasColumnName("Email_add")
                    .IsFixedLength(true);

                entity.Property(e => e.EmailBcc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_BCC");

                entity.Property(e => e.EmailCc)
                    .HasMaxLength(100)
                    .HasColumnName("Email_CC")
                    .IsFixedLength(true);

                entity.Property(e => e.FullnameEn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fullname_en");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailNotificationSetting>(entity =>
            {
                entity.HasKey(e => e.NotificationName);

                entity.ToTable("Email_Notification_Settings");

                entity.Property(e => e.NotificationName)
                    .HasMaxLength(50)
                    .HasColumnName("notification_name");

                entity.Property(e => e.EmailBcc)
                    .HasMaxLength(150)
                    .HasColumnName("email_bcc");

                entity.Property(e => e.EmailCc)
                    .HasMaxLength(150)
                    .HasColumnName("email_cc");

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(150)
                    .HasColumnName("email_to");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .HasColumnName("subject");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<EmployeeDimensionsvalue2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee_dimensionsvalue2");

                entity.Property(e => e.Code)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeesInformation>(entity =>
            {
                entity.ToTable("employees_information");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .HasColumnName("company_code");

                entity.Property(e => e.Division)
                    .HasMaxLength(100)
                    .HasColumnName("division");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(100)
                    .HasColumnName("employee_code");

                entity.Property(e => e.EmployeeNameA)
                    .HasMaxLength(100)
                    .HasColumnName("employee_name_a");

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(100)
                    .HasColumnName("employee_name_eng");

                entity.Property(e => e.EmployeeStatusDesc)
                    .HasMaxLength(200)
                    .HasColumnName("employee_status_desc");

                entity.Property(e => e.HiringDate)
                    .HasColumnType("datetime")
                    .HasColumnName("hiring_date");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .HasColumnName("mobile");
            });

            modelBuilder.Entity<Expirationreminder>(entity =>
            {
                entity.HasKey(e => new { e.Empcode, e.Description, e.Expirydate });

                entity.ToTable("expirationreminder");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(20)
                    .HasColumnName("empcode");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Expirydate)
                    .HasColumnType("datetime")
                    .HasColumnName("expirydate");

                entity.Property(e => e.AlertDayinterval).HasColumnName("alert_dayinterval");

                entity.Property(e => e.AlerttimeTosend)
                    .HasMaxLength(50)
                    .HasColumnName("alerttime_tosend");

                entity.Property(e => e.AmPm)
                    .HasMaxLength(10)
                    .HasColumnName("AM_PM")
                    .IsFixedLength(true);

                entity.Property(e => e.Cancel).HasColumnName("cancel");

                entity.Property(e => e.CategoryKey).HasColumnName("category_key");

                entity.Property(e => e.Dateentry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateentry")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Documentname)
                    .HasMaxLength(250)
                    .HasColumnName("documentname");

                entity.Property(e => e.Dw)
                    .HasMaxLength(15)
                    .HasColumnName("dw");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Emailcc)
                    .HasMaxLength(150)
                    .HasColumnName("emailcc");

                entity.Property(e => e.Enddate)
                    .HasColumnType("datetime")
                    .HasColumnName("enddate");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mobile2)
                    .HasMaxLength(50)
                    .HasColumnName("mobile2");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.Occurence)
                    .HasMaxLength(10)
                    .HasColumnName("occurence")
                    .IsFixedLength(true);

                entity.Property(e => e.Pattern1)
                    .HasMaxLength(10)
                    .HasColumnName("pattern1");

                entity.Property(e => e.Pattern2)
                    .HasMaxLength(10)
                    .HasColumnName("pattern2");

                entity.Property(e => e.Pattern3)
                    .HasMaxLength(10)
                    .HasColumnName("pattern3");

                entity.Property(e => e.Sms)
                    .HasMaxLength(50)
                    .HasColumnName("sms");

                entity.Property(e => e.Xday).HasColumnName("xday");

                entity.Property(e => e.Xmonth).HasColumnName("xmonth");

                entity.Property(e => e.Xweek).HasColumnName("xweek");

                entity.Property(e => e.Xyear).HasColumnName("xyear");
            });

            modelBuilder.Entity<ExpirationreminderCategory>(entity =>
            {
                entity.HasKey(e => e.Category);

                entity.ToTable("expirationreminder_category");

                entity.Property(e => e.Category)
                    .HasMaxLength(150)
                    .HasColumnName("category");

                entity.Property(e => e.CatKey)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cat_key");
            });

            modelBuilder.Entity<ExpirationreminderDayinterval>(entity =>
            {
                entity.HasKey(e => e.Dayinterval);

                entity.ToTable("expirationreminder_dayinterval");

                entity.Property(e => e.Dayinterval)
                    .HasMaxLength(250)
                    .HasColumnName("dayinterval");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ExpirationreminderEventlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("expirationreminder_eventlogs");

                entity.Property(e => e.Dateentry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateentry")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(50)
                    .HasColumnName("empcode");

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RecordKey).HasColumnName("record_key");
            });

            modelBuilder.Entity<ExpirationreminderSmsSetup>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("expirationreminder_sms_setup");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Sms).HasColumnName("sms");
            });

            modelBuilder.Entity<ExpirationreminderSmsSetupView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("expirationreminder_sms_setup_view");

                entity.Property(e => e.Sms).HasColumnName("sms");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ExpirationreminderSmsSetupView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("expirationreminder_sms_setup_view2");

                entity.Property(e => e.Sms).HasColumnName("sms");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<ExtensionDirectory>(entity =>
            {
                entity.HasKey(e => e.ExtNo);

                entity.ToTable("Extension_Directory");

                entity.Property(e => e.ExtNo)
                    .HasMaxLength(10)
                    .HasColumnName("Ext_No")
                    .IsFixedLength(true);

                entity.Property(e => e.Company)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'ARTAR')");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DepartmentEn)
                    .HasMaxLength(50)
                    .HasColumnName("Department_En");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DescriptionEn)
                    .HasMaxLength(50)
                    .HasColumnName("Description_En");

                entity.Property(e => e.Floor)
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.Hide).HasDefaultValueSql("((0))");

                entity.Property(e => e.MenaId)
                    .HasMaxLength(10)
                    .HasColumnName("MenaID")
                    .IsFixedLength(true);

                entity.Property(e => e.Port)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<GatePassAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GatePassAll");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.Gpn).HasColumnName("GPN");

                entity.Property(e => e.Gpndate)
                    .HasColumnType("datetime")
                    .HasColumnName("GPNDate");

                entity.Property(e => e.Gpnseries)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("GPNSeries");

                entity.Property(e => e.ItemDesc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ItemQty).HasMaxLength(6);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.ResEmployee).HasMaxLength(100);
            });

            modelBuilder.Entity<GatePassMaster>(entity =>
            {
                entity.HasKey(e => e.Gpnseries);

                entity.ToTable("GatePass_Master");

                entity.Property(e => e.Gpnseries)
                    .HasMaxLength(20)
                    .HasColumnName("GPNSeries");

                entity.Property(e => e.EmpName).HasMaxLength(100);

                entity.Property(e => e.Empcode).HasMaxLength(20);

                entity.Property(e => e.Gpn)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("GPN");

                entity.Property(e => e.Gpndate)
                    .HasColumnType("datetime")
                    .HasColumnName("GPNDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ResEmployee).HasMaxLength(100);
            });

            modelBuilder.Entity<GatePassTransaction>(entity =>
            {
                entity.HasKey(e => new { e.ItemDesc, e.Gpnseries })
                    .HasName("PK_GatePass_Transactions_1");

                entity.ToTable("GatePass_Transactions");

                entity.Property(e => e.ItemDesc).HasMaxLength(250);

                entity.Property(e => e.Gpnseries)
                    .HasMaxLength(20)
                    .HasColumnName("GPNSeries");

                entity.Property(e => e.Gpn).HasColumnName("GPN");

                entity.Property(e => e.ItemQty).HasMaxLength(6);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.Tid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TID");
            });

            modelBuilder.Entity<GetAllTicket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("getAllTickets");

                entity.Property(e => e.Admin).HasMaxLength(50);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DateForwardA)
                    .HasMaxLength(50)
                    .HasColumnName("DateForward_A");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.DepartmentNameArab)
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Arab");

                entity.Property(e => e.DepartmentNameEng)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Eng");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNameArab)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Arab");

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.HostName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.NotesA).HasColumnName("Notes_A");

                entity.Property(e => e.NotesS).HasColumnName("Notes_S");

                entity.Property(e => e.ProblemDesc).IsRequired();

                entity.Property(e => e.ProblemType).HasMaxLength(100);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Support).HasMaxLength(50);

                entity.Property(e => e.Xstatus).HasColumnName("xstatus");

                entity.Property(e => e.XstatusDesc)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("xstatus_desc");
            });

            modelBuilder.Entity<HaratEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HaratEmployee");

                entity.Property(e => e.Arabicname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ARABICNAME");

                entity.Property(e => e.Dep)
                    .IsRequired()
                    .HasColumnName("DEP");

                entity.Property(e => e.Englishname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ENGLISHNAME");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POSITION");

                entity.Property(e => e.Site)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SITE");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasKey(e => new { e.HolidayEndDate, e.HolidayStartDate });

                entity.ToTable("HOLIDAYS");

                entity.Property(e => e.HolidayEndDate)
                    .HasColumnType("date")
                    .HasColumnName("Holiday_End_Date");

                entity.Property(e => e.HolidayStartDate)
                    .HasColumnType("date")
                    .HasColumnName("Holiday_Start_Date");

                entity.Property(e => e.HolidayDescription)
                    .HasMaxLength(50)
                    .HasColumnName("Holiday_Description");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<InvAccounting>(entity =>
            {
                entity.HasKey(e => e.AccId);

                entity.ToTable("Inv_Accounting");

                entity.Property(e => e.AccId).HasColumnName("AccID");

                entity.Property(e => e.AccDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<InvMainTable>(entity =>
            {
                entity.ToTable("Inv_MainTable");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingId).HasColumnName("AccountingID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CheckedId).HasColumnName("CheckedID");

                entity.Property(e => e.DeleviryDate).HasColumnType("datetime");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceInfo).HasMaxLength(100);

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<InvMainTable2>(entity =>
            {
                entity.HasKey(e => e.IndexId)
                    .HasName("PK_MainTable");

                entity.ToTable("Inv_MainTable2");

                entity.Property(e => e.IndexId)
                    .ValueGeneratedNever()
                    .HasColumnName("IndexID");

                entity.Property(e => e.AccountingId).HasColumnName("AccountingID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceInfo).HasMaxLength(100);

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<InvRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK_Inv_Request1");

                entity.ToTable("Inv_Request");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.RequestDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<InvStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Inv_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusDesc).HasMaxLength(50);
            });

            modelBuilder.Entity<InvSupplier>(entity =>
            {
                entity.HasKey(e => e.SuppId);

                entity.ToTable("Inv_Suppliers");

                entity.Property(e => e.SuppId).HasColumnName("SuppID");

                entity.Property(e => e.SuppDatabase).HasMaxLength(100);

                entity.Property(e => e.SuppDesc).HasMaxLength(50);

                entity.Property(e => e.SuppName).HasMaxLength(100);

                entity.Property(e => e.SuppNotes).HasMaxLength(100);

                entity.Property(e => e.SuppNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<InvSuppliers1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inv_Suppliers1");

                entity.Property(e => e.SuppDatabase).HasMaxLength(100);

                entity.Property(e => e.SuppDesc).HasMaxLength(50);

                entity.Property(e => e.SuppId).HasColumnName("SuppID");

                entity.Property(e => e.SuppName).HasMaxLength(100);

                entity.Property(e => e.SuppNotes).HasMaxLength(100);

                entity.Property(e => e.SuppNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoices");

                entity.Property(e => e.AccDesc).HasMaxLength(50);

                entity.Property(e => e.AccountingId).HasColumnName("AccountingID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CheckedId).HasColumnName("CheckedID");

                entity.Property(e => e.DeleviryDate).HasColumnType("datetime");

                entity.Property(e => e.ExportDate).HasColumnType("datetime");

                entity.Property(e => e.ImportDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.RequestDesc).HasMaxLength(50);

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.StatusDesc).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.SuppDesc).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<ItCode>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("IT_Code");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<ItDelivery>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.Id });

                entity.ToTable("IT_Delivery");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("EmpID")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.ItemDescription).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ItDeliveryDummy>(entity =>
            {
                entity.ToTable("IT_Delivery_dummy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("EmpID")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ItDeliveryList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IT_DeliveryList");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("EmpID")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDNo");

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ItTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IT_Task");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DateForwardA)
                    .HasMaxLength(50)
                    .HasColumnName("DateForward_A");

                entity.Property(e => e.ProblemType).HasMaxLength(100);

                entity.Property(e => e.Support).HasMaxLength(50);
            });

            modelBuilder.Entity<ItTaskSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IT_Task_Summary");

                entity.Property(e => e.ProblemType).HasMaxLength(100);

                entity.Property(e => e.Support).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardBlockedsiteTicket>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jobcard_blockedsite_ticket");

                entity.Property(e => e.Dateentry)
                    .HasColumnType("datetime")
                    .HasColumnName("dateentry");

                entity.Property(e => e.Host)
                    .HasMaxLength(30)
                    .HasColumnName("host");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(25)
                    .HasColumnName("ip");

                entity.Property(e => e.ProblemtypeId)
                    .HasMaxLength(150)
                    .HasColumnName("ProblemtypeID");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<JobcardCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jobcard_Company");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Sequence)
                    .HasColumnName("sequence")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<JobcardEmailRx>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jobcard_emailRX");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardEmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jobcard_EmployeeInfo");

                entity.Property(e => e.ControlId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ControlID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Ext)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardFeedbackV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Jobcard_feedback_V");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("comment");

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Details).IsRequired();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Problemtype)
                    .HasMaxLength(100)
                    .HasColumnName("problemtype");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Recordid).HasColumnName("recordid");

                entity.Property(e => e.SDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sDate");

                entity.Property(e => e.Support).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardGroupcountticket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("jobcard_groupcountticket");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Totalticket).HasColumnName("totalticket");
            });

            modelBuilder.Entity<JobcardGroupticket>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("jobcard_groupticket");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");
            });

            modelBuilder.Entity<JobcardOracleCategory>(entity =>
            {
                entity.HasKey(e => e.Categoryname);

                entity.ToTable("Jobcard_OracleCategory");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(250)
                    .HasColumnName("categoryname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<JobcardOracleCategoryUser>(entity =>
            {
                entity.HasKey(e => new { e.Userid, e.Categoryfkid });

                entity.ToTable("Jobcard_OracleCategoryUser");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Categoryfkid).HasColumnName("categoryfkid");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<JobcardOracleCategoryUserV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Jobcard_OracleCategoryUser_V");

                entity.Property(e => e.Categoryfkid).HasColumnName("categoryfkid");

                entity.Property(e => e.Categoryname)
                    .HasMaxLength(250)
                    .HasColumnName("categoryname");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<JobcardOracleSupportMessage>(entity =>
            {
                entity.HasKey(e => new { e.Ticketfkid, e.Datecreation });

                entity.ToTable("Jobcard_OracleSupportMessage");

                entity.Property(e => e.Ticketfkid).HasColumnName("ticketfkid");

                entity.Property(e => e.Datecreation)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreation")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .HasColumnName("action");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(250)
                    .HasColumnName("attachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Support)
                    .HasMaxLength(30)
                    .HasColumnName("support");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<JobcardOraclesubCategory>(entity =>
            {
                entity.HasKey(e => new { e.Categoryfkid, e.Subcategoryname });

                entity.ToTable("Jobcard_OraclesubCategory");

                entity.Property(e => e.Categoryfkid).HasColumnName("categoryfkid");

                entity.Property(e => e.Subcategoryname)
                    .HasMaxLength(250)
                    .HasColumnName("subcategoryname");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<JobcardProblemrecordn>(entity =>
            {
                entity.HasKey(e => e.ControlId);

                entity.ToTable("Jobcard_problemrecordn");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.AssignBy).HasMaxLength(50);

                entity.Property(e => e.Categoryfkid).HasColumnName("categoryfkid");

                entity.Property(e => e.DateForwardedA)
                    .HasMaxLength(30)
                    .HasColumnName("DateForwarded_A");

                entity.Property(e => e.DateForwardedS)
                    .HasMaxLength(30)
                    .HasColumnName("DateForwarded_S");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.DepartmentNameArab)
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Arab");

                entity.Property(e => e.DepartmentNameEng)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Eng");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNameArab)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Arab");

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.HostName).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.NotesA).HasColumnName("Notes_A");

                entity.Property(e => e.NotesS).HasColumnName("Notes_S");

                entity.Property(e => e.Priority)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Normal')");

                entity.Property(e => e.ProblemDesc).IsRequired();

                entity.Property(e => e.ProblemType).HasMaxLength(100);

                entity.Property(e => e.Problemtypefkid).HasColumnName("problemtypefkid");

                entity.Property(e => e.RateIi).HasColumnName("rateII");

                entity.Property(e => e.RateIii).HasColumnName("rateIII");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.RemarksS)
                    .HasMaxLength(30)
                    .HasColumnName("remarks_S");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Subcategoryfkid).HasColumnName("subcategoryfkid");

                entity.Property(e => e.Support).HasMaxLength(50);

                entity.Property(e => e.SupportIi)
                    .HasMaxLength(30)
                    .HasColumnName("SupportII");

                entity.Property(e => e.SupportIii)
                    .HasMaxLength(30)
                    .HasColumnName("SupportIII");
            });

            modelBuilder.Entity<JobcardProblemrecordnView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Jobcard_problemrecordn_view");

                entity.Property(e => e.AssignBy).HasMaxLength(50);

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("comment");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.DateForwardedA)
                    .HasMaxLength(30)
                    .HasColumnName("DateForwarded_A");

                entity.Property(e => e.DateForwardedS)
                    .HasMaxLength(30)
                    .HasColumnName("DateForwarded_S");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.Daterate)
                    .HasColumnType("datetime")
                    .HasColumnName("daterate");

                entity.Property(e => e.DepartmentNameArab)
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Arab");

                entity.Property(e => e.DepartmentNameEng)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Eng");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNameArab)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Arab");

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.HostName).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.Isadmin).HasColumnName("isadmin");

                entity.Property(e => e.NotesA).HasColumnName("Notes_A");

                entity.Property(e => e.NotesS).HasColumnName("Notes_S");

                entity.Property(e => e.ProblemDesc).IsRequired();

                entity.Property(e => e.ProblemType).HasMaxLength(100);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.RemarksS)
                    .HasMaxLength(30)
                    .HasColumnName("remarks_S");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.Support).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardProblemtype>(entity =>
            {
                entity.HasKey(e => e.ProblemType);

                entity.ToTable("Jobcard_problemtype");

                entity.Property(e => e.ProblemType).HasMaxLength(50);

                entity.Property(e => e.ControlId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ControlID");
            });

            modelBuilder.Entity<JobcardRate>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("Jobcard_rates");

                entity.Property(e => e.Recordid)
                    .ValueGeneratedNever()
                    .HasColumnName("recordid");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.Comment)
                    .HasMaxLength(250)
                    .HasColumnName("comment");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.Yesno).HasColumnName("yesno");
            });

            modelBuilder.Entity<JobcardRecordHistorylog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Jobcard_Record_historylog");

                entity.Property(e => e.Admin).HasMaxLength(50);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.DateForwardA)
                    .HasMaxLength(50)
                    .HasColumnName("DateForward_A");

                entity.Property(e => e.DateSubmitted).HasMaxLength(50);

                entity.Property(e => e.DepartmentNameEng)
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Eng");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.HostName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.NotesA).HasColumnName("Notes_A");

                entity.Property(e => e.NotesS).HasColumnName("Notes_S");

                entity.Property(e => e.PrDataSubmitted)
                    .HasColumnType("datetime")
                    .HasColumnName("pr_DataSubmitted");

                entity.Property(e => e.ProblemType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Remarks).HasMaxLength(20);

                entity.Property(e => e.Support).HasMaxLength(50);

                entity.Property(e => e.Supportfullname).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardRecordTaskassignmentlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Jobcard_record_taskassignmentlogs");

                entity.Property(e => e.Admin).HasMaxLength(50);

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.Property(e => e.DateForwardA)
                    .HasMaxLength(50)
                    .HasColumnName("DateForward_A");

                entity.Property(e => e.DateSubmitted).HasMaxLength(50);

                entity.Property(e => e.DepartmentNameEng)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("DepartmentName_Eng");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(150)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.HostName).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.NotesA).HasColumnName("Notes_A");

                entity.Property(e => e.NotesS).HasColumnName("Notes_S");

                entity.Property(e => e.PrDateSubmitted)
                    .HasColumnType("datetime")
                    .HasColumnName("pr_DateSubmitted");

                entity.Property(e => e.ProblemDesc).IsRequired();

                entity.Property(e => e.ProblemType).HasMaxLength(100);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Support).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardRequeststatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jobcard_requeststatus");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<JobcardTaskAssignmentLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jobcard_TaskAssignment_Logs");

                entity.Property(e => e.Admin).HasMaxLength(50);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DateForwardA)
                    .HasMaxLength(50)
                    .HasColumnName("DateForward_A");

                entity.Property(e => e.DateSubmitted).HasMaxLength(50);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NotesA).HasColumnName("Notes_A");

                entity.Property(e => e.NotesS).HasColumnName("Notes_S");

                entity.Property(e => e.Priority)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Support).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardTicketdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("jobcard_ticketdate");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Late>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LATES");

                entity.Property(e => e.LateIn).HasColumnName("Late_IN");

                entity.Property(e => e.RamadanEndDate)
                    .HasColumnType("date")
                    .HasColumnName("Ramadan_EndDate");

                entity.Property(e => e.RamadanLateIn).HasColumnName("Ramadan_LateIN");

                entity.Property(e => e.RamadanStartDate)
                    .HasColumnType("date")
                    .HasColumnName("Ramadan_StartDate");

                entity.Property(e => e.RamadanStartTimeHour).HasColumnName("Ramadan_StartTimeHour");

                entity.Property(e => e.RamadanStartTimeMinute).HasColumnName("Ramadan_StartTimeMinute");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.LocationName);

                entity.ToTable("Location");

                entity.Property(e => e.LocationName).HasMaxLength(20);
            });

            modelBuilder.Entity<Maintenance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("maintenance");

                entity.Property(e => e.Column1).HasColumnName("column1");

                entity.Property(e => e.Column2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("column2");

                entity.Property(e => e.Column3).HasColumnName("column3");
            });

            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.ToTable("Meeting");

                entity.Property(e => e.Audience).HasMaxLength(1000);

                entity.Property(e => e.MettingNum)
                    .HasMaxLength(50)
                    .HasColumnName("Metting_Num");

                entity.Property(e => e.Tasks)
                    .HasMaxLength(4000)
                    .HasColumnName("tasks");
            });

            modelBuilder.Entity<Misplace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MISPLACE");

                entity.Property(e => e.Column1).HasColumnName("column1");

                entity.Property(e => e.Column2)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("column2");
            });

            modelBuilder.Entity<ModuleAndPrivilege>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PrivilegeId).HasColumnName("PrivilegeID");

                entity.Property(e => e.SubModuleId)
                    .HasColumnName("SubModuleID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ModulesType>(entity =>
            {
                entity.HasKey(e => e.ModuleDescriptionEn)
                    .HasName("pkmodulestypes");

                entity.Property(e => e.ModuleDescriptionEn)
                    .HasMaxLength(100)
                    .HasColumnName("ModuleDescriptionEN");

                entity.Property(e => e.ModuleDescriptionAr)
                    .HasMaxLength(100)
                    .HasColumnName("ModuleDescriptionAR");

                entity.Property(e => e.ModuleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ModuleID");

                entity.Property(e => e.PageDescription)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'None')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mymonth)
                    .HasMaxLength(20)
                    .HasColumnName("mymonth")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NewMobile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NewMobile");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Newmobile1)
                    .HasMaxLength(255)
                    .HasColumnName("newmobile");
            });

            modelBuilder.Entity<NumberSeries>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("code");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastnumberused).HasColumnName("lastnumberused");

                entity.Property(e => e.Module)
                    .HasMaxLength(20)
                    .HasColumnName("module")
                    .IsFixedLength(true);

                entity.Property(e => e.Numberofzeros).HasColumnName("numberofzeros");

                entity.Property(e => e.Startseries).HasColumnName("startseries");
            });

            modelBuilder.Entity<OApprovalEntry>(entity =>
            {
                entity.HasKey(e => new { e.Employeecode, e.BuId, e.Approvercode, e.Remarks })
                    .HasName("PK_O_ApprovalEntries_1");

                entity.ToTable("O_ApprovalEntries");

                entity.Property(e => e.Employeecode)
                    .HasMaxLength(20)
                    .HasColumnName("employeecode");

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.Approvercode)
                    .HasMaxLength(20)
                    .HasColumnName("approvercode");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(20)
                    .HasColumnName("remarks");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastupdate");

                entity.Property(e => e.Lastupdateby)
                    .HasMaxLength(20)
                    .HasColumnName("lastupdateby");

                entity.Property(e => e.Module)
                    .HasMaxLength(10)
                    .HasColumnName("module");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.SeqNo).HasColumnName("seq_no");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OApprovalHistoryV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("O_ApprovalHistory_V");

                entity.Property(e => e.Approvercode)
                    .HasMaxLength(20)
                    .HasColumnName("approvercode");

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Employeecode)
                    .HasMaxLength(20)
                    .HasColumnName("employeecode");

                entity.Property(e => e.Module)
                    .HasMaxLength(20)
                    .HasColumnName("module");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .HasColumnName("notes");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("remarks");

                entity.Property(e => e.SeqNo).HasColumnName("seq_no");
            });

            modelBuilder.Entity<OApprovalList>(entity =>
            {
                entity.HasKey(e => new { e.BuId, e.Module, e.Employeecode, e.SeqNo, e.Position });

                entity.ToTable("O_ApprovalList");

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.Module)
                    .HasMaxLength(20)
                    .HasColumnName("module")
                    .HasComment("module equal to zero means all module");

                entity.Property(e => e.Employeecode)
                    .HasMaxLength(25)
                    .HasColumnName("employeecode");

                entity.Property(e => e.SeqNo).HasColumnName("seq_no");

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .HasColumnName("position");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Inactive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OAttachment>(entity =>
            {
                entity.HasKey(e => e.Attachment);

                entity.ToTable("O_Attachment");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(250)
                    .HasColumnName("attachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Reportid).HasColumnName("reportid");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OBusinessUnit>(entity =>
            {
                entity.HasKey(e => e.BusinessUnit);

                entity.ToTable("O_BusinessUnit");

                entity.Property(e => e.BusinessUnit).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.OrganizationId).HasColumnName("Organization_ID");
            });

            modelBuilder.Entity<OLevel>(entity =>
            {
                entity.HasKey(e => new { e.BuId, e.Module, e.NestedToLevel, e.Title });

                entity.ToTable("O_Levels");

                entity.Property(e => e.BuId).HasColumnName("BU_Id");

                entity.Property(e => e.Module).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.Createdby).HasMaxLength(20);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(350);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");
            });

            modelBuilder.Entity<OManagement>(entity =>
            {
                entity.HasKey(e => new { e.ManagementTitle, e.Code });

                entity.ToTable("O_Managements");

                entity.Property(e => e.ManagementTitle).HasMaxLength(150);

                entity.Property(e => e.Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ManagementDescription).HasMaxLength(250);
            });

            modelBuilder.Entity<OModule>(entity =>
            {
                entity.HasKey(e => new { e.Module, e.BusinessUnit });

                entity.ToTable("O_Modules");

                entity.Property(e => e.Module).HasMaxLength(20);

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastDateModify).HasColumnType("datetime");

                entity.Property(e => e.LastModify).HasMaxLength(50);

                entity.Property(e => e.ManagementCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleDescription)
                    .IsRequired()
                    .HasMaxLength(350);
            });

            modelBuilder.Entity<OParameter>(entity =>
            {
                entity.HasKey(e => new { e.Parameter, e.Reportid });

                entity.ToTable("O_Parameter");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter");

                entity.Property(e => e.Reportid).HasColumnName("reportid");

                entity.Property(e => e.ParameterDescription)
                    .HasMaxLength(150)
                    .HasColumnName("parameter_description");

                entity.Property(e => e.Parameterid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("parameterid");
            });

            modelBuilder.Entity<OParameterTemp>(entity =>
            {
                entity.HasKey(e => new { e.Parameter, e.Requestorcode });

                entity.ToTable("O_ParameterTemp");

                entity.Property(e => e.Parameter)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("parameter");

                entity.Property(e => e.Requestorcode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("requestorcode");

                entity.Property(e => e.Datetimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("datetimestamp")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParameterDescription)
                    .HasMaxLength(150)
                    .HasColumnName("parameter_description");

                entity.Property(e => e.Parameterid).HasColumnName("parameterid");
            });

            modelBuilder.Entity<OProcessStep>(entity =>
            {
                entity.HasKey(e => new { e.ModuleId, e.StepDescription, e.BusinessUnitId })
                    .HasName("PK_O_ProcessSteps_1");

                entity.ToTable("O_ProcessSteps");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.StepDescription).HasMaxLength(300);

                entity.Property(e => e.Createdby).HasMaxLength(30);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(30)
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastDateModify).HasColumnType("datetime");

                entity.Property(e => e.LastModify).HasMaxLength(30);

                entity.Property(e => e.ResponsiblePerson).HasMaxLength(30);
            });

            modelBuilder.Entity<ORemark>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("O_Remarks");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.RemarksId)
                    .HasColumnName("RemarksID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RemarksTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OReport>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("O_Reports");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(450)
                    .HasColumnName("attachment");

                entity.Property(e => e.Daterequest)
                    .HasColumnType("datetime")
                    .HasColumnName("daterequest");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .HasColumnName("description");

                entity.Property(e => e.Notes)
                    .HasMaxLength(350)
                    .HasColumnName("notes");

                entity.Property(e => e.Reportid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reportid");

                entity.Property(e => e.Requestorcode)
                    .HasMaxLength(50)
                    .HasColumnName("requestorcode");
            });

            modelBuilder.Entity<ORequestor>(entity =>
            {
                entity.HasKey(e => new { e.EmpCode, e.BuId })
                    .HasName("PK_O_LocalPermission");

                entity.ToTable("O_Requestor");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .HasColumnName("emp_code");

                entity.Property(e => e.BuId).HasColumnName("bu_id");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OResponsibility>(entity =>
            {
                entity.HasKey(e => new { e.ModuleId, e.Responsibility })
                    .HasName("PK_O_Responsibility");

                entity.ToTable("O_Responsibilities");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.Responsibility).HasMaxLength(250);

                entity.Property(e => e.Createdby).HasMaxLength(30);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastDateModify).HasColumnType("datetime");

                entity.Property(e => e.LastModify).HasMaxLength(50);
            });

            modelBuilder.Entity<OSecurityProfileV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("O_SecurityProfile_V");

                entity.Property(e => e.L1AccessLevel).HasColumnName("L1_AccessLevel");

                entity.Property(e => e.L1Id).HasColumnName("L1_ID");

                entity.Property(e => e.L1Title)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("L1_Title");

                entity.Property(e => e.L2AccessLevel).HasColumnName("L2_AccessLevel");

                entity.Property(e => e.L2Id).HasColumnName("L2_ID");

                entity.Property(e => e.L2Title)
                    .HasMaxLength(250)
                    .HasColumnName("L2_Title");

                entity.Property(e => e.L3AccessLevel).HasColumnName("L3_AccessLevel");

                entity.Property(e => e.L3Id).HasColumnName("L3_ID");

                entity.Property(e => e.L3Title)
                    .HasMaxLength(250)
                    .HasColumnName("L3_Title");

                entity.Property(e => e.L4AccessLevel).HasColumnName("L4_AccessLevel");

                entity.Property(e => e.L4Id).HasColumnName("L4_ID");

                entity.Property(e => e.L4Title)
                    .HasMaxLength(250)
                    .HasColumnName("L4_Title");

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<OTemplate>(entity =>
            {
                entity.HasKey(e => e.Template);

                entity.ToTable("O_Template");

                entity.Property(e => e.Template)
                    .HasMaxLength(150)
                    .HasColumnName("template");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.TemplateDesc)
                    .HasMaxLength(250)
                    .HasColumnName("templateDesc");
            });

            modelBuilder.Entity<OTemplateEntry>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.BuId, e.Module, e.Fid })
                    .HasName("PK_O_Templates");

                entity.ToTable("O_TemplateEntries");

                entity.Property(e => e.BuId)
                    .HasMaxLength(10)
                    .HasColumnName("Bu_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OUserAccess>(entity =>
            {
                entity.HasKey(e => new { e.EmpCode, e.Fid, e.BuId });

                entity.ToTable("O_UserAccess");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(20)
                    .HasColumnName("Emp_Code");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.BuId).HasColumnName("BU_ID");

                entity.Property(e => e.Createdby).HasMaxLength(30);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatorCode).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EmpUsername)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Username");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastDateModify).HasColumnType("datetime");

                entity.Property(e => e.LastModify).HasMaxLength(30);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Position).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<OUserAccessV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("O_UserAccess_V");

                entity.Property(e => e.BuId).HasColumnName("BU_ID");

                entity.Property(e => e.BusinessUnit)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Createdby).HasMaxLength(30);

                entity.Property(e => e.Creationdate).HasColumnType("datetime");

                entity.Property(e => e.CreatorCode).HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EmpCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Emp_Code");

                entity.Property(e => e.EmpUsername)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Username");

                entity.Property(e => e.Fid).HasColumnName("FID");

                entity.Property(e => e.LastDateModify).HasColumnType("datetime");

                entity.Property(e => e.LastModify).HasMaxLength(30);

                entity.Property(e => e.Module)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Position).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<OWorkflow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("O_Workflow");

                entity.Property(e => e.Assignedto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("assignedto");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attachment");

                entity.Property(e => e.Dateforwarded)
                    .HasColumnType("datetime")
                    .HasColumnName("dateforwarded");

                entity.Property(e => e.Datereceived)
                    .HasColumnType("datetime")
                    .HasColumnName("datereceived");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .HasColumnName("notes");

                entity.Property(e => e.Reportid).HasColumnName("reportid");
            });

            modelBuilder.Entity<OracleSqlIntegrationLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Oracle_Sql_Integration_Logs");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Inserted).HasColumnName("inserted");

                entity.Property(e => e.Iteration).HasColumnName("iteration");

                entity.Property(e => e.TimelapsedSec)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("timelapsed_sec");

                entity.Property(e => e.Timestamped)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamped")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updated).HasColumnName("updated");
            });

            modelBuilder.Entity<OracleUser>(entity =>
            {
                entity.HasKey(e => e.Company)
                    .HasName("PK_Oracle_User");

                entity.ToTable("Oracle_Users");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Usercount).HasColumnName("usercount");
            });

            modelBuilder.Entity<OracleUsersList>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("Oracle_Users_List");

                entity.Property(e => e.EmpId).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<PoBank>(entity =>
            {
                entity.HasKey(e => e.BankCode)
                    .HasName("PK_PO_Bank_1");

                entity.ToTable("PO_Bank");

                entity.Property(e => e.BankCode).HasMaxLength(10);

                entity.Property(e => e.BankName).HasMaxLength(150);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<PoDummy>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Poid });

                entity.ToTable("PO_Dummy");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Poid)
                    .HasMaxLength(50)
                    .HasColumnName("poid");

                entity.Property(e => e.Authorizedby)
                    .HasMaxLength(50)
                    .HasColumnName("authorizedby");

                entity.Property(e => e.Boq)
                    .HasMaxLength(50)
                    .HasColumnName("BOQ");

                entity.Property(e => e.Comment)
                    .HasMaxLength(300)
                    .HasColumnName("comment");

                entity.Property(e => e.Datetimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("datetimestamp")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("discount");

                entity.Property(e => e.ItemDesc).HasMaxLength(300);

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Paymentterms)
                    .HasMaxLength(150)
                    .HasColumnName("paymentterms");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(50)
                    .HasColumnName("projectnameid");

                entity.Property(e => e.Purchasedate)
                    .HasColumnType("date")
                    .HasColumnName("purchasedate");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Requestno)
                    .HasMaxLength(50)
                    .HasColumnName("requestno");

                entity.Property(e => e.Respeng)
                    .HasMaxLength(50)
                    .HasColumnName("respeng");

                entity.Property(e => e.Shippingterms)
                    .HasMaxLength(150)
                    .HasColumnName("shippingterms");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Totalvatamount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("totalvatamount");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vatamount");
            });

            modelBuilder.Entity<PoListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PO_ListView");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .HasColumnName("accountno");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Authorizedby)
                    .HasMaxLength(50)
                    .HasColumnName("authorizedby");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasColumnName("company");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Officialname)
                    .HasMaxLength(300)
                    .HasColumnName("officialname");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Personname)
                    .HasMaxLength(50)
                    .HasColumnName("personname");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PObox");

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POID");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(250)
                    .HasColumnName("projectnameid");

                entity.Property(e => e.Purchasedate)
                    .HasColumnType("date")
                    .HasColumnName("purchasedate");

                entity.Property(e => e.Requestno)
                    .HasMaxLength(50)
                    .HasColumnName("requestno");

                entity.Property(e => e.Respeng)
                    .HasMaxLength(50)
                    .HasColumnName("respeng");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(300)
                    .HasColumnName("suppliername");

                entity.Property(e => e.Swift)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFT");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vatamount");
            });

            modelBuilder.Entity<PoMaster>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Poid });

                entity.ToTable("PO_Master");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Poid)
                    .HasMaxLength(50)
                    .HasColumnName("POID");

                entity.Property(e => e.Authorizedby)
                    .HasMaxLength(50)
                    .HasColumnName("authorizedby");

                entity.Property(e => e.Boq)
                    .HasMaxLength(50)
                    .HasColumnName("BOQ");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasColumnName("company");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(300)
                    .HasColumnName("itemdesc");

                entity.Property(e => e.Lastdatemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("lastdatemodified");

                entity.Property(e => e.Lastmodify)
                    .HasMaxLength(50)
                    .HasColumnName("lastmodify");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Paymentterms).HasColumnName("paymentterms");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(250)
                    .HasColumnName("projectnameid");

                entity.Property(e => e.Purchasedate)
                    .HasColumnType("date")
                    .HasColumnName("purchasedate");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Requestno)
                    .HasMaxLength(50)
                    .HasColumnName("requestno");

                entity.Property(e => e.Respeng)
                    .HasMaxLength(50)
                    .HasColumnName("respeng");

                entity.Property(e => e.Shippingterms).HasColumnName("shippingterms");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Totalvatamount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("totalvatamount");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vatamount");

                entity.Property(e => e.X)
                    .HasMaxLength(300)
                    .HasColumnName("x");
            });

            modelBuilder.Entity<PoMasterV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PO_Master_V");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .HasColumnName("accountno");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Bankcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasColumnName("company");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Officialname)
                    .HasMaxLength(300)
                    .HasColumnName("officialname");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Personname)
                    .HasMaxLength(50)
                    .HasColumnName("personname");

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POID");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(250)
                    .HasColumnName("projectnameid");

                entity.Property(e => e.Purchasedate)
                    .HasColumnType("date")
                    .HasColumnName("purchasedate");

                entity.Property(e => e.Requestno)
                    .HasMaxLength(50)
                    .HasColumnName("requestno");

                entity.Property(e => e.Respeng)
                    .HasMaxLength(50)
                    .HasColumnName("respeng");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(300)
                    .HasColumnName("suppliername");

                entity.Property(e => e.Swift)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFT");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vatamount");
            });

            modelBuilder.Entity<PoPrePayment>(entity =>
            {
                entity.HasKey(e => e.Serialnumber)
                    .HasName("PK_PO_PrePayment_1");

                entity.ToTable("PO_PrePayment");

                entity.Property(e => e.Serialnumber)
                    .HasMaxLength(10)
                    .HasColumnName("serialnumber");

                entity.Property(e => e.Approvedrequest)
                    .HasMaxLength(250)
                    .HasColumnName("approvedrequest");

                entity.Property(e => e.Authorizedby)
                    .HasMaxLength(50)
                    .HasColumnName("authorizedby");

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Collectingchequeplace)
                    .HasMaxLength(150)
                    .HasColumnName("collectingchequeplace");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lang)
                    .HasMaxLength(5)
                    .HasColumnName("lang")
                    .IsFixedLength(true);

                entity.Property(e => e.Lastmodified)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastmodified");

                entity.Property(e => e.Lastmodifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastmodifieddate");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Paymentmethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentmethod")
                    .HasComment("Transfer /  Cheque");

                entity.Property(e => e.Paymentto)
                    .HasMaxLength(250)
                    .HasColumnName("paymentto");

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("poid");

                entity.Property(e => e.Prepaymentamount).HasColumnName("prepaymentamount");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("reason");

                entity.Property(e => e.Remainingamount).HasColumnName("remainingamount");

                entity.Property(e => e.Totalamount).HasColumnName("totalamount");
            });

            modelBuilder.Entity<PoPrepaymentV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PO_Prepayment_V");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .HasColumnName("accountno");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Approvedrequest)
                    .HasMaxLength(250)
                    .HasColumnName("approvedrequest");

                entity.Property(e => e.Authorizedby)
                    .HasMaxLength(50)
                    .HasColumnName("authorizedby");

                entity.Property(e => e.BankName).HasMaxLength(150);

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Collectingchequeplace)
                    .HasMaxLength(150)
                    .HasColumnName("collectingchequeplace");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasColumnName("company");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Lang)
                    .HasMaxLength(5)
                    .HasColumnName("lang")
                    .IsFixedLength(true);

                entity.Property(e => e.Lastmodified)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastmodified");

                entity.Property(e => e.Lastmodifieddate)
                    .HasColumnType("datetime")
                    .HasColumnName("lastmodifieddate");

                entity.Property(e => e.Officialname)
                    .HasMaxLength(300)
                    .HasColumnName("officialname");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Paymentmethod)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("paymentmethod");

                entity.Property(e => e.Paymentto)
                    .HasMaxLength(250)
                    .HasColumnName("paymentto");

                entity.Property(e => e.Personname)
                    .HasMaxLength(50)
                    .HasColumnName("personname");

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("poid");

                entity.Property(e => e.Prepaymentamount).HasColumnName("prepaymentamount");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(250)
                    .HasColumnName("projectnameid");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("reason");

                entity.Property(e => e.Remainingamount).HasColumnName("remainingamount");

                entity.Property(e => e.RemainingamountAftersave).HasColumnName("remainingamount_aftersave");

                entity.Property(e => e.Serialnumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("serialnumber");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(300)
                    .HasColumnName("suppliername");

                entity.Property(e => e.Swift)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFT");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vatamount");
            });

            modelBuilder.Entity<PoSector>(entity =>
            {
                entity.HasKey(e => e.SectorCode);

                entity.ToTable("PO_Sector");

                entity.Property(e => e.SectorCode).HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SectorName).HasMaxLength(150);
            });

            modelBuilder.Entity<PoSupplier>(entity =>
            {
                entity.HasKey(e => e.Suppliername);

                entity.ToTable("PO_Supplier");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(300)
                    .HasColumnName("suppliername");

                entity.Property(e => e.Accountno)
                    .HasMaxLength(50)
                    .HasColumnName("accountno");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Bankcode)
                    .HasMaxLength(50)
                    .HasColumnName("bankcode");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .HasColumnName("IBAN");

                entity.Property(e => e.Officialname)
                    .HasMaxLength(300)
                    .HasColumnName("officialname");

                entity.Property(e => e.Personname)
                    .HasMaxLength(50)
                    .HasColumnName("personname");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PObox");

                entity.Property(e => e.Supplierid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("supplierid");

                entity.Property(e => e.Swift)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFT");
            });

            modelBuilder.Entity<PoUnitPermission>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Unit });

                entity.ToTable("PO_UnitPermission");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ViewPo).HasColumnName("viewPO");

                entity.Property(e => e.ViewPrepayment).HasColumnName("viewPrepayment");

                entity.Property(e => e.Viewall).HasColumnName("viewall");
            });

            modelBuilder.Entity<PoView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PO_View");

                entity.Property(e => e.Address).HasMaxLength(250);

                entity.Property(e => e.Authorizedby)
                    .HasMaxLength(50)
                    .HasColumnName("authorizedby");

                entity.Property(e => e.Boq)
                    .HasMaxLength(50)
                    .HasColumnName("BOQ");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments");

                entity.Property(e => e.Company)
                    .HasMaxLength(50)
                    .HasColumnName("company");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Itemdesc)
                    .HasMaxLength(300)
                    .HasColumnName("itemdesc");

                entity.Property(e => e.Officialname)
                    .HasMaxLength(300)
                    .HasColumnName("officialname");

                entity.Property(e => e.Orderby)
                    .HasMaxLength(50)
                    .HasColumnName("orderby");

                entity.Property(e => e.Paymentterms).HasColumnName("paymentterms");

                entity.Property(e => e.Personname)
                    .HasMaxLength(50)
                    .HasColumnName("personname");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pobox)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PObox");

                entity.Property(e => e.Poid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("POID");

                entity.Property(e => e.Projectnameid)
                    .HasMaxLength(250)
                    .HasColumnName("projectnameid");

                entity.Property(e => e.Purchasedate)
                    .HasColumnType("date")
                    .HasColumnName("purchasedate");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Requestno)
                    .HasMaxLength(50)
                    .HasColumnName("requestno");

                entity.Property(e => e.Respeng)
                    .HasMaxLength(50)
                    .HasColumnName("respeng");

                entity.Property(e => e.Shippingterms).HasColumnName("shippingterms");

                entity.Property(e => e.Subtotal).HasColumnName("subtotal");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Suppliername)
                    .HasMaxLength(300)
                    .HasColumnName("suppliername");

                entity.Property(e => e.Totalvatamount)
                    .HasColumnType("decimal(18, 6)")
                    .HasColumnName("totalvatamount");

                entity.Property(e => e.Unitprice).HasColumnName("unitprice");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Vatamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vatamount");
            });

            modelBuilder.Entity<PrivilegesType>(entity =>
            {
                entity.HasKey(e => e.PrivilegeDescriptionEn)
                    .HasName("pksprivilegetypes");

                entity.Property(e => e.PrivilegeDescriptionEn)
                    .HasMaxLength(100)
                    .HasColumnName("PrivilegeDescriptionEN");

                entity.Property(e => e.PrivilegeDescriptionAr)
                    .HasMaxLength(100)
                    .HasColumnName("PrivilegeDescriptionAR");

                entity.Property(e => e.PrivilegeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PrivilegeID");
            });

            modelBuilder.Entity<ProjectSetupTable>(entity =>
            {
                entity.ToTable("Project_Setup_Table");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FolderName).HasMaxLength(1000);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SetupDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProjectTable>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("Project_Table");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectName).HasMaxLength(100);
            });

            modelBuilder.Entity<Requisition>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeCode, e.Purchasecategory, e.Purchasedetails, e.Notes, e.ReqNo });

                entity.ToTable("Requisition");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("employee_code");

                entity.Property(e => e.Purchasecategory)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("purchasecategory");

                entity.Property(e => e.Purchasedetails)
                    .HasMaxLength(250)
                    .HasColumnName("purchasedetails");

                entity.Property(e => e.Notes)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("notes");

                entity.Property(e => e.ReqNo).HasColumnName("Req_no");

                entity.Property(e => e.Completed)
                    .HasColumnName("completed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("currency");

                entity.Property(e => e.CurrentDirectmanagercode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("current_directmanagercode");

                entity.Property(e => e.CurrentPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("current_price");

                entity.Property(e => e.DateOfWithdrawal)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_withdrawal");

                entity.Property(e => e.Datecompletion)
                    .HasColumnType("datetime")
                    .HasColumnName("datecompletion");

                entity.Property(e => e.Datecreation)
                    .HasColumnType("date")
                    .HasColumnName("datecreation")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimeCreation)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_creation")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DatetimeLastmodify)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime_lastmodify");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Iswithdrawed).HasColumnName("iswithdrawed");

                entity.Property(e => e.Lastmodifyby)
                    .HasMaxLength(50)
                    .HasColumnName("lastmodifyby");

                entity.Property(e => e.Posteddate)
                    .HasColumnType("datetime")
                    .HasColumnName("posteddate");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.Purchasecategoryid).HasColumnName("purchasecategoryid");

                entity.Property(e => e.Purchasedetailsid).HasColumnName("purchasedetailsid");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<RequisitionApprovalCommittee>(entity =>
            {
                entity.HasKey(e => new { e.Branchcode, e.Title, e.Empcode });

                entity.ToTable("Requisition_ApprovalCommittee");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(50)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title");

                entity.Property(e => e.Empcode)
                    .HasMaxLength(50)
                    .HasColumnName("empcode");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastmodify)
                    .HasColumnType("datetime")
                    .HasColumnName("lastmodify");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RequisitionApprovalOrder>(entity =>
            {
                entity.HasKey(e => new { e.Branchcode, e.FkId });

                entity.ToTable("Requisition_ApprovalOrder");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(50)
                    .HasColumnName("branchcode");

                entity.Property(e => e.FkId).HasColumnName("fk_id");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datemodified)
                    .HasColumnType("datetime")
                    .HasColumnName("datemodified");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastmodifyby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastmodifyby");

                entity.Property(e => e.Onapproval).HasColumnName("onapproval");

                entity.Property(e => e.Onnotify).HasColumnName("onnotify");

                entity.Property(e => e.Onrecommendation).HasColumnName("onrecommendation");

                entity.Property(e => e.Onrejection).HasColumnName("onrejection");

                entity.Property(e => e.Onwithdraw).HasColumnName("onwithdraw");

                entity.Property(e => e.Sortid).HasColumnName("sortid");
            });

            modelBuilder.Entity<RequisitionApprover>(entity =>
            {
                entity.HasKey(e => new { e.ManagerCode, e.RequisitionNo, e.EmployeeCode })
                    .HasName("PK_RequisitionManagerException");

                entity.Property(e => e.ManagerCode).HasMaxLength(10);

                entity.Property(e => e.RequisitionNo).HasMaxLength(10);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.Actionby)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovalAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateofAction).HasColumnType("datetime");

                entity.Property(e => e.Entryby).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Lastmodificationdate).HasColumnType("datetime");

                entity.Property(e => e.Lastmodifiedby).HasMaxLength(15);
            });

            modelBuilder.Entity<RequisitionAuditLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Requisition_Audit_Log");

                entity.Property(e => e.Datetimestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Details).HasMaxLength(300);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.TableOrigin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<RequisitionDataEntryPersonnel>(entity =>
            {
                entity.HasKey(e => e.Company);

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("company");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(50)
                    .HasColumnName("bcc");

                entity.Property(e => e.Cc)
                    .HasMaxLength(50)
                    .HasColumnName("cc");

                entity.Property(e => e.Emailto)
                    .HasMaxLength(50)
                    .HasColumnName("emailto");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Primaryname)
                    .HasMaxLength(50)
                    .HasColumnName("primaryname");
            });

            modelBuilder.Entity<RequisitionItemCategory>(entity =>
            {
                entity.HasKey(e => e.ItemCategoryDesc)
                    .HasName("PK_Requisition_Categories");

                entity.ToTable("Requisition_ItemCategory");

                entity.Property(e => e.ItemCategoryDesc).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<RequisitionItemDetail>(entity =>
            {
                entity.HasKey(e => new { e.Itemdescription, e.FkCategoryid });

                entity.ToTable("Requisition_ItemDetails");

                entity.Property(e => e.Itemdescription)
                    .HasMaxLength(150)
                    .HasColumnName("itemdescription");

                entity.Property(e => e.FkCategoryid).HasColumnName("fk_categoryid");

                entity.Property(e => e.FkCategory)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("fk_category");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(500)
                    .HasColumnName("imagepath");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<RequisitionItpersonel>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Requisition_ITPersonel");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Emailbcc)
                    .HasMaxLength(250)
                    .HasColumnName("emailbcc");

                entity.Property(e => e.Emailcc)
                    .HasMaxLength(250)
                    .HasColumnName("emailcc");

                entity.Property(e => e.Emailto)
                    .HasMaxLength(150)
                    .HasColumnName("emailto");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<RequisitionSerial>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK_Requisition_Serial_1");

                entity.ToTable("Requisition_Serial");

                entity.Property(e => e.Itemid)
                    .ValueGeneratedNever()
                    .HasColumnName("itemid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby")
                    .IsFixedLength(true);

                entity.Property(e => e.Creationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("creationdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Oraclecode)
                    .HasMaxLength(150)
                    .HasColumnName("oraclecode");

                entity.Property(e => e.Oracleserial)
                    .HasMaxLength(150)
                    .HasColumnName("oracleserial");

                entity.Property(e => e.Requisitionno)
                    .HasMaxLength(15)
                    .HasColumnName("requisitionno");
            });

            modelBuilder.Entity<RequisitionWorkflowLog>(entity =>
            {
                entity.HasKey(e => new { e.Status, e.ApprovalEmployeeCode, e.ReqNo })
                    .HasName("PK_Requisition_Workflow_log_1");

                entity.ToTable("Requisition_Workflow_log");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('Pending')");

                entity.Property(e => e.ApprovalEmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_employee_code");

                entity.Property(e => e.ReqNo).HasColumnName("Req_no");

                entity.Property(e => e.ApprovalUsername)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("approval_username");

                entity.Property(e => e.Dateofapproval)
                    .HasColumnType("datetime")
                    .HasColumnName("dateofapproval");

                entity.Property(e => e.Forwardedto)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("forwardedto");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lastmodifyby)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lastmodifyby");

                entity.Property(e => e.Lastmodifydatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("lastmodifydatetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .HasColumnName("remarks");

                entity.Property(e => e.RequisitionFkid).HasColumnName("requisition_fkid");
            });

            modelBuilder.Entity<RequisitionWorkflowSetup>(entity =>
            {
                entity.HasKey(e => new { e.Orderid, e.ApprovalEmployeeid, e.Type });

                entity.ToTable("Requisition_WorkflowSetup");

                entity.Property(e => e.Orderid).HasColumnName("orderid");

                entity.Property(e => e.ApprovalEmployeeid)
                    .HasMaxLength(50)
                    .HasColumnName("approval_employeeid");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("branchcode");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("createdby");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<RequisitionWorkflowtype>(entity =>
            {
                entity.HasKey(e => e.Approvaltypedesc);

                entity.ToTable("Requisition_Workflowtype");

                entity.Property(e => e.Approvaltypedesc)
                    .HasMaxLength(150)
                    .HasColumnName("approvaltypedesc");

                entity.Property(e => e.Approvaltypeid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("approvaltypeid");
            });

            modelBuilder.Entity<Sim>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("SIM");

                entity.Property(e => e.Idno)
                    .HasMaxLength(20)
                    .HasColumnName("IDNo");

                entity.Property(e => e.AccountingNote).HasMaxLength(250);

                entity.Property(e => e.AssignedTo).HasMaxLength(90);

                entity.Property(e => e.BillAccount)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BySpeed)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.ConnectionType).HasComment("Direct, BPX");

                entity.Property(e => e.CreditLimit).HasColumnType("money");

                entity.Property(e => e.Crno)
                    .HasMaxLength(10)
                    .HasColumnName("CRNo")
                    .IsFixedLength(true);

                entity.Property(e => e.DateActivated).HasColumnType("date");

                entity.Property(e => e.DateDeactivated).HasColumnType("date");

                entity.Property(e => e.DateReceived).HasColumnType("date");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.DistributionDate).HasColumnType("date");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("EmpID")
                    .IsFixedLength(true);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Internet)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Ispaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastDateModified).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.MobileDescription).HasMaxLength(25);

                entity.Property(e => e.MobileSerialNo)
                    .HasMaxLength(25)
                    .IsFixedLength(true);

                entity.Property(e => e.Note1).HasMaxLength(250);

                entity.Property(e => e.Note2).HasMaxLength(250);

                entity.Property(e => e.Package)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.Paidby)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneType)
                    .HasMaxLength(10)
                    .IsFixedLength(true)
                    .HasComment("Mobile, Landline, Data-SIM, FAX");

                entity.Property(e => e.Pin1)
                    .HasMaxLength(10)
                    .HasColumnName("PIN1")
                    .IsFixedLength(true);

                entity.Property(e => e.Pin12)
                    .HasMaxLength(10)
                    .HasColumnName("PIN1_2")
                    .IsFixedLength(true);

                entity.Property(e => e.Pin13)
                    .HasMaxLength(10)
                    .HasColumnName("PIN1_3")
                    .IsFixedLength(true);

                entity.Property(e => e.Pin2)
                    .HasMaxLength(10)
                    .HasColumnName("PIN2")
                    .IsFixedLength(true);

                entity.Property(e => e.Pin22)
                    .HasMaxLength(10)
                    .HasColumnName("PIN2_2")
                    .IsFixedLength(true);

                entity.Property(e => e.Pin23)
                    .HasMaxLength(10)
                    .HasColumnName("PIN2_3")
                    .IsFixedLength(true);

                entity.Property(e => e.Puk1)
                    .HasMaxLength(10)
                    .HasColumnName("PUK1")
                    .IsFixedLength(true);

                entity.Property(e => e.Puk12)
                    .HasMaxLength(10)
                    .HasColumnName("PUK1_2")
                    .IsFixedLength(true);

                entity.Property(e => e.Puk13)
                    .HasMaxLength(10)
                    .HasColumnName("PUK1_3")
                    .IsFixedLength(true);

                entity.Property(e => e.Puk2)
                    .HasMaxLength(10)
                    .HasColumnName("PUK2")
                    .IsFixedLength(true);

                entity.Property(e => e.Puk22)
                    .HasMaxLength(10)
                    .HasColumnName("PUK2_2")
                    .IsFixedLength(true);

                entity.Property(e => e.Puk23)
                    .HasMaxLength(10)
                    .HasColumnName("PUK2_3")
                    .IsFixedLength(true);

                entity.Property(e => e.RefCode)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).HasMaxLength(25);

                entity.Property(e => e.ServiceAccount)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ServiceProvider)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(4)
                    .IsFixedLength(true);

                entity.Property(e => e.Sim2serialno)
                    .HasMaxLength(20)
                    .HasColumnName("SIM2serialno");

                entity.Property(e => e.Sim3serialno)
                    .HasMaxLength(20)
                    .HasColumnName("SIM3serialno");

                entity.Property(e => e.Simserialno)
                    .HasMaxLength(20)
                    .HasColumnName("SIMserialno");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.Sims)
                    .HasForeignKey(d => d.Company)
                    .HasConstraintName("FK_SIM_Company");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Sims)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK_SIM_SIM_department");

                entity.HasOne(d => d.LocationNavigation)
                    .WithMany(p => p.Sims)
                    .HasForeignKey(d => d.Location)
                    .HasConstraintName("FK_SIM_Location");
            });

            modelBuilder.Entity<SimAssetTransferHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIM_Asset_TransferHistory");

                entity.Property(e => e.Category)
                    .HasMaxLength(15)
                    .IsFixedLength(true);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("EmpID")
                    .IsFixedLength(true);

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.Manufacturer).HasMaxLength(20);

                entity.Property(e => e.Model).HasMaxLength(30);

                entity.Property(e => e.SerialNo).HasMaxLength(25);
            });

            modelBuilder.Entity<SimDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentName);

                entity.ToTable("SIM_department");

                entity.Property(e => e.DepartmentName).HasMaxLength(50);

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DepartmentID");
            });

            modelBuilder.Entity<SimIdsetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SIM_IDsetting");

                entity.Property(e => e.Itdelivery).HasColumnName("ITDelivery");
            });

            modelBuilder.Entity<Simdepartment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SIMdepartment");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Simservicetype>(entity =>
            {
                entity.HasKey(e => new { e.Provider, e.ServiceType })
                    .HasName("pk_simservicetype");

                entity.ToTable("SIMservicetype");

                entity.Property(e => e.Provider)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.ServiceType).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<SiteAccessPermissionV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Site_AccessPermission_V");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sitecode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("sitecode");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<SiteAttendanceLog>(entity =>
            {
                entity.HasKey(e => new { e.MachineUserId, e.Datelog, e.SiteCode });

                entity.ToTable("Site_AttendanceLogs");

                entity.Property(e => e.MachineUserId).HasColumnName("MachineUserID");

                entity.Property(e => e.Datelog).HasColumnType("datetime");

                entity.Property(e => e.SiteCode).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Ip)
                    .HasMaxLength(20)
                    .HasColumnName("IP");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Timestamp= when records was created in table");
            });

            modelBuilder.Entity<SiteAttendanceMode>(entity =>
            {
                entity.HasKey(e => e.ModeDesc);

                entity.ToTable("Site_AttendanceMode");

                entity.Property(e => e.ModeDesc).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<SiteBioTime>(entity =>
            {
                entity.HasKey(e => e.SerialNumber);

                entity.ToTable("Site_BioTime");

                entity.Property(e => e.SerialNumber).HasMaxLength(50);

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LocalIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LocalIP");

                entity.Property(e => e.SiteCode).HasMaxLength(10);
            });

            modelBuilder.Entity<SiteDayOff>(entity =>
            {
                entity.HasKey(e => new { e.Sitecode, e.Departmentid, e.Weekday })
                    .HasName("PK_Site_DayOffs");

                entity.ToTable("Site_DayOff");

                entity.Property(e => e.Sitecode)
                    .HasMaxLength(20)
                    .HasColumnName("sitecode");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Weekday)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("weekday");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<SiteDepartment>(entity =>
            {
                entity.HasKey(e => new { e.SiteCode, e.DepartmentName })
                    .HasName("PK_Site_SiteDept");

                entity.ToTable("Site_Departments");

                entity.Property(e => e.SiteCode).HasMaxLength(10);

                entity.Property(e => e.DepartmentName).HasMaxLength(100);

                entity.Property(e => e.Bcc)
                    .HasMaxLength(250)
                    .HasColumnName("BCc");

                entity.Property(e => e.BodyStyle).HasColumnName("Body_Style");

                entity.Property(e => e.DayOff).HasMaxLength(50);

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("DepartmentName_ar");

                entity.Property(e => e.Evenrow)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('#F7F6F3')");

                entity.Property(e => e.FkDepartmentId)
                    .HasColumnName("FK_DepartmentID")
                    .HasComment("this Foreign Key Department ID is base on actatek.dbo.access_department");

                entity.Property(e => e.FullName).HasMaxLength(50);

                entity.Property(e => e.FullNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("FullName_Ar");

                entity.Property(e => e.Gperiod)
                    .HasMaxLength(5)
                    .HasColumnName("GPeriod");

                entity.Property(e => e.HeaderText).HasColumnName("Header_Text");

                entity.Property(e => e.Language)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('English')");

                entity.Property(e => e.Mode)
                    .HasDefaultValueSql("((1))")
                    .HasComment("Attendance type,set 1 'standard' as default");

                entity.Property(e => e.Oddrow)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('#E3EAEB')");

                entity.Property(e => e.PayrollEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('payroll@artar.com.sa')");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.Property(e => e.TdDetails).HasColumnName("TD_Details");

                entity.Property(e => e.TdSummary).HasColumnName("TD_Summary");

                entity.Property(e => e.ThDetails).HasColumnName("TH_Details");

                entity.Property(e => e.ThSummary).HasColumnName("TH_Summary");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Mr.')");

                entity.Property(e => e.TotalingFooter).HasColumnName("Totaling_Footer");
            });

            modelBuilder.Entity<SiteDepartmentGroupDirectmanager>(entity =>
            {
                entity.HasKey(e => e.Directmanagercode);

                entity.ToTable("Site_DepartmentGroup_Directmanager");

                entity.Property(e => e.Directmanagercode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("directmanagercode");

                entity.Property(e => e.EmailBcc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_bcc");

                entity.Property(e => e.EmailCc)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("email_cc");

                entity.Property(e => e.EmailTo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_to");

                entity.Property(e => e.FullnameAr)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("fullname_ar");

                entity.Property(e => e.FullnameEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("fullname_en");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Language)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("language");

                entity.Property(e => e.Payrollemail)
                    .HasMaxLength(50)
                    .HasColumnName("payrollemail");

                entity.Property(e => e.ReplyTo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("reply_to");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<SiteDepartmentsGroup>(entity =>
            {
                entity.HasKey(e => new { e.Sitecode, e.Departmentid, e.DirectmanagerCode });

                entity.ToTable("Site_Departments_Group");

                entity.Property(e => e.Sitecode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sitecode");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.DirectmanagerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("directmanager_code");

                entity.Property(e => e.Bcc)
                    .HasMaxLength(150)
                    .HasColumnName("bcc");

                entity.Property(e => e.Cc)
                    .HasMaxLength(150)
                    .HasColumnName("cc");

                entity.Property(e => e.Creator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("creator");

                entity.Property(e => e.Datecreated)
                    .HasColumnType("datetime")
                    .HasColumnName("datecreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Mode)
                    .HasColumnName("mode")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SiteDutiesSched>(entity =>
            {
                entity.HasKey(e => e.ShiftCode)
                    .HasName("PK_Site_Shiftings");

                entity.ToTable("Site_DutiesSched");

                entity.Property(e => e.ShiftCode).HasMaxLength(10);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("Created_by");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastModify)
                    .HasMaxLength(20)
                    .HasColumnName("Last_Modify");

                entity.Property(e => e.LastModifyDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Modify_datetime");

                entity.Property(e => e.ShiftDesc).HasMaxLength(50);

                entity.Property(e => e.TimeIn).HasMaxLength(10);

                entity.Property(e => e.TimeOut).HasMaxLength(10);

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteDuty>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeCode, e.DutyDate })
                    .HasName("PK_Site_ShiftSchedule");

                entity.ToTable("Site_Duties");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(10)
                    .HasComment("EmployeeCode from Mena ME");

                entity.Property(e => e.DutyDate)
                    .HasColumnType("date")
                    .HasColumnName("Duty_date");

                entity.Property(e => e.Createdby).HasMaxLength(25);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DutyShift)
                    .HasMaxLength(2)
                    .HasColumnName("Duty_Shift");

                entity.Property(e => e.DutyShiftDesc)
                    .HasMaxLength(50)
                    .HasColumnName("Duty_ShiftDesc");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastDateModify)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_DateModify");

                entity.Property(e => e.LastModify)
                    .HasMaxLength(20)
                    .HasColumnName("Last_Modify");

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TimeIn)
                    .HasMaxLength(10)
                    .HasColumnName("TimeIN");

                entity.Property(e => e.TimeOut)
                    .HasMaxLength(10)
                    .HasColumnName("TimeOUT");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteEmailScheduling>(entity =>
            {
                entity.HasKey(e => new { e.SitecodeGroup, e.Recurrence });

                entity.ToTable("Site_EmailScheduling");

                entity.Property(e => e.SitecodeGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sitecode_group");

                entity.Property(e => e.Recurrence)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("recurrence");

                entity.Property(e => e.Creator)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("creator");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.ExecuteExemption)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("execute_exemption");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Isgrouped)
                    .HasColumnName("isgrouped")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lastmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("lastmodified");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("modifyby");

                entity.Property(e => e.Nthday)
                    .HasColumnName("nthday")
                    .HasComment("execute monthly on the nth day of the month");

                entity.Property(e => e.Timeofexecution)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("timeofexecution");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteEmailSchedulingV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Site_EmailScheduling_V");

                entity.Property(e => e.Creator)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("creator");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.ExecuteExemption)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("execute_exemption");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isgrouped).HasColumnName("isgrouped");

                entity.Property(e => e.Lastmodified)
                    .HasColumnType("datetime")
                    .HasColumnName("lastmodified");

                entity.Property(e => e.Modifyby)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("modifyby");

                entity.Property(e => e.NextExecution).HasMaxLength(116);

                entity.Property(e => e.Nthday).HasColumnName("nthday");

                entity.Property(e => e.Recurrence)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("recurrence");

                entity.Property(e => e.SitecodeGroup)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sitecode_group");

                entity.Property(e => e.SitecodeGroupName)
                    .HasMaxLength(50)
                    .HasColumnName("sitecode_group_name");

                entity.Property(e => e.Timeofexecution)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("timeofexecution");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp");
            });

            modelBuilder.Entity<SiteEmployeeInfo>(entity =>
            {
                entity.HasKey(e => new { e.SiteCode, e.MachineUserId, e.Status });

                entity.ToTable("Site_EmployeeInfo");

                entity.Property(e => e.SiteCode).HasMaxLength(10);

                entity.Property(e => e.MachineUserId).HasColumnName("MachineUserID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("Created_by");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DirectManagerCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Direct_Manager_Code");

                entity.Property(e => e.EmployeeCodeMena)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("EmployeeCode_mena");

                entity.Property(e => e.EmployeeNameArab)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeName_Arab");

                entity.Property(e => e.EmployeeNameEng)
                    .HasMaxLength(50)
                    .HasColumnName("EmployeeName_Eng");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModify)
                    .HasMaxLength(20)
                    .HasColumnName("Last_Modify");

                entity.Property(e => e.LastModifyDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_Modify_datetime");

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())")
                    .HasComment("Timestamp= when records was created in table");
            });

            modelBuilder.Entity<SiteHoliday>(entity =>
            {
                entity.HasKey(e => new { e.Startdate, e.Enddate, e.SiteCode });

                entity.ToTable("Site_Holidays");

                entity.Property(e => e.Startdate)
                    .HasColumnType("date")
                    .HasColumnName("startdate");

                entity.Property(e => e.Enddate)
                    .HasColumnType("date")
                    .HasColumnName("enddate");

                entity.Property(e => e.SiteCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<SiteNotificationErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Site_NotificationErrorLog");

                entity.Property(e => e.Errorline).HasColumnName("ERRORLINE");

                entity.Property(e => e.Errormessage)
                    .HasMaxLength(1)
                    .HasColumnName("ERRORMESSAGE");

                entity.Property(e => e.Errornumber).HasColumnName("ERRORNUMBER");

                entity.Property(e => e.Errorprocedure)
                    .HasMaxLength(1)
                    .HasColumnName("ERRORPROCEDURE");

                entity.Property(e => e.Errorseverity).HasColumnName("ERRORSEVERITY");

                entity.Property(e => e.Errorstate).HasColumnName("ERRORSTATE");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Rowindex).HasColumnName("ROWINDEX");

                entity.Property(e => e.Scriptstatement).HasColumnName("SCRIPTSTATEMENT");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("TIMESTAMP")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteRamadan>(entity =>
            {
                entity.HasKey(e => new { e.Religion, e.Datefrom, e.Dateto, e.Sitecode });

                entity.ToTable("Site_Ramadan");

                entity.Property(e => e.Religion)
                    .HasColumnName("religion")
                    .HasComment("1 = Non Muslim  0=Muslim");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("date")
                    .HasColumnName("datefrom");

                entity.Property(e => e.Dateto)
                    .HasColumnType("date")
                    .HasColumnName("dateto");

                entity.Property(e => e.Sitecode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sitecode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Timein)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("timein")
                    .IsFixedLength(true);

                entity.Property(e => e.Timeout)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("timeout")
                    .IsFixedLength(true);

                entity.Property(e => e.Workinghours)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("workinghours");
            });

            modelBuilder.Entity<SiteRamadanV>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Site_Ramadan_V");

                entity.Property(e => e.Datefrom)
                    .HasColumnType("date")
                    .HasColumnName("datefrom");

                entity.Property(e => e.Dateto)
                    .HasColumnType("date")
                    .HasColumnName("dateto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Religion).HasColumnName("religion");

                entity.Property(e => e.Religiondesc)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("religiondesc");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sitecode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sitecode");

                entity.Property(e => e.Timein)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("timein")
                    .IsFixedLength(true);

                entity.Property(e => e.Timeout)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("timeout")
                    .IsFixedLength(true);

                entity.Property(e => e.Workinghours)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("workinghours");
            });

            modelBuilder.Entity<SiteSitePermission>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Sitecode, e.Departmentid })
                    .HasName("PK_Site_SiteAccess");

                entity.ToTable("Site_SitePermission");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Sitecode)
                    .HasMaxLength(10)
                    .HasColumnName("sitecode");

                entity.Property(e => e.Departmentid).HasColumnName("departmentid");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(20)
                    .HasColumnName("createdby");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SiteTbl>(entity =>
            {
                entity.HasKey(e => e.SiteCode);

                entity.ToTable("Site_tbl");

                entity.Property(e => e.SiteCode).HasMaxLength(10);

                entity.Property(e => e.Etime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LoginMode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("F(Flex)    /  G(GracePeriod)");

                entity.Property(e => e.PayrollEmail)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'payroll@artar.com.sa')");

                entity.Property(e => e.RequiredWorkedHrs)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasComment("flex || graceperiod");

                entity.Property(e => e.SiteNameAr)
                    .HasMaxLength(50)
                    .HasColumnName("SiteName_Ar");

                entity.Property(e => e.Stime)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubModulesType>(entity =>
            {
                entity.HasKey(e => e.ModuleDescEn);

                entity.Property(e => e.ModuleDescEn)
                    .HasMaxLength(30)
                    .HasColumnName("ModuleDescEN")
                    .IsFixedLength(true);

                entity.Property(e => e.ModuleDescAr)
                    .HasMaxLength(30)
                    .HasColumnName("ModuleDescAR")
                    .IsFixedLength(true);

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SubModuleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SubModuleID");
            });

            modelBuilder.Entity<TempBonyanNewCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempBonyanNewCode");

                entity.Property(e => e.New).HasColumnName("new");

                entity.Property(e => e.Old)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("old");
            });

            modelBuilder.Entity<TestOldCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test_Old_code");

                entity.Property(e => e.NewCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("New_code");

                entity.Property(e => e.OldCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Old_code");
            });

            modelBuilder.Entity<TransCarsTbl>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("Trans_CarsTbl");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.CarCode).HasMaxLength(50);

                entity.Property(e => e.CarDesc).HasMaxLength(100);

                entity.Property(e => e.CarPlateNo).HasMaxLength(50);

                entity.Property(e => e.ChangeOil)
                    .HasMaxLength(50)
                    .HasColumnName("Change_Oil");

                entity.Property(e => e.ChangeTyres)
                    .HasMaxLength(50)
                    .HasColumnName("Change_Tyres");

                entity.Property(e => e.LiDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Li_Date");
            });

            modelBuilder.Entity<TransDriver>(entity =>
            {
                entity.ToTable("Trans_Drivers");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DriverCode)
                    .HasMaxLength(50)
                    .HasColumnName("Driver_Code");

                entity.Property(e => e.DriverNameArabic)
                    .HasMaxLength(100)
                    .HasColumnName("Driver_Name_Arabic");

                entity.Property(e => e.DriverPostionArabic)
                    .HasMaxLength(100)
                    .HasColumnName("Driver_Postion_Arabic");
            });

            modelBuilder.Entity<TransRegionTbl>(entity =>
            {
                entity.HasKey(e => e.PlaceId);

                entity.ToTable("Trans_RegionTbl");

                entity.Property(e => e.PlaceId).HasColumnName("PlaceID");

                entity.Property(e => e.PlaceDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<TransTrack>(entity =>
            {
                entity.ToTable("Trans_Tracks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobDate).HasColumnType("datetime");

                entity.Property(e => e.JobTime).HasMaxLength(50);
            });

            modelBuilder.Entity<TransTransTbl>(entity =>
            {
                entity.HasKey(e => e.JobOrderNum);

                entity.ToTable("Trans_TransTbl");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.DepartureId).HasColumnName("DepartureID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.Edistance)
                    .HasMaxLength(50)
                    .HasColumnName("EDistance");

                entity.Property(e => e.JobDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Job_date");

                entity.Property(e => e.Km)
                    .HasMaxLength(50)
                    .HasColumnName("KM");

                entity.Property(e => e.TimeT).HasMaxLength(50);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<TransView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Trans_View");

                entity.Property(e => e.CarCode).HasMaxLength(50);

                entity.Property(e => e.CarPlateNo).HasMaxLength(50);

                entity.Property(e => e.DriverCode)
                    .HasMaxLength(50)
                    .HasColumnName("Driver_Code");

                entity.Property(e => e.DriverNameArabic)
                    .HasMaxLength(100)
                    .HasColumnName("Driver_Name_Arabic");

                entity.Property(e => e.Edistance)
                    .HasMaxLength(50)
                    .HasColumnName("EDistance");

                entity.Property(e => e.Expr1).HasMaxLength(100);

                entity.Property(e => e.JobDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Job_date");

                entity.Property(e => e.Km)
                    .HasMaxLength(50)
                    .HasColumnName("KM");

                entity.Property(e => e.PlaceDesc).HasMaxLength(100);

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<TransportTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("transport_tracking");

                entity.Property(e => e.CarCode).HasMaxLength(50);

                entity.Property(e => e.CarDesc).HasMaxLength(100);

                entity.Property(e => e.CarPlateNo).HasMaxLength(50);

                entity.Property(e => e.Departure).HasMaxLength(100);

                entity.Property(e => e.Destination).HasMaxLength(100);

                entity.Property(e => e.DriverCode)
                    .HasMaxLength(50)
                    .HasColumnName("Driver_Code");

                entity.Property(e => e.DriverNameArabic)
                    .HasMaxLength(100)
                    .HasColumnName("Driver_Name_Arabic");

                entity.Property(e => e.DriverPostionArabic)
                    .HasMaxLength(100)
                    .HasColumnName("Driver_Postion_Arabic");

                entity.Property(e => e.Edistance)
                    .HasMaxLength(50)
                    .HasColumnName("EDistance");

                entity.Property(e => e.JdTracking)
                    .HasColumnType("datetime")
                    .HasColumnName("JD_Tracking");

                entity.Property(e => e.JtTracking)
                    .HasMaxLength(50)
                    .HasColumnName("JT_Tracking");

                entity.Property(e => e.Km)
                    .HasMaxLength(50)
                    .HasColumnName("KM");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Trans_Date");
            });

            modelBuilder.Entity<Transtrack1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("transtracks");

                entity.Property(e => e.Expr1).HasMaxLength(100);

                entity.Property(e => e.JobDate).HasColumnType("datetime");

                entity.Property(e => e.JobTime).HasMaxLength(50);

                entity.Property(e => e.PlaceDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserName)
                    .HasName("pkusers");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.UserGroup).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.GroupDescEn);

                entity.Property(e => e.GroupDescEn)
                    .HasMaxLength(100)
                    .HasColumnName("GroupDescEN");

                entity.Property(e => e.GroupDescAr)
                    .HasMaxLength(100)
                    .HasColumnName("GroupDescAR");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<UserGroupsPermission>(entity =>
            {
                entity.HasKey(e => new { e.UserGroupId, e.ModuleId, e.SubModuleId, e.PrivilegeId, e.HasPermission });

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModuleID");

                entity.Property(e => e.PrivilegeId).HasColumnName("PrivilegeID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UserPermissions");

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VUserGroupsPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserGroupsPermissions");

                entity.Property(e => e.GroupDescEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("GroupDescEN");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModuleDescEn)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("ModuleDescEN")
                    .IsFixedLength(true);

                entity.Property(e => e.ModuleDescriptionEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("ModuleDescriptionEN");

                entity.Property(e => e.PrivilegeDescriptionEn)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PrivilegeDescriptionEN");
            });

            modelBuilder.Entity<VisaCountryTbl>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("Visa_Country_tbl");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryDesc).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");
            });

            modelBuilder.Entity<VisaDetail>(entity =>
            {
                entity.ToTable("Visa_Details");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.ProfId).HasColumnName("ProfID");

                entity.Property(e => e.VisaId).HasColumnName("VisaID");
            });

            modelBuilder.Entity<VisaEnjaz>(entity =>
            {
                entity.ToTable("Visa_Enjaz");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profession)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VisaNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisaOffice>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.ToTable("Visa_Offices");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.OfficeDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<VisaProfession>(entity =>
            {
                entity.HasKey(e => e.ProfessionId);

                entity.ToTable("Visa_Professions");

                entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");

                entity.Property(e => e.ProfDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<VisaProfessionsCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Visa_professions_country");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryDesc).HasMaxLength(100);

                entity.Property(e => e.ProfDesc).HasMaxLength(100);

                entity.Property(e => e.VisaId).HasColumnName("VisaID");
            });

            modelBuilder.Entity<VisaStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Visa_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusDesc).HasMaxLength(100);
            });

            modelBuilder.Entity<VisaTbl>(entity =>
            {
                entity.HasKey(e => e.VisaId)
                    .HasName("PK_Visa_Tbl1");

                entity.ToTable("Visa_Tbl");

                entity.Property(e => e.VisaId)
                    .ValueGeneratedNever()
                    .HasColumnName("VisaID");

                entity.Property(e => e.Gdate)
                    .HasMaxLength(100)
                    .HasColumnName("GDate");

                entity.Property(e => e.Hdate)
                    .HasMaxLength(100)
                    .HasColumnName("HDate");

                entity.Property(e => e.Vquantity).HasColumnName("VQuantity");
            });

            modelBuilder.Entity<VisaTbl1>(entity =>
            {
                entity.ToTable("Visa_Tbl1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gdate)
                    .HasMaxLength(100)
                    .HasColumnName("GDate");

                entity.Property(e => e.Hdate)
                    .HasMaxLength(100)
                    .HasColumnName("HDate");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.VisaId).HasColumnName("VisaID");

                entity.Property(e => e.Vquantity).HasColumnName("VQuantity");
            });

            modelBuilder.Entity<VisaTblold>(entity =>
            {
                entity.HasKey(e => e.VisaId)
                    .HasName("PK_Visa_Tbl");

                entity.ToTable("Visa_Tblold");

                entity.Property(e => e.VisaId).HasColumnName("VisaID");

                entity.Property(e => e.Gdate)
                    .HasMaxLength(100)
                    .HasColumnName("GDate");

                entity.Property(e => e.Hdate)
                    .HasMaxLength(100)
                    .HasColumnName("HDate");

                entity.Property(e => e.Vquantity).HasColumnName("VQuantity");
            });

            modelBuilder.Entity<VisaWork>(entity =>
            {
                entity.ToTable("Visa_Work");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.ProfId).HasColumnName("ProfID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.VisaId).HasColumnName("VisaID");
            });

            modelBuilder.Entity<VisaWorkStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("visa_work_status");

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryDesc).HasMaxLength(100);

                entity.Property(e => e.OfficeDesc).HasMaxLength(100);

                entity.Property(e => e.ProfDesc).HasMaxLength(100);

                entity.Property(e => e.StatusDesc).HasMaxLength(100);

                entity.Property(e => e.VisaId).HasColumnName("VisaID");
            });

            modelBuilder.Entity<WorkflowDept>(entity =>
            {
                entity.HasKey(e => new { e.DeptName, e.BranchCode });

                entity.ToTable("Workflow_Dept");

                entity.Property(e => e.DeptName).HasMaxLength(35);

                entity.Property(e => e.BranchCode).HasMaxLength(20);

                entity.Property(e => e.DeptEmail).HasMaxLength(30);

                entity.Property(e => e.DeptHead).HasMaxLength(50);

                entity.Property(e => e.DeptHead1).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<WorkflowEeClearance>(entity =>
            {
                entity.HasKey(e => e.Idno);

                entity.ToTable("Workflow_Ee_Clearance");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("Date_End");

                entity.Property(e => e.LastDatePrinted).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PrintedBy).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkflowEeDept>(entity =>
            {
                entity.HasKey(e => new { e.Idno, e.DeptName });

                entity.ToTable("Workflow_Ee_Dept");

                entity.Property(e => e.Idno)
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.DeptName).HasMaxLength(35);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ManagerName).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(350);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdnoNavigation)
                    .WithMany(p => p.WorkflowEeDepts)
                    .HasForeignKey(d => d.Idno)
                    .HasConstraintName("FK_Workflow_Ee_Dept_Workflow_Ee_Clearance");
            });

            modelBuilder.Entity<WorkflowEeDeptList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Workflow_EeDeptList");

                entity.Property(e => e.DeptEmail).HasMaxLength(30);

                entity.Property(e => e.DeptHead).HasMaxLength(50);

                entity.Property(e => e.DeptHead1).HasMaxLength(50);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDNo")
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<XattIp>(entity =>
            {
                entity.HasKey(e => e.IpAddr);

                entity.ToTable("XATT_IP");

                entity.Property(e => e.IpAddr)
                    .HasMaxLength(20)
                    .HasColumnName("IP_Addr");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Enabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Port)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((4370))");
            });

            modelBuilder.Entity<ZkPersonnel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZK_Personnel");

                entity.Property(e => e.CardNumber).HasMaxLength(255);

                entity.Property(e => e.DepartmentName).HasMaxLength(255);

                entity.Property(e => e.DepartmentNumber).HasMaxLength(255);

                entity.Property(e => e.FaceQty).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.PersonnelId)
                    .HasMaxLength(255)
                    .HasColumnName("PersonnelID");

                entity.Property(e => e.PlamVeinQty).HasMaxLength(255);

                entity.Property(e => e.VeinQuantity).HasMaxLength(255);

                entity.Property(e => e._10fpqty)
                    .HasMaxLength(255)
                    .HasColumnName("10FPQty");

                entity.Property(e => e._9fpqty)
                    .HasMaxLength(255)
                    .HasColumnName("9FPQty");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
