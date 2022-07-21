@Leads
Feature: Leads
	
Background: 
	Given I am logged in



@Leads @WWM-8420  @WW_LD_001
@SmokeProd
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify default display of Lead Card   
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
  
@Leads @WWM-8416 @WW_LD_002
@SmokeProd
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify user can create and delete a lead   
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
    When Delete the lead
    Then Lead deleted confirmation message should be displayed <DeleteConfirmMessage>
    
 Examples:  
     | FirstName        | LastName | CompanyName  | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | DeleteConfirmMessage | 
     | Automation user2 | Test2    | autocompany2 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | Lead deleted.        | 
	 

@WWM-8427 @Leads @WW_LD_003
@SmokeProd
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify user can create lead and convert to opportunity
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
 
 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName   | Services            | FunnelStage | Ownername  | OpportunityCreated  | OpportunityDeleteConfirmMessage | OpportunityName |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | Automation | ANT- Ant Treatments | Stage1      | Unassigned | Opportunity created | Opportunity Deleted             | Automation Labs |


@Leads @WWM-8428 @WW_LD_004
@SmokeProd
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify user able to create new opportunity directly 
    When Click on plus icon
    And  Click on Create opportunity button
    And Search the lead <LeadName>
    When Click on Create opportunity button in create opportunity page 
    Then Create opportunity slider should be displayed
    When Click on Apply button
    Then Create opportunity page should be displayed
    And click on add additional service or product button
    And Select the services <Services>
    When Click on Add services button in create new opportunity slider
    Then Service should be successfully added
    And Select the SalesTeam <SalesTeam>
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage>
    Then validation message should be displayed <OpportunityCreated>
 
 Examples:  
      | Services            | SalesTeam                  | FunnelStage | Ownername  | FunnelName        | OpportunityCreated  | LeadName  |
      | ANT- Ant Treatments | Secondary south sales Team | Stage1      | Unassigned | Test Sales funnel | Opportunity created | qa        |



@Leads @WWM-8422  @8422 @WW_LD_005
@SmokeProd
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify User Can Add a Contract to a Lead
    When Click on plus icon
    And Click on Add Lead button
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
    And  Click on Service expand icon
    And  Click on Add Serivces button
    And  Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on send contract button
    Then Create contract slider should be displayed
    And  Select contract template <Template> and click on launch form to complete button  
    And  Click on complete form button
    And  Click on proceed button
    Then Contract should be successfully added

Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Services            | Template                 |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | ANT- Ant Treatments | Residential Service Form |


@Leads @WWM-8426  @WW_LD_006
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify User Can Re-Open a Disqualified Lead 
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
    And  Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider 
    And  Click on filters button   
    And  Select the lead status <LeadStatus>
    When Click on Apply button
    Then All the disqualified leads should be diplayed
    And Click on three dots icon for disqualified lead
    And Select the reopen option
    And Select Qualify option in popup <Qualify>
    When Click on Save button in Re-Open Lead popup
   # Then Lead should be successfully reopened validation message should be displayed

Examples:  
     | LeadStatus   | Qualify  | 
     | Disqualified | Qualify  | 


@Leads @WWM-8423 @WW_LD_007
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify user able to attach lead card to existing location  
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
    And  Click on search icon
    And  Enter the lead name <LeadName> and click on search icon
    And Click on Bill to locations expand icon  
    When Click on Match or create link
    Then Match or create new location slider should be displayed
    And Click to match to existing location button
    And Select the pestpac location 
    When Click on Save button in bill to search for matching slider
    And Select match to service location <ServiceLocation>
    When Click on Save button
    Then Location matched validation message should be displayed <LocationMatchedValMsg>
  
 Examples:  
     | FirstName        | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  |
     | Automation user3 | Test3    | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created |                     
	 
	 
