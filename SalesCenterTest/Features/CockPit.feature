@Cockpit
Feature: CockPit
	
Background: 
	Given I am logged in
	
@Smoke @Regression @WWM-8411 @CockPit @WW_CP_001
Scenario: Verify Captured Leads, Open Opportunities, Leads to Qualify cards are displayed on dashboard
    Then Verify the Leads opportunities and Leads to Qualify cards are displayed on dashboard

@Smoke @Regression @WWM-8412 @CockPit @WW_CP_002
Scenario: Verify default dispay of Records with Overdue Next Action Dates on dashboard
    Then Verify the  default dispay of Records with Overdue Next Action Dates on dashboard

@Smoke @Regression @CockPit @WW_CP_003
Scenario: Verify  Contract History is displayed on dashboard
    Then Verify the Contract History is displayed on dashboard

@Smoke @Regression @WWM-8414 @CockPit @WW_CP_004
Scenario: Verify default dispay of Upcoming Follow-Ups on dashboard
    Then Verify the default dispay of Upcoming Follow-Ups on dashboard

