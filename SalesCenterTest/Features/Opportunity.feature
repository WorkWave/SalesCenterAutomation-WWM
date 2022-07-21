@Opportunities
Feature: Opportunities
	

Background: 
	Given I am logged in

@Regression @Opportunities @WWM-8447 @WW_OP_001
Scenario Outline: SC-Bulk Re-open: Verify that user can Bulk reopen the multiple closed opportunities at once
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider  
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

@Smoke @Opportunities @WWM-8438 @WW_OP_002
@Regression 
@Regression_Full
Scenario Outline: Verify user can close an opportunity as closed/lost
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
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

@Regression @Opportunities @WWM-8442 @WW_OP_003
Scenario: Verification of multiple records selection on Opportunity List View Page
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	And Click on List view button
	When select the all checkbox option
	Then checkbox should be selected

@Opportunities @WWM-8440 @WW_OP_004
@Smoke
@Regression 
@Regression_Full
Scenario Outline: Verify Users Can Re-Open Closed/Won and Closed/Lost Opportunities
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	And Click on filters button
	And Select the opportunity status <OpportunityStatus>
    When Click on Apply button
	Then All the closed opportunities should be displayed
	And Click on three dots icon for closed opportunities
	And Select the reopen option for closed opportunities
	When Click on reopen button in reopen opportunity popup
	
Examples:  
     | OpportunityStatus | 
     | Closed            | 

@Opportunities @WWM-8439 @WW_OP_005
@Smoke
@Regression 
@Regression_Full
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
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And Click on proceed button
    When Click on Close form manager button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link in leads page
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
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
    Then Close won opportunity slider should be displayed
    When Click on Submit button in Close won opportunity slider
   #Then Validation message should be displayed
    
  
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | Template                 | Services            | OpportunityCreated   |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | Residential Service Form | ANT- Ant Treatments | Opportunity created  |
	
    
@Regression @Opportunities @WWM-8433 @WW_OP_006 
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
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And Click on proceed button
    When Click on Close form manager button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link in leads page
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
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
   # Then Validation message should be displayed <ValMessage>
    
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | Template                 | Services            | OpportunityCreated  | CardHolderName | CardNumber        | ValMessage                         |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | Residential Service Form | ANT- Ant Treatments | Opportunity created | John Smith     | 4111111111111111  | Successfully added payment method. |           
	
   
@Regression @Opportunities @WWM-8445 @WW_OP_007
Scenario Outline: Verification of Bulk Re-assignment of Opportunities which are associated with same branch Sales Team
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	And Click on List view button
	And Select the multiple opportunities
	When Click on Reassign button
	Then Reassign slider should be displayed
    And Select the same branch SalesTeam in reassign slider <SalesTeam>
    And Select the team member in reassign slider <SalesTeamMember>
	When Click on Save button
   # Then validation message should be displayed

  Examples:  
     | SalesTeam             | SalesTeamMember |
     | Auto Test Sales Team  | unassigned      |

@Opportunities @WWM-8432 @WW_OP_008
@Smoke
@Regression 
@Regression_Full
Scenario Outline: Veriy user not able to close win if opportunity is not matched to any PP location
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
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link in leads page 
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And Click on View detail page link
    And Click on closed won/closed lost bar
    When Select the closed won option
    Then Closing requirements missing popup should be displayed
    
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName |  Services             | OpportunityCreated  | 
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      |   ANT- Ant Treatments | Opportunity created |           


 @Opportunities @WWM-8611 @WW_OP_009
 @Smoke 
Scenario Outline: Remove WWM Contact for Opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And  Click on search icon
    And  Enter the lead name <OpportunityName> and click on search icon
	When Click on View details page link
	Then Opportunity detail page should be displayed
    When Click on view contacts link
    Then Contacts page should be displayed
    And Click on workwave contacts tab
    When Click on Add contact button
    Then Add contact slider should be displayed
    And Search the existing contact <ExistingContact>
    And Click on Add contact button
    When Remove the contact
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
     | ExistingContact | OpportunityName               |
     | James           | Add CC for API Auto CC Refund |


@Smoke @Opportunities @WWM-8610 @WW_OP_010
Scenario Outline: Edit WWM Contact for Opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And  Click on search icon
    And  Enter the lead name <OpportunityName> and click on search icon
	When Click on View details page link
	Then Opportunity detail page should be displayed
    When Click on view contacts link
    Then Contacts page should be displayed
    And Click on workwave contacts tab
    When Click on Add contact button
    Then Add contact slider should be displayed
    And Search the existing contact <ExistingContact>
    And Click on Add contact button
    When Edit the contacts
    And Enter company name <CompanyName>
    And Click on Update button in add contact slider
    When Remove the contact
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
     | ExistingContact | CompanyName     |  OpportunityName               |
     | James           | James pvt ltd   |  Add CC for API Auto CC Refund |


@Smoke @Opportunities @WWM-8609 @WW_OP_011 @ignore @WWM-10168
Scenario Outline: Create WWM Contact for Opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And  Click on search icon
    And  Enter the lead name <OpportunityName> and click on search icon
	When Click on View details page link
	Then Opportunity detail page should be displayed
    When Click on view contacts link
    Then Contacts page should be displayed
    And Click on workwave contacts tab
    When Click on Add contact button
    Then Add contact slider should be displayed
    And Click on Add new contact tab
    And Enter the contact details <FirstName> <LastName> <Email>
    When Click on Create contact button
    When Remove the contact
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
    | FirstName | LastName | Email           | OpportunityName               |
    | James     | Jacob    | james@gmail.com | Add CC for API Auto CC Refund |


@Regression @Opportunities @WWM-8608 @WW_OP_012
Scenario Outline: Verify that Primary contact which is shown in the Contacts slide-out is the same contact displayed on the Opportunity-cards
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	When Click on View details page link
	Then Opportunity detail page should be displayed
    When Click on view contacts link
    Then Contacts page should be displayed
    And Click on workwave contacts tab
    When Click on Add contact button
    Then Add contact slider should be displayed
    And Click on Add new contact tab
    And Enter the contact details <FirstName> <LastName> <Email>
    When Click on Create contact button
    And Select the primary contact radio button
    When Click on close button
    Then Same contact name should be displayed in primary contact section
    When Click on view contacts link
    Then Contacts page should be displayed
    And Select the other contact
    When Remove the workwave contact
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
     | ExistingContact | EmailId        | FirstName | LastName | Email           |
     | James           | john@gmail.com | James     | Jacob    | james@gmail.com |


@Regression @Opportunities @WWM-8607 @WW_OP_013
Scenario Outline: Verification of Pushing WWM contact to PestPac Location for opportunities
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
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
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
    When Click on view contacts link
    Then Contacts page should be displayed
    And Click on workwave contacts tab
    When Click on Add contact button
    Then Add contact slider should be displayed
    And Search the existing contact <ExistingContact>
    And Click on Add contact button
    And Push the wwm contacts to pestpac contacts
    When Click on Pestpac contacts tab
    Then Wwm contact should be displayed in pestpac contacts page

 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | Template                 | Services            | OpportunityCreated  | ExistingContact |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | Residential Service Form | ANT- Ant Treatments | Opportunity created | James           |
	

@Regression @Opportunities @WWM-8603 @WW_OP_014 @ignore
Scenario Outline: Verify a User can Create,Edit and delete a Note on an Opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	When Click on View details page link
	Then Opportunity detail page should be displayed
    When Click on Add note button
    Then Add note slider should be dislayed
    And Enter the title <Title> 
    And Enter the note <Note>
    When Click on Save button
    Then validation message should be displayed <NoteCreated>
    When Edit the note
    And Update the note <UpdateNote>
    When Click on Save button
    Then validation message should be displayed <NoteUpdated>
    And verify cancel button in notes delete popup
    When Delete the note
    Then validation message should be displayed <NoteDeleted>
    
   Examples:  
     | Title              | Note             | NoteCreated   | NoteUpdated   | NoteDeleted   | UpdateNote      |
     | TestAutomationNote | added first note | Note created. | Note updated. | Note deleted. | addedsecondnote |


@Regression @Opportunities @WWM-8597 @WW_OP_015
Scenario Outline: Verify user able to delete a opportunity card
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    When Delete the opportunity card
    Then validation message should be displayed <OpportunityDeleted>

  Examples:  
     | OpportunityDeleted   |
     | Opportunity deleted. | 


@Opportunities @WWM-8594 @WW_OP_016
@Regression @Regression_Full
Scenario Outline: Verify user able to add multiple services to a opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And Click on Service expand icon for opportunity
    And Click on Add Serivces button
    And Select the first services <FirstServices>
    When Click on Add services button in slider
    Then Service should be successfully added
    And click on add additional service or product button
    And Select the different services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
   
  Examples:  
     | OpportunityDeleted   | FirstServices        | Services                    |
     | Opportunity deleted. | ANT - Ant Treatments | BEDBUG - Bed Bug Treatment  |

@Opportunities @WWM-8595 @WW_OP_017
@Regression @Regression_Full
Scenario Outline: Verify user able to Delete already added service to a opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And Click on Service expand icon for opportunity
    And Click on Add Serivces button
    And Select the different services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    When Delete the already added service
   # Then validation message should be displayed <ServiceDeleted>
   

  Examples:  
     | OpportunityDeleted   | Services                   |
     | Opportunity deleted. | BEDBUG- Bed Bug Treatment  |


@Regression @Opportunities @WWM-8599 @WW_OP_018
Scenario Outline: Verify that a Close/Won Opportunity Cannot Send Additional Contracts
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	And Click on filters button
	And Select the opportunity status <OpportunityStatus>
    And Click on Apply button in filter slider
    And Click on Service expand icon
    When Mouse hover on send contracts button
    Then Toast message should be displayed <Toastmessage>
   

  Examples:  
      | OpportunityStatus | Toastmessage                                         |
      | Closed            | You cannot send a contract for a closed Opportunity. |


@Regression @Opportunities @WWM-8598 @WW_OP_019
Scenario Outline: Verify that a Closed/Won Opportunity Cannot Add, Edit or Delete Services
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	And Click on filters button
	And Select the opportunity status <OpportunityStatus>
    And Click on Apply button in filter slider
    And Click on Service expand icon
    When Mouse hover on Add service button
    Then Toast message should be displayed <Toastmessage>
    And Click on View services added link
    And Try to click add,Edit and delete additional service or product
    And Click on Close services and product button
    And Click on View detail page link
    And Click on View services added link
    And Try to click add,Edit and delete additional service or product    
    And Click on Close services and product button

  Examples:  
      | OpportunityStatus | Toastmessage                                     |
      | Closed            | You cannot add services to a closed Opportunity. |


@Opportunities @WWM-8434 @WW_OP_020 @WWM-9587 @ignore @WWM-10035-Defect
@Smoke
@Regression 
@Regression_Full
Scenario Outline: Verify User Can Add a Contract to an Opportunity
	When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And Click on Service expand icon for opportunity
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And  Click on proceed button
    When Click on Close form manager button
    When Click on View contracts link
    Then Contract should be successfully added
    And Click on Close icon in contract slider
    And Click on View detail page link
    When Click on View contracts link
    Then Same Contract form should be displayed in contracts slider
    And Click on Close icon in contract slider
    
  Examples:  
  | Template                  |
  | Residential Service Form  |

@Opportunities @WWM-9432 @WW_OP_021  @ignore @WWM-9833 
@Sanity
@Regression
@Regression_Full
Scenario Outline: Verification of basic regression Track A scenario
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
    And Click on Apply button in filter slider  
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>  
    And Navigate back to dashboard
    When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And  Click on Service expand icon
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And  Click on proceed button
    When Click on Close form manager button
    Then Contract should be successfully added
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
   # And Click on Service expand icon in opportunity page
    And Click on Capture card button
    And Enter the card holder name <CardHolderName>
    And Click on Enter button
    And Enter the card details <CardNumber>
    And Select the expiration month and year
    When Click on Add credit card button
    Then Card added successfully validation message should be displayed <CardAddedMessage>
    And Click on View detail page link
    And Click on closed won/closed lost bar
    When Select the closed won option
    Then Close won opportunity slider should be displayed
    When Click on Submit button in Close won opportunity slider

 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName   | Services            | FunnelStage | Ownername  | OpportunityCreated  | Template                 | ValMessage          | OpportunityName | ServiceLocation     | LocationMatchedValMsg                  | CardHolderName | CardNumber       | CardAddedMessage                   |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | Automation | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Residential Service Form | Opportunity Deleted | Automation Labs | 3600 STATE ROUTE 66 | Locations successfully matched/created | John Smith     | 4111111111111111 | Successfully added payment method. |

@Opportunities @9433 @WW_OP_022
@SmokeProd
Scenario Outline: Verification of basic regression Track B scenario
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
    And Click on Apply button in filter slider
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
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on convert to opportunity button after matching the location
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And  Click on Service expand icon
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And  Click on proceed button
    When Click on Close form manager button
    Then Contract should be successfully added
    And Click on View detail page link
    And Click on closed won/closed lost bar
    When Select the closed won option
    Then Close won opportunity slider should be displayed
    When Click on Submit button in Close won opportunity slider
    Then validation message should be displayed <ClosedWonSuccessfully>
    And Click on Capture card button
    And Enter the card holder name <CardHolderName>
    And Click on Enter button
    And Enter the card details <CardNumber>
    And Select the expiration month and year
    When Click on Add credit card button
   # Then validation message should be displayed <CardAddedMessage>

    Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName   | Services            | FunnelStage | Ownername  | OpportunityCreated  | Template                 | ValMessage          | OpportunityName | ServiceLocation     | LocationMatchedValMsg                  | CardHolderName | CardNumber       | CardAddedMessage                   | ClosedWonSuccessfully           |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | Automation | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Residential Service Form | Opportunity Deleted | Automation Labs | 3600 STATE ROUTE 66 | Locations successfully matched/created | John Smith     | 4111111111111111 | Successfully added payment method. | Opportunity closed successfully |