@Leads @WWM-8430 @WW_LD_008
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify user able to edit the services on opportunity form
    When Click on plus icon
    And Click on Add Lead button
    Then Add Lead details page should be displayed
    And Enter the lead details <FirstName> <LastName> <CompanyName> <Email> 
    And Select the SalesTeam <SalesTeam>
    And Select the Owner <Owner> 
    And Select the sales funnel <SalesFunnel>
    When Click on Save button
    Then Lead created validation message should be displayed <ValidationMessage>
    And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider  
    And Click on Service expand icon
    And Click on Add Serivces button
    And Select the services <Services>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button   
    When Click on view services added link
    Then Manage services and products page should be displayed
    And Click on three dots icon in update service or product slider
    And Select the other service <UpdateServcie>
    And click on update servcie button
    When click on close convert lead button
    Then Leads page should be displayed

  
Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Services            | UpdateService   |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | ANT- Ant Treatments | EXTERIOR LIGHT  |

@Regression @Leads  @WWM-8443 @WW_LD_009
Scenario: Verification of multiple records selection on Leads List View Page
	When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider  
	And Click on List view button
	When select the all checkbox option
	Then checkbox should be selected


@Leads @WWM-8424 @WW_LD_0010
@Smoke
@Regression
@Regression_Full
Scenario Outline: Verify user able to create a new location in PP from a lead card   
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
    When Click on Create new location tab
    Then Create new location page should be displayed
    When Click on Edit button for bill to location
    Then Update location slider should be displayed
    And Enter the address details <Address> <City> <State> <PostalCode>
    When Click on Save button update location slider
    Then Location matched validation message should be displayed <LocationMatchedValMsg>
    When Click on Edit button for service location
    Then Update location slider should be displayed
    And Enter the address details <Address> <City> <State> <PostalCode>
    When Click on Save button update location slider
    Then Location matched validation message should be displayed <LocationMatchedValMsg>
    When Click on Save button
    Then Location created successfully message should be displayed <LocationValMsg>
    
 Examples:  
     | FirstName | LastName | CompanyName   | Email          | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Address        | City    | State | PostalCode | LocationMatchedValMsg                           | LocationValMsg                 |
     | John      | Smith    | autocompany03 | john@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | 200 street san | chester | PA    | 93013-373  | A Service Location has been added successfully. | Locations Created Successfully |

@Regression @Opportunities @WWM-8446 @WW_LD_011
Scenario Outline: Verification of Bulk Re-assignment of leads which are associated with same branch Sales Team 
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	And Click on List view button
	And Select the multiple leads
	When Click on Reassign button
	Then Reassign slider should be displayed
    And Select the same branch SalesTeam in reassign slider <SalesTeam>
    And Select the team member in reassign slider <SalesTeamMember>
	When Click on Save button
    Then validation message should be displayed <ValidationMessage>

  Examples:  
     | SalesTeam            | SalesTeamMember | ValidationMessage                  |
     | Auto Test Sales Team | unassigned      | Bulk update successfully applied   |


@Leads @WWM-8418 @WW_LD_012
@Smoke
@Regression 
@Regression_Full
Scenario Outline: Verify duplicate alerts are displayed when there is matching First Name ,Last Name ,Phone, Email address from an existing lead or opportunity
    When Click on plus icon
    And  Click on Add Lead button
    Then Add Lead details page should be displayed
    When Enable show only required fields toggle on
    When Enter the first name <FirstName>
    Then Duplicate alerts count should be displayed
    When Click on Dulicate alerts link
    Then Same duplicate alerts count should be displayed in duplicate alert page
    When Click on close duplicate alert button
    Then Add Lead details page should be displayed
     
 Examples:  
     | FirstName       | 
     | Qa              | 


@Regression @Leads @WWM-8613 @WW_LD_013
Scenario Outline: Verify user not able to add invalid payment card for a matched Lead to a PP location  
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
    And Click on Service expand icon in opportunity page
    And Click on Capture card button
    And Enter the card holder name <CardHolderName>
    And Click on Enter button
    And Enter the card details <CardNumber>
    And Select the expiration month and year
    When Click on Add credit card button
    Then Error message should be displayed <ErrorMessage>
  
 Examples:  
     | FirstName        | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | LeadName    | LocationName | ServiceLocation     | LocationMatchedValMsg                  | CardHolderName | CardNumber        | ErrorMessage       |
     | Automation user3 | Test3    | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | autocompany | QA Labs      | 3600 STATE ROUTE 66 | Locations successfully matched/created | John Smith     | 4111111111111231  | INVALID CARD INFO  |                         
	 

