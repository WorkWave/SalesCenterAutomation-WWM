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
    public class LeadSteps : TestSteps
    {
        private PestPacData pestPacData;

        private MainPage mainPage;
        private LeadDetailPage leadDetailPage;
        LeadDetailPage leadspage = new LeadDetailPage();
        SettingsPage settingpage = new SettingsPage();

        //  private ViewLeadsPage viewLeadsPage;
        // private AddCustomerPage addCustomerPage;




        public LeadSteps(PestPacData pestPacData)
        {
            this.pestPacData = pestPacData;
            mainPage = new MainPage();
            leadDetailPage = new LeadDetailPage();
        }



        [When(@"I mouse hover on sales center side menu")]
        public void WhenIMouseHoverOnSalesCenterSideMenu()
        {
            leadspage.ClickSalesCenterMenu();
        }

        [When(@"I click on Leads link")]
        public void WhenIClickOnLeadsLink()
        {
            Assert.True(leadspage.IsLoaded(), "Failed to verify the Leads page loaded after click on leads link");
        }

        [Then(@"Leads page should be displayed")]
        public void ThenLeadsPageShouldBeDisplayed()
        {
            leadspage.ClickonLeadLink();
        }

        [When(@"I click on plus icon")]
        public void WhenIClickOnPlusIcon()
        {
            leadspage.ClickonPlusButton();
        }

        [When(@"I click on Add Lead button")]
        public void WhenIClickOnAddLeadButton()
        {
            leadspage.ClickonAddLeadButton();
        }

        [Then(@"Add Lead details page should be displayed")]
        public void ThenAddLeadDetailsPageShouldBeDisplayed()
        {
            Assert.True(leadspage.IsLeadPageLoaded(), "Failed to verify the Leads page loaded after click on Add lead button");
        }

        //Leads creation



        [Then(@"I enter the lead details (.*) (.*) (.*) (.*)")]
        public void ThenIEnterTheLeadDetailsAutomationUserTestAutocompanyAutouserGmail_Com(string name, string lastname, string company, string email)
        {
            leadspage.EnterLeadDetails(name, lastname, company, email);
        }

        [Then(@"I select the sales team (.*)")]
        public void ThenISelectTheSalesTeamAutoTestingSalesTeam(string salesteamname)
        {
            leadspage.SelectSalesTeamfromdropdown();
        }

        [Then(@"I select the owner (.*)")]
        public void ThenISelectTheOwner(string ownername)
        {
            leadspage.SelecttheOwnerName();
        }

        [Then(@"I select the sales funnel (.*)")]
        public void ThenISelectTheSalesFunnelUserDeleted(string funnelname)
        {
            leadspage.SelecttheFunnelName();
        }

        [When(@"I click on Save button")]
        public void WhenIClickOnSaveButton()
        {
            leadspage.ClickOnSaveButton();
        }

        [Then(@"Lead created validation message should be displayed (.*)")]
        public void ThenLeadCreatedValidationMessageShouldBeDisplayedLeadCreated(string message)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(message);
        }


        [Then(@"I click on search icon")]
        public void ThenIClickOnSearchIcon()
        {
            leadspage.ClickOnSearchIcon();
        }

        [Then(@"I enter the lead name (.*) and click on search icon")]
        public void ThenIEnterTheLeadNameAndClickOnSearchIcon(string leadname)
        {
            leadspage.EnterTheLeadName(leadname);
        }

        [Then(@"I click on three dots icon")]
        public void ThenIClickOnThreeDotsIcon()
        {
            leadspage.ClickOnThreeDotsIconforAddedLead();
        }

        [Then(@"I click on delete link for added lead")]
        public void ThenIClickOnDeleteLinkForAddedLead()
        {
            leadspage.ClickOnDeleteLinkforLead();
        }

        [When(@"I click on Delete button in delete lead popup")]
        public void WhenIClickOnDeleteButtonInDeleteLeadPopup()
        {
            leadspage.ClickDeleteButtonInLeadPopup();
        }


        [Then(@"Lead deleted confirmation message should be displayed (.*)")]
        public void ThenLeadDeletedConfirmationMessageShouldBeDisplayedRecordsDeletedSuccessfully_(string deletemessage)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(deletemessage);
        }





    }

}
