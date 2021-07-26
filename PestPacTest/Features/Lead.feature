@Lead

Feature: Lead
	I want to able to verify leads scenarios

Background: 
	Given I am logged in


@WW_SM_011
@smoke
Scenario Outline: Verify Display of Leads Page through sales center menu

  When I mouse hover on sales center side menu
  And I click on Leads link
  Then Leads page should be displayed
  
 
 @WW_SM_012
@smoke
Scenario Outline: Verify user can create and delete a lead  

  When I click on plus icon
  And I click on Add Lead button
  Then Add Lead details page should be displayed
  And I enter the lead details <FirstName> <LastName> <CompanyName> <Email>
  And I select the sales team <SalesTeam>
  And I select the owner <Owner>
  And I select the sales funnel <SalesFunnel>
  When I click on Save button
  Then Lead created validation message should be displayed <ValidationMessage>
  And I click on search icon
  And I enter the lead name <LeadName> and click on search icon
  And I click on three dots icon
  And I click on delete link for added lead
  When I click on Delete button in delete lead popup
  Then Lead deleted confirmation message should be displayed <DeleteConfirmMessage>


 Examples:  
     | FirstName        | LastName | CompanyName  | Email              | SalesTeam            | Owner     | SalesFunnel           | ValidationMessage | LeadName   | DeleteConfirmMessage |
     | Automation user2 | Test2    | autocompany2 | autouser@gmail.com | AutoTestingSalesTeam | UnAsigned | Test reg sales funnel | Lead created      | Automation | Lead deleted.        |
	 
