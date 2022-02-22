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

        [FindsBy(How = How.XPath, Using = "//span[text(),'Upcoming Follow-Ups']")]
        private IWebElement UpcomingfollowupsDisplayed { get { return PageFactory.Load(this); } }
        
        [FindsBy(How = How.XPath, Using = "//span[text()='Manage Contracts']")]
        private IWebElement ContractHistory { get { return PageFactory.Load(this); } }

        #region Sales funnel summary

        [FindsBy(How = How.XPath, Using = "//*[local-name()='svg' and @data-icon='funnel-dollar']")]
        private IWebElement ClickSalesFunnelSummaryButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Sales Funnel Summary']")]
        private IWebElement SalesFunnelSummaryPageIsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Funnel Stage Details'])[2]")]
        private IWebElement ClickSalesFunnelStageExpandIcon { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Lead Statuses']")]
        private IWebElement LeadStatusesDetailsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Opportunity Stages']")]
        private IWebElement OpportunityStagesDetailsDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Count: '])[1]")]
        private IWebElement LeadCountDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Status'])[1]")]
        private IWebElement LeadStagenameDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Leads'])[1]")]
        private IWebElement ClickViewLeadsButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[contains(text(),'Narrowed to 2  Leads')]")]
        private IWebElement LeadCountDisplayedInLeadsPage { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//p[text()='Dashboard']")]
        private IWebElement ClickDashboardLink { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//p[text()='Count: '])[5]")]
        private IWebElement OpportunityCountDisplayed { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "(//button[text()='Opportunities'])[1]")]
        private IWebElement ClickViewOpportunitiesButton { get { return PageFactory.Load(this); } }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Narrowed to')]")]
        private IWebElement OpportunityCountDisplayedInOpportunityPage { get { return PageFactory.Load(this); } }

        
        #endregion Sales funnel summary

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
                    SalesCenterUtility.ScrollToElement(LeadsToQualifyCards);
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

        public void IsUpcomingfollowupsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => UpcomingfollowupsDisplayed)))
                {
                    UpcomingfollowupsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Upcoming follow-ups  is diplayed on dashboard");
                }
                else
                {
                    SUT.Log.ErrorFormat("Upcoming follow-ups  is not diplayed on dashboard {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Upcoming follow-ups  is not diplayed on dashboard");
            }
        }

        //Sales funnel summary

        public void ClickOnSalesFunnelSummaryButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesFunnelSummaryButton)))
                {
                    ClickSalesFunnelSummaryButton.Click();
                    Thread.Sleep(5000);
                    SUT.Log.DebugFormat("Sales funnel summary button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel summary button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel summary button is not clicked");
            }
        }

        public void IsSalesFunnelSummaryPageIsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => SalesFunnelSummaryPageIsDisplayed)))
                {
                    SalesFunnelSummaryPageIsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Sales funnel summary page is displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales funnel summary page is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales funnel summary page is not displayed");
            }
        }

        public void ClickOnSalesFunnelStageExpandIcon()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickSalesFunnelStageExpandIcon)))
                {
                    ClickSalesFunnelStageExpandIcon.Click();
                    Thread.Sleep(2000);
                    SUT.Log.DebugFormat("Sales Funnel stage expand icon is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Sales Funnel stage expand icon is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Sales Funnel stage expand icon is not clicked");
            }
        }

        public void IsLeadStatusesDetailsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadStatusesDetailsDisplayed)))
                {
                    LeadStatusesDetailsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Lead statuses details displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead statuses details not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead statuses details not displayed");
            }
        }

        public void IsOpportunityStagesDetailsDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OpportunityStagesDetailsDisplayed)))
                {
                    OpportunityStagesDetailsDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Opportunity stages details displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunity stages details not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunity stages details not displayed");
            }
        }

        public void IsLeadStagenameDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadStagenameDisplayed)))
                {
                    LeadStagenameDisplayed.Displayed.ToString();
                    SUT.Log.DebugFormat("Lead stage name is displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Lead stage name is not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Lead stage name is not displayed");
            }
        }
        public void IsLeadCountDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadCountDisplayed)))
                {
                    string text = LeadCountDisplayed.Text;

                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Leads count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Leads count displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Leads count not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Leads count not displayed");
            }
        }

        public void ClickOnViewLeadsButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewLeadsButton)))
                {
                    ClickViewLeadsButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("View leads button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("View leads button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("View leads button is not clicked");
            }
        }

        public void IsLeadCountDisplayedInLeadsPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => LeadCountDisplayedInLeadsPage)))
                {
                    string text = LeadCountDisplayedInLeadsPage.Text;

                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Leads count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Leads count displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Leads count not displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Leads count not displayed");
            }
        }

        public void ClickonDashboardLink()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickDashboardLink)))
                {
                    ClickDashboardLink.Click();
                    Thread.Sleep(5000);
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

        public void IsOpportunityCountDisplayed()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OpportunityCountDisplayed)))
                {
                    string text = OpportunityCountDisplayed.Text;

                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Opportunities count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Opportunity Count Displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunity Count not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunity Count not Displayed");
            }
        }

        public void ClickOnViewOpportunitiesButton()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => ClickViewOpportunitiesButton)))
                {
                    SalesCenterUtility.ScrollToElement(ClickViewOpportunitiesButton);
                    ClickViewOpportunitiesButton.Click();
                    Thread.Sleep(4000);
                    SUT.Log.DebugFormat("Opportunities button is clicked");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunities button is not clicked {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunities button is not clicked");
            }
        }

        public void IsOpportunityCountDisplayedInOpportunityPage()
        {
            try
            {
                if (SeleniumUtility.WaitFor(CustomExpectedConditions.ElementIsVisible(() => OpportunityCountDisplayedInOpportunityPage)))
                {
                    string text = OpportunityCountDisplayedInOpportunityPage.Text;

                    Regex re = new Regex(@"[0-9]+");

                    var match = re.Matches(text);
                    foreach (Match m in match)
                    {
                        Console.WriteLine("Opportunities count is:::" + m.Value);
                    }

                    SUT.Log.DebugFormat("Opportunity Count Displayed");
                }
                else
                {
                    SUT.Log.ErrorFormat("Opportunity Count not Displayed {0}", MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (WebDriverTimeoutException)
            {
                SUT.Log.ErrorFormat("Opportunity Count not Displayed");
            }
        }
    }
}
