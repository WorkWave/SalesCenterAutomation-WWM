using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using OpenQA.Selenium;
using WorkWave.PestPac.TA.Model;
using WorkWave.PestPac.TA.SharedData;
using WorkWave.TA.TestEngine;
using System.Linq;
using System.Threading;

namespace WorkWave.PestPac.TA.Steps
{
    [Binding]
    class CockPitSteps : TestSteps
    {
        CockPitPage cockpitpage = new CockPitPage();
        private SalesCenterData salesCenterData;
        private MainPage mainPage;
        LeadDetailPage leadspage = new LeadDetailPage();

        public CockPitSteps(SalesCenterData salesCenterData)
        {
            this.salesCenterData = salesCenterData;
            mainPage = new MainPage();
        }

       [Then(@"Verify the Leads opportunities and Leads to Qualify cards are displayed on dashboard")]
        public void ThenVerifyTheLeadsOpportunitiesAndLeadsToQualifyCardsAreDisplayedOnDashboard()
        {
            cockpitpage.IsLeadsCardDisplayed();
            cockpitpage.IsOpportunitiesCardDisplayed();
            cockpitpage.IsLeadsToQualifyCardDisplayed();
        }

        [Then(@"Verify the  default dispay of Records with Overdue Next Action Dates on dashboard")]
        public void ThenVerifyTheDefaultDispayOfRecordsWithOverdueNextActionDatesOnDashboard()
        {
            cockpitpage.IsOverdueNextActionDatesDisplayed();
            cockpitpage.IsLeadsCardDisplayed();
            cockpitpage.IsOpportunitiesCardDisplayed();
        }

        [Then(@"Verify the Contract History is displayed on dashboard")]
        public void ThenVerifyTheContractHistoryIsDisplayedOnDashboard()
        {
            cockpitpage.IsContractHistoryDisplayed();
        }


        [Then(@"Verify the default dispay of Upcoming Follow-Ups on dashboard")]
        public void ThenVerifyTheDefaultDispayOfUpcomingFollow_UpsOnDashboard()
        {
            cockpitpage.IsUpcomingfollowupsDisplayed();
        }

        //Sales funnel summary

        [When(@"Sales funnel summary button")]
        public void WhenSalesFunnelSummaryButton()
        {
            cockpitpage.ClickOnSalesFunnelSummaryButton();
        }

        [Then(@"Sales funnel summary page should be displayed")]
        public void ThenSalesFunnelSummaryPageShouldBeDisplayed()
        {
            cockpitpage.IsSalesFunnelSummaryPageIsDisplayed();
        }

        [When(@"Click on Funel stage expand icon")]
        public void WhenClickOnFunelStageExpandIcon()
        {
            cockpitpage.ClickOnSalesFunnelStageExpandIcon();
        }

        [Then(@"Lead statuses and opportunity stages details should be displayed")]
        public void ThenLeadStatusesAndOpportunityStagesDetailsShouldBeDisplayed()
        {
            cockpitpage.IsLeadStatusesDetailsDisplayed();
            cockpitpage.IsOpportunityStagesDetailsDisplayed();
        }

        [Then(@"Get the lead name and count")]
        public void ThenGetTheLeadNameAndCount()
        {
            cockpitpage.IsLeadCountDisplayed();
        }


        [When(@"Click on View leads button")]
        public void WhenClickOnViewLeadsButton()
        {
            cockpitpage.ClickOnViewLeadsButton();
        }

        [Then(@"Leads page should be displayed and  Same leads count should be displayed in leads page")]
        public void ThenLeadsPageShouldBeDisplayedAndSameLeadsCountShouldBeDisplayedInLeadsPage()
        {
            cockpitpage.IsLeadCountDisplayedInLeadsPage();
        }

        [Then(@"Navigate back to dashboard")]
        public void ThenNavigateBackToDashboard()
        {
            leadspage.ClickSalesCenterMenu();
            cockpitpage.ClickonDashboardLink();

        }

        [Then(@"Get the opportinity stage name and count")]
        public void ThenGetTheOpportinityStageNameAndCount()
        {
            cockpitpage.IsOpportunityCountDisplayed();
        }

        [When(@"Click on View opportinities button")]
        public void WhenClickOnViewOpportinitiesButton()
        {
            cockpitpage.ClickOnViewOpportunitiesButton();
        }

        [Then(@"Opportunity page should be displayed and Same opportunities count should be displayed in opportunity page")]
        public void ThenOpportunityPageShouldBeDisplayedAndSameOpportunitiesCountShouldBeDisplayedInOpportunityPage()
        {
            cockpitpage.IsOpportunityCountDisplayedInOpportunityPage();
        }


    }
}
