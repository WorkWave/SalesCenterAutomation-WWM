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
        private PestPacData pestPacData;
        OpportunityPage opportunitypage = new OpportunityPage();

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


    }
}
