using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWave.PestPac.TA.SharedData
{
    public class Reports
    {

        public string InvoiceReportType { get; set; }
        public string DefaultSettings { get; set; }
        public string DetailWithPrices { get; set; }
        public string DetailWithoutPrices { get; set; }
        public string SummaryWithPrices { get; set; }
        public string SummaryWithoutPrices { get; set; }
        public string AreaSpecific { get; set; }
        public string UnitSpecific { get; set; }
        public string UnitInspectionSummary { get; set; }
        public string InvoiceOption { get; set; }
        public bool Print { get; set; }
        public bool Email { get; set; }
        public string InvoiceReportExpectedBillAmount { get; set; }
        public string ReportForm { get; set; }
        public string ReportType { get; set; }
        public string ReportLink { get; set; }
        public string ReportStartDate { get; set; }
        public string ReportsEndDate { get; set; }
        public string OutputFormat { get; set; }
        public string CAMessage { get; set; }
        public string CallAheadDate { get; set; }
        public string CallAheadTime { get; set; }
        public string CallsSent { get; set; }
        public string NoAlert { get; set; }
        public string VantivTransactionRefNumber { get; set; }
        public string Report_Verification { get; set; }
        public string PDFText { get; set; }
        public string NotExpectedData { get; set; }
        public string StartWorkDate { get; set; }
        public string EndWorkDate { get; set; }
        public string ServiceOption { get; set; }
        public string ServiceReportType { get; set; }
        public string ServiceReportExpectedBillAmount { get; set; }
        public string ServiceReportTitle { get; set; }

        public string CreditCardOrACHReport_PaymentNetworkRef { get; set; }
        public string CreditCardOrACHReport_BillAmount { get; set; }
        public string CreditCardOrACHReport_Response { get; set; }
        public string CreditCardOrACHReport_ExpectedResponse { get; set; }

        #region Change Log Report

        public string ChangeLogReport_StartingDate { get; set; }
        public string ChangeLogReport_EndingDate { get; set; }
        public string ChangeLogReport_LatestOldValue { get; set; }
        public string ChangeLogReport_LatestNewValue { get; set; }
        public string ChangeLogReport_FetchedLatestJobScheduleCode { get; set; }
        public string ChangeLogReport_TableCode { get; set; }

        #endregion Change Log Report

        public string EmailNotification { get; set; }
        public string StartingOrderNumber { get; set; }
        public string EndingOrderNumber { get; set; }
        public string SentValue { get; set; }

        public string ARBillToCode { get; set; }
        public string ARLetter { get; set; }

        public string ChooseReport { get; set; }
        public string ARMailingType { get; set; }
        public string EmailFrom { get; set; }

        public string MailingCheckBox { get; set; }
        public string EmailTo { get; set; }
        public string InvoiceNumber { get; set; }

        #region Credit Card/ACH Billing Report

        public string CreditCardOrACHBillingReport_CreditCardTotals { get; set; }

        #endregion Credit Card/ACH Billing Report

        #region Exception Report

        public string ExceptionReport_StartingDate { get; set; }
        public string ExceptionReport_EndingDate { get; set; }
        public string ExceptionReport_ShowProcessedCreditCardsWithNoPayments { get; set; }
        public string ExceptionReport_ShowCreditCardPaymentsWithNoCreditCardTransaction { get; set; }

        #endregion Exception Report

        #region Commission Report	

        public string CommissionReport_Format { get; set; }

        #endregion Commission Report

        #region Statements Report	

        public string StatementsReport_BillToCode { get; set; }
        public string StatementsReport_CustomerDivision { get; set; }

        #endregion Statements Report

        #region Service Orders Report	

        public string NotificationEmails_Letter { get; set; }
        public string NotificationEmails_OverrideEmailFromAddress { get; set; }
        public string NotificationEmails_EmailSubject { get; set; }

        #endregion Service Orders Report

        public string ReportGallery_Category { get; set; }
        public string ReportGallery_Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string AlertMessage { get; set; }
        public string Print_Statement { get; set; }
        public string EmailStatement { get; set; }
        public string StartingBillTo { get; set; }
        public string EndingBillTo { get; set; }
        public string EmailVerification { get; set; }
        public string ExportText { get; set; }

        #region Activity Log Report

        public string ActivityLogReport_ActiviyDescription { get; set; }
        public string ActivityLogReport_LastArchivedActiviyText { get; set; }
        public string ActivityLogReport_StartDate { get; set; }
        public string ActivityLogReport_EndDate { get; set; }
        public string ActivityLogReport_Message { get; set; }
        public string StatementReport_Message { get; set; }
        public string CreditCardUpdater_StartDate { get; set; }
        public string CreditCardUpdater_EndDate { get; set; }
        public string CreditCard { get; set; }
        public string ActivityLogReport_Activiy { get; set; }

        #endregion Activity Log Report

    }
}
