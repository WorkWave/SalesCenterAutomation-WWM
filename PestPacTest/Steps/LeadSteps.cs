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
        OpportunityPage opportunitypage = new OpportunityPage();
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

        [When(@"I mouse hover on sales center side menu and click on opportunities link")]
        public void WhenIMouseHoverOnSalesCenterSideMenuAndClickOnOpportunitiesLink()
        {
           
            leadspage.VerifyOpportunitiesLink();
        }


        [When(@"I click on Leads link")]
        public void WhenIClickOnLeadsLink()
        {
            leadspage.ClickonLeadLink();
        }

        [Then(@"Leads page should be displayed")]
        public void ThenLeadsPageShouldBeDisplayed()
        {
            Assert.True(leadspage.IsLoaded(), "Failed to verify the Leads page loaded after click on leads link");           
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
            leadspage.SelecttheOwnerAssigneeName();
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

        //Create opportunity

        [Then(@"I click on Service expand icon")]
        public void ThenIClickOnServiceExpandIcon()
        {
            leadspage.ClickAddServiceExpandIcon();
        }

        [Then(@"Click on Add Serivces button")]
        public void ThenClickOnAddSerivcesButton()
        {
            leadspage.ClickAddServiceButton();
        }

        [Then(@"I select the services (.*)")]
        public void ThenISelectTheServicesANT_AntTreatments(string service)
        {
            leadspage.SelectServiceFromDropDown();
        }

        [When(@"I click on Add services button in slider")]
        public void WhenIClickOnAddServicesButtonInSlider()
        {
            leadspage.ClickAddServiceButtonInSlider();
        }

        [Then(@"service should be successfully added")]
        public void ThenServiceShouldBeSuccessfullyAdded()
        {
            Assert.True(leadspage.IsServiceAdded(), "Serive is addded");
        }

        [Then(@"I click on Close services and product button")]
        public void ThenIClickOnCloseServicesAndProductButton()
        {
            leadspage.ClickCloseServicesAndProductButton();
        }

        [When(@"I click on convert to opportunity button")]
        public void WhenIClickOnConvertToOpportunityButton()
        {
            leadspage.ClickOnConvertOpportunityButton();
        }

        [Then(@"Convert to lead page should be displayed")]
        public void ThenConvertToLeadPageShouldBeDisplayed()
        {
            leadspage.IsConvertLeadPageIsDisplayed();
        }

        [When(@"I select the ownername in convert lead page (.*)")]
        public void WhenISelectTheOwnernameInConvertLeadPage(string ownername)
        {
            leadspage.SelecttheOwnerName();
        }

        [When(@"I select the funnel stage Stage(.*)")]
        public void WhenISelectTheFunnelStageStage(string funnelstage)
        {
            leadspage.SelecttheStageFromDropdown();
        }

        [Then(@"validation message should be displayed (.*)")]
        public void ThenValidationMessageShouldBeDisplayed(string message)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(message);
        }

        //Delete opportunity
        
        [Then(@"Opportunities page should be displayed")]
        public void ThenOpportunitiesPageShouldBeDisplayed()
        {
            Assert.True(opportunitypage.IsLoaded(), "Failed to verify the Opportunity page loaded after click on opportunities link");
        }

        //[Then(@"Opporunities deleted confirmation message should be displayed Opportunity Deleted")]
        //public void ThenOpporunitiesDeletedConfirmationMessageShouldBeDisplayedOpportunityDeleted()
        //{
           
        //}
    }
}
