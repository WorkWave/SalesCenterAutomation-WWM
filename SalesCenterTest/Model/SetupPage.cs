using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;
using System.Threading;

namespace WorkWave.PestPac.TA.Model
{
    public class SetupPage : IWebPage
    {
        #region PageFactory

        [FindsBy(How = How.Id, Using = "page-header")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butEdit")]
        private IWebElement EditButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butAdd")]
        private IWebElement AddButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butSearch")]
        private IWebElement SearchButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butSaveTop")]
        private IWebElement SaveButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butCancelTop")]
        private IWebElement CancelButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butDelete")]
        private IWebElement DeleteButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butExit")]
        private IWebElement ExitButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butDiagram")]
        private IWebElement DiagramsButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butBait")]
        private IWebElement DevicesButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butBaitStationLog")]
        private IWebElement DeviceLogButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "butCalendar")]
        private IWebElement CalendarButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ServiceCode1")]
        private IWebElement SetupService1 { get { return PageFactory.Load(this); } }
        //---------Card Number----------->
        [FindsBy(How = How.Id, Using = "CardNumber")]
        private IWebElement SetupCardNum_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "CardName")]
        private IWebElement CardName_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "CardExpMonth")]
        private IWebElement CardExpMonth_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "CardExpYear")]
        private IWebElement CardExpYear_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "DisabledCardType")]
        private IWebElement CardType_Dropdown { get { return PageFactory.Load(this); } }
        //END -------Card Number------------>
        [FindsBy(How = How.Id, Using = "UnitPrice1")]
        private IWebElement SetupPrice1 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Schedule")]
        private IWebElement SetupSchedule { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#SetupType")]
        private IWebElement SetupChargeType { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "StartDate")]
        private IWebElement startDate { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "NextGeneratedDate")]
        private IWebElement NextGenDate { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "LastGeneratedDate")]
        private IWebElement LastGenDate { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BillingSchedule")]
        private IWebElement BillingSchedule { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BillingAmount")]
        private IWebElement BillingAmount { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BillingTaxable")]
        private IWebElement BillingTax { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "BillingLastGeneratedDate")]
        private IWebElement BillingLastGeneratedDate { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UseAnnualPrepayDiscount")]
        private IWebElement AnnualPrepayDiscount { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "#UseAnnualPrepayDiscount")]
        private IWebElement DiscountEligibiltyCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech1")]
        private IWebElement SetupTech1 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ManageCC")]
        private IWebElement ManageCardsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ManageACH")]
        private IWebElement ManageACHLink { get { return PageFactory.Load(this); } }

        //REMOVE
        [FindsBy(How = How.CssSelector, Using = "iframe[src*='ManageCardsOnFile.asp']")]
        private IWebElement ManageCard_Iframe { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "CardName0")]
        private IWebElement AddName_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "select[id*='SetupSelectedCardID']")]
        private IWebElement savedCardsDropDown { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech3")]
        private IWebElement SetupSales1 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "TechBonus3")]
        private IWebElement SetupSales1Bonus { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "TechBonus1")]
        private IWebElement SetupTech1Bonus { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech2")]
        private IWebElement SetupTech2 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech4")]
        private IWebElement SetupSales2 { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "TechComm1")]
        private IWebElement Tech1Commission { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "TechComm2")]
        private IWebElement Tech2Commission { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "TechComm3")]
        private IWebElement Tech3Commission { get { return PageFactory.Load(this); } }
        [FindsBy(How = How.Id, Using = "TechComm4")]
        private IWebElement Tech4Commission { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//a[@id='locationHeaderDetailLink']//strong")]
        private IWebElement LocationHeaderLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#TaxCode")]
        private IWebElement LocationTaxCode { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#butSave")]
        private IWebElement LocationSave { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#ProgramsTable > tbody > tr:nth-child(3) > td:nth-child(2) > a:nth-child(1)")]
        private IWebElement ServiceSetupLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Taxable1")]
        private IWebElement TaxCheckBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#AnnualPrepayDiscountPayment")]
        private IWebElement AnnualPayment { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//tr[@id='RSRow1']//td[3]//span[1]")]
        private IWebElement FirstRowServiceSetup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#AnnualPrepayDiscount")]
        private IWebElement AnnualPrepayDiscountTextField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AutoBillTypeCC")]
        private IWebElement CreditCard_RdoButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AutoBillTypeCH")]
        private IWebElement ACH_RdoButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "AutoBill")]
        private IWebElement AutoBillCard_ChkBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ACHAutoBill")]
        private IWebElement AutoBillAccount_ChkBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "SetupSelectedAchID")]
        private IWebElement SavedACH_DropDown { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#WorkTime")]
        private IWebElement WorkTime { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech3")]
        private IWebElement SetupTech3 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech4")]
        private IWebElement SetupTech4 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "Tech5")]
        private IWebElement SetupTech5 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#Locked")]
        private IWebElement LockedCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech1']")]
        private IWebElement VerifyTech1 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech2']")]
        private IWebElement VerifyTech2 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech3']")]
        private IWebElement VerifyTech3 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech4']")]
        private IWebElement VerifyTech4 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech5']")]
        private IWebElement VerifyTech5 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech1']//parent::td/span")]
        private IWebElement VerifyEditableTech1 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech2']//parent::td/span")]
        private IWebElement VerifyEditableTech2 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech3']//parent::td/span")]
        private IWebElement VerifyEditableTech3 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech4']//parent::td/span")]
        private IWebElement VerifyEditableTech4 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='Tech5']//parent::td/span")]
        private IWebElement VerifyEditableTech5 { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@class='close-me']/img[contains(@src,'close')]")]
        private IWebElement ManageCardFrame_CloseIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "div[class^='cards-on-file-'][style]")]
        private IWebElement ManageCard_Modal { get { return PageFactory.Load(this); } }

        /** ---------------------------------------- Service Setup Materials ---------------------------------------- **/

        [FindsBy(How = How.Id, Using = "ChemicalCode1")]
        private IWebElement ChemicalCode1_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "UnitOfMeasure1")]
        private IWebElement QuantityUOM1_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "MethodOfAppl1")]
        private IWebElement AppMethod1_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ApplicationRateCode1")]
        private IWebElement AppRate1_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ApplicationEquipmentCode1")]
        private IWebElement AppEquipment1_Field { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//table[@id='Chem']//tr[@bgcolor]/td/input[contains(@idfield,'ChemicalID')]")]
        private IList<IWebElement> MaterialTable_MaterialFields { get { return PageFactory.LoadList(this); } }

        /** --------------------------------------------------------------------------------------------------------- **/

        [FindsBy(How = How.XPath, Using = "//span[text()='close']")]
        private IWebElement LeadPopup_CloseButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#iframe-modal-0")]
        private IWebElement popupFrame { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@class='ui-button ui-widget ui-state-default ui-corner-all ui-button-icon-only ui-dialog-titlebar-close']")]
        private IWebElement Popup_CloseButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#iframe-modal-0")]
        private IWebElement AddDeviceFrame { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "#addAllDevicesCheckBox")]
        private IWebElement AddAllDevicesCheckBox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "iframe-modal-0")]
        private IWebElement LeadAttachmentSetup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//table/tbody/tr/td[contains(text(),'BEES')]")]
        private IWebElement LeadAttachmentSetupRow { get { return PageFactory.Load(this); } }


        #endregion PageFactory

        private readonly string PageHeaderText = "Service Setup";


        public bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader)))
            {
                if (PageHeader.Text.TrimStart().StartsWith(PageHeaderText))
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
        //public IWebPage Add()
        //{
        //    {
        //        AddButton.Click(); AddButton.Click();
        //        return new LocationPage();
        //        //IAlert alert = SUT.Web.ExplicitWait.Until(ExpectedConditions.AlertIsPresent());
        //        //if (alert != null)
        //        //{
        //        //    SUT.Web.Alert_Accept();
        //        //}
        //        //return new LocationPage();
        //    }
        //}




        #endregion behaviors

        #region Selenium 
        private IWebElement FindServiceSetup(string serviceCode)//verification
        {
            string css = String.Format("#ProgramsTable tr td[sortdata='{0}']", serviceCode);
            IWebElement setupElement = SUT.Web.WebDriver.FindElement(By.CssSelector(css));
            return setupElement;
        }


        public bool VerifyTec1Commision(string tech1Commission)
        {
            if (Tech1Commission.GetAttribute("value") == tech1Commission)
            {
                return true;
            }
            else
                return false;
        }
        public bool VerifyTec2Commision(string tech2Commission)
        {
            if (Tech2Commission.GetAttribute("value") == tech2Commission)
            {
                return true;
            }
            else
                return false;
        }
        public bool VerifyTec3Commision(string tech3Commission)
        {
            if (Tech3Commission.GetAttribute("value") == tech3Commission)
            {
                return true;
            }
            else
                return false;
        }
        public bool VerifyTec4Commision(string tech4Commission)
        {
            if (Tech4Commission.GetAttribute("value") == tech4Commission)
            {
                return true;
            }
            else
                return false;
        }
        public bool VerifyTec1Bonus(string tech1Bonus)
        {
            if (SetupTech1Bonus.GetAttribute("value") == tech1Bonus)
            {
                return true;
            }
            else
                return false;
        }
        public bool VerifySales1Bonus(string sales1Bonus)
        {
            if (SetupSales1Bonus.GetAttribute("value") == sales1Bonus)
            {
                return true;
            }
            else
                return false;
        }

        public void locationHeaderLink()
        {
            LocationHeaderLink.Click();
        }

        public void setLocationTaxCode(string taxCode)
        {
            LocationTaxCode.Clear();
            LocationTaxCode.SendKeys(taxCode);
        }

        public void saveLocation()
        {
            LocationSave.Click();
        }

        public void setServiceCode(string serviceCode)
        {
            SetupService1.SendKeys(serviceCode + Keys.Tab);
        }

        public void setPrice(string price)
        {
            SetupPrice1.SendKeys(Keys.Control + "a");
            SetupPrice1.SendKeys(Keys.Delete);
            SetupPrice1.SendKeys(price);
        }

        public void setSchedule(string schedule)
        {
            SetupSchedule.SendKeys(schedule);
        }



        public bool taxCheckbox(string selectOption)
        {
            if (TaxCheckBox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!TaxCheckBox.Selected && selectOption.Equals("True"))
            {
                TaxCheckBox.Click();
                return true;
            }
            else if (TaxCheckBox.Selected && selectOption.Equals("False"))
            {
                TaxCheckBox.Click();
                return true;
            }
            else if (!TaxCheckBox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;

        }

        public void setChargeType(string chargeType)
        {
            /*//SetupChargeType.Click();
            SelectElement charge = new SelectElement(SetupChargeType);
            charge.SelectByValue(chargeType);*/
            SetupChargeType.SendKeys(chargeType + Keys.Enter);

        }

        public bool EligibleForAnnualPrepayDiscount(string selectOption)
        {

            if (AnnualPrepayDiscount.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!AnnualPrepayDiscount.Selected && selectOption.Equals("True"))
            {
                AnnualPrepayDiscount.Click();
                return true;
            }
            else if (AnnualPrepayDiscount.Selected && selectOption.Equals("False"))
            {
                AnnualPrepayDiscount.Click();
                return true;
            }
            else if (!AnnualPrepayDiscount.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;

        }

        public void setbillingSchedule(string billingSchedule)
        {
            BillingSchedule.SendKeys(billingSchedule + Keys.Tab);
        }

        public void SetBillingLastGenDate(string billingLastGenDate)
        {
            BillingLastGeneratedDate.SendKeys(billingLastGenDate + Keys.Tab);
        }

        public void setBillingAmount(string billingAmount)
        {

            BillingAmount.SendKeys(Keys.Control + "a");
            BillingAmount.SendKeys(Keys.Delete);
            BillingAmount.SendKeys(billingAmount + Keys.Tab);

        }
        public void setDiscountAmount(string discount)
        {
            AnnualPrepayDiscountTextField.SendKeys(Keys.Control + "a");
            AnnualPrepayDiscountTextField.SendKeys(Keys.Delete);
            AnnualPrepayDiscountTextField.SendKeys(discount);
        }
        public void saveButton()
        {
            SalesCenterUtility.ScrollToElement(AddButton);
            Thread.Sleep(2000);
            AddButton.Click();
        }

        public void firstRecord()
        {
            FirstRowServiceSetup.Click();
        }

        public string annualPayment()
        {
            return AnnualPayment.GetAttribute("value");
        }
        public void exitButton()
        {
            ExitButton.Click();
        }

        public void setWorkTIme(string time)
        {
            WorkTime.SendKeys(time);
        }

        public void clickOnEdit()
        {
            EditButton.Click();
        }

        public bool setTech1(string tech1)
        {
            bool entered = false;

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SetupTech1)))
            {
                SetupTech1.SendKeys(tech1 + Keys.Tab);
                Thread.Sleep(3000);
                entered = true;
            }
            else
            {
                SUT.Log.DebugFormat("Unable to enter in Service field on service setup page");
            }
            return entered;
        }

        public bool setTech2(string tech2)
        {
            bool entered = false;

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SetupTech2)))
            {
                SetupTech2.SendKeys(tech2 + Keys.Tab);
                Thread.Sleep(3000);
                entered = true;
            }
            else
            {
                SUT.Log.DebugFormat("Unable to enter second Tech");
            }
            return entered;
        }

        public bool setTech3(string tech3)
        {
            bool entered = false;

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SetupTech3)))
            {
                SetupTech3.SendKeys(tech3 + Keys.Tab);
                Thread.Sleep(3000);
                entered = true;
            }
            else
            {
                SUT.Log.DebugFormat("Unable to enter third Tech");
            }
            return entered;
        }

        public bool setTech4(string tech4)
        {
            bool entered = false;

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SetupTech4)))
            {
                SetupTech4.SendKeys(tech4 + Keys.Tab);
                Thread.Sleep(3000);
                entered = true;
            }
            else
            {
                SUT.Log.DebugFormat("Unable to enter Fourth Tech");
            }
            return entered;
        }

        public bool setTech5(string tech5)
        {
            bool entered = false;

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SetupTech5)))
            {
                SetupTech5.SendKeys(tech5 + Keys.Tab);
                Thread.Sleep(3000);
                entered = true;
            }
            else
            {
                SUT.Log.DebugFormat("Unable to enter Fifth Tech");
            }
            return entered;
        }

        public bool lockedCheckbox(string selectOption)
        {
            if (LockedCheckbox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!LockedCheckbox.Selected && selectOption.Equals("True"))
            {
                LockedCheckbox.Click();
                return true;
            }
            else if (LockedCheckbox.Selected && selectOption.Equals("False"))
            {
                LockedCheckbox.Click();
                return true;
            }
            else if (!LockedCheckbox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool verifyTech1Disabled()
        {
            VerifyTech1.Click();
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => VerifyEditableTech1)))
            {
                return true;
            }
            else
            {
                SUT.Log.DebugFormat("Element non editable");
                return false;
            }
        }

        public bool verifyTech2Disabled()
        {
            VerifyTech2.Click();
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => VerifyEditableTech2)))
            {
                return true;
            }
            else
            {
                SUT.Log.DebugFormat("Element non editable");
                return false;
            }


        }

        public bool verifyTech3Enabled()
        {
            VerifyTech3.Click();
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => VerifyEditableTech3)))
            {
                return true;
            }
            else
            {
                SUT.Log.DebugFormat("Element non editable");
                return false;
            }

        }

        public bool verifyTech4Enabled()
        {
            VerifyTech4.Click();
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => VerifyEditableTech4)))
            {
                return true;
            }
            else
            {
                SUT.Log.DebugFormat("Element non editable");
                return false;
            }
        }

        public bool verifyTech5Enabled()
        {
            VerifyTech5.Click();
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => VerifyEditableTech5)))
            {
                return true;
            }
            else
            {
                SUT.Log.DebugFormat("Element non editable");
                return false;
            }

        }

        public void verifyLeadpopup()
        {
            Popup_CloseButton.Click();
        }

        public void setSavedCards()
        {
            SelectElement sc = new SelectElement(savedCardsDropDown);
            sc.SelectByIndex(1);
            SUT.Log.DebugFormat("Selected saved card drop down"); ;
        }

        public void setSavedForACHCards()
        {
            SelectElement sc = new SelectElement(savedCardsDropDown);
            sc.SelectByIndex(1);
        }

        public bool addAllDevices(string selectOption)
        {
            SalesCenterUtility.Frame_SafeSwitch(AddDeviceFrame, () => AddAllDevicesCheckBox);
            if (AddAllDevicesCheckBox.Selected && selectOption.Equals("True"))
            {
                return true;
            }
            else if (!AddAllDevicesCheckBox.Selected && selectOption.Equals("True"))
            {
                AddAllDevicesCheckBox.Click();
                return true;
            }
            else if (AddAllDevicesCheckBox.Selected && selectOption.Equals("False"))
            {
                AddAllDevicesCheckBox.Click();
                return true;
            }
            else if (!AddAllDevicesCheckBox.Selected && selectOption.Equals("False"))
            {
                return true;
            }

            return false;
        }

        public bool enterStartDate()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => startDate)))
            {
                startDate.SendKeys("t" + Keys.Tab);
                SUT.Log.DebugFormat("Entered start date");
                return true;
            }
            else
            {
                SUT.Log.DebugFormat("Did not Entered start date");
                return false;
            }
        }

        public bool leadAttatchmentSetuppopup()
        {
            if (SalesCenterUtility.Frame_SafeSwitch_without_elementInFrame(LeadAttachmentSetup))
            {
                SUT.Log.Debug("Successfully switched to: Lead Attchment setup frame.");
                LeadAttachmentSetupRow.Click();
                SUT.Log.Debug("Clicked on lead row");
                Thread.Sleep(3000);
                SUT.Web.Alert_Accept();
                return true;
            }
            SUT.Log.Error("Unable to switch to: Lead Attchment setup frame!");
            return false;
        }

        #endregion Selenium
    }
}