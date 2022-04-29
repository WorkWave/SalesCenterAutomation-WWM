@Cockpit
Feature: CockPit
	
Background: 
	Given I am logged in
	
@CockPit @WWM-8411  @WW_CP_001
@Smoke
@Regression_Base 
@Regression_Full
Scenario: Verify Captured Leads, Open Opportunities, Leads to Qualify cards are displayed on dashboard
    Then Verify the Leads opportunities and Leads to Qualify cards are displayed on dashboard

@CockPit @WWM-8412  @WW_CP_002
@SmokeProd
@Smoke
@Regression_Base 
@Regression_Full
Scenario: Verify default dispay of Records with Overdue Next Action Dates on dashboard
    Then Verify the  default dispay of Records with Overdue Next Action Dates on dashboard

@Smoke  @CockPit @WW_CP_003 @WWM-8415
Scenario: Verify  Contract History is displayed on dashboard
    Then Verify the Contract History is displayed on dashboard

@CockPit  @WWM-8414  @WW_CP_004
@SmokeProd
@Smoke
@Regression_Base 
@Regression_Full
Scenario: Verify default dispay of Upcoming Follow-Ups on dashboard
    Then Verify the default dispay of Upcoming Follow-Ups on dashboard

@Regression @Leads @WWM-8441 @WW_CP_005
Scenario: Verification of  breakdown of each stage on expanding sales funnel card
    When Sales funnel summary button
    Then Sales funnel summary page should be displayed
    When Click on Funel stage expand icon
    Then Lead statuses and opportunity stages details should be displayed
    And Get the lead name and count
    When Click on View leads button
    Then Leads page should be displayed and  Same leads count should be displayed in leads page
    And Navigate back to dashboard
    When Sales funnel summary button
    Then Sales funnel summary page should be displayed
    When Click on Funel stage expand icon
    Then Lead statuses and opportunity stages details should be displayed
    And Get the opportinity stage name and count
    When Click on View opportinities button
    Then Opportunity page should be displayed and Same opportunities count should be displayed in opportunity page


   
 
  

