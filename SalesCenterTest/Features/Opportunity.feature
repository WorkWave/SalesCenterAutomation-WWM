﻿@Opportunities
Feature: Opportunities
	

Background: 
	Given I am logged in

@Smoke @Regression @Opportunities @WWM-8447 @WW_OP_001
Scenario Outline: SC-Bulk Re-open: Verify that user can Bulk reopen the multiple closed opportunities at once
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
	And Click on filters button
	And Select the opportunity status <OpportunityStatus>
    When Click on Apply button
	Then All the closed opportunities should be displayed
	And Click on List view button
	And Select the multiple opportunities
	When Click on Reopen button
	Then Reopen slider should be displayed
	When Click on Save button
   # Then validation message should be displayed

  Examples:  
     | OpportunityStatus | 
     | Closed            | 


@Smoke @Regression @Opportunities @WWM-8442 @WW_OP_003
Scenario: Verification of multiple records selection on Opportunity List View Page
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
	And Click on List view button
	When select the all checkbox option
	Then checkbox should be selected