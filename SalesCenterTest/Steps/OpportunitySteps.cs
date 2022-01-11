using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WorkWave.PestPac.TA.Model;
using WorkWave.PestPac.TA.SharedData;
using WorkWave.TA.TestEngine;

namespace WorkWave.PestPac.TA.Steps
{
    [Binding]
    public class OpportunitySteps : TestSteps
    {
      
        OpportunityPage opportunitypage = new OpportunityPage();
        LeadDetailPage leadspage = new LeadDetailPage();

        [When(@"Click on Opportunities link")]
        public void WhenClickOnOpportunitiesLink()
        {
            opportunitypage.ClickonOpportunitiesLink();
        }

        [Then(@"Select the opportunity status (.*)")]
        public void ThenSelectTheOpportunityStatusClosed(string opportunitiesstatus)
        {
            opportunitypage.SelectOpportunitiesStatus();
        }

        [Then(@"All the closed opportunities should be displayed")]
        public void ThenAllTheClosedOpportunitiesShouldBeDisplayed()
        {
            opportunitypage.IsClosedOpportunitiesDisplayed();
        }

        [Then(@"Click on List view button")]
        public void ThenClickOnListViewButton()
        {
            opportunitypage.ClickonListViewButton();
        }

        [Then(@"Select the multiple opportunities")]
        public void ThenSelectTheMultipleOpportunities()
        {
            opportunitypage.SelecttheOpportunities();
        }

        [When(@"Click on Reopen button")]
        public void WhenClickOnReopenButton()
        {
            opportunitypage.ClickOnBulkReopenButton();
        }

        [Then(@"Reopen slider should be displayed")]
        public void ThenReopenSliderShouldBeDisplayed()
        {
            opportunitypage.IsReopenSliderDisplayed();
        }

        [Then(@"validation message should be displayed")]
        public void ThenValidationMessageShouldBeDisplayed()
        {
            
        }

        //Opp closed lost

        [When(@"Click on View details page link")]
        public void WhenClickOnViewDetailsPageLink()
        {
            opportunitypage.ClickOnViewDetailsLink();
        }

        [Then(@"Opportunity detail page should be displayed")]
        public void ThenOpportunityDetailPageShouldBeDisplayed()
        {
            opportunitypage.IsOpportunityDetailPageDisplayed();
        }

        [Then(@"Click on closed won/closed lost bar")]
        public void ThenClickOnClosedWonClosedLostBar()
        {
            opportunitypage.ClickOnCloseLostExpandIcon();
        }
        //Select all the opportunities checkbox

        [When(@"select the all checkbox option")]
        public void WhenSelectTheAllCheckboxOption()
        {
            opportunitypage.SelecttheAllOpportunitiesCheckBox();
        }

        [Then(@"checkbox should be selected")]
        public void ThenCheckboxShouldBeSelected()
        {
            opportunitypage.IsCheckBoxSelected();
        }

        //Reopen closed won or closed lost opportunities through card view'

        [Then(@"Click on three dots icon for closed opportunities")]
        public void ThenClickOnThreeDotsIconForClosedOpportunities()
        {
            opportunitypage.ClickOnThreeDotsIconforClosedOpportunities();
        }

        [Then(@"Select the date")]
        public void ThenSelectTheDates()
        {
            opportunitypage.ClickonCalenderIcon();
            opportunitypage.ClickonOkButtonInCalenderPopup();
        }

        [When(@"Click on reopen button in reopen opportunity popup")]
        public void WhenClickOnReopenButtonInReopenOpportunityPopup()
        {
            opportunitypage.ClickonOkReopenButtonInCalenderPopup();
        }

        [Then(@"Select the reopen option for closed opportunities")]
        public void ThenSelectTheReopenOptionForClosedOpportunities()
        {
            opportunitypage.SelectReopenOptionforClosedOpportunities();
        }


        [Then(@"Select the closed lost option")]
        public void ThenSelectTheClosedLostOption()
        {
            opportunitypage.ClickOnCloseLostOption();
        }

        [When(@"Click on save button in closed lost popup")]
        public void WhenClickOnSaveButtonInClosedLostPopup()
        {
            opportunitypage.ClickOnSaveButtonInCloseLostPopup();
        }

        [Then(@"Select Lost to competitor radio button in close lost popup")]
        public void ThenSelectLostToCompetitorRadioButtonInCloseLostPopup()
        {
            opportunitypage.IsSelectLostCompetitorRadioButton();
        }

        [Then(@"Opportunity closed validation message should be displayed")]
        public void ThenOpportunityClosedValidationMessageShouldBeDisplayed()
        {
           
        }

        //Closed won opportunity

        [When(@"Click on Opportunities link in leads page")]
        public void WhenClickOnOpportunitiesLinkInLeadsPage()
        {
            opportunitypage.ClickonOpportunitiesLInkinLeadsPage();
        }

        [Then(@"Click on View detail page link")]
        public void ThenClickOnViewDetailPageLink()
        {
            opportunitypage.ClickOnViewDetailsLink();
        }

        [Then(@"Click on again billto expand icon")]
        public void ThenClickOnAgainBilltoExpandIcon()
        {
            opportunitypage.ClickonAgainBilltoexpandicon();
        }

        [When(@"Select the closed won option")]
        public void WhenSelectTheClosedWonOption()
        {
            opportunitypage.ClickOnCloseWonOption();
        }

        [Then(@"Click on Close form manager button")]
        public void ThenClickOnCloseFormManagerButton()
        {
            opportunitypage.ClickOnCloseFormManagerButton();
        }

        //credit card details

        [Then(@"Click on Capture card button")]
        public void ThenClickOnCaptureCardButton()
        {
            opportunitypage.ClickonCaptureCardButton();
        }