@Opportunities @9434 @WW_OP_023 @ignore
@Sanity

Scenario Outline: Verification of basic regression Track C scenario
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
    And Click on Apply button in filter slider  
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And  Click on proceed button
    When Click on Close form manager button
    Then Contract should be successfully added
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>  
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
    And Click on Service expand icon
    And Click on Capture card button
    And Enter the card holder name <CardHolderName>
    And Click on Enter button
    And Enter the card details <CardNumber>
    And Select the expiration month and year
    When Click on Add credit card button
    Then Added payment method validation message should be displayed
    And Click on View detail page link
    And Click on closed won/closed lost bar
    When Select the closed won option
    Then Close won opportunity slider should be displayed
    When Click on Submit button in Close won opportunity slider

Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName   | Services            | FunnelStage | Ownername  | OpportunityCreated  | Template                 | ValMessage          | OpportunityName | ServiceLocation     | LocationMatchedValMsg                  | CardHolderName | CardNumber       | 
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | Automation | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Residential Service Form | Opportunity Deleted | Automation Labs | 3600 STATE ROUTE 66 | Locations successfully matched/created | John Smith     | 4111111111111111 | 


@Opportunities @WW_OP_024 @WWM-9616 @ignore @WWM-9833 
@Regression 
@Regression_Full
Scenario Outline: Verification of Closed/Won Opportunity Info while sending it to core product(PestPac) SSQ
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
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button
    And  Click on complete form button
    And Click on proceed button
    When Click on Close form manager button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
    When Mouse hover on sales center side menu
    And Click on Opportunities link in leads page
    Then Opportunities page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
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
    Then Close won opportunity slider should be displayed
    And Select the Technicians details <Tech1> <Tech2> <Sales1> <Sales2>
    And Enter the sales note <SalesNote>
    When Click on Submit button in Close won opportunity slider
    Then validation message should be displayed <OpportunityClosed>
    
  
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | Template                 | Services            | OpportunityCreated  | Tech1 | Tech2  | Sales1 | Sales2 | SalesNote                               | OpportunityClosed               |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | Residential Service Form | ANT- Ant Treatments | Opportunity created | ADMN  | EDWARD | AKLEIN | DAVID  | sending it to core product(PestPac) SSQ | Opportunity closed successfully |
	

@Opportunities @WWM-8593 @WW_OP_025
@Regression
@Regression_Full
Scenario Outline: Verify user able to add new services and delete old services
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
    And  Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider  
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the different services <DiffServices>
    When Click on Add services button in slider
    Then Service should be successfully added
    When Delete the already added service
   # Then validation message should be displayed <ServiceDeleted>
 
 Examples:   
     | Services            | FunnelStage | Ownername  | OpportunityCreated  | OpportunityDeleteConfirmMessage | OpportunityName | DiffServices              |
     | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Opportunity Deleted             | Automation Labs | BEDBUG- Bed Bug Treatment |


@Opportunities @WWM-8591 @WW_OP_026 @ignore
@Regression
@Regression_Full
Scenario Outline: Verification of closing requirement counts in open cards for Opportunities
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
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on convert to opportunity button
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage> 
    Then validation message should be displayed <OpportunityCreated>
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider  
    And Click on Service expand icon
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button  
    And  Click on complete form button
    And  Click on proceed button
    Then Contract should be successfully added
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
    And Click on Capture card button
    And Enter the card holder name <CardHolderName>
    And Click on Enter button
    And Enter the card details <CardNumber>
    And Select the expiration month and year
    When Click on Add credit card button
    Then Validation message should be displayed <ValMessage>
    And Verify the service count
    When Click on view services added link
    Then Same service count should be displayed in Manage services and products page

Examples:   
      | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Services            | Template                 | CardHolderName | CardNumber       | ValMessage                         | ServiceLocation     | FunnelStage | Ownername  | OpportunityCreated  | LocationMatchedValMsg                  |
      | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | ANT- Ant Treatments | Residential Service Form | John Smith     | 4111111111111111 | Successfully added payment method. | 3600 STATE ROUTE 66 | Stage1      | Unassigned | Opportunity created | Locations successfully matched/created |
