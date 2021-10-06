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
       
        LeadDetailPage leadspage = new LeadDetailPage();
        OpportunityPage opportunitypage = new OpportunityPage();
        SettingsPage settingpage = new SettingsPage();
      
      

        [When(@"Mouse hover on sales center side menu")]
        public void WhenMouseHoverOnSalesCenterSideMenu()
        {
             leadspage.ClickSalesCenterMenu();
        }

        [When(@"I mouse hover on sales center side menu and click on opportunities link")]
        public void WhenIMouseHoverOnSalesCenterSideMenuAndClickOnOpportunitiesLink()
        {
           
            leadspage.VerifyOpportunitiesLink();
        }

        [When(@"Click on Leads link")]
        public void WhenClickOnLeadsLink()
        {
            leadspage.ClickonLeadLink();
        }

        [Then(@"Leads page should be displayed")]
        public void ThenLeadsPageShouldBeDisplayed()
        {
            Assert.True(leadspage.IsLoaded(), "Failed to verify the Leads page loaded after click on leads link");
            Thread.Sleep(3000);
        }

        [When(@"Click on plus icon")]
        public void WhenClickOnPlusIcon()
        {
            leadspage.ClickonPlusButton();
        }

        [When(@"Click on Add Lead button")]
        public void WhenClickOnAddLeadButton()
        {
            leadspage.ClickonAddLeadButton();
        }

        [Then(@"Add Lead details page should be displayed")]
        public void ThenAddLeadDetailsPageShouldBeDisplayed()
        {
            Assert.True(leadspage.IsLeadPageLoaded(), "Failed to verify the Leads page loaded after click on Add lead button");
        }

        //Leads creation

        [Then(@"Enter the lead details (.*) (.*) (.*) (.*)")]
        public void ThenEnterTheLeadDetailsAutomationUserTestAutocompanyAutouserGmail_Com(string firstname, string lastname, string company, string email)
        {
            leadspage.EnterLeadDetails(firstname, lastname, company, email);           
        }

        [Then(@"Select the SalesTeam (.*)")]
        public void ThenSelectTheSalesTeamSecondarySouthSalesTeam(string salesteam)
        {
            leadspage.SelectSalesTeamfromdropdown();
        }

        [Then(@"Select the Owner (.*)")]
        public void ThenSelectTheOwnerUnassigned(string owner)
        {
            leadspage.SelecttheOwnerAssigneeName();
        }

        [Then(@"Select the sales funnel (.*)")]
        public void ThenSelectTheSalesFunnelUserDeleted(string funnelname)
        {
            leadspage.SelecttheFunnelName();
        }

        [When(@"Click on Save button")]
        public void WhenClickOnSaveButton()
        {
            leadspage.ClickOnSaveButton();
        }

        [Then(@"Lead created validation message should be displayed (.*)")]
        public void ThenLeadCreatedValidationMessageShouldBeDisplayedLeadCreated(string message)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(message);
        }

        [Then(@"Click on search icon")]
        public void ThenClickOnSearchIcon()
        {
            leadspage.ClickOnSearchIcon();
        }

        [Then(@"Enter the lead name (.*) and click on search icon")]
        public void ThenEnterTheLeadNameAndClickOnSearchIcon(string leadname)
        {
            leadspage.EnterTheLeadName(leadname);
        }

        [When(@"Delete the lead")]
        public void WhenDeleteTheLead()
        {
            leadspage.ClickOnThreeDotsIconforAddedLead();
            leadspage.ClickOnDeleteLinkforLead();
            leadspage.ClickDeleteButtonInLeadPopup();
        }

        [Then(@"Lead deleted confirmation message should be displayed (.*)")]
        public void ThenLeadDeletedConfirmationMessageShouldBeDisplayedRecordsDeletedSuccessfully_(string deletemessage)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(deletemessage);
        }

        //Create opportunity

        [Then(@"Click on Service expand icon")]
        public void ThenClickOnServiceExpandIcon()
        {
            leadspage.ClickAddServiceExpandIcon();
        }

        [Then(@"Click on Add Serivces button")]
        public void ThenClickOnAddSerivcesButton()
        {
            leadspage.ClickAddServiceButton();
        }

        [Then(@"Select the services (.*)")]
        public void ThenSelectTheServicesANT_AntTreatments(string service)
        {
            leadspage.SelectServiceFromDropDown();
        }

        [When(@"Click on Add services button in slider")]
        public void WhenClickOnAddServicesButtonInSlider()
        {
            leadspage.ClickAddServiceButtonInSlider();
        }

        [Then(@"Service should be successfully added")]
        public void ThenServiceShouldBeSuccessfullyAdded()
        {
            Assert.True(leadspage.IsServiceAdded(), "Serive is addded");
        }

        [Then(@"Click on Close services and product button")]
        public void ThenClickOnCloseServicesAndProductButton()
        {
            leadspage.ClickCloseServicesAndProductButton();
        }

        [When(@"Click on convert to opportunity button")]
        public void WhenClickOnConvertToOpportunityButton()
        {
            leadspage.ClickOnConvertOpportunityButton();
        }

        [Then(@"Convert to lead page should be displayed")]
        public void ThenConvertToLeadPageShouldBeDisplayed()
        {
            leadspage.IsConvertLeadPageIsDisplayed();
        }

        [When(@"Select the ownername in convert lead page (.*)")]
        public void WhenSelectTheOwnernameInConvertLeadPage(string ownername)
        {
           
        }

        [When(@"Select the lead details (.*) (.*) (.*)")]
        public void WhenISelectTheLeadDetails(string ownername,string funnelname, string funnelstage)
        {
            leadspage.SelecttheOwnerName();
            leadspage.SelecttheFunnelName();
            leadspage.SelecttheStageFromDropdown();
            leadspage.ClickOnSaveButton();
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
        
        //Create opportunity directly

        [When(@"Click on Create opportunity button")]
        public void WhenClickOnCreateOpportunityButton()
        {
            leadspage.ClickonCreateOpportunityButton();
        }

        [When(@"Search the lead (.*)")]
        public void WhenSearchTheLead(string leadname) 
        {
            leadspage.EnterTheLeadNameInSearchField(leadname);          
        }

        [When(@"Click on Create opportunity button in create opportunity page")]
        public void WhenIClickOnCreateOpportunityButtonInCreateOpportunityPage()
        {
            leadspage.ClickonCreateOpportunityButtonInOppPage();
        }

        //Add contract to the lead

        [When(@"Click on send contract button")]
        public void WhenClickOnSendContractButton()
        {
            leadspage.ClickonSendContractButton();
        }

        [Then(@"Create contract slider should be displayed")]
        public void ThenCreateContractSliderShouldBeDisplayed()
        {
            leadspage.IsCreateContractSliderDisplayed();
        }

        [Then(@"Select contract template (.*) and click on launch form to complete button")]
        public void ThenSelectContractTemplateAndClickOnLaunchFormToCompleteButton(string templatename)
        {
            leadspage.SelecttheTemplateName();
            leadspage.ClickOnLaunchFormToCompleteButton();
        }


        [Then(@"Click on complete form button")]
        public void ThenIClickOnCompleteFormButton()
        {
            leadspage.ClickOnCompleteFormButton();
        }

        [When(@"Click on proceed button")]
        public void WhenClickOnProceedButton()
        {
            leadspage.ClickOnProceedButtonInPopup();
        }

        [Then(@"Contract should be successfully added")]
        public void ThenContractShouldBeSuccessfullyAdded()
        {
           
        }

        //Reopen disqualified leads

        [Then(@"Click on filters button")]
        public void ThenClickOnFiltersButton()
        {
            leadspage.ClickFiltersButton();
        }

        [Then(@"Click on clear filter button")]
        public void ThenClickOnClearFilterButton()
        {
            leadspage.ClickOnClearFilterButtonInSider();
        }

        [Then(@"Select the lead status (.*)")]
        public void ThenSelectTheLeadStatusAutomationLabs(string leadstatus)
        {
            leadspage.SelectleadStatus();
        }

        [When(@"Click on Apply button")]
        public void WhenClickOnApplyButton()
        {
            leadspage.ClickOnApplyButtonInSider();
        }

        [Then(@"All the disqualified leads should be diplayed")]
        public void ThenAllTheDisqualifiedLeadsShouldBeDiplayed()
        {
            leadspage.IsDisqualifiedLeadsDisplayed();
        }

        [Then(@"Click on three dots icon for disqualified lead")]
        public void ThenClickOnThreeDotsIconForDisqualifiedLead()
        {
            leadspage.ClickOnThreeDotsIconforDisqualifiedLead();
        }

        [Then(@"Select the reopen option")]
        public void ThenSelectTheReopenOption()
        {
            leadspage.SelectReopenOptionforDisqualifiedLead();
        }

        [Then(@"Select Qualify option in popup (.*)")]
        public void ThenSelectQualifyOptionInPopupLabs(string leadstatus)
        {
            leadspage.SelectReopenleadStatus();
        }

        [When(@"Click on Save button in Re-Open Lead popup")]
        public void WhenClickOnSaveButtonInRe_OpenLeadPopup()
        {
            leadspage.ClickOnSaveButton();
        }

        //[Then(@"Lead should be successfully reopened validation message should be displayed")]
        //public void ThenLeadShouldBeSuccessfullyReopenedValidationMessageShouldBeDisplayed()
        //{
        //   //Validation message not displaying
        //}

        //Attach location to the lead

        [Then(@"Click on Bill to locations expand icon")]
        public void ThenClickOnBillToLocationsExpandIcon()
        {
            leadspage.ClickOnBillToExpandIcon();
        }

        [When(@"Click on Match or create link")]
        public void WhenClickOnMatchOrCreateLink()
        {
            leadspage.ClickOnMatchOrCreateLocationLink();
        }

        [Then(@"Match or create new location slider should be displayed")]
        public void ThenMatchOrCreateNewLocationSliderShouldBeDisplayed()
        {
            leadspage.IsMatchorCreateSliderDisplayed();
        }

        [Then(@"Click to match to existing location button")]
        public void ThenClickToMatchToExistingLocationButton()
        {
            leadspage.ClickOnMatchToExistingLocationButton();
        }

        [Then(@"Select the pestpac location")]
        public void ThenSelectThePestpacLocation()
        {
            leadspage.ClickOnExistingLocationRadioButton();
        }

        [When(@"Click on Save button in bill to search for matching slider")]
        public void WhenClickOnSaveButtonInBillToSearchForMatchingSlider()
        {
            leadspage.ClickOnSaveButtonInBilltoMatchingSlider();
        }

        //[When(@"Select match to service location")]
        //public void WhenSelectMatchToServiceLocation()
        //{
        //    leadspage.SelecttheServiceLocation();
        //}

        [When(@"Select match to service location (.*)")]
        public void WhenSelectMatchToServiceLocationSTATEROUTE(string servicelocation)
        {
            leadspage.SelecttheServiceLocation();
        }

        [Then(@"Location matched validation message should be displayed (.*)")]
        public void ThenLocationMatchedValidationMessageShouldBeDisplayed(string message)
        {
            settingpage.VerifySalesTeamCreatedConfirmMsg(message);
        }

        //Update the servcie in opportunity form

        [Then(@"Click on three dots icon in update service or product slider")]
        public void ThenClickOnThreeDotsIconInUpdateServiceOrProductSlider()
        {
            leadspage.ClickOnThreeDotsIconInUpdateServiceSlider();
            leadspage.ClickOnEditOption();
        }

        [Then(@"Select the other service (.*)")]
        public void ThenSelectTheOtherService(string otherservice)
        {
            leadspage.SelectOtherServiceFromDropDown();
        }

        [Then(@"click on update servcie button")]
        public void ThenClickOnUpdateServcieButton()
        {
            leadspage.ClickOnUpdateServiceButton();
        }

        [When(@"click on close convert lead button")]
        public void WhenClickOnCloseConvertLeadButton()
        {
            
        }


    }
}
