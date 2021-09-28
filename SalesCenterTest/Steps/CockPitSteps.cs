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

    }
}
