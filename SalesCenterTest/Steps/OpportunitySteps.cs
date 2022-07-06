using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
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

        [When(@"Click on Close form manager button")]
        public void WhenClickOnCloseFormManagerButton()
        {
            opportunitypage.ClickOnCloseFormManagerButton();
        }


        [Then(@"Close won opportunity slider should be displayed")]
        public void ThenCloseWonOpportunitySliderShouldBeDisplayed()
        {
            opportunitypage.IsCloseWonOpportunitySliderDisplayed();
        }

        [When(@"Click on Submit button in Close won opportunity slider")]
        public void WhenClickOnSubmitButtonInCloseWonOpportunitySlider()
        {
            opportunitypage.ClickonSubmitButtonInCloseWOnOpportunitySlider();
        }

        [Then(@"Select the Technicians details (.*) (.*) (.*) (.*)")]
        public void ThenSelectTheTechniciansDetails(string tech1, string tech2, string sales1, string sales2)
        {
            opportunitypage.SelecttheTech1Details();
            opportunitypage.SelecttheTech2Details();
            opportunitypage.SelecttheSales1Details();
            opportunitypage.SelecttheSales2Details();
        }

        [Then(@"Enter the sales note (.*)")]
        public void ThenEnterTheSalesNote(string salesnote)
        {
            opportunitypage.EnterSalesNote(salesnote);
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

        [Then(@"Added payment method validation message should be displayed")]
        public void ThenAddedPaymentMethodValidationMessageShouldBeDisplayed()
        {
            
           Assert.True(opportunitypage.IsPaymentAddedMessageIsDisplayed(), "Validation message is not displayed");
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

        [When(@"Remove the workwave contact")]
        public void WhenRemoveTheWorkwaveContact()
        {
            
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

         
        [When(@"Enter the phonenumber (.*)")]
        public void WhenEnterThePhonenumber(string phonenumber)
        {
            opportunitypage.EnterPhoneNumber(phonenumber);
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

        [When(@"Enter company name (.*)")]
        public void WhenEnterCompanyNameJamesPvtLtd(string companyname)
        {
            opportunitypage.EnterCompanyName(companyname);
        }


        [When(@"Click on Create contact button")]
        public void WhenClickOnCreateContactButton()
        {
            opportunitypage.ClickOnCreateContactButton();
        }

        //Verify primary contact name which is shown in contacts section

        [When(@"Select the primary contact radio button")]
        public void WhenSelectThePrimaryContactRadioButton()
        {
            opportunitypage.ClickOnPrimaryContactRadioButton();
        }

        [When(@"Click on close button")]
        public void WhenClickOnCloseButton()
        {
            opportunitypage.ClickOnCloseButtonInContactsPage();
        }

        [Then(@"Same contact name should be displayed in primary contact section")]
        public void ThenSameContactNameShouldBeDisplayedInPrimaryContactSection()
        {
            opportunitypage.VerifyPrimaryContactName_isDisplayed();
        }

        [Then(@"Select the other contact")]
        public void ThenSelectTheOtherContact()
        {
            opportunitypage.SelectOtherPrimaryContactRadioButton();
        }

        //Push wwm contacts to pestpac contacts

        [Then(@"Push the wwm contacts to pestpac contacts")]
        public void ThenPushTheWwmContactsToPestpacContacts()
        {
            opportunitypage.ClickOnThreeDotsIconforAddedContacts();
            opportunitypage.ClickOnSendTopestPaclocationlink();
        }

        [When(@"Click on Pestpac contacts tab")]
        public void WhenClickOnPestpacContactsTab()
        {
            opportunitypage.ClickOnPestPacTab();
        }


        [Then(@"Wwm contact should be displayed in pestpac contacts page")]
        public void ThenWwmContactShouldBeDisplayedInPestpacContactsPage()
        {
            opportunitypage.VerifyPrimaryContactName_isDisplayed();
        }

        //Add note

        [When(@"Click on Add note button")]
        public void WhenClickOnAddNoteButton()
        {
            opportunitypage.ClickOnAddNoteButton();
        }

        [Then(@"Add note slider should be dislayed")]
        public void ThenAddNoteSliderShouldBeDislayed()
        {
            opportunitypage.IsAddNoteSliderIsDisplayed();
        }

        [Then(@"Enter the title (.*)")]
        public void ThenEnterTheTitleTestAutomationNote(string title)
        {
            opportunitypage.EnterNoteTitle(title);
        }

        [Then(@"Enter the note (.*)")]
        public void ThenEnterTheNoteAddedFirstNote(string note)
        {
            opportunitypage.EnterNote(note);
        }

        [When(@"Edit the note")]
        public void WhenEditTheNote()
        {
            opportunitypage.ClickOnThreeDotsIconforAddedNotes();
            opportunitypage.ClickOnEditLinkforNotes();
            
        }

        [When(@"Update the note (.*)")]
        public void WhenUpdateTheNote(string notesdetails)
        {
            opportunitypage.UpdateNotesDetail(notesdetails);
        }

        [Then(@"verify cancel button in notes delete popup")]
        public void ThenVerifyCancelButtonInNotesDeletePopup()
        {
            opportunitypage.ClickOnThreeDotsIcontoDeleteNotes();
            opportunitypage.ClickOnDeleteOptionforNotes();
            opportunitypage.ClickOnCancelButtonInNotesDeletePopup();
        }


        [When(@"Delete the note")]
        public void WhenDeleteTheNote()
        {
            opportunitypage.ClickOnThreeDotsIcontoDeleteNotes();
            opportunitypage.ClickOnDeleteOptionforNotes();
            opportunitypage.ClickOnDeleteButtonInNotesDeletePopup();
        }

        //Delete opportnity card

        [When(@"Delete the opportunity card")]
        public void WhenDeleteTheOpportunityCard()
        {
            opportunitypage.ClickOnThreeDotsIconforOpportunityCard();
            opportunitypage.ClickOnDeleteLinkforOpportunityCard();
            opportunitypage.ClickOnDeleteButtonInOpportunityDeletePopup();
        }

        //Delete already added service

        [Then(@"Click on Service expand icon for opportunity")]
        public void ThenClickOnServiceExpandIconForOpportunity()
        {
            opportunitypage.ClickOnServiceExpandIconForOpportunity();
        }

        [When(@"Delete the already added service")]
        public void WhenDeleteTheAlreadyAddedService()
        {
            opportunitypage.ClickOnThreeDotsIconforaddedService();
            opportunitypage.ClickOnDeleteLinkOptionforAddedService();
            opportunitypage.ClickOnDeleteButtonInDeleteServicePopup();
        }

        [Then(@"Select the first services (.*)")]
        public void ThenSelectTheFirstServices(string service)
        {
            opportunitypage.SelectTheServiceFromDropDown();
        }


        [Then(@"Select the different services (.*)")]
        public void ThenSelectTheDifferentServicesBEDBUG_BedBugTreatment(string diffservice)
        {
            opportunitypage.SelectTheOtherServiceFromDropDown();
        }


        //Not able to send additionl contracts for closed won opp

        [When(@"Mouse hover on send contracts button")]
        public void WhenMouseHoverOnSendContractsButton()
        {
            opportunitypage.MouseHoverOnSendContractsButton();
        }

        //Not able to add,edit and delete the services for closed won app

        [When(@"Mouse hover on Add service button")]
        public void WhenMouseHoverOnAddServiceButton()
        {
            opportunitypage.MouseHoverOnAddServiceButton();
        }

        [Then(@"Click on View services added link")]
        public void ThenClickOnViewServicesAddedLink()
        {
            opportunitypage.ClickOnViewServicesAddedLink();
        }
    

        [Then(@"Try to click add,Edit and delete additional service or product")]
        public void ThenTryToClickAddEditAndDeleteAdditionalServiceOrProduct()
        {
            opportunitypage.TryToClickOnAddAdditionalServiceOrProductButton();
        }


        //send contract form to the customer

        [When(@"Click on Send form and notify button")]
        public void WhenClickOnSendFormAndNotifyButton()
        {
            opportunitypage.ClickOnSendFormandNotifyFormButton();
        }

        [Then(@"Instruction page should be displayed")]
        public void ThenInstructionPageShouldBeDisplayed()
        {
            opportunitypage.IsInstructionPageIsDisplayed();
        }

        [Then(@"Select send form and notify option radio button")]
        public void ThenSelectSendFormAndNotifyOptionRadioButton()
        {
            opportunitypage.ClickOnDepartmentRadioButton();
        }

        [Then(@"Click on Sales center expand icon")]
        public void ThenClickOnSalesCenterExpandIcon()
        {
            opportunitypage.ClickOnSalesCenterUserExpandButton();
        }

        [Then(@"Select the user mail id checkbox")]
        public void ThenSelectTheUserMailIdCheckbox()
        {
            opportunitypage.SelectMailIdUserCheckBox();
        }

        [Then(@"Residential form sent validation message should be displayed")]
        public void ThenResidentialFormSentValidationMessageShouldBeDisplayed()
        {
           
        }

        //Add a contract form to an opportunity

        [When(@"Click on View contracts link")]
        public void WhenClickOnViewContractsLink()
        {
            opportunitypage.ClickOnViewContractsLink();
        }

        [Then(@"Click on Close icon in contract slider")]
        public void ThenClickOnCloseIconInContractSlider()
        {
            opportunitypage.ClickOnCloseIconInContractSlider();
        }

        [Then(@"Same Contract form should be displayed in contracts slider")]
        public void ThenSameContractFormShouldBeDisplayedInContractsSlider()
        {
            opportunitypage.IsSameContractFormDisplayedInViewDetailsPage();
        }

        //Switch back to default content

        [Then(@"Card added successfully validation message should be displayed (.*)")]
        public void ThenCardAddedSuccessfullyValidationMessageShouldBeDisplayed(string message)
        {
            opportunitypage.VerifyCardAddedConfirmMsg(message);
        }

        //TrackB scenario

        [When(@"Click on convert to opportunity button after matching the location")]
        public void WhenClickOnConvertToOpportunityButtonAfterMatchingTheLocation()
        {
            opportunitypage.ClickOnConvertOpportunityButtonAfterMatchingTheLocation();
        }

        //Closing requirements counts

        [Then(@"Same service count should be displayed in Manage services and products page")]
        public void ThenSameServiceCountShouldBeDisplayedInManageServicesAndProductsPage()
        {
            opportunitypage.IsServiceCountDisplayedInManageServicesPage();
        }

       

    }
}
