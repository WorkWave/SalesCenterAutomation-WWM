@Opportunities
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

@Smoke @Regression @Opportunities @WWM-8438 @WW_OP_002
Scenario Outline: Verify user can close an opportunity as closed/lost
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
	When Click on View details page link
	Then Opportunity detail page should be displayed
	And Click on closed won/closed lost bar
	And Select the closed lost option
	And Select Lost to competitor radio button in close lost popup
	When Click on save button in closed lost popup
	Then Opportunity closed validation message should be displayed
	
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

@Smoke @Regression @Opportunities @WWM-8440 @WW_OP_004
Scenario Outline: Verify Users Can Re-Open Closed/Won and Closed/Lost Opportunities
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
	And Click on filters button
	And Select the opportunity status <OpportunityStatus>
    When Click on Apply button
	Then All the closed opportunities should be displayed
	And Click on three dots icon for closed opportunities
	And Select the reopen option for closed opportunities
	And Select the date
	When Click on reopen button in reopen opportunity popup
	
Examples:  
     | OpportunityStatus | 
     | Closed            | 

@Smoke @Regression @Opportunities @WWM-8439 @WW_OP_005
Scenario Outline: Verify user can closed won a opportunity
	When Click on plus icon 
    And  Click on Add Lead button
    Then Add Lead details page should be displayed
    And Enter the lead details <FirstName> <LastName> <CompanyName> <Email> 
    And Select the SalesTeam <SalesTeam>
    And Select the Owner <Owner>
    And Select the sales funnel <SalesFunnel>
    When Click on Save button
    Then Lead created validation message should be displayed <ValidationMessage>
    And  Click on filters button
    And Click on clear filter button
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button  
    And  Click on Close form manager button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link in leads page
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Bill to locations expand icon
    When Click on Match or create link
    Then Match or create new location slider should be displayed
    And Click to match to existing location button
    And Select the pestpac location
    When Click on Save button in bill to search for matching slider
    And Select match to service location <ServiceLocation>
    When Click on Save button
    Then Location matched validation message should be displayed <LocationMatchedValMsg> 
    And Click on again billto expand icon
    And Click on View detail page link
    And Click on closed won/closed lost bar
    When Select the closed won option
   #Then Validation message should be displayed
    
  
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | Template                 | Services            | OpportunityCreated   |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | Residential Service Form | ANT- Ant Treatments | Opportunity created  |
	
    
@Smoke @Regression @Opportunities @WWM-8433 @WW_OP_006
Scenario Outline: Veriy user able to add payment card for a matched opportunity to a PP location
	When Click on plus icon 
    And  Click on Add Lead button
    Then Add Lead details page should be displayed
    And Enter the lead details <FirstName> <LastName> <CompanyName> <Email> 
    And Select the SalesTeam <SalesTeam>
    And Select the Owner <Owner>
    And Select the sales funnel <SalesFunnel>
    When Click on Save button
    Then Lead created validation message should be displayed <ValidationMessage>
    And  Click on filters button
    And Click on clear filter button
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button  
    And  Click on Close form manager button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link in leads page
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Bill to locations expand icon
    When Click on Match or create link
    Then Match or create new location slider should be displayed
    And Click to match to existing location button
    And Select the pestpac location
    When Click on Save button in bill to search for matching slider
    And Select match to service location <ServiceLocation>
    When Click on Save button
    Then Location matched validation message should be displayed <LocationMatchedValMsg> 
    And Click on again billto expand icon
    And Click on Service expand icon in opportunity page
    And Click on Capture card button
    And Enter the card holder name <CardHolderName>
    And Click on Enter button
    And Enter the card details <CardNumber>
    And Select the expiration month and year
    When Click on Add credit card button
    Then Validation message should be displayed <ValMessage>
    
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | Template                 | Services            | OpportunityCreated  | CardHolderName | CardNumber        | ValMessage                         |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | Residential Service Form | ANT- Ant Treatments | Opportunity created | John Smith     | 4111111111111111  | Successfully added payment method. |           
	
    