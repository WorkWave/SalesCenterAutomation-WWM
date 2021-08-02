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

        [FindsBy(How = How.XPath, Using = "(//p[text()='Leads'])[2]")]
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


        [FindsBy(How = How.XPath, Using = "//li[text()='AutoTestingSalesTeam']")]
        private IWebElement SelectSalesTeam { get { return PageFactory.Load(this); } }



        [FindsBy(How = How.Id, Using = "mui-component-select-assigneeId")]
        private IWebElement ClickOwnerAssigneeField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SelectOwnerAssigneeName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.Id, Using = "mui-component-select-salesFunnelId")]
        private IWebElement ClickFunnelField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Test reg sales funnel']")]
        private IWebElement SelectFunnelName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Save']/..")]
        private IWebElement ClickSaveButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@role='alert']")]
        private IWebElement LeadcreatedConfirm_Txt { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "//div[@class='MuiFormControl-root MuiTextField-root']")]
        private IWebElement ClickSearchIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[@class='MuiFormControl-root MuiTextField-root']/descendant::input")]
        private IWebElement EnterLeadname { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Automation user2 Test2']/../../../preceding-sibling::div/descendant::button[2]")]
        private IWebElement ClickThreeDotsforLead { get { return PageFactory.Load(this); } }


        [FindsBy(How = How.XPath, Using = "(//span[contains(@class,'MuiTypography-root MuiListItemText-primary')])[2]")]
        private IWebElement ClickDeleteLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//span[text()='Delete']/parent::button)[1]")]
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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesCenter)))
            {
                ClickSalesCenter.Click();
                Thread.Sleep(1000);
            }
        }
        public void ClickonLeadLink()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLeadLink)))
            {
                ClickLeadLink.Click();           
            }
        }
        public void ClickonPlusButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickPlusButton)))
            {
                ClickPlusButton.Click();             
            }
        }
        public void ClickonAddLeadButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
            {
                ClickAddLeadButton.Click();              
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
            ClickSalesTeamField.Click();
            PestPacUtility.ScrollToElement(SelectSalesTeam);
            SelectSalesTeam.Click();
        }
        public void SelecttheOwnerAssigneeName()
        {
            ClickOwnerAssigneeField.Click();
            PestPacUtility.ScrollToElement(SelectOwnerAssigneeName);
            SelectOwnerAssigneeName.Click();
        }

        public void SelecttheFunnelName()
        {
            ClickFunnelField.Click();
            PestPacUtility.ScrollToElement(SelectFunnelName);
            SelectFunnelName.Click();
        }

        public void ClickOnSaveButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButton)))
            {
                ClickSaveButton.Click();
            }
        }

        public bool VerifyLeadCreatedConfirmMsg(string message)
        {

            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadcreatedConfirm_Txt)))
            {
                SUT.Log.Debug("User is deleted message is displayed");
                Assert.True(LeadcreatedConfirm_Txt.Text.Contains(message), "Validation message is not matching");
                Thread.Sleep(7000);
                return true;
            }
            else
            {
                SUT.Log.Debug("Lead is created message is displayed");
                return false;
            }
        }
        public void ClickOnSearchIcon()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSearchIcon)))
            {
                ClickSearchIcon.Click();
            }
        }

        public void EnterTheLeadName(string leadname)
        {
            EnterLeadname.SendKeys(leadname);
            EnterLeadname.SendKeys(Keys.Enter);
        }

        public void ClickOnThreeDotsIconforAddedLead()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforLead)))
            {
                ClickThreeDotsforLead.Click();
            }
        }

        public void ClickOnDeleteLinkforLead()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteLink)))
            {
                ClickDeleteLink.Click();
            }
        }
        public void ClickDeleteButtonInLeadPopup()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeletebutton)))
            {
                ClickDeletebutton.Click();
            }
        }

        //Create opportunity
        public void ClickAddServiceExpandIcon()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceExapndIcon)))
            {
                ClickServiceExapndIcon.Click();
            }
        }

        public void ClickAddServiceButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceButton)))
            {
                PestPacUtility.ScrollToElement(ClickServiceButton);
                ClickServiceButton.Click();
            }
        }

        public void SelectServiceFromDropDown()
        {            
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceField)))
            {
               ClickServiceField.Click();
                Thread.Sleep(2000);
               SelectServicename.Click();
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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => CloseServicesButton)))
            {
                CloseServicesButton.Click();
            }
        }
        public void ClickOnConvertOpportunityButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickConvertOpportunityButton)))
            {
               ClickConvertOpportunityButton.Click();
               Thread.Sleep(5000);
            }
        }

        public void ClickAddServiceButtonInSlider()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickServiceButtonInSlider)))
            {              
                ClickServiceButtonInSlider.Click();
            }
        }

        public void IsConvertLeadPageIsDisplayed()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ConvertLeadPageIsDisplayed)))
            {
                ConvertLeadPageIsDisplayed.Displayed.ToString();
            }
        }
        public void SelecttheStageFromDropdown()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => StageField)))
            {
                PestPacUtility.ScrollToElement(StageField);
                StageField.Click();
                SelectStageName.Click();
            }           
        }

        public void SelecttheOwnerName()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickOwnerField)))
            {
                ClickOwnerField.Click();
                Thread.Sleep(2000);
                SelectOwnerName.Click();
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
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
            {
                ClickCreateOpportunityButton.Click();
            }
        }

        public void EnterTheLeadNameInSearchField(string leadname)
        {
            EnterTheLeadname.SendKeys(leadname);
            EnterTheLeadname.SendKeys(Keys.Enter);
        }

        public void ClickonCreateOpportunityButtonInOppPage()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickCreateOpportunityButtonInOppPage)))
            {
                ClickCreateOpportunityButtonInOppPage.Click();
                Thread.Sleep(5000);
            }
        }
        #endregion Selenium

    }
}