        [Then(@"Enter the card holder name (.*)")]
        public void ThenEnterTheCardHolderName(string name)
        {
            opportunitypage.IsCardNameEntered(name);
        }


        [Then(@"Click on Enter button")]
        public void ThenClickOnEnterButton()
        {
            opportunitypage.ClickOnEnterButton();
        }

        //[Then(@"Enter the card details (.*)")]
        //public void ThenEnterTheCardDetails(string cardnumber)
        //{
        //    opportunitypage.EnterCardNumber(cardnumber);
        //}

        [Then(@"Enter the card details (.*)")]
        public void ThenEnterTheCardDetails(string cardnumber)
        {
            opportunitypage.EnterCardNumber(cardnumber);
        }

        [When(@"Click on Add credit card button")]
        public void WhenClickOnAddCreditCardButton()
        {
            opportunitypage.ClickOnAddCreditCardButton();
        }

        [Then(@"Click on Service expand icon in opportunity page")]
        public void ThenClickOnServiceExpandIconInOpportunityPage()
        {
            opportunitypage.ClickOnServiceExpandIconForMatchedOpportunity();
        }

        [Then(@"Select the expiration month and year")]
        public void ThenSelectTheExpirationMonthAndYear()
        {
            opportunitypage.EnterthedateandYear();
        }

        //Reassign the sales team

        [When(@"Click on Reassign button")]
        public void WhenClickOnReassignButton()
        {
            opportunitypage.ClickOnReassignButton();
        }

        [Then(@"Reassign slider should be displayed")]
        public void ThenReassignSliderShouldBeDisplayed()
        {
            opportunitypage.IsReassignSliderDisplayed();
        }

        [Then(@"Select the same branch SalesTeam in reassign slider (.*)")]
        public void ThenSelectTheSameBranchSalesTeamInReassignSliderAutoTestSalesTeam(string salesteam)
        {
            opportunitypage.SelectSalesTeamInReassignSlider();
        }


        [Then(@"Select the team member in reassign slider (.*)")]
        public void ThenSelectTheTeamMemberInReassignSliderUnassigned(string salesteammember)
        {
            opportunitypage.SelectSalesTeamMemberInReassignSlider();
        }

        //Opportunity close win when pp location not matched

        [Then(@"Closing requirements missing popup should be displayed")]
        public void ThenClosingRequirementsMissingPopupShouldBeDisplayed()
        {
            opportunitypage.IsCloseRequirementMissingPopupDisplayed();
            opportunitypage.ClickOnCloseButtonInPopup();
        }

        //Remove sc contacts

        [When(@"Click on view contacts link")]
        public void WhenClickOnViewContactsLink()
        {
            opportunitypage.ClickOnViewContactsLink();
        }

        [Then(@"Contacts page should be displayed")]
        public void ThenContactsPageShouldBeDisplayed()
        {
            opportunitypage.ContactPageIsDisplayed();
        }

        [Then(@"Click on workwave contacts tab")]
        public void ThenClickOnWorkwaveContactsTab()
        {
            opportunitypage.ClickOnWorkWaveContactsLink();
        }


        [When(@"Click on Add contact button")]
        public void WhenClickOnAddContactButton()
        {
            opportunitypage.ClickOnAddContactButton();
        }

        [Then(@"Add contact slider should be displayed")]
        public void ThenAddContactSliderShouldBeDisplayed()
        {
            opportunitypage.IsAddContactSliderIsDisplayed();
        }

        [Then(@"Search the existing contact (.*)")]
        public void ThenSearchTheExistingContactJames(string contactname)
        {
            opportunitypage.ClickOnSearchiconInContactSlider();
            opportunitypage.EnterTheExistingContactName(contactname);        
        }

        [Then(@"Click on Add contact button")]
        public void ThenClickOnAddContactButton()
        {
            opportunitypage.ClickOnAddContactButtonInContactSlider();
        }

        [When(@"Remove the contact")]
        public void WhenRemoveTheContact()
        {
            opportunitypage.ClickOnThreeDotsIconforAddedContacts();
            opportunitypage.ClickOnRemoveLinkforContacts();
            opportunitypage.ClickOnRemoveButtonInPopup();
        }

        //[Then(@"Confirmation message should be displayed Closed")]
        //public void ThenConfirmationMessageShouldBeDisplayedClosed()
        //{

        //}

        //Edit the opportunity contacts

        [When(@"Edit the contacts")]
        public void WhenEditTheContacts()
        {
            opportunitypage.ClickOnThreeDotsIconforAddedContacts();
            opportunitypage.ClickOnEditLinkforContacts();
        }

         
        [When(@"Enter the EmailId (.*)")]
        public void WhenEnterTheEmailId(string emailid)
        {
            opportunitypage.EnterEmailId(emailid);
        }

        [When(@"Click on Update button in add contact slider")]
        public void WhenClickOnUpdateButtonInAddContactSlider()
        {
            opportunitypage.ClickOnUpdateButtonInAddContactSlider();
        }

        //Create WWM contacts

        [Then(@"Click on Add new contact tab")]
        public void ThenClickOnAddNewContactTab()
        {
            opportunitypage.ClickOnAddNewContactTab();
        }

        [Then(@"Enter the contact details (.*) (.*) (.*)")]
        public void ThenEnterTheContactDetails(string firstname, string lastname, string emailid)
        {
            opportunitypage.EnterFirstName(firstname);
            opportunitypage.EnterLastName(lastname);
            opportunitypage.EnterEmailId(emailid);
        }

        [When(@"Click on Create contact button")]
        public void WhenClickOnCreateContactButton()
        {
            opportunitypage.ClickOnCreateContactButton();
        }





    }
}
