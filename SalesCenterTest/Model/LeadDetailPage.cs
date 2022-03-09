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
using System.Text.RegularExpressions;

namespace WorkWave.PestPac.TA.Model
{
    public class LeadDetailPage : IWebPage
    {
        #region PageFactory

        [FindsBy(How = How.XPath, Using = "//p[text()='Leads']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='button']//img[1]")]
        private IWebElement ClickSalesCenter { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Leads'])[2]")]
        private IWebElement ClickLeadLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='addBtn']")]
        private IWebElement ClickPlusButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='addLeadBtn']")]
        private IWebElement ClickAddLeadButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Add Lead']")]
        private IWebElement leadPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement FirstNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "company")]
        private IWebElement CompanyNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "emailAddresses[0].emailAddress")]
        private IWebElement EmailNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//input[@name='salesTeamId']/..")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//li[text()='Testing sales Team']")]
        private IWebElement SelectSalesTeam { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//input[@name='assigneeId']/..")]
        private IWebElement ClickOwnerAssigneeField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SelectOwnerAssigneeName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='salesFunnelId']/..")]
        private IWebElement ClickFunnelField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Required Contract & Payment')]")]
        private IWebElement SelectFunnelName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Save']")]
        private IWebElement ClickSaveButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement LeadcreatedConfirm_Txt { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@data-test-id='searchInputField']")]
        private IWebElement ClickSearchIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Name, email, phone, address, location']")]
        private IWebElement EnterLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='autocompany2']/../../../preceding-sibling::div/descendant::button[2]")]
        private IWebElement ClickThreeDotsforLead { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//span[text()='Delete']")]
        private IWebElement ClickDeleteLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='okBtn'])[1]")]
        private IWebElement ClickDeletebutton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'ANT')]")]
        private IWebElement ServcieAdded { get { return PageFactory.Load(this); } }

       

        #region Create opportunity

        [FindsBy(How = How.XPath, Using = "(//div[contains(@data-test-id,'cardFooter')])[1]")]
        private IWebElement ClickServiceExapndIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'serviceBtn')]")]
        private IWebElement ClickServiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='services']/../..")]
        private IWebElement ClickServiceField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = " //li[text()='ANT- Ant Treatments']")]
        private IWebElement SelectServicename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='ANT']")]
        private IWebElement servicePage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Close Services and Products')]")]
        private IWebElement CloseServicesButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='autocompany03']/../../../preceding-sibling::div/descendant::div/div[2]/child::button[1])[1]")]
        private IWebElement ClickConvertOpportunityButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add Service']")]
        private IWebElement ClickServiceButtonInSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Services or Products Added']")]
        private IWebElement ConvertLeadPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='opportunityStageId']/..")]
        private IWebElement StageField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Stage1']")]
        private IWebElement SelectStageName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='ownerId']/..")]
        private IWebElement ClickOwnerField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SelectOwnerName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "mui-component-select-salesFunnelId")]
        private IWebElement FunnelField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'Test Sales funnel')]")]
        private IWebElement FunnelName { get { return PageFactory.Load(this); } }

        #endregion Create opportunity

        #region Create oportunity directly

        [FindsBy(How = How.XPath, Using = "//div[text()='Create Opportunity']/..")]
        private IWebElement ClickCreateOpportunityButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement EnterTheLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Create Opportunity'])[1]")]
        private IWebElement ClickCreateOpportunityButtonInOppPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Choose one or more service locations related to this Bill-to']/../preceding-sibling::div")]
        private IWebElement CreateOpportunityPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Add Opportunity']")]
        private IWebElement AddOpportunityPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Add Additional Service or Product']")]
        private IWebElement ClickAddAdditionalServiceOrProductButton { get { return PageFactory.Load(this); } }
      
        #endregion create opportunity directly


        #region Delete Opportunity

     [FindsBy(How = How.XPath, Using = "(//p[text()='Opportunities'])[2]")]
        private IWebElement ClickOpportunitiesLink { get { return PageFactory.Load(this); } }




        #endregion Delete Opportunity

        #region Add contract to the lead

        [FindsBy(How = How.XPath, Using = "//span[text()='Send Contract']/../..")]
        private IWebElement ClickSendContractButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Create Contract']")]
        private IWebElement CreateContractPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Select Contract Template')]/..")]
        private IWebElement ClickTemplateField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Residential Service Form']")]
        private IWebElement SelectContractTemplate { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Launch Form to Complete']")]
        private IWebElement ClickLaunchFormToCompleteButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Proceed')]")]
        private IWebElement ClickProceedButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Complete Form']")]
        private IWebElement ClickCompleteFormButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='This form has been completed.']")]
        private IWebElement ContractIsAdded { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'mui')]")]
        private IWebElement ReopenLeadStatusField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='This form has been completed.']")]
        private IWebElement LeadStatusField { get { return PageFactory.Load(this); } }


        #endregion Add contract to the lead

        #region Reopen disqualified leads


        [FindsBy(How = How.XPath, Using = "//button[@data-test-id='filterBtn']")]
        private IWebElement ClickOnFilterButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Lead Status']")]
        private IWebElement LeadStatusExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Disqualified']")]
        private IWebElement LeadStatusName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Apply']")]
        private IWebElement ClickApplyButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//div[@class='sc-hGPBjI hYnhmQ actions']/descendant::button[2])[1]")]
        private IWebElement ClickThreeDotsIconforDisqualified { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Re-Open']")]
        private IWebElement ReopenoptionforDisqualifiedlead { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Qualify']")]
        private IWebElement ReopenLeadStatusName { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Open']")]
        private IWebElement LeadStatusOpenField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Reset Filters to Default']")]
        private IWebElement ClickClearFilterButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Disqualified']/..")]
        private IWebElement DisqualifiedLeadDisplayed { get { return PageFactory.Load(this); } }

        #endregion Reopen disqualified leads


        #region Attach a lead to location

        [FindsBy(How = How.XPath, Using = "//p[text()='autocompany03']/../descendant::button")]
        private IWebElement ClickBillToExpandButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//a[text()='Match / Create New']")]
        private IWebElement ClickMatchOrCreateLocationLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Match / Create New Location']")]
        private IWebElement MatchorCreateNewLocationSliderDisplayed { get { return PageFactory.Load(this); } }

      
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Match To Existing Location')]")]
        private IWebElement ClickMatchToExistingLocationButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Match Bill-to'])[1]")]
        private IWebElement ClickExistingLocationRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Save'])[2]")]
        private IWebElement ClickSaveButtonInBilltoMatchingSlider { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Select Service Location']")]
        private IWebElement ClickServiceLocationField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[contains(text(),'3600 STATE ROUTE 66')]")]
        private IWebElement SelectServiceLocationName { get { return PageFactory.Load(this); } }

        #endregion Attach a lead to location


        #region Update service

        [FindsBy(How = How.XPath, Using = "//div[text()='ANT']/../../descendant::button")]
        private IWebElement ClickThreeDotsIconInSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='BEDBUG- Bed Bug Treatment']")]
        private IWebElement SelectOtherServicename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Update Service']")]
        private IWebElement ClickUpdateServiceButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@data-test-id='editBtn']")]
        private IWebElement ClickEditOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='View Services Added']")]
        private IWebElement ClickViewServicesAddedLink { get { return PageFactory.Load(this); } }







        #endregion Update service


        #region Create new location in PP

        [FindsBy(How = How.XPath, Using = "//button[text()='Create New Location']")]
        private IWebElement ClickCreatenewLocationTab { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Create New Location']")]
        private IWebElement CreateNewLocationPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='editCardFooterBtn'])[1]")]
        private IWebElement ClickBillToEditButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "address1")]
        private IWebElement AddressNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "city")]
        private IWebElement CityNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "state")]
        private IWebElement StateNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "postalCode")]
        private IWebElement PostalcodeNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Update Bill-To Location']")]
        private IWebElement UpdateLocationSliderDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[@data-test-id='editCardFooterBtn'])[2]")]
        private IWebElement ClickServiceLocationEditButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Save'])[2]")]
        private IWebElement ClickSaveButtonInUpdateLocationSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='A Service Location has been added successfully.']")]
        private IWebElement ServiceLocationValidationConfirm_Txt { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='Locations Created Successfully']")]
        private IWebElement NewLocationValidationConfirm_Txt { get { return PageFactory.Load(this); } }

        #endregion Create new location in PP

        #region Duplicate alerts

        [FindsBy(How = How.XPath, Using = "//span[@class='MuiIconButton-label']//input/../../../..")]
        private IWebElement ToggleButtonOn { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Duplicate Alert')]")]
        private IWebElement DuplicateAlertCountDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Duplicate Alert')]")]
        private IWebElement ClickDuplicateAlertLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Duplicate Alert']")]
        private IWebElement DuplicateAlertPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Close Duplicate Alert')]")]
        private IWebElement ClickCloseDuplicateAlertButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//span[text()='Results']/..)[1]")]
        private IWebElement SameDuplicateAlertCountIsDisplayed { get { return PageFactory.Load(this); } }




        #endregion Duplicate alerts

        #region Invalid card info

        [FindsBy(How = How.XPath, Using = "//span[text()=': INVALID CARD INFO']")]
        private IWebElement InvalidCardErrorMessage_Txt { get { return PageFactory.Load(this); } }


        #endregion Invalid card info

        #region verify captre card button

        [FindsBy(How = How.XPath, Using = "//button[contains(@data-test-id,'paymentBtn')]")]
        private IWebElement MouseHoverCaptureCardButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='tooltip']//div[1]")]
        private IWebElement CatureCardButtonWarningToastmessage { get { return PageFactory.Load(this); } }


        #endregion verify captre card button

        #region Disqualified the lead

        [FindsBy(How = How.XPath, Using = "(//div[@role='button'])[2]")]
        private IWebElement ClickLeadStatusField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Disqualified']")]
        private IWebElement DisqualifiedOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//h2[text()='Disqualified']")]
        private IWebElement DisqualifiedPopupIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Not Interested']")]
        private IWebElement NotInterestedRadioButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='SAVE']")]
        private IWebElement SaveButtonInDisqualifiedPopup { get { return PageFactory.Load(this); } }

      
        #endregion Disqualified the lead

        #endregion PageFactory

        private readonly string PageHeaderText = "Leads";


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

        #region Selenium
    
        public void ClickSalesCenterMenu()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesCenter)))
                {
                    ClickSalesCenter.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Send center menu  is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Send center menu  is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Send contract button is not clicked");
            }
        }

        public void ClickonLeadLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLeadLink)))
                {
                    ClickLeadLink.Click();
                    SUT.Log.DebugFormat("Lead link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead link is not clicked");
            }
        }


        public void ClickonPlusButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickPlusButton)))
                {
                    ClickPlusButton.Click();
                    SUT.Log.DebugFormat("Plus icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Plus icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Plus icon is not clicked");
            }
        }
        public void ClickonAddLeadButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
                {
                    ClickAddLeadButton.Click();
                    SUT.Log.DebugFormat("Add lead button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add lead button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add lead button is not clicked");
            }
        }

        private readonly string LeadsPage = "Add Lead";
        public bool IsLeadPageLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => leadPage), TimeSpan.FromSeconds(10)))
            {
                if (leadPage.Text.TrimStart().StartsWith(LeadsPage))
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

        //Lead creation
        public void EnterLeadDetails(string firstname, string lastname, string company, string email)
        {
            FirstNamefield.SendKeys(firstname);
            Thread.Sleep(1000);
            LastNamefield.SendKeys(lastname);
            Thread.Sleep(1000);
            CompanyNamefield.SendKeys(company);
            Thread.Sleep(1000);
            EmailNamefield.SendKeys(email);
            Thread.Sleep(1000);
        }

        public void SelectSalesTeamfromdropdown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesTeamField)))
                {
                  //  PestPacUtility.ScrollToElement(SelectSalesTeam);
                    ClickSalesTeamField.Click();                  
                    SelectSalesTeam.Click();
                    SUT.Log.DebugFormat("Sales team selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales team is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales team is not selected from the dropdown");
            }

        }
        public void SelecttheOwnerAssigneeName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickOwnerAssigneeField), TimeSpan.FromSeconds(10)))
                {
                    ClickOwnerAssigneeField.Click();
                    SalesCenterUtility.ScrollToElement(SelectOwnerAssigneeName);
                    SelectOwnerAssigneeName.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Owner selected from the dropdown");
                }
                else
                {

                    SUT.Log.ErrorFormat("Owner is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Owner is not selected from the dropdown");
            }
        }

        public void SelecttheFunnelName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickFunnelField), TimeSpan.FromSeconds(10)))
                {
                    SalesCenterUtility.ScrollToElement(ClickFunnelField);
                    ClickFunnelField.Click();
                    Thread.Sleep(3000);
                  //  SalesCenterUtility.ScrollToElement(SelectFunnelName);
                    SelectFunnelName.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Sales funnel selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel  is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel is not selected from the dropdown");
            }
        }

        public void ClickOnSaveButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickSaveButton)))
                {
                    ClickSaveButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Save button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Save button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Save button is not clicked ");
            }
        }

        public bool VerifyLeadCreatedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadcreatedConfirm_Txt)))
            {
                SUT.Log.Debug("Validation message is dislayed");
                Assert.True(LeadcreatedConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(7000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is not dislayed");
                return false;
            }
        }
        public void ClickOnSearchIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSearchIcon)))
                {
                    ClickSearchIcon.Click();
                    SUT.Log.DebugFormat("Search icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Search icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Search icon is not clicked ");
            }
        }

        public void EnterTheLeadName(string leadname)
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => EnterLeadname)))
                {
                    EnterLeadname.SendKeys(leadname);
                    EnterLeadname.SendKeys(Keys.Enter);
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Lead name is entered");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead name is not entered {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead name is not entered ");
            }
        }

        public void ClickOnThreeDotsIconforAddedLead()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforLead)))
                {
                    ClickThreeDotsforLead.Click();
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

        public void ClickOnDeleteLinkforLead()
        {
            try {

                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteLink)))
                {
                    ClickDeleteLink.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Delete link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete link is not clicked");
            }
        }
        public void ClickDeleteButtonInLeadPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeletebutton)))
                {
                    ClickDeletebutton.Click();
                    SUT.Log.DebugFormat("Delete button is clicked in popup");
                }
                else
                {
                    SUT.Log.ErrorFormat("Delete button is not clicked in popup {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Delete button is not clicked in popup");
            }
        }

        //Create opportunity
        public void ClickAddServiceExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceExapndIcon)))
                {
                    ClickServiceExapndIcon.Click();
                    Thread.Sleep(3000);
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

        public void ClickAddServiceButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceButton)))
                {
                    SalesCenterUtility.ScrollToElement(ClickServiceButton);
                    ClickServiceButton.Click();
                    SUT.Log.DebugFormat("Add service button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add service button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add service button is not clicked");
            }
        }

        public void SelectServiceFromDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceField)))
                {
                    ClickServiceField.Click();
                    Thread.Sleep(2000);
                    SelectServicename.Click();
                    SUT.Log.DebugFormat("Service selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service is not selected from the dropdown");
            }
        }

        public void IsServiceAdded()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServcieAdded), TimeSpan.FromSeconds(10)))
                {
                    ServcieAdded.Displayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Service added");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service is not added {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service is not added");
            }
        }


        public void ClickCloseServicesAndProductButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseServicesButton)))
                {
                    Thread.Sleep(5000);
                    CloseServicesButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Closeservice and product button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closeservice and product button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closeservice and product button is not clicked");
            }
        }
        public void ClickOnConvertOpportunityButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickConvertOpportunityButton)))
                {                  
                    ClickConvertOpportunityButton.Click();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Closeservice and product button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Closeservice and product button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Closeservice and product button is not clicked");
            }
        }

        public void ClickAddServiceButtonInSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceButtonInSlider)))
                {
                    ClickServiceButtonInSlider.Click();
                    Thread.Sleep(6000);
                    SUT.Log.DebugFormat("Add service button is clicked in the slider");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add service button is not clicked in the slider {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add service button is not clicked in the slider");
            }
        }

        public void IsConvertLeadPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ConvertLeadPageIsDisplayed)))
                {
                    ConvertLeadPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Convert lead page is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Convert lead page is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Convert lead page is not diplayed");
            }
        }
        public void SelecttheStageFromDropdown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => StageField)))
                {
                 //   SalesCenterUtility.ScrollToElement(StageField);
                    StageField.Click();
                    SelectStageName.Click();
                    SUT.Log.DebugFormat("Stage is selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Stage is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Stage is not selected from the droddown");
            }
        }

        public void SelecttheOwnerName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOwnerField)))
                {
                    SalesCenterUtility.ScrollToElement(ClickOwnerField);
                    ClickOwnerField.Click();
                    Thread.Sleep(2000);
                    SelectOwnerName.Click();
                    SUT.Log.DebugFormat("Owner selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Owner is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Owner is not selected from the dropdown");
            }
        }
        
        public void VerifyOpportunitiesLink()
        {
            Actions actions = new Actions(SUT.Web.WebDriver);
            actions.MoveToElement(ClickSalesCenter).Build().Perform();
            actions.MoveToElement(ClickOpportunitiesLink).Click().Perform();
        }
      
        //Create opportunity directly

        public void ClickonCreateOpportunityButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
                {
                    ClickCreateOpportunityButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Create opportunity button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity button is not clicked");
            }
        }

        public void EnterTheLeadNameInSearchField(string leadname)
        {
            EnterTheLeadname.SendKeys(leadname);
            EnterTheLeadname.SendKeys(Keys.Enter);
        }

        public void ClickonCreateOpportunityButtonInOppPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCreateOpportunityButtonInOppPage)))
                {
                    ClickCreateOpportunityButtonInOppPage.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Create opportunity button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity button is not clicked");
            }
        }

        public void IsCreateOpportunitySliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CreateOpportunityPageIsDisplayed)))
                {
                    CreateOpportunityPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Create opportunity slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity slider is diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity slider is diplayed");
            }
        }

        public void IsAddOpportunityPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => AddOpportunityPageIsDisplayed),TimeSpan.FromSeconds(10)))
                {
                    AddOpportunityPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Create opportunity slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create opportunity slider is diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create opportunity slider is diplayed");
            }
        }

        public void ClickAddAdditionalServiceorProductButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddAdditionalServiceOrProductButton)))
                {
                    ClickAddAdditionalServiceOrProductButton.Click();
                    SUT.Log.DebugFormat("Add additional service or product button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Add additional service or product button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Add additional service or product button is not clicked");
            }
        }


        //Add contract to the elad

        public void ClickonSendContractButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSendContractButton),TimeSpan.FromSeconds(5)))
                {
                    ClickSendContractButton.Click();
                    SUT.Log.DebugFormat("Send contract button is clicked");                  
                }
                else
                {
                    SUT.Log.ErrorFormat("Send contract button is not clicked {0}", MethodBase.GetCurrentMethod().Name);                    
                }
               
            } 
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Send contract button is not clicked");
            }
        }

        public void IsCreateContractSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CreateContractPageIsDisplayed)))
                {
                    CreateContractPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Create Contrcat slider is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create Contrcat slider is not diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create Contrcat slider is not diplayed");
            }
        }

        public void SelecttheTemplateName()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickTemplateField)))
                {
                    ClickTemplateField.Click();
                 //   PestPacUtility.ScrollToElement(SelectContractTemplate);
                    SelectContractTemplate.Click();
                    SUT.Log.DebugFormat("Contract template selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract template is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract template is not selected from the dropdown");
            }
        }

        public void ClickOnLaunchFormToCompleteButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLaunchFormToCompleteButton)))
                {
                    ClickLaunchFormToCompleteButton.Click();
                    Thread.Sleep(20000);
                    SUT.Log.DebugFormat("Launch form button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Launch form button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Launch form button is not clicked ");
            }
        }

        public void ClickOnProceedButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickProceedButton)))
                {
                    ClickProceedButton.Click();
                    Thread.Sleep(3000);
                    SUT.Log.DebugFormat("Proceed button in popup is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Proceed button in popup is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Proceed button in popup is not clicked ");
            }
        }

        public void IsContractIsAdded()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ContractIsAdded)))
                {
                    ContractIsAdded.Displayed.ToString();
                    SUT.Log.DebugFormat("Contract is added");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract is not added {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract is not added");
            }
        }

        public void ClickFiltersButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOnFilterButton)))
                {
                    Thread.Sleep(4000);
                    ClickOnFilterButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Filters button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Filters button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Filters button is not clicked ");
            }
        }

        public void SelectleadStatus()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadStatusExpandIcon)))
                {
                    SalesCenterUtility.ScrollToElement(LeadStatusExpandIcon);
                    LeadStatusExpandIcon.Click();
                    Thread.Sleep(1000);
                    LeadStatusOpenField.Click();
                    Thread.Sleep(1000);
                    LeadStatusName.Click();
                    SUT.Log.DebugFormat("Lead status is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status is not selected");
            }
        }

        public void ClickOnApplyButtonInSider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickApplyButton)))
                {
                    ClickApplyButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Apply button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Apply button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Apply button is not clicked ");
            }
        }

        public void ClickOnThreeDotsIconforDisqualifiedLead()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconforDisqualified)))
                {
                    ClickThreeDotsIconforDisqualified.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Three dots icon is clicked for Disqualified lead");
                }
                else
                {
                    SUT.Log.ErrorFormat("Three dots icon is not clicked for Disqualified lead {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Three dots icon is not clicked for Disqualified lead ");
            }

        }

        public void SelectReopenOptionforDisqualifiedLead()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenoptionforDisqualifiedlead)))
                {
                    ReopenoptionforDisqualifiedlead.Click();
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

        public void SelectReopenleadStatus()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ReopenLeadStatusField)))
                {
                    ReopenLeadStatusField.Click();
                    Thread.Sleep(2000);
                    ReopenLeadStatusName.Click();
                    SUT.Log.DebugFormat("Lead status is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status is not selected");
            }
        }

        public void ClickOnClearFilterButtonInSider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickClearFilterButton)))
                {
                    ClickClearFilterButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Clear filter button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Clear filter button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Clear filter button is not clicked ");
            }
        }

        public void IsDisqualifiedLeadsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DisqualifiedLeadDisplayed)))
                {
                    DisqualifiedLeadDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Contract is added");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract is not added {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract is not added");
            }
        }

        public void ClickOnBillToExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBillToExpandButton)))
                {
                    ClickBillToExpandButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Bill to location expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bill to location expand icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bill to location expand icon is not clicked ");
            }
        }

        public void ClickOnMatchOrCreateLocationLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickMatchOrCreateLocationLink)))
                {
                    ClickMatchOrCreateLocationLink.Click();
                    SUT.Log.DebugFormat("Match/Create new location is clicked");
                }
                else
                {
                    SUT.Log.DebugFormat("Location matched");
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match/Create new location is not clicked ");
            }
        }

        public void IsMatchorCreateSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MatchorCreateNewLocationSliderDisplayed)))
                {
                    MatchorCreateNewLocationSliderDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Match or create new location slider is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match or create new location slider is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match or create new location slider is not displayed");
            }
        }

        public void ClickOnMatchToExistingLocationButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickMatchToExistingLocationButton)))
                {
                    ClickMatchToExistingLocationButton.Click();
                    SUT.Log.DebugFormat("Match to existing location button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match to existing location button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match to existing location button is not clicked");
            }
        }

        public void ClickOnSaveButtonInBilltoMatchingSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButtonInBilltoMatchingSlider)))
                {
                    ClickSaveButtonInBilltoMatchingSlider.Click();
                    SUT.Log.DebugFormat("Match to existing location button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match to existing location button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match to existing location button is not clicked");
            }
        }

        public void ClickOnExistingLocationRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickExistingLocationRadioButton)))
                {
                    ClickExistingLocationRadioButton.Click();
                    SUT.Log.DebugFormat("Existing location radio button is selected");
                }
                else
                {
                    SUT.Log.ErrorFormat("Existing location radio button is not selected {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Existing location radio button is selected");
            }
        }

        public void SelecttheServiceLocation()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceLocationField)))
                {
                    SalesCenterUtility.ScrollToElement(ClickServiceLocationField);
                    ClickServiceLocationField.Click();
                    Thread.Sleep(2000);
                    SelectServiceLocationName.Click();
                    SUT.Log.DebugFormat("Service location is selected from the dropdown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service location is not selected from the dropdown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service location is not selected from the dropdown");
            }
        }

        //Update service in opportunity form

        public void ClickOnThreeDotsIconInUpdateServiceSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsIconInSlider)))
                {
                    ClickThreeDotsIconInSlider.Click();
                    SUT.Log.DebugFormat("Match to existing location button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match to existing location button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match to existing location button is not clicked");
            }
        }

        public void ClickOnEditOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickEditOption)))
                {
                    ClickEditOption.Click();
                    SUT.Log.DebugFormat("Edit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Edit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Edit button is not clicked");
            }
        }

        public void SelectOtherServiceFromDropDown()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceField)))
                {
                    ClickServiceField.Click();
                    Thread.Sleep(2000);
                    SelectOtherServicename.Click();
                    SUT.Log.DebugFormat("Service selected from the droddown");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service is not selected from the droddown {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service is not selected from the dropdown");
            }
        }

        public void ClickOnUpdateServiceButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickUpdateServiceButton)))
                {
                    ClickUpdateServiceButton.Click();
                    SUT.Log.DebugFormat("Update service button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Update service button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Update service button is not clicked");
            }
        }

        public void ClickOnViewServicesAddedLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewServicesAddedLink)))
                {
                    ClickViewServicesAddedLink.Click();
                    SUT.Log.DebugFormat("View services added link is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View services added link is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View services added link is not clicked");
            }
        }

        //Create new location in PP

        public void ClickOnCreateNewLocationTab()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCreatenewLocationTab)))
                {
                    ClickCreatenewLocationTab.Click();
                    SUT.Log.DebugFormat("Create New location tab is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create New location tab is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create New location tab is not clicked");
            }
        }

        public void IsCreateNewLocationDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() =>CreateNewLocationPageIsDisplayed), TimeSpan.FromSeconds(10)))
                {
                    CreateNewLocationPageIsDisplayed.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Create new location page is diplayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Create new location page is diplayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Create new location page is diplayed");
            }
        }

        public void ClickOnBillToEditButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickBillToEditButton)))
                {
                    ClickBillToEditButton.Click();
                    Thread.Sleep(8000);
                    SUT.Log.DebugFormat("Bill-to Edit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Bill-to Edit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Bill-to Edit button is not clicked");
            }
        }

        public void IsUpdateLocationSliderDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpdateLocationSliderDisplayed)))
                {
                    UpdateLocationSliderDisplayed.Displayed.ToString();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Match or create new location slider is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Match or create new location slider is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Match or create new location slider is not displayed");
            }
        }

        public void EnterLocationAddressDetails(string address, string city, string state, string postalcode)
        {
            SalesCenterUtility.ScrollToElement(AddressNamefield);
            AddressNamefield.Clear();
            AddressNamefield.SendKeys(address);
            AddressNamefield.SendKeys(Keys.Enter);
            Thread.Sleep(1000);

            CityNamefield.Clear();
            CityNamefield.SendKeys(city);
            Thread.Sleep(1000);

            StateNamefield.Clear();
            StateNamefield.SendKeys(state);
            Thread.Sleep(1000);

            PostalcodeNamefield.Clear();
            PostalcodeNamefield.SendKeys(postalcode);
            Thread.Sleep(1000);
        }

        public void ClickOnServiceLocationEditButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceLocationEditButton)))
                {
                    ClickServiceLocationEditButton.Click();
                    SUT.Log.DebugFormat("Service location Edit button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Service location Edit button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Service location Edit button is not clicked");
            }
        }

        public void ClickOnSaveButtonInUpdateLocationSlider()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButtonInUpdateLocationSlider)))
                {
                    ClickSaveButtonInUpdateLocationSlider.Click();
                    Thread.Sleep(10000);
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

        public bool VerifyServiceLocationAddedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ServiceLocationValidationConfirm_Txt)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(ServiceLocationValidationConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(12000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is displayed");
                return false;
            }
        }

        public bool VerifyNewLocationCreatedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => NewLocationValidationConfirm_Txt)))
            {
                SUT.Log.Debug("Validation  message is displayed");
                Assert.True(NewLocationValidationConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(12000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Validation message is not displayed");
                return false;
            }
        }

        //Duplicate alerts

        public void EnableToggleButtonOn()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ToggleButtonOn)))
                {
                    ToggleButtonOn.Click();
                    Thread.Sleep(1000);
                    SUT.Log.DebugFormat("Show only required fields toggle button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Show only required fields toggle button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Show only required fields toggle button is not clicked");
            }
        }

        public void EnterLeadFirstName(string firstname)
        {
            FirstNamefield.SendKeys(firstname);
            FirstNamefield.SendKeys(Keys.Enter);
            Thread.Sleep(6000);
        }

        public void IsDuplicateAlertCountDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DuplicateAlertCountDisplayed)))
                {
                    string text = DuplicateAlertCountDisplayed.Text;
            
                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach(Match m in match)
                    {
                        Console.WriteLine("Duplicate alert count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Duplicate alerts are displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Duplicate alerts are not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Duplicate alerts are not displayed");
            }
        }

        public void ClickOnDuplicateAlertLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDuplicateAlertLink)))
                {
                    ClickDuplicateAlertLink.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Duplicate alert page is displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Duplicate alert page is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Duplicate alert page is not displayed");
            }
        }

        public void IsDuplicatePageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DuplicateAlertCountDisplayed)))
                {
                    string text = SameDuplicateAlertCountIsDisplayed.Text;
           
                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Duplicate alert count is:::" +m.Value);
                    }

                    SUT.Log.DebugFormat("Duplicate alerts same count diplayed in duplicate alerts page");
                }
                else
                {
                    SUT.Log.ErrorFormat("Duplicate alerts same count is not diplayed in duplicate alerts page {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Duplicate alerts same count is not diplayed in duplicate alerts page");
            }
        }

        public void ClickOnCloseDuplicateAlertButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCloseDuplicateAlertButton)))
                {
                    ClickCloseDuplicateAlertButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Close duplicate alert button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Close duplicate alert button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Close duplicate alert button is not clicked");
            }
        }

        //Verifying invliad card info

        public bool VerifyInvalidCardErrorMessage(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => InvalidCardErrorMessage_Txt)))
            {
                SUT.Log.Debug("Error  message is displayed");
                Assert.True(InvalidCardErrorMessage_Txt.Text.Contains(message), "Error  message is not displayed");
                Thread.Sleep(4000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Error  message is not displayed");
                return false;
            }
        }

        //Validate capture card button

        public void MouseHoverOnCaptureCardButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => MouseHoverCaptureCardButton)))
                {
                    SalesCenterUtility.ScrollToElement(MouseHoverCaptureCardButton);
                    Thread.Sleep(2000);
                    Assert.AreEqual(false, MouseHoverCaptureCardButton.Enabled);                  
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Capture card button is disabled");
                }
                else
                {
                    Assert.AreEqual(true, MouseHoverCaptureCardButton.Enabled);
                    SUT.Log.ErrorFormat("Capture card button is enabled {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Capture card button is enabled");
            }
        }

        public bool VerifyCatureCardButtonWarningToastmessage(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CatureCardButtonWarningToastmessage)))
            {
                SUT.Log.Debug("Toast  message is displayed");
                Assert.True(CatureCardButtonWarningToastmessage.Text.Contains(message), "Toast  message is not displayed");
                Thread.Sleep(4000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Toast  message is not displayed");
                return false;
            }
        }

        //Disqualified the lead

        public void ClickOnLeadStatusField()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLeadStatusField)))
                {
                    ClickLeadStatusField.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Lead status dropdown is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead status dropdown is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead status dropdown is not clicked");
            }
        }

        public void SelectDisqualifiedOption()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DisqualifiedOption)))
                {
                    DisqualifiedOption.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Disqualified option is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Disqualified option is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Disqualified option is not clicked");
            }
        }

        public void IsDisqualifiedPopupIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => DisqualifiedPopupIsDisplayed)))
                {
                    DisqualifiedPopupIsDisplayed.Displayed.ToString();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Disqualified popup is displayed ");
                }
                else
                {
                    SUT.Log.ErrorFormat("Disqualified popup is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Disqualified popup is not displayed");
            }
        }

        public void ClickOnNotInterestedRadioButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => NotInterestedRadioButton)))
                {
                    NotInterestedRadioButton.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Not interested radio button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Not interested radio button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Not interested radio button is not clicked");
            }
        }

        public void ClickOnSaveButtonInDisqualifiedPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SaveButtonInDisqualifiedPopup)))
                {
                    SaveButtonInDisqualifiedPopup.Click();
                    Thread.Sleep(5000);
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

       

       

    }

}



    #endregion Selenium



