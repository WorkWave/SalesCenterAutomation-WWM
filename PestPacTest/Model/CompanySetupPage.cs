using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;
using NUnit.Framework;
using System.Threading;

using OpenQA.Selenium.Support.UI;


using System.Reflection;


namespace WorkWave.PestPac.TA.Model
{
    class CompanySetupPage : IWebPage
    {
        #region Page Factory

        [FindsBy(How = How.XPath, Using = "//span[text()='Company Setup']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Link_NewAccount")]
        private IWebElement DefaultsForNewAccount_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Div_NewAccount")]
        private IWebElement DefaultsForNewAccount_Section { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BlankBranch")]
        private IWebElement BlankBranch_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butSave")]
        private IWebElement Save_Button { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butShowAll")]
        private IWebElement ShowAll_Button { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butExit")]
        private IWebElement Exit_Button { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Link_CreditCard")]
        private IWebElement CreditCards_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Div_CreditCard")]
        private IWebElement CreditCardOptions_Section { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "PayFlowLive")]
        private IWebElement UseLivePaymentServer_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UseVantivAccountUpdater")]
        private IWebElement UseVantivAccountUpdater_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "MethodOfPayment")]
        private IWebElement MethodOfPayment_Picker { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Link_GeneralLedger")]
        private IWebElement GeneralLedger_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Div_GeneralLedger")]
        private IWebElement GeneralLedger_Section { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UseGL")]
        private IWebElement UseGL_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "GLCode")]
        private IWebElement GLCode_Picker { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "GLSuspenseAccount")]
        private IWebElement GLSuspenseAccount_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "DefaultGLFromMOP")]
        private IWebElement DefaultGLFromMOP_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Div_GeneralLedger > table:nth-child(1) > tbody > tr.UseGL > td:nth-child(2) > table > tbody > tr:nth-child(2)")]
        private IWebElement SalesCode_Customer { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Div_GeneralLedger > table:nth-child(1) > tbody > tr.UseGL > td:nth-child(2) > table > tbody > tr:nth-child(3)")]
        private IWebElement SalesCode_Service { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Link_Posting")]
        private IWebElement Posting_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Div_Posting")]
        private IWebElement Posting_Section { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ShowGL")]
        private IWebElement GLCodes_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "PostBatchInv")]
        private IWebElement Batch_Checkbox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "Link_CreditCard")]
        private IWebElement PaymentMethods_Link { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "Div_CreditCard")]
        private IWebElement PaymentMethods_Section { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "CreditCardProvider")]
        private IWebElement CCprovider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#PromptToAssociateLead")]
        private IWebElement Prompt_Associated { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#UseMultipleTechLicenses")]
        private IWebElement MultipleTechLicense { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Link_OrderSetup")]
        private IWebElement ServiceOrder_Setup_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#FCPmtEntryService")]
        private IWebElement Finance_Charge_field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#LockGL")]
        private IWebElement Lock_GLCodes { get { return PageFactory.Load(this); } }

        #region Defaults for New Account

        [FindsBy(How = How.Name, Using = "BillToPrintStatement")]
        private IWebElement PrintStatementButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "BillToPrintInvoice")]
        private IWebElement PrintInvoiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "BillToEmailStatement")]
        private IWebElement EmailStatementButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "BillToEmailInvoice")]
        private IWebElement EmailInvoiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BillToAutomatedEmailInspectionReport")]
        private IWebElement AutomatedEmailInspectionReportButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BillToAutomatedEmailInvoice")]
        private IWebElement AutomatedEmailInvoiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "SendInspectionReportOn")]
        private IWebElement SendInspectionReportOn_DropDown { get { return PageFactory.Load(this); } }

        #endregion Defaults for New Account

        #region Payment Methods

        [FindsBy(How = How.Id, Using = "CreatePayment")]
        private IWebElement AutomaticallySavePayment_ChkBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "OneTimePaymentsRequireCVV")]
        private IWebElement RequireCVV_ChkBox { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.CssSelector, Using = "#Link_CreditCard")]
        private IWebElement Payment_Method_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#UseACHBilling")]
        private IWebElement ACHCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#butSave")]
        private IWebElement CompanySetup_Save { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UseCCAuthorization")]
        private IWebElement AllowPreAuthorizationOfCC_ChkBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ACHProcessThroughE")]
        private IWebElement SelectedPaymentProcessor_RdoButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ACHProcessThroughN")]
        private IWebElement NACHACompatibleExportFile_RdoButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "CreditCardProvider")]
        private IWebElement Processor_drpdwn { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#PayFlowUsername")]
        private IWebElement Processor_usrName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#PayFlowPassword")]
        private IWebElement Processor_Password { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//a[text()='Edit']")]
        private IWebElement PasswordEditLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//img[@id='PayFlowPasswordValidationIndicator'][@src='/images/greencheck.gif']")]
        private IWebElement GreenPasswordTick { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//img[@id='PayFlowPasswordValidationIndicator'][@src='/images/x_red.gif']")]
        private IWebElement RedPasswordTick { get { return PageFactory.Load(this); } }

        #endregion Payment Methods

        #region Additional Features

        [FindsBy(How = How.Id, Using = "Link_Additional")]
        private IWebElement AdditionalFeatures_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UseActiveDirectory")]
        private IWebElement UseActiveDirectory_Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "DefaultDomain")]
        private IWebElement DefaultDomain_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "NoteCodeValidationL")]
        private IWebElement ValidationAndLookup_RdoBtn { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "NoteCodeValidationN")]
        private IWebElement NoValidation_RdoBtn { get { return PageFactory.Load(this); } }
        #endregion Additional Features

        #region Payment Screen

        [FindsBy(How = How.Id, Using = "Link_PaymentScreen")]
        private IWebElement PaymentScreen_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "CreateFCPmtEntry")]
        private IWebElement CreateFinanceChargeOnPaymentEntry_ChckBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "FCPmtEntryService")]
        private IWebElement ServiceCode_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "HideUnusedServices")]
        private IWebElement HideServicesNotAssignedToBillTo_ChckBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AutoApplyPayment")]
        private IWebElement AutoApplyOnPaymentEntry_ChckBox { get { return PageFactory.Load(this); } }

        #endregion Payment Screen

        #region Service Order/Service Setup

        [FindsBy(How = How.Id, Using = "Link_OrderSetup")]
        private IWebElement ServiceOrderOrServiceSetup_Link { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UseAnnualPrepayDiscount")]
        private IWebElement AnnualPrepayDiscount_ChckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "NotificationDays")]
        private IWebElement NotificationDays_Field { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "NotifyDefaultLocation")]
        private IWebElement NotifyLocation_CheckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "NotifyDefaultBillTo")]
        private IWebElement NotifyBillTo_CheckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "PrintNotify")]
        private IWebElement PrintNotification_CheckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.CssSelector, Using = "#PriceServiceByBranch")]
        private IWebElement PriceServiceByBranch_ChckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.CssSelector, Using = "#CreateFCPmtEntry")]
        private IWebElement CreateFCPmtEntry_ChckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "EmailNotify")]
        private IWebElement EmailNotification_CheckBox { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "CallNotify")]
        private IWebElement CallNotification_CheckBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AnnualPrepayDiscount")]
        private IWebElement Discount_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AnnualPrepayAdjustmentReason")]
        private IWebElement DiscountReason_LookupField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AnnualPrepayDiscountIncludeTax")]
        private IWebElement IncludeTaxInDiscount_CheckBox { get { return PageFactory.Load(this); } }

        #endregion Service Order/Service Setup

        #region Field Setup
        [FindsBy(How = How.CssSelector, Using = "#Link_FieldSetup")]
        private IWebElement FieldSetup { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.CssSelector, Using = "#Tech1Show")]
        private IWebElement Tech1Checkbox { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.CssSelector, Using = "#Tech3Show")]
        private IWebElement Tech3Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Tech4Show")]
        private IWebElement Tech4Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Tech5Show")]
        private IWebElement Tech5Checkbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Tech3Caption")]
        private IWebElement Tech3Caption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Tech4Caption")]
        private IWebElement Tech4Caption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Tech5Caption")]
        private IWebElement Tech5Caption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#TechShare5")]
        private IWebElement TechShare { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Tech5Role")]
        private IWebElement TechRole { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.CssSelector, Using = "#TechPaidOn1")]
        private IWebElement TechPayOn { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.CssSelector, Using = "#butSave")]
        private IWebElement SaveFieldSetup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#UseRequiredFields")]
        private IWebElement Required_Fields { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#UseFourDecimalUnitPrice")]
        private IWebElement DecimalUnitPrice { get { return PageFactory.Load(this); } }

        #endregion Field Setup

        #region Invoices
        public bool multipleTechLicense(string selectOption)
        {
            if (MultipleTechLicense.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!MultipleTechLicense.Selected && selectOption.Equals("True"))
            {
                MultipleTechLicense.Click();
                return true;
            }
            else if (MultipleTechLicense.Selected && selectOption.Equals("False"))
            {
                MultipleTechLicense.Click();
                return true;
            }
            else if (!MultipleTechLicense.Selected && selectOption.Equals("False"))
            {
                return true;
            }
            return false;
        }

        #endregion Invoices

        #region Renewals

        [FindsBy(How = How.Id, Using = "Link_Renewal")]
        private IWebElement RenewalLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Div_Renewal")]
        private IWebElement RenewalSection { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "RenewalPrepayment")]
        private IWebElement PromptForRenewalPrepayment_Chckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "PrepaymentInvoice")]
        private IWebElement CreateInvoice_Chckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "PrepaymentOrder")]
        private IWebElement CreateServiceOrder_Chckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "RequireWorkDate")]
        private IWebElement RequireWorkDate_Chckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "RequireService")]
        private IWebElement RequireService_Chckbox { get { return PageFactory.Load(this); } }

        #endregion Renewals

        #endregion Page Factory


        private string PageHeaderTitle = "Company Setup";


        public virtual bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader)))
            {
                if (PageHeader.Text.Contains(PageHeaderTitle))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #region behaviors
        //public LocationSearchPage Save()
        //{
        //    Save_Button.Click();
        //    return new LocationSearchPage();
        //}
        public CompanySetupPage ShowAll()
        {
            ShowAll_Button.Click();
            return this;
        }
        //public LocationSearchPage Exit()
        //{
        //    Exit_Button.Click();
        //    return new LocationSearchPage();
        //}

        public void Click_DefaultsForNewAccount()
        {
            DefaultsForNewAccount_Link.Click();
            Assert.AreEqual(DefaultsForNewAccount_Section.GetAttribute("class"), "Visible");
        }
        public void Set_BlankBranch(bool blank)
        {
            SeleniumUtility.SetCheckBox(BlankBranch_Checkbox, blank);
        }
        public void Set_MOP(string mop)
        {
            //picker - type
            MethodOfPayment_Picker.Clear();
            MethodOfPayment_Picker.SendKeys(mop);
        }
        public void Click_CreditCards()
        {
            CreditCards_Link.Click();
            Assert.AreEqual(CreditCardOptions_Section.GetAttribute("class"), "Visible");
        }
        public void Set_LivePaymentServer(bool isChecked)
        {
            SeleniumUtility.SetCheckBox(UseLivePaymentServer_Checkbox, isChecked);
        }
        public void Set_VantivAccountUpdater(bool isChecked)
        {
            SeleniumUtility.SetCheckBox(UseVantivAccountUpdater_Checkbox, isChecked);
        }
        public void Click_GeneralLedger()
        {
            GeneralLedger_Link.Click();
            Assert.AreEqual(GeneralLedger_Section.GetAttribute("class"), "Visible");
        }
        public void Set_UseGeneralLedger(bool state)
        {
            SeleniumUtility.SetCheckBox(UseGL_Checkbox, state);
        }
        public void Set_DefaultGLCode(string glCode)
        {
            //picker - type
            GLCode_Picker.Clear();
            GLCode_Picker.SendKeys(glCode);
        }
        public void Set_GLSuspenseAccount(string account)
        {
            GLSuspenseAccount_Field.Clear();
            GLSuspenseAccount_Field.SendKeys(account);
        }
        public void Set_DefaultPaymentGLCodeFromMOP(bool state)
        {
            SeleniumUtility.SetCheckBox(DefaultGLFromMOP_Checkbox, state);
        }
        public void Set_SalesCodeSource(string source)
        {
            if (source.Equals("Customer"))
            {
                SalesCode_Customer.FindElement(By.CssSelector("input[value = 'C']")).Click();
            }
            if (source.Equals("Service"))
            {
                SalesCode_Service.FindElement(By.CssSelector("input[value = 'S']")).Click();
            }
        }
        public void Click_Posting()
        {
            Posting_Link.Click();
            Assert.AreEqual(Posting_Section.GetAttribute("class"), "Visible");
        }
        public void Set_GLCodes(bool state)
        {
            SeleniumUtility.SetCheckBox(GLCodes_Checkbox, state);
        }

        public void Set_Batch(bool state)
        {
            SeleniumUtility.SetCheckBox(Batch_Checkbox, state);
        }
        //public void DefaultForNewAccountsOptions(SharedData.NewAccountDefaults companySetup)
        //{
        //    ClickBillToPrintStatement(companySetup.BillToPrintStatement);
        //    ClickBillToPrintInvoice(companySetup.BillToPrintInvoice);
        //    ClickBillToEmailStatement(companySetup.BillToEmailStatement);
        //    ClickBillToEmailInvoice(companySetup.BillToEmailInvoice);
        //    ClickBillToAutomatedEmailsInspectionReport(companySetup.BillToAutomatedEmailsInspectionReport);
        //    ClickBillToAutomatedEmailsInvoices(companySetup.BillToAutomatedEmailsInvoice);
        //}
        private void ClickBillToPrintStatement(bool? click)
        {
            if (click ?? false)
            {
                PrintStatementButton.Click();
            }
        }
        private void ClickBillToPrintInvoice(bool? click)
        {
            if (click ?? false)
            {
                PrintInvoiceButton.Click();
            }
        }
        private void ClickBillToEmailStatement(bool? click)
        {
            if (click ?? false)
            {
                EmailStatementButton.Click();
            }
        }
        private void ClickBillToEmailInvoice(bool? click)
        {
            if (click ?? false)
            {
                EmailInvoiceButton.Click();
            }
        }
        private void ClickBillToAutomatedEmailsInspectionReport(bool? click)
        {
            if (click ?? false)
            {
                AutomatedEmailInspectionReportButton.Click();
            }
        }
        private void ClickBillToAutomatedEmailsInvoices(bool? click)
        {
            if (click ?? false)
            {
                AutomatedEmailInvoiceButton.Click();
            }
        }
        public void Click_MethodsOfPayment()
        {
            PaymentMethods_Link.Click();
            Assert.AreEqual(PaymentMethods_Section.GetAttribute("class"), "Visible");
        }
        public bool VerifyProvider(string Paymentprovider)
        {
            string path = "/html/body/form/div/div[2]/div[8]/table[1]/tbody/tr[2]/td[2]/table/tbody/tr[1]/td[2]/select/option[2]";

            string selectedtext = SUT.Web.WebDriver.FindElement(By.XPath(path)).Text;

            if (Paymentprovider == selectedtext)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Click_AdditionalFeatures()
        {
            AdditionalFeatures_Link.Click();
        }

        public bool EnableOrDisable_UseActiveDirectory(string enableOrDisable, string defaultDomain)
        {
            if (UseActiveDirectory_Checkbox.Selected && enableOrDisable.Equals("enable"))
            {
                //Set Default Domain
                if (!String.IsNullOrEmpty(defaultDomain))
                {
                    PestPacUtility.BackspaceClear(DefaultDomain_Field);
                    DefaultDomain_Field.SendKeys(defaultDomain + Keys.Tab);
                }
                return true;
            }
            else if (!UseActiveDirectory_Checkbox.Selected && enableOrDisable.Equals("enable"))
            {
                UseActiveDirectory_Checkbox.Click();
                //Set Default Domain
                if (!String.IsNullOrEmpty(defaultDomain))
                {
                    PestPacUtility.BackspaceClear(DefaultDomain_Field);
                    DefaultDomain_Field.SendKeys(defaultDomain + Keys.Tab);
                }
                return true;
            }
            else if (UseActiveDirectory_Checkbox.Selected && enableOrDisable.Equals("disable"))
            {
                UseActiveDirectory_Checkbox.Click();
                return true;
            }
            else if (!UseActiveDirectory_Checkbox.Selected && enableOrDisable.Equals("disable"))
            {
                return true;
            }

            return false;
        }

        public void Click_PaymentScreen()
        {
            PaymentScreen_Link.Click();
        }

        public bool Select_DefaultPaymentDateFrom(string defaultPaymentDateFrom)
        {
            string checkBoxValue = null;

            if (defaultPaymentDateFrom.Equals("Batch Date"))
            {
                checkBoxValue = "B";
            }
            else if (defaultPaymentDateFrom.Equals("System Date"))
            {
                checkBoxValue = "S";
            }
            else if (defaultPaymentDateFrom.Equals("None"))
            {
                checkBoxValue = "N";
            }

            string temp_DefaultPaymentDateFrom_ChkBox = "//input[@name='DefaultPaymentDate' and @value='" + checkBoxValue + "']";
            IWebElement DefaultPaymentDateFrom_ChkBox = SUT.Web.WebDriver.FindElement(By.XPath(temp_DefaultPaymentDateFrom_ChkBox));
            DefaultPaymentDateFrom_ChkBox.Click();

            return true;
        }

        public void Click_ServiceOrderOrServiceSetup()
        {
            ServiceOrderOrServiceSetup_Link.Click();
        }

        public void AnnualPrepayDiscount(bool annualPrepayDiscount, string discount, string discountReason, bool includeTax)
        {

            if (!String.IsNullOrEmpty(annualPrepayDiscount.ToString()))
            {
                SeleniumUtility.SetCheckBox(AnnualPrepayDiscount_ChckBox, annualPrepayDiscount);

                if (!String.IsNullOrEmpty(discount))
                {
                    PestPacUtility.BackspaceClear(Discount_Field);
                    Discount_Field.SendKeys(discount + Keys.Tab);
                }
                if (!String.IsNullOrEmpty(discountReason))
                {
                    DiscountReason_LookupField.SendKeys(discountReason + Keys.Tab);
                }
                if (!String.IsNullOrEmpty(includeTax.ToString()))
                {
                    SeleniumUtility.SetCheckBox(IncludeTaxInDiscount_CheckBox, includeTax);
                }
            }
        }

        public bool CreateFinanceChargeOnPaymentEntry(bool createFinanceChargeOnPaymentEntry, string serviceCode)
        {
            SeleniumUtility.SetCheckBox(CreateFinanceChargeOnPaymentEntry_ChckBox, createFinanceChargeOnPaymentEntry);

            if (!String.IsNullOrEmpty(serviceCode))
            {
                PestPacUtility.BackspaceClear(ServiceCode_Field);
                ServiceCode_Field.SendKeys(serviceCode + Keys.Tab);
            }

            return true;
        }

        public bool HideServicesNotAssignedToBillTo(bool hideServicesNotAssignedToBillTo)
        {
            SeleniumUtility.SetCheckBox(HideServicesNotAssignedToBillTo_ChckBox, hideServicesNotAssignedToBillTo);

            return true;
        }

        public void RequireCVV(bool requireCVV)
        {
            SeleniumUtility.SetCheckBox(RequireCVV_ChkBox, requireCVV);
        }

        public void AllowPreAuthorizationOfCC(bool allowPreAuthorizationOfCC)
        {
            SeleniumUtility.SetCheckBox(AllowPreAuthorizationOfCC_ChkBox, allowPreAuthorizationOfCC);
        }

        public void ProcessACHThrough(string processACHThrough)
        {
            if (processACHThrough.Equals("Selected Payment Processor"))
            {
                SelectedPaymentProcessor_RdoButton.Click();
            }
            else if (processACHThrough.Equals("NACHA-Compatible Export File"))
            {
                NACHACompatibleExportFile_RdoButton.Click();
            }
        }
        public void NotificationDays(string days)
        {
            NotificationDays_Field.Clear();
            NotificationDays_Field.SendKeys(days);
        }
        public void NotifyLocation(bool notifyLocation)
        {
            SeleniumUtility.SetCheckBox(NotifyLocation_CheckBox, notifyLocation);
        }
        public void NotifyBillTo(bool notifyBillTo)
        {
            SeleniumUtility.SetCheckBox(NotifyBillTo_CheckBox, notifyBillTo);
        }
        public void PrintNotification(bool printNotification)
        {
            SeleniumUtility.SetCheckBox(PrintNotification_CheckBox, printNotification);
        }
        public void EmailNotification(bool emailNotification)
        {
            SeleniumUtility.SetCheckBox(EmailNotification_CheckBox, emailNotification);
        }
        public void CallNotification(bool callNotification)
        {
            SeleniumUtility.SetCheckBox(CallNotification_CheckBox, callNotification);
        }
        #endregion behaviors

        public bool AutomaticallySavePaymentOption(string selectOption)
        {
            if (AutomaticallySavePayment_ChkBox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!AutomaticallySavePayment_ChkBox.Selected && selectOption.Equals("True"))
            {
                AutomaticallySavePayment_ChkBox.Click();
                return true;
            }
            else if (AutomaticallySavePayment_ChkBox.Selected && selectOption.Equals("False"))
            {
                AutomaticallySavePayment_ChkBox.Click();
                return true;
            }
            else if (!AutomaticallySavePayment_ChkBox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public void fieldSetupLink()
        {
            FieldSetup.Click();
        }

        public void FinanceChargefield(string code)
        {
            Finance_Charge_field.Clear();
            Finance_Charge_field.SendKeys(code);
            Thread.Sleep(1000);
            Finance_Charge_field.SendKeys(Keys.Tab);
        }

        public bool tech1Checkbox(string selectOption)
        {
            if (Tech1Checkbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!Tech1Checkbox.Selected && selectOption.Equals("True"))
            {
                Tech1Checkbox.Click();
                return true;
            }
            else if (Tech1Checkbox.Selected && selectOption.Equals("False"))
            {
                Tech1Checkbox.Click();
                return true;
            }
            else if (!Tech1Checkbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }


        public bool tech3Checkbox(string selectOption)
        {
            if (Tech3Checkbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!Tech3Checkbox.Selected && selectOption.Equals("True"))
            {
                Tech3Checkbox.Click();
                return true;
            }
            else if (Tech3Checkbox.Selected && selectOption.Equals("False"))
            {
                Tech3Checkbox.Click();
                return true;
            }
            else if (!Tech3Checkbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public void tech3Caption(string name)
        {
            Tech3Caption.Clear();
            Tech3Caption.SendKeys(name);
        }

        public bool tech4Checkbox(string selectOption)
        {
            if (Tech4Checkbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!Tech4Checkbox.Selected && selectOption.Equals("True"))
            {
                Tech4Checkbox.Click();
                return true;
            }
            else if (Tech4Checkbox.Selected && selectOption.Equals("False"))
            {
                Tech4Checkbox.Click();
                return true;
            }
            else if (!Tech4Checkbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public void tech4Caption(string name)
        {
            Tech4Caption.Clear();
            Tech4Caption.SendKeys(name);
        }

        public void tech5Caption(string name)
        {
            Tech5Caption.Clear();
            Tech5Caption.SendKeys(name);
        }

        public bool tech5Checkbox(string selectOption)
        {
            if (Tech5Checkbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!Tech5Checkbox.Selected && selectOption.Equals("True"))
            {
                Tech5Checkbox.Click();
                return true;
            }
            else if (Tech5Checkbox.Selected && selectOption.Equals("False"))
            {
                Tech5Checkbox.Click();
                return true;
            }
            else if (!Tech5Checkbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public void techShare(string value)
        {

            TechShare.SendKeys(Keys.Delete);
            TechShare.SendKeys(value);
        }

        public void saveField()
        {
            SaveFieldSetup.Click();
        }

        public void techRole(string name)
        {
            TechRole.SendKeys(name + Keys.Tab);
        }




        public void selectProductionPayOn(string name)
        {
            TechPayOn.SendKeys(name);
        }

        public void selectUpFrontPayOn(string name)
        {
            TechPayOn.SendKeys(name);
        }

        public void selectBlankPayOn()
        {

            SelectElement select = new SelectElement(TechPayOn);
            select.SelectByIndex(0);
        }

        public string payOnProductionAlertPopup()
        {
            string value = SUT.Web.WebDriver.SwitchTo().Alert().Text;
            SUT.Log.Debug("Alert displayed" + value);
            return value;
        }

        public string payOnAlertUpfrontPopup()
        {
            string value = SUT.Web.WebDriver.SwitchTo().Alert().Text;
            SUT.Log.Debug("Alert displayed" + value);
            return value;
        }

        public bool promptAssociatLead(string selectOption)
        {
            if (Prompt_Associated.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!Prompt_Associated.Selected && selectOption.Equals("True"))
            {
                Prompt_Associated.Click();
                return true;
            }
            else if (Prompt_Associated.Selected && selectOption.Equals("False"))
            {
                Prompt_Associated.Click();
                return true;
            }
            else if (!Prompt_Associated.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }



        public bool paymentMethodLink()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => Payment_Method_Link)))
            {

                Payment_Method_Link.Click();
                return true;
            }
            else
            {
                SUT.Log.ErrorFormat("Could not find Payment Method Link {0}", MethodBase.GetCurrentMethod().Name);
                return false;
            }
        }

        public bool showACHCheckbox(string selectOption)
        {
            if (ACHCheckbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!ACHCheckbox.Selected && selectOption.Equals("True"))
            {
                ACHCheckbox.Click();
                return true;
            }
            else if (ACHCheckbox.Selected && selectOption.Equals("False"))
            {
                ACHCheckbox.Click();
                return true;
            }
            else if (!ACHCheckbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool saveCompanySetup()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => CompanySetup_Save)))
            {

                CompanySetup_Save.Click();
                return true;
            }
            else
            {
                SUT.Log.ErrorFormat("Could not find CompanySetup Save button {0}", MethodBase.GetCurrentMethod().Name);
                return false;
            }
        }

        public bool AutoApplyOnPaymentEntry(bool autoApplyOnPaymentEntry)
        {
            SeleniumUtility.SetCheckBox(AutoApplyOnPaymentEntry_ChckBox, autoApplyOnPaymentEntry);

            return true;
        }

        //public void setProcessor()
        //{
        //    var processor_value=Processor_drpdwn.GetAttribute("value");
        //    if (processor_value.Equals("None"))
        //    {
        //        var currentURL = SUT.Web.WebDriver.Url;

        //        if (currentURL.Contains("ppsxb"))
        //        {
        //            Processor_drpdwn.SendKeys("WorkWave");
        //            Processor_usrName.Clear();
        //            Processor_usrName.SendKeys("jpdbylLeJDNaQO5Z1lD1x9r8WA2P4oEkBXMG");
        //            PasswordEditLink.Click();
        //            Processor_Password.Clear();
        //            Processor_Password.SendKeys("011493d7-f771-11ea-80fc-0aa4488b8344"+Keys.Tab);
        //            Thread.Sleep(5000);
        //            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GreenPasswordTick)))
        //            {
        //                Assert.True(true, "Entered Valid Credentials");
        //            }
        //            else
        //            {
        //                Assert.True(false, "Entered Invalid Credentials");
        //            }
        //            saveCompanySetup();
        //            Thread.Sleep(6000);
        //        }
        //        else if (currentURL.Contains("pptxb"))
        //        {
        //            Processor_drpdwn.SendKeys("WorkWave");
        //            Processor_usrName.Clear();
        //            Processor_usrName.SendKeys("ar4yjgMWvY8BXd5G6PGq9wnmRboO7p0QkzlN");
        //            PasswordEditLink.Click();
        //            Processor_Password.Clear();
        //            Processor_Password.SendKeys("eb6803bb-f770-11ea-80fc-0aa4488b8344"+Keys.Tab);
        //            Thread.Sleep(5000);
        //            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GreenPasswordTick)))
        //            {
        //                Assert.True(true, "Entered Valid Credentials");
        //            }
        //            else
        //            {
        //                Assert.True(false, "Entered Invalid Credentials");
        //            }
        //            saveCompanySetup();
        //            Thread.Sleep(6000);
        //        }

        //    }
        //    else if (processor_value.Contains("WorkWave"))
        //    {
        //        var currentURL = SUT.Web.WebDriver.Url;
        //        if (currentURL.Contains("ppsxb"))
        //        {
        //            var currUsername = Processor_usrName.GetAttribute("value");
        //            if (currUsername.Equals("jpdbylLeJDNaQO5Z1lD1x9r8WA2P4oEkBXMG"))
        //            {
        //                SUT.Log.Debug("Payment methods for PPSXB is correct");
        //            }
        //            else
        //            {
        //                Processor_usrName.Clear();
        //                Processor_usrName.SendKeys("jpdbylLeJDNaQO5Z1lD1x9r8WA2P4oEkBXMG");
        //                PasswordEditLink.Click();
        //                Processor_Password.Clear();
        //                Processor_Password.SendKeys("011493d7-f771-11ea-80fc-0aa4488b8344"+Keys.Tab);
        //                Thread.Sleep(5000);
        //                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GreenPasswordTick)))
        //                {
        //                    Assert.True(true, "Entered Valid Credentials");
        //                }
        //                else
        //                {
        //                    Assert.True(false, "Entered Invalid Credentials");
        //                }
        //                saveCompanySetup();
        //                Thread.Sleep(6000);
        //            }
        //        }
        //        else if (currentURL.Contains("pptxb"))
        //        {
        //            var currUsername = Processor_usrName.GetAttribute("value");
        //            if (currUsername.Equals("ar4yjgMWvY8BXd5G6PGq9wnmRboO7p0QkzlN"))
        //            {
        //                SUT.Log.Debug("Payment methods for PPTXB is correct");
        //            }
        //            else
        //            {
        //                Processor_usrName.Clear();
        //                Processor_usrName.SendKeys("ar4yjgMWvY8BXd5G6PGq9wnmRboO7p0QkzlN");
        //                PasswordEditLink.Click();
        //                Processor_Password.Clear();
        //                Processor_Password.SendKeys("eb6803bb-f770-11ea-80fc-0aa4488b8344"+Keys.Tab);
        //                Thread.Sleep(5000);
        //                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GreenPasswordTick)))
        //                {
        //                    Assert.True(true, "Entered Valid Credentials");
        //                }
        //                else
        //                {
        //                    Assert.True(false, "Entered Invalid Credentials");
        //                }
        //                saveCompanySetup();
        //                Thread.Sleep(6000);
        //            }
        //        }
        //    }


        //}

        public void setProcessor()
        {
            var currentURL = SUT.Web.WebDriver.Url;

            if (currentURL.Contains("ppsxb"))
            {
                Processor_drpdwn.SendKeys("WorkWave");
                Processor_usrName.Clear();
                Processor_usrName.SendKeys("jpdbylLeJDNaQO5Z1lD1x9r8WA2P4oEkBXMG");
                PasswordEditLink.Click();
                Processor_Password.Clear();
                Processor_Password.SendKeys("011493d7-f771-11ea-80fc-0aa4488b8344" + Keys.Tab);
                Thread.Sleep(20000);
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GreenPasswordTick)))
                {
                    Assert.True(true, "Entered Valid Credentials");
                }
                else
                {
                    Assert.True(false, "Entered Invalid Credentials");
                }
                saveCompanySetup();
                Thread.Sleep(6000);
            }
            else if (currentURL.Contains("pptxb"))
            {
                Processor_drpdwn.SendKeys("WorkWave");
                Processor_usrName.Clear();
                Processor_usrName.SendKeys("ar4yjgMWvY8BXd5G6PGq9wnmRboO7p0QkzlN");
                PasswordEditLink.Click();
                Processor_Password.Clear();
                Processor_Password.SendKeys("eb6803bb-f770-11ea-80fc-0aa4488b8344" + Keys.Tab);
                Thread.Sleep(20000);
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => GreenPasswordTick)))
                {
                    Assert.True(true, "Entered Valid Credentials");
                }
                else
                {
                    Assert.True(false, "Entered Invalid Credentials");
                }
                saveCompanySetup();
                Thread.Sleep(6000);
            }
        }

        public bool useRequiredFields(string selectOption)
        {
            if (Required_Fields.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!Required_Fields.Selected && selectOption.Equals("True"))
            {
                Required_Fields.Click();
                return true;
            }
            else if (Required_Fields.Selected && selectOption.Equals("False"))
            {
                Required_Fields.Click();
                return true;
            }
            else if (!Required_Fields.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool decimalUnitPrice(string selectOption)
        {
            if (DecimalUnitPrice.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!DecimalUnitPrice.Selected && selectOption.Equals("True"))
            {
                DecimalUnitPrice.Click();
                return true;
            }
            else if (DecimalUnitPrice.Selected && selectOption.Equals("False"))
            {
                DecimalUnitPrice.Click();
                return true;
            }
            else if (!DecimalUnitPrice.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool ClickServiceOrderSetupLink()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServiceOrder_Setup_Link)))
            {
                SUT.Log.Debug("Clicking on Service Order Setup Link");
                ServiceOrder_Setup_Link.Click();
                SUT.Log.Debug("Clicked on Service Order Setup Link");
                return true;
            }
            else
            {
                SUT.Log.Debug("Service Order Setup Link not found");
                return false;
            }

        }

        public bool PriceServicesBrancheckbox(string selectOption)
        {
            if (PriceServiceByBranch_ChckBox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!PriceServiceByBranch_ChckBox.Selected && selectOption.Equals("True"))
            {
                PriceServiceByBranch_ChckBox.Click();
                return true;
            }
            else if (PriceServiceByBranch_ChckBox.Selected && selectOption.Equals("False"))
            {
                PriceServiceByBranch_ChckBox.Click();
                return true;
            }
            else if (!PriceServiceByBranch_ChckBox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool CreateFinanceCharge_Chkbox(string selectOption)
        {
            if (CreateFCPmtEntry_ChckBox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!CreateFCPmtEntry_ChckBox.Selected && selectOption.Equals("True"))
            {
                CreateFCPmtEntry_ChckBox.Click();
                return true;
            }
            else if (CreateFCPmtEntry_ChckBox.Selected && selectOption.Equals("False"))
            {
                CreateFCPmtEntry_ChckBox.Click();
                return true;
            }
            else if (!CreateFCPmtEntry_ChckBox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool vantiveAccountUpdater(string selectOption)
        {
            if (UseVantivAccountUpdater_Checkbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!UseVantivAccountUpdater_Checkbox.Selected && selectOption.Equals("True"))
            {
                UseVantivAccountUpdater_Checkbox.Click();
                return true;
            }
            else if (UseVantivAccountUpdater_Checkbox.Selected && selectOption.Equals("False"))
            {
                UseVantivAccountUpdater_Checkbox.Click();
                return true;
            }
            else if (!UseVantivAccountUpdater_Checkbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public void SendInspectionReportOn(string sendInspectionReportOn)
        {
            PestPacUtility.ScrollToElement(SendInspectionReportOn_DropDown);
            SelectElement selectElement = new SelectElement(SendInspectionReportOn_DropDown);
            selectElement.SelectByText(sendInspectionReportOn);
            SendInspectionReportOn_DropDown.SendKeys(Keys.Tab);
        }

        public void Click_Renewals()
        {
            RenewalLink.Click();
            Assert.AreEqual(RenewalSection.GetAttribute("class"), "Visible");
        }

        public bool VerifyDefaultStatus_RequireServiceChckbox()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RequireService_Chckbox)))
            {
                if (!RequireService_Chckbox.Selected)
                {
                    SUT.Log.Debug("Require Service checkbox is unchecked by default");
                    return true;
                }

                SUT.Log.Debug("Require Service checkbox is not unchecked by default");
                return false;
            }

            SUT.Log.Debug("Require Service checkbox is not visible");
            return false;
        }

        public void SetPromptForRenewalPrepayment(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                SeleniumUtility.SetCheckBox(PromptForRenewalPrepayment_Chckbox, Convert.ToBoolean(value));
            }
        }

        public bool VerifyRequireServiceChckbox()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RequireService_Chckbox)))
            {
                SUT.Log.Debug("Require Service checkbox is visible");
                return true;
            }

            SUT.Log.Debug("Require Service checkbox is not visible");
            return false;
        }

        public void SetCreateServiceOrder(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                SeleniumUtility.SetCheckBox(CreateServiceOrder_Chckbox, Convert.ToBoolean(value));
            }
        }

        public void SetRequireWorkDate(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                SeleniumUtility.SetCheckBox(RequireWorkDate_Chckbox, Convert.ToBoolean(value));
            }
        }

        public bool VerifyDefaultStatus_RequireWorkDate()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => RequireWorkDate_Chckbox)))
            {
                if (!RequireWorkDate_Chckbox.Selected)
                {
                    SUT.Log.Debug("Require Work Date checkbox is unchecked by default");
                    return true;
                }

                SUT.Log.Debug("Require Work Date checkbox is not unchecked by default");
                return false;
            }

            SUT.Log.Debug("Require Work Date checkbox is not visible");
            return false;
        }

        public void SetRequireService(string value)
        {
            if (!String.IsNullOrEmpty(value))
            {
                SeleniumUtility.SetCheckBox(RequireService_Chckbox, Convert.ToBoolean(value));
            }
        }
        public bool UseGLCode_Chkbox(string selectOption)
        {
            if (GLCodes_Checkbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!GLCodes_Checkbox.Selected && selectOption.Equals("True"))
            {
                GLCodes_Checkbox.Click();
                return true;
            }
            else if (GLCodes_Checkbox.Selected && selectOption.Equals("False"))
            {
                GLCodes_Checkbox.Click();
                return true;
            }
            else if (!GLCodes_Checkbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public void ClearCreateFCField()
        {
            Finance_Charge_field.Clear();
            Thread.Sleep(1000);

        }
        public void Set_LockGLCodes(bool state)
        {
            SeleniumUtility.SetCheckBox(Lock_GLCodes, state);
        }

        public void SetNotecodeValidation(String notecodeValidation)
        {
            if (notecodeValidation.Equals("Validate and Lookup"))
            {
                ValidationAndLookup_RdoBtn.Click();
            }
            else if (notecodeValidation.Equals("No Validation"))
            {
                NoValidation_RdoBtn.Click();

            }

        }

        #region Selenium

        #endregion Selenium
    }

}
