using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WorkWave.PestPac.TA.Model;
using WorkWave.TA.TestEngine;

namespace WorkWave.PestPac.TA.Steps
{
    [Binding]
    public class OpportunitySteps : TestSteps
    {
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


    }
}
