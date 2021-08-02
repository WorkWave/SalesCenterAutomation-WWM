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
  When I mouse hover on sales center side menu
 

 Examples:  
     | FirstName        | LastName | CompanyName  | Email              | SalesTeam            | Owner     | SalesFunnel           | ValidationMessage | LeadName   | DeleteConfirmMessage |
     | Automation user2 | Test2    | autocompany2 | autouser@gmail.com | AutoTestingSalesTeam | UnAsigned | Test reg sales funnel | Lead created      | Automation | Lead deleted.        |
	 

@WW_SM_013
@smoke
Scenario Outline: Verify user can create lead and convert to opportunity

  When I click on plus icon
  And I click on Add Lead button
  Then Add Lead details page should be displayed
  And I enter the lead details <FirstName> <LastName> <CompanyName> <Email>
  And I select the sales team <SalesTeam>
  And I select the owner <Owner>
  And I select the sales funnel <SalesFunnel>
  When I click on Save button
  Then Lead created validation message should be displayed <ValidationMessage>
  And I click on Service expand icon
  And Click on Add Serivces button
  And I select the services <Services>
  When I click on Add services button in slider
  Then service should be successfully added
  And I click on Close services and product button
  When I click on convert to opportunity button
  And I select the ownername in convert lead page <OwnerName>
  And I select the funnel stage <FunnelStage>
  When I click on Save button
  Then validation message should be displayed <OpportunityCreated>
 
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam            | Owner      | SalesFunnel           | ValidationMessage | LeadName   | Services            | FunnelStage | Ownername  | OpportunityCreated  | OpportunityDeleteConfirmMessage | OpportunityName |
     | Automation Labs | Labs01   | autocompany01 | autouser@gmail.com | AutoTestingSalesTeam | UnAssigned | Test reg sales funnel | Lead created      | Automation | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Opportunity Deleted             | Automation Labs |


@WW_SM_014
@WWM-8428
@smoke
Scenario Outline: Verify user able to create new opportunity directly

  When I click on plus icon
  And I click on Add Lead button
  Then Add Lead details page should be displayed
  And I enter the lead details <FirstName> <LastName> <CompanyName> <Email>
  And I select the sales team <SalesTeam>
  And I select the owner <Owner>
  And I select the sales funnel <SalesFunnel>
  When I click on Save button
  Then Lead created validation message should be displayed <ValidationMessage>
  And I click on Service expand icon
  And Click on Add Serivces button
  And I select the services <Services>
  When I click on Add services button in slider
  Then service should be successfully added
  And I click on Close services and product button
  When I click on plus icon
  And I click on Create opportunity button
  And I enter the company name <LeadName>
  When I click on Create opportunity button in create opportunity page
  And I select the ownername in convert lead page <OwnerName>
  And I select the funnel stage <FunnelStage>
  When I click on Save button
  Then validation message should be displayed <OpportunityCreated>
 

 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam            | Owner      | SalesFunnel           | ValidationMessage | Services            | FunnelStage | Ownername  | OpportunityCreated  | OpportunityDeleteConfirmMessage | OpportunityName | LeadName      |
     | Automation Labs | Labs02   | autocompany02 | autouser@gmail.com | AutoTestingSalesTeam | UnAssigned | Test reg sales funnel | Lead created      | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Opportunity Deleted             | Automation Labs | Automation    |
