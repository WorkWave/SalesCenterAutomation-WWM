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
    class OpportunityPage : IWebPage
    {
        #region PageFactory

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

        [FindsBy(How = How.XPath, Using = "//div[text()='Open']")]
        private IWebElement OpportunitiesStatusOpenField { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//li[text()='Closed']")]
        private IWebElement OpportunitiesStatusName { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Narrowed to Opportunities')]")]
        private IWebElement ClosedOpportunitiesDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Reopen')]")]
        private IWebElement ReopenPageIsDisplayed { get { return PageFactory.Load(this); } }

        #region Select all the checkbox in listview

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[1]/..")]
        private IWebElement ClickAllCheckboxOption { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//input[@type='checkbox'])[1]/..")]
        private IWebElement CheckboxSelected { get { return PageFactory.Load(this); } }

        #endregion Select all the checkbox in listview


        #endregion PageFactory
        private readonly string PageHeaderText = "Opportunities";

        public bool IsLoaded()
        {
            if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => PageHeader),TimeSpan.FromSeconds(10)))
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
                    Thread.Sleep(5000);
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
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickFirstOpportunitiesCheckbox)))
                {
                    ClickFirstOpportunitiesCheckbox.Click(); 
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

    }
}
