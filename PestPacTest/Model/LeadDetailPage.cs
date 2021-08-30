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

namespace WorkWave.PestPac.TA.Model
{
    public class LeadDetailPage : IWebPage
    {
        #region PageFactory

        [FindsBy(How = How.XPath, Using = "//p[text()='Leads']")]
        private IWebElement PageHeader { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='button']//p/..")]
        private IWebElement ClickSalesCenter { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Leads']")]
        private IWebElement ClickLeadLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[@class='MuiButton-label']/../preceding-sibling::button)[1]")]
        private IWebElement ClickPlusButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='Add Lead']/..")]
        private IWebElement ClickAddLeadButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Add Lead']")]
        private IWebElement leadPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "firstName")]
        private IWebElement FirstNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Name, Using = "lastName")]
        private IWebElement LastNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "company")]
        private IWebElement CompanyNamefield { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Name, Using = "emailAddress")]
        private IWebElement EmailNamefield { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@id='mui-component-select-salesTeamId']")]
        private IWebElement ClickSalesTeamField { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//li[text()='Testing sales Team']")]
        private IWebElement SelectSalesTeam { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.Id, Using = "mui-component-select-assigneeId")]
        private IWebElement ClickOwnerAssigneeField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SelectOwnerAssigneeName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "mui-component-select-salesFunnelId")]
        private IWebElement ClickFunnelField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Required Contract & Payment']")]
        private IWebElement SelectFunnelName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Save']/..")]
        private IWebElement ClickSaveButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement LeadcreatedConfirm_Txt { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@class='MuiFormControl-root MuiTextField-root']")]
        private IWebElement ClickSearchIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiFormControl-root MuiTextField-root']/descendant::input")]
        private IWebElement EnterLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='autocompany2']/../../../preceding-sibling::div/descendant::button[2]")]
        private IWebElement ClickThreeDotsforLead { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//span[contains(@class,'MuiTypography-root MuiListItemText-primary')])[2]")]
        private IWebElement ClickDeleteLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@id='root']/following-sibling::div[5]/descendant::button[2]")]
        private IWebElement ClickDeletebutton { get { return PageFactory.Load(this); } }

        #region Create opportunity

        [FindsBy(How = How.XPath, Using = "(//p[text()='Service ('])[1]")]
        private IWebElement ClickServiceExapndIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[@class='MuiButton-label']//span/../..)[1]")]
        private IWebElement ClickServiceButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@id='services']/../..")]
        private IWebElement ClickServiceField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = " //li[text()='ANT- Ant Treatments']")]
        private IWebElement SelectServicename { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[text()='ANT']")]
        private IWebElement servicePage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Close Services and Products']/..")]
        private IWebElement CloseServicesButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Convert to Opportunity'])[1]/..")]
        private IWebElement ClickConvertOpportunityButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Add Service']/..")]
        private IWebElement ClickServiceButtonInSlider { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Convert Lead']")]
        private IWebElement ConvertLeadPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='opportunityStageId']/..")]
        private IWebElement StageField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Stage1']")]
        private IWebElement SelectStageName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@name='ownerId']/..")]
        private IWebElement ClickOwnerField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SelectOwnerName { get { return PageFactory.Load(this); } }


        #endregion Create opportunity

        #region Create oportunity directly

        [FindsBy(How = How.XPath, Using = "//div[text()='Create Opportunity']/..")]
        private IWebElement ClickCreateOpportunityButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search']")]
        private IWebElement EnterTheLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Create Opportunity'])[2]/..")]
        private IWebElement ClickCreateOpportunityButtonInOppPage { get { return PageFactory.Load(this); } }

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

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Launch Form to Complete')]/..")]
        private IWebElement ClickLaunchFormToCompleteButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Proceed')]")]
        private IWebElement ClickProceedButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//button[text()='Complete Form']")]
        private IWebElement ClickCompleteFormButton { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[text()='This form has been completed.']")]
        private IWebElement ContractIsAdded { get { return PageFactory.Load(this); } }

        
        #endregion Add contract to the lead


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
                    Thread.Sleep(1000);
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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => leadPage)))
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
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOwnerAssigneeField)))
                {
                    ClickOwnerAssigneeField.Click();
                    PestPacUtility.ScrollToElement(SelectOwnerAssigneeName);
                    SelectOwnerAssigneeName.Click();
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
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickFunnelField)))
                {
                    PestPacUtility.ScrollToElement(ClickFunnelField);
                    ClickFunnelField.Click();
                    PestPacUtility.ScrollToElement(SelectFunnelName);
                    SelectFunnelName.Click();
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
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButton)))
                {
                    ClickSaveButton.Click();
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
                    PestPacUtility.ScrollToElement(ClickServiceButton);
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

        private readonly string ServicePage = "ANT";
        public bool IsServiceAdded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => servicePage)))
            {
                if (servicePage.Text.TrimStart().StartsWith(ServicePage))
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

        public void ClickCloseServicesAndProductButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseServicesButton)))
                {
                    CloseServicesButton.Click();
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
                    Thread.Sleep(5000);
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
                    PestPacUtility.ScrollToElement(StageField);
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

        //Add contract to the elad

        public void ClickonSendContractButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSendContractButton)))
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
                    Thread.Sleep(15000);
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

        public void ClickOnCompleteFormButton()
        {           
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCompleteFormButton)))
                {               
                ClickCompleteFormButton.Click();
                    SUT.Log.DebugFormat("Complete button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Complete button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
                       
        }

        public void ClickOnProceedButtonInPopup()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickProceedButton)))
                {
                    ClickProceedButton.Click();
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
    }



    #endregion Selenium

}   

