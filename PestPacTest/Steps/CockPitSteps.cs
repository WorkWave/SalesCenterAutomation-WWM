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
        private PestPacData pestPacData;
        private MainPage mainPage;

        public CockPitSteps(PestPacData pestPacData)
        {
            this.pestPacData = pestPacData;
            mainPage = new MainPage();
        }

       [Then(@"Verify the Leads opportunities and Leads to Qualify cards are displayed on dashboard")]
        public void ThenVerifyTheLeadsOpportunitiesAndLeadsToQualifyCardsAreDisplayedOnDashboard()
        {
            cockpitpage.IsLeadsCardDisplayed();
            cockpitpage.IsOpportunitiesCardDisplayed();
            cockpitpage.IsLeadsToQualifyCardDisplayed();
        }

    }
}