@Regression @Leads @WWM-8612 @WW_LD_014
Scenario Outline: Veriy user not able to add payment card with out matching lead to a PP location
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
    When Mouse hover on capture button
    Then Toast message should be displayed <Toastmessage>
   
  
 Examples:  
     | FirstName        | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Toastmessage                                                       |
     | Automation user3 | Test3    | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | Link this lead to a location to view/capture payment information.  |
	 
	 
@Regression  @Leads @WW_LD_015
Scenario Outline: Verify User Can Disqualified Lead 
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
    And  Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider 
    And Click on Lead status field
    When Select the lead status in dropdown <Leadstatus>
    Then Disqulified popup should be displayed
    And Select the Not interested radio button
    When Click on save button in disqualified popup
    Then validation message should be displayed <LeadDisqualified>

Examples:  
     | LeadStatus   | LeadDisqualified  |
     | Disqualified | Lead Disqualified |
	 

@Regression @Leads @WWM-8444 @WW_LD_016
Scenario Outline: Verify that user can Bulk reopen the multiple disqualified Leads at once_Automation
	When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider  
	And Click on filters button
	And  Select the lead status <LeadStatus>
    When Click on Apply button
    Then All the disqualified leads should be diplayed
	And Click on List view button
	And Select the multiple opportunities
	When Click on Reopen button
	Then Reopen slider should be displayed
	When Click on Save button
    Then validation message should be displayed <ReopenedLeads>

 Examples:  
     | LeadStatus   | ReopenedLeads                     |
     | Disqualified | Bulk update successfully applied  |


@Leads @WWM-8421 @WW_LD_017
@SmokeProd
@Smoke
@Regression 
@Regression_Full
Scenario Outline: Verify user able to add service to a lead
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
    When Click on view services added link
    Then Service should be successfully added
    And Click on Close services and product button
    When Click on View details page link
    Then Lead detail page should be displayed
    When Click on view services added link
    Then Service should be successfully added
    And Click on Close services and product button

 
 Examples:  
      | Services            | 
      | ANT- Ant Treatments | 

@Smoke  @Leads @WWM-9436 @WW_LD_018 @ignore @WWM-10168
Scenario Outline:Verify user able to Create WWM Contact for Lead
	When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	When Click on View details page link
    Then Lead detail page should be displayed
    When Click on view contacts link
    Then Contacts page should be displayed
    And Click on workwave contacts tab
    When Click on Add contact button
    Then Add contact slider should be displayed
    And Click on Add new contact tab
    And Enter the contact details <FirstName> <LastName> <Email>
    When Click on Create contact button
    When Remove the contact for leads
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
    | FirstName | LastName | Email           |
    | James     | Jacob    | james@gmail.com |

@Smoke  @Leads @WWM-9439 @WW_LD_019
Scenario Outline:Verify user able to Edit WWM Contact for Lead
	When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	When Click on View details page link
    Then Lead detail page should be displayed
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
    When Remove the contact for leads
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
     | ExistingContact | CompanyName     |
     | James           | James pvt ltd   | 

@Smoke @Leads @WWM-9438 @WW_LD_020
Scenario Outline:Verify user able to Remove WWM Contact for Lead
	When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
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
    And Search the existing contact <ExistingContact>
    And Click on Add contact button
    When Remove the contact for leads
    #Then Confirmation message should be displayed <ContactDeleted>
    	
   Examples:  
     | ExistingContact | 
     | James           | 

@WWM-8592 @Leads @WW_LD_021
@Regression
@Regression_Full
Scenario Outline: Verify user should not be able to convert a lead to opportunity if there are no services in the lead
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
    When Try to click on Convert to Opportunity button
    Then Toast message should be displayed <Toastmessage>

 Examples:  
     | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Toastmessage                                                      |
     | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | Add services to this lead to convert it into a sales opportunity  |


@Leads @WWM-8578  @WW_LD_022
@Regression
@Regression_Full
Scenario Outline: Verify Users Can Edit the Lead Details   
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
    When Click on View details page link
    Then Lead detail page should be displayed
    And Click on grey pencil edit icon
    And Rename this field popup should be displayed
    And Update first name and last name <UpdateFirstName> <UpdateLastName>
    When Click on Save button
    Then validation message should be displayed <UpdatedLeads>
    And Verify updated names displayed in the details page
    When Click on edit link for bill to location
    Then Update bill to location slider should be displayed
    And Select Branch Location type and division <Branch> <LocationType> <Division>
    And Update first name and last name <UpdateFirstName> <UpdateLastName>
    And Enter the address details <Address> <City> <State> <PostalCode>
    When Click on Save button
    Then Bill to location updated validation message should be displayed <BillToUpdated>
    And Click on View more information link
    And Verify the updated billto location details
    When Click on edit link for service location
    Then Update service location slider should be displayed
    And Select Branch Location type and division <Branch> <LocationType> <Division>
    And Update first name and last name <UpdateFirstName> <UpdateLastName>
    And Enter the address details <Address> <City> <State> <PostalCode>
    When Click on Save button
    Then Bill to location updated validation message should be displayed <ServiceLocationUpdated >
    And Click on View more information link for service location
    And Verify the updated billto location details
    When Click on Edit link for additional information
    Then Edit additional information slider should be displayed
    And Update additional information details <SalesTeamName> <OwnerName> <SalesFunnelName> <LeadStatus> <TargetPets> <Campaign> <LeadSource>
    When Click on Save button
    Then validation message should be displayed <LeadInformationUpdated>
    And Verify lead updated information details
    
Examples:  
      | FirstName        | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | UpdateFirstName | UpdateLastName | UpdatedLeads       | Branch      | LocationType       | Division                | Address        | City    | State | PostalCode | BillToUpdated                 | ServiceLocationUpdated                 | SalesTeamName           | OwnerName   | SalesFunnelName   | TargetPets | LeadStatus | Campaign | LeadSource | LeadInformationUpdated |
      | Automation user3 | Test3    | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | James           | Smith          | Lead name updated. | Main Branch | HOSPITAL- Hospital | CONSTRUCT- Construction | 200 street san | chester | PA    | 93013-373  | Bill-to successfully updated. | Service Location successfully updated. | South Branch Sales Team | Chad Kochel | Test Sales funnel | CLOVR MITE | Qualify    | CUSTOMER | RECOMMEND  | Lead information updated. |

@Leads @WWM-8577 @WW_LD_023
@Regression
@Regression_Full
Scenario Outline: Verify a User can Create,Edit and delete a Note on an Lead
	When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
	And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
	When Click on View details page link
    Then Lead detail page should be displayed
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

@Leads @WWM-8573 @WW_LD_024
@Regression 
@Regression_Full
Scenario Outline: Verify default display of duplicate alerts detail page
    When Click on plus icon
    And  Click on Add Lead button
    Then Add Lead details page should be displayed
    When Enable show only required fields toggle on
    When Enter the first name <FirstName>
    Then Duplicate alerts count should be displayed
    When Click on Dulicate alerts link
    Then Same duplicate alerts count should be displayed in duplicate alert page
    And Click on workwave contacts tab
    And Verify workwave marketing contacts column details
    When Click on pestpac location tab
    Then Verify the pestpac location column names
        
 Examples:  
     | FirstName       | 
     | Qa              | 

@Leads @WWM-8574 @WW_LD_025
@Regression 
@Regression_Full
Scenario Outline: Verify user able to create new opportunity from duplicate alert detail page for a pestpac location
    When Click on plus icon
    And  Click on Add Lead button
    Then Add Lead details page should be displayed
    When Enable show only required fields toggle on
    When Enter the first name <FirstName>
    Then Duplicate alerts count should be displayed
    When Click on Dulicate alerts link
    Then Same duplicate alerts count should be displayed in duplicate alert page
    When Click on pestpac location tab
    Then Verify the pestpac location column names
    When Click on Create opportunity button in create opportunity page
    Then Create opportunity page should be displayed
    And click on add additional service or product button
    And Select the services <Services>
    When Click on Add services button in create new opportunity slider
    Then Service should be successfully added
    And Select the SalesTeam <SalesTeam>
    When Select the lead details <OwnerName> <FunnelName> <FunnelStage>
    Then validation message should be displayed <OpportunityCreated>

        
 Examples:  
     | FirstName | Services            | SalesTeam                   | FunnelStage | Ownername  | FunnelName         | OpportunityCreated |
     | james     | ANT- Ant Treatments | Secondary south sales Team  | Stage1      | Unassigned | Test Sales funnel  | Opportunity created |         

