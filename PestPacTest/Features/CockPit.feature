Feature: CockPit
	I want to able to verify dashboard scenarios

Background: 
	Given I am logged in
	
@smoke
Scenario: Verify Captured Leads, Open Opportunities, Leads to Qualify cards are displayed on dashboard
    Then Verify the Leads opportunities and Leads to Qualify cards are displayed on dashboard