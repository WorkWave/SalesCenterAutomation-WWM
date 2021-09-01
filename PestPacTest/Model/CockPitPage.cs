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
    class CockPitPage :IWebPage
    {

        #region PageFactory

        [FindsBy(How = How.XPath, Using = "//p[text()='Leads']")]
        private IWebElement LeadsCards { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Opportunities']")]
        private IWebElement OpportunitiesCards { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Leads to Qualify']")]
        private IWebElement LeadsToQualifyCards { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Records with Overdue Next Action Dates']")]
        private IWebElement OverdueNextActionDates { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//span[text()='Manage Contracts']")]
        private IWebElement ContractHistory { get { return PageFactory.Load(this); } }
        
        #endregion PageFactory



        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public void IsLeadsCardDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadsCards)))
                {
                    LeadsCards.Displayed.ToString();
                    SUT.Log.DebugFormat("Leads card  is diplayed on dashboard");
                }
                else
                {
                    SUT.Log.ErrorFormat("Leads card  is not diplayed on dashboard {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Leads card  is not diplayed on dashboard");
            }
        }

        public void IsOpportunitiesCardDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OpportunitiesCards)))
                {
                    OpportunitiesCards.Displayed.ToString();
                    SUT.Log.DebugFormat("Opportunities card  is diplayed on dashboard");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities card  is not diplayed on dashboard {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities card  is not diplayed on dashboard");
            }
        }

        public void IsLeadsToQualifyCardDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadsToQualifyCards)))
                {
                    PestPacUtility.ScrollToElement(LeadsToQualifyCards);
                    LeadsToQualifyCards.Displayed.ToString();
                    SUT.Log.DebugFormat("Leads To Qualify card  is diplayed on dashboard");
                }
                else
                {
                    SUT.Log.ErrorFormat("Leads To Qualify card  is not diplayed on dashboard {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Leads To Qualify card  is not diplayed on dashboard");
            }
        }

        //Overdue next action dates

        public void IsOverdueNextActionDatesDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OverdueNextActionDates)))
                {       
                    OverdueNextActionDates.Displayed.ToString();
                    SUT.Log.DebugFormat("Overdue next action dates is diplayed on dashboard");
                }
                else
                {
                    SUT.Log.ErrorFormat("Overdue next action dates is not diplayed on dashboard {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Overdue next action dates is not diplayed on dashboard");
            }
        }

        public void IsContractHistoryDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ContractHistory)))
                {
                    ContractHistory.Displayed.ToString();
                    SUT.Log.DebugFormat("Contract history is diplayed on dashboard");
                }
                else
                {
                    SUT.Log.ErrorFormat("Contract history is not diplayed on dashboard {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Contract history is not diplayed on dashboard");
            }
        }
    }
}