@Leads @WWM-8564  @WW_LD_026
@Regression
@Regression_Full
Scenario Outline: Verify user able to delete a lead card  
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
    And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    When Delete the lead card
    Then validation message should be displayed <LeadDeleted>

  Examples:  
    | LeadDeleted   | 
    | Lead deleted. |   

@Leads @WWM-8562 @WW_LD_027
@Regression 
@Regression_Full
Scenario Outline: Verify user is able to edit already added service to a lead
    When Click on plus icon
    And Click on Add Lead button
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
    When Click on view services added link
    Then Manage services and products page should be displayed
    And Click on three dots icon in update service or product slider
    And Update the servcie details <UpdateServcie> <IntialPrice>
    And click on update servcie button
    And Click on view details expand icon
    And Verify the updated details
    And Delete the service

    
 Examples:  
       | FirstName        | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage  | Services            | UpdateServcie  | IntialPrice   |
       | Automation Labs  | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created       | ANT- Ant Treatments | EXTERIOR LIGHT | 50            |

@Leads @WWM-8561  @WW_LD_028
@Regression
@Regression_Full
Scenario: Verify default display of Add service or Product slideout
    When Mouse hover on sales center side menu
    And Click on Leads link
    Then Leads page should be displayed
    And Click on filters button
    And Click on clear filter button
    And Click on Apply button in filter slider
    And Click on Service expand icon
    And Click on Add Serivces button
    And Veriry the details in add servcie or product slide out
    
@Leads @WWM-8560 @WW_LD_029
@Regression 
@Regression_Full
Scenario Outline: Verify user is able to add discount in dollar amount or percentage while adding service
    When Click on plus icon
    And Click on Add Lead button
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
    And Enter the initial price and discount percentage <InitialPrice> <DiscountPercentage>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button     
    And Click on Add Serivces button
    And Select the services <Services>
    And Enter the initial price and discount percentage <InitialPrice1> <DiscountPercentage1>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    And Delete the service

    
 Examples:  
       | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Services            |  InitialPrice  | DiscountPercentage  | InitialPrice1 | DiscountPercentage1  |
       | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | ANT- Ant Treatments |     50         |      10             |    60         |         11%          |

@Leads @WWM-8559 @WW_LD_030
@Regression 
@Regression_Full
Scenario Outline: Verify user able to add multiple services to a lead
    When Click on plus icon
    And Click on Add Lead button
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
    And Enter the initial price and discount percentage <InitialPrice> <DiscountPercentage>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button     
    And Click on Add Serivces button
    And Select the services <Services>
    And Enter the initial price and discount percentage <InitialPrice> <DiscountPercentage>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button
    And Click on Add Serivces button
    And Select the services <Services>
    And Enter the initial price and discount percentage <InitialPrice> <DiscountPercentage>
    When Click on Add services button in slider
    Then Service should be successfully added
    And Click on Close services and product button   
    And Verify the service count
    When Click on view services added link
    Then Same service count should be displayed in Manage services and products page
    
 Examples:  
       | FirstName       | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | Services            |  InitialPrice  | DiscountPercentage  | 
       | Automation Labs | Labs03   | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      | ANT- Ant Treatments |     50         |      10             |    


@Leads @WWM-8558  @WW_LD_031
@Regression
@Regression_Full
Scenario Outline: Verify newly added lead is displayed with all the details correctly on lead cards   
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
    And Verify the company details
    When Click on View primary contact link
    Then Verify the lead details
    

Examples:  
      | FirstName        | LastName | CompanyName   | Email              | SalesTeam                  | Owner      | SalesFunnel                 | ValidationMessage | 
      | Automation user3 | Test3    | autocompany03 | autouser@gmail.com | Secondary south sales Team | Unassigned | Required Contract & Payment | Lead created      |