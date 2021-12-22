using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using WorkWave.TA.TestEngine.PageFactory;
using WorkWave.TA.TestEngine;
using OpenQA.Selenium.Interactions;
using System.Threading;
using NUnit.Framework;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WorkWave.PestPac.TA.Model
{
    class OpportunityPage : IWebPage
    {
        #region PageFactory

        #region Bulk reopen close opportunities

        [FindsBy(How = How.XPath, Using = "(//p[text()='Opportunities'])[2]")]
        private IWebElement ClickOpportunitiesLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Opportunities']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//*[local-name()='svg' and @class='MuiSvgIcon-root MuiSvgIcon-fontSizeSmall']/*[local-name()='path'])[2]")]
        private IWebElement ClickListviewButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[2]/..")]
        private IWebElement ClickFirstOpportunitiesCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[3]")]
        private IWebElement ClickSecondOpportunitiesCheckbox { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Re-Open']")]
        private IWebElement ClickBulkReopenButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Opportunity Status']")]
        private IWebElement OpportunitiesStatusExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='All']")]
        private IWebElement OpportunitiesStatusOpenField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Closed']")]
        private IWebElement OpportunitiesStatusName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Narrowed to Opportunities')]")]
        private IWebElement ClosedOpportunitiesDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Reopen')]")]
        private IWebElement ReopenPageIsDisplayed { get { return PageFactory.Load(this); } }

        #endregion  Bulk reopen close opportunities

        #region close lost opportunities

        [FindsBy(How = How.LinkText, Using = "View Detail Page")]
        private IWebElement ClickViewDetailsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Opportunity Detail Page')]")]
        private IWebElement OpportunityDetailPageIsDisplayed { get { return PageFactory.Load(this); } }

        #endregion Close lost opportunities

        #region Select all the checkbox in listview

        [FindsBy(How = How.XPath, Using = "//div[text()='Closed Won / Closed Lost']")]
        private IWebElement ClickCloseLostExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Closed Lost...')]/..")]
        private IWebElement ClickCloseLostOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Lost to Competitor']")]
        private IWebElement ClickLostCompetitorRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'SAVE')]/..")]
        private IWebElement ClickSaveButtonInCloseLostPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[1]/..")]
        private IWebElement ClickAllCheckboxOption { get { return PageFactory.Load(this); } }
    
        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[1]/..")]
        private IWebElement CheckboxSelected { get { return PageFactory.Load(this); } }

        #endregion Select all the checkbox in listview

        #region reopen closed won/lost opportunities through card view

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='opportunityMoreBtn']")]
        private IWebElement ClickThreeDotsIconforClosedOpportunities { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='- - / - - / - - - -']/..")]
        private IWebElement ClickCalenderIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='OK']/..")]
        private IWebElement ClickOkButtonInCalenderPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Re-Open']/..")]
        private IWebElement ClickReopenButtonInCalenderPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@data-test-id='reopenBtn']")]
        private IWebElement ReopenoptionforClosedOpportunities { get { return PageFactory.Load(this); } }




        #endregion reopen closed won/lost opportunities through card view 

        #region  closed won opportunity

        [FindsBy(How = How.XPath, Using = "//div[@id='contacts-popover']/div[3]/div[1]/div[1]/div[1]/p[1]")]
        private IWebElement ClickAnywhere { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Closed Won']")]
        private IWebElement ClickCloseWonOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Close Form Manager']/..")]
        private IWebElement ClickCloseFormmanagerButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Opportunities']")]
        private IWebElement ClickOpportunitiesLinkInLeadsPage { get { return PageFactory.Load(this); } }

        #endregion closed won opportunity

        #region Add credit card details

        [FindsBy(How = How.XPath, Using = "//span[text()='Capture Card']/../..")]
        private IWebElement ClickCaptureCardButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "name")]
        private IWebElement EnterCardName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Enter']/..")]
        private IWebElement ClickEnterButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Add CC for API Auto CC Refund')]/../../../following-sibling::div[1]")]
        private IWebElement ClickServiceExapndIconForMatchedOpportunity { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "cardNumber")]
        private IWebElement CardNumber { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ddlExpirationMonth")]
        private IWebElement selmonth { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "ddlExpirationYear")]
        private IWebElement selyear { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement ClickAddcreditCardButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.CssSelector, Using = "iframe[src*='certtransaction.hostedpayments']")]
        private IWebElement IframeName { get { return PageFactory.Load(this); } }


        #endregion  Add credit card details

        #region Bulk  Reassign opportunitues

        [FindsBy(How = How.XPath, Using = "//span[text()='Re-Assign']")]
        private IWebElement ClickReassignButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='reassign']")]
        private IWebElement ReassignSliderIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@id='mui-component-select-salesTeamId']")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//li[text()='Auto Test Sales Team']")]
        private IWebElement SalesTeamNameInReassignSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "mui-component-select-assigneeId")]
        private IWebElement ClickSalesTeamMemberField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SalesTeamMemberInReassignSlider { get { return PageFactory.Load(this); } }


        #endregion Bulk reaasign opportunities

        #region Close won the opportunity without pp location matched

        [FindsBy(How = How.XPath, Using = "//h2[text()='Closing Requirements Missing']")]
        private IWebElement CloseRequirementMissingPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='CLOSE']/..")]
        private IWebElement ClickCloseButton { get { return PageFactory.Load(this); } }

        #endregion Close won the opportunity without pp location matched

        #region Remove SC contacts

        [FindsBy(How = How.XPath, Using = "//span[text()='View Contacts']/..")]
        private IWebElement ClickViewContactsLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Contacts'])[2]")]
        private IWebElement ContactPageDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Contact']/..")]
        private IWebElement ClickAddContactButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement ClickSearchIconInContactSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement Searchfield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Add Contact'])[3]")]
        private IWebElement ClickAddContactButtonInContactSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='James Jacob']/../descendant::button")]
        private IWebElement ClickThreeDotsforContacts { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[@class='MuiListItemText-root MuiListItemText-dense']//span)[2]/..")]
        private IWebElement ClickRemoveLinkForContacts { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Remove'])[2]")]
        private IWebElement ClickRemoveButtonInPopup { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Add Contact'])[2]")]
        private IWebElement AddOpportunityPageIsDisplayed { get { return PageFactory.Load(this); } }

        #endregion Remove SC Contacts

        #endregion PageFactory

        private readonly string PageHeaderText = "Opportunities";

        public bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader),TimeSpan.FromSeconds(15)))
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

        public void ClickonOpportunitiesLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOpportunitiesLink)))
                {
                    ClickOpportunitiesLink.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Opportunities link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities link is not clicked");
            }
        }

        public void ClickonListViewButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickListviewButton)))
                {
                   
                    ClickListviewButton.Click();
                    Thread.Sleep(10000);
                    SUT.Log.DebugFormat("List view button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("List view button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("List view button is not clicked");
            }
        }

        public void IsClosedOpportunitiesDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClosedOpportunitiesDisplayed)))
                {
                    ClosedOpportunitiesDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Closed opportunities are displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closed opportunities are not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closed opportunities are not displayed");
            }
        }

        public void SelecttheOpportunities()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickFirstOpportunitiesCheckbox),TimeSpan.FromSeconds(10)))
                {
                    ClickFirstOpportunitiesCheckbox.Click();
                    Thread.Sleep(3000);
                    ClickSecondOpportunitiesCheckbox.Click();
                    SUT.Log.DebugFormat("Opportunities are selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities are not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities are not selected");
            }
        }

        public void ClickOnBulkReopenButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBulkReopenButton)))
                {
                    ClickBulkReopenButton.Click();
                    SUT.Log.DebugFormat("Bulk reopen button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bulk reopen button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bulk reopen button is not clicked");
            }
        }

        public void SelectOpportunitiesStatus()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OpportunitiesStatusExpandIcon)))
                {
                    SalesCenterUtility.ScrollToElement(OpportunitiesStatusExpandIcon);
                    OpportunitiesStatusExpandIcon.Click();
                    Thread.Sleep(1000);
                    OpportunitiesStatusOpenField.Click();
                    OpportunitiesStatusName.Click();
                    SUT.Log.DebugFormat("Opportunties status is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunties status is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunties status is not selected");
            }
        }

        public void IsReopenSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    ReopenPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(10000);
                    SUT.Log.DebugFormat("Reopen slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen slider is not diplayed");
            }
        }

        //Close lost opportunities

        public void ClickOnViewDetailsLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewDetailsLink)))
                {
                    ClickViewDetailsLink.Click();
                    SUT.Log.DebugFormat("View detail link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View detail link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View detail link is not clicked");
            }
        }

        public void IsOpportunityDetailPageDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() =>OpportunityDetailPageIsDisplayed), TimeSpan.FromSeconds(5)))
                {
                    OpportunityDetailPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Reopen slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen slider is not diplayed");
            }
        }

        public void ClickOnCloseLostExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseLostExpandIcon)))
                {
                    ClickCloseLostExpandIcon.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Closed Won/Close Lost expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closed Won/Close Lost expand icon is clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closed Won/Close Lost expand icon is clicked");
            }
        }

        public void ClickOnCloseLostOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickCloseLostOption)))
                {
                    ClickCloseLostOption.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Close lost option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close lost option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close lost option is not clicked");
            }
        }

        public void IsSelectLostCompetitorRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLostCompetitorRadioButton)))
                {
                    ClickLostCompetitorRadioButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Lost competitor radio button is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lost competitor radio button is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lost competitor radio button is not selected");
            }
        }

        public void ClickOnSaveButtonInCloseLostPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButtonInCloseLostPopup)))
                {
                    ClickSaveButtonInCloseLostPopup.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Save button is not clicked");
            }
        }

        //Select all checkbox

        public void SelecttheAllOpportunitiesCheckBox()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAllCheckboxOption)))
                {
                    ClickAllCheckboxOption.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("All Opportunities checkbox is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("All Opportunities checkbox is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("All Opportunities checkbox is not selected");
            }
        }

        public void IsCheckBoxSelected()
        {
            try
            {
              bool IscheckboxSelected=  CheckboxSelected.Selected;

                if (IscheckboxSelected)
                {                   
                    SUT.Log.DebugFormat("All Opportunities checkbox is selected");
                }
                else
                {
                    CheckboxSelected.Click();
                    SUT.Log.ErrorFormat("All Opportunities checkbox is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("All Opportunities checkbox is not selected");
            }
        }

        public void ClickOnThreeDotsIconforClosedOpportunities()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforClosedOpportunities)))
                {
                    ClickThreeDotsIconforClosedOpportunities.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked for closed won/lost opportunities");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for closed won/lost opportunities {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for closed won/lost opportunities ");
            }
        }

        public void ClickonCalenderIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCalenderIcon)))
                {
                    ClickCalenderIcon.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("");
                }
                else
                {
                    SUT.Log.ErrorFormat("All Opportunities checkbox is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("All Opportunities checkbox is not selected");
            }
        }

        //Reopen closed won/lost opportunities
        public void ClickonOkButtonInCalenderPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOkButtonInCalenderPopup)))
                {
                    ClickOkButtonInCalenderPopup.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Ok button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Ok button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Ok button is not clicked");
            }
        }

        public void ClickonOkReopenButtonInCalenderPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickReopenButtonInCalenderPopup)))
                {
                    ClickReopenButtonInCalenderPopup.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Reopen button is clicked in calender popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen button is not clicked in calender popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen button is not clicked in calender popup");
            }
        }

        public void SelectReopenOptionforClosedOpportunities()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenoptionforClosedOpportunities)))
                {
                    ReopenoptionforClosedOpportunities.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Reopen option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reopen option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reopen option is not clicked");
            }
        }

        //Closed won opportunity

        public void ClickonAgainBilltoexpandicon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAnywhere)))
                {
                    ClickAnywhere.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Ok button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Ok button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Ok button is not clicked");
            }
        }

        public void ClickOnCloseWonOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickCloseWonOption)))
                {
                    ClickCloseWonOption.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Close lost option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close lost option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close lost option is not clicked");
            }
        }

        public void ClickOnCloseFormManagerButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseFormmanagerButton)))
            {
                ClickCloseFormmanagerButton.Click();
                SUT.Log.DebugFormat("Complete button is clicked");
            }
            else
            {
                SUT.Log.ErrorFormat("Complete button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
            }
        }

        public void ClickonOpportunitiesLInkinLeadsPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOpportunitiesLinkInLeadsPage)))
                {
                    ClickOpportunitiesLinkInLeadsPage.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Opportunities link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities link is not clicked");
            }
        }

        //Enter the card details

        public void ClickonCaptureCardButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCaptureCardButton)))
                {
                    SalesCenterUtility.ScrollToElement(ClickCaptureCardButton);
                    ClickCaptureCardButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Opportunities link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities link is not clicked");
            }
        }

        public void IsCardNameEntered(string name)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EnterCardName)))
                {
                    EnterCardName.SendKeys(name);                  
                    SUT.Log.DebugFormat("Card name is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Card name is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Card name is not entered");
            }
        }

        public void ClickOnEnterButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickEnterButton)))
                {
                    ClickEnterButton.Click();
                    Thread.Sleep(15000);
                    SUT.Log.DebugFormat("Enter button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Enter button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Enter button is not clicked");
            }
        }

        public void ClickOnServiceExpandIconForMatchedOpportunity()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceExapndIconForMatchedOpportunity)))
                {
                    ClickServiceExapndIconForMatchedOpportunity.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Service expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service expand icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service expand icon is not clicked");
            }
        }

        public void EnterCardNumber(string cardnumber)
        {
            if (SalesCenterUtility.Frame_SafeSwitch(IframeName, () => CardNumber, 10))
            {
                SUT.Log.Debug("Safely switched to the payment iFrame");               
                    CardNumber.Click();
                    CardNumber.SendKeys(cardnumber);
                    SUT.Log.DebugFormat("Card number is entered");
           }  
        }

       
        public void EnterthedateandYear()
            
        {

            SelectElement month = new SelectElement(selmonth);
            month.SelectByIndex(3);
            Thread.Sleep(2000);

            SelectElement year = new SelectElement(selyear);
            year.SelectByIndex(5);
            Thread.Sleep(1000);
        }

        public void ClickOnAddCreditCardButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddcreditCardButton)))
                {
                    ClickAddcreditCardButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Add credit card button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add credit card button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add credit card button is not clicked");
            }
        }

        //Reassign sales team

        public void ClickOnReassignButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickReassignButton)))
                {
                    ClickReassignButton.Click();
                    SUT.Log.DebugFormat("Reassign button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reassign button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reassign button is not clicked");
            }
        }

        public void IsReassignSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReassignSliderIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    ReassignSliderIsDisplayed.Displayed.ToString();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Reassign slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Reassign slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Reassign slider is not diplayed");
            }
        }

        public void SelectSalesTeamInReassignSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesTeamField)))
                {
                    ClickSalesTeamField.Click();
                    SalesTeamNameInReassignSlider.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Sales team is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team is not selected");
            }
        }

        public void SelectSalesTeamMemberInReassignSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesTeamMemberField)))
                {
                    ClickSalesTeamMemberField.Click();
                    SalesTeamMemberInReassignSlider.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Sales team member is assigned");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team member is not assigned {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team member is not assigned");
            }
        }

        public void IsCloseRequirementMissingPopupDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseRequirementMissingPopup)))
                {
                    CloseRequirementMissingPopup.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Close requirements missing popup is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close requirements missing popup is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close requirements missing popup is not displayed");
            }
        }

        public void ClickOnCloseButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseButton)))
                {
                    ClickCloseButton.Click();
                    SUT.Log.DebugFormat("Close button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close button is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close button is not clicked");
            }
        }

        //Removing SC contacts

        public void ClickOnViewContactsLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewContactsLink)))
                {
                    ClickViewContactsLink.Click();
                    SUT.Log.DebugFormat("View Contacts link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View Contacts link is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View Contacts link is not clicked");
            }
        }

        public void ContactPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ContactPageDisplayed), TimeSpan.FromSeconds(4)))
                {
                    ContactPageDisplayed.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Contact page is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contact page is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contact page is not diplayed");
            }
        }

        public void ClickOnAddContactButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddContactButton)))
                {
                    ClickAddContactButton.Click();
                    SUT.Log.DebugFormat("Add contact button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact button is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact button is not clicked");
            }
        }

        public void IsAddContactSliderIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddOpportunityPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    AddOpportunityPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Add contact slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact slider is not diplayed");
            }
        }

        public void ClickOnSearchiconInContactSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSearchIconInContactSlider)))
                {
                    ClickSearchIconInContactSlider.Click();
                    SUT.Log.DebugFormat("Search icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Search icon is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Search icon is not clicked");
            }
        }

        public void EnterTheExistingContactName(string contactname)
        {
            Searchfield.SendKeys(contactname);
            Searchfield.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
           
        }

        public void ClickOnAddContactButtonInContactSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddContactButtonInContactSlider)))
                {
                    ClickAddContactButtonInContactSlider.Click();
                    SUT.Log.DebugFormat("Add contact button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add contact button is not clicked{0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add contact button is not clicked");
            }
        }

        public void ClickOnThreeDotsIconforAddedContacts()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforContacts)))
                {
                    ClickThreeDotsforContacts.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dot icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dot icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dot icon is not clicked ");
            }
        }

        public void ClickOnRemoveLinkforContacts()
        {
            try
            {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickRemoveLinkForContacts)))
                {
                    ClickRemoveLinkForContacts.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Remove link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Remove link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Remove link is not clicked");
            }
        }

        public void ClickOnRemoveButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickRemoveButtonInPopup)))
                {
                    ClickRemoveButtonInPopup.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Remove button is clicked in popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Remove button is not clicked in popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Remove button is not clicked in popup");
            }
        }

    }
}
