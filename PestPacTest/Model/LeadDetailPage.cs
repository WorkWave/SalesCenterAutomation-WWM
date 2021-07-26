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

        [FindsBy(How = How.XPath, Using = "//div[@role='button']//p")]
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
        private IWebElement ClickOwnerField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Unassigned']")]
        private IWebElement SelectOwnerName { get { return PageFactory.Load(this); } }

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
               // Thread.Sleep(2000);
            }
        }

        public void ClickonLeadLink()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickLeadLink)))
            {
                ClickLeadLink.Click();
             //   Thread.Sleep(2000);
            }
        }

        public void ClickonPlusButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickPlusButton)))
            {
                ClickPlusButton.Click();
              //  Thread.Sleep(2000);
            }
        }

        public void ClickonAddLeadButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickAddLeadButton)))
            {
                ClickAddLeadButton.Click();
                Thread.Sleep(2000);
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
            Thread.Sleep(2000);
            PestPacUtility.ScrollToElement(SelectSalesTeam);
            SelectSalesTeam.Click();

        }


        public void SelecttheOwnerName()
        {
            ClickOwnerField.Click();
            Thread.Sleep(2000);
            PestPacUtility.ScrollToElement(SelectOwnerName);
            SelectOwnerName.Click();

        }

        public void SelecttheFunnelName()
        {
            ClickFunnelField.Click();
            Thread.Sleep(2000);
            PestPacUtility.ScrollToElement(SelectFunnelName);
            SelectFunnelName.Click();
        }

        public void ClickOnSaveButton()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSaveButton)))
            {
                ClickSaveButton.Click();
                Thread.Sleep(2000);
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


        //if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsEnabled(() => ClickListViewButton)))
        //{

        //    PestPacUtility.DbleClick(SUT.Web.WebDriver, ClickListViewButton);
        //    return true;
        //}
        //else
        //{
        //    SUT.Log.ErrorFormat("Could not find element in method {0}", MethodBase.GetCurrentMethod().Name);
        //    return false;
        //}



        public void ClickOnSearchIcon()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSearchIcon)))
            {
                ClickSearchIcon.Click();
                Thread.Sleep(2000);
            }
        }

        public void EnterTheLeadName(string leadname)
        {
            EnterLeadname.SendKeys(leadname);
            EnterLeadname.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        public void ClickOnThreeDotsIconforAddedLead()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickThreeDotsforLead)))
            {
                ClickThreeDotsforLead.Click();
                Thread.Sleep(2000);
            }
        }

        public void ClickOnDeleteLinkforLead()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeleteLink)))
            {
                ClickDeleteLink.Click();
                Thread.Sleep(2000);
            }
        }


        public void ClickDeleteButtonInLeadPopup()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDeletebutton)))
            {
                ClickDeletebutton.Click();
                Thread.Sleep(2000);
            }
        }






        #endregion Selenium



    }
}
