Feature: Settings
	I want to able to verify the all the settings  pages

Background: 
	Given I am logged in

@WW_SM_001
@smoke
Scenario: Verify Display of Settings Home Page
    When I click on Settings Gear Icon
    Then Settings page should be displayed

@WW_SM_002
@smoke
Scenario: Verify Display of Company Setup Page
    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Company Setup link
    Then Company Setup page should be displayed

@WW_SM_003
@smoke
Scenario: Verify Display of Roles and Permission  Page
    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Roles and Permissions link
    Then Roles and Permissions page should be displayed

@WW_SM_004
@smoke
Scenario: Verify Display of User and Access  Page

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on User and Access link
    Then User and Access page should be displayed

@WW_SM_005
@smoke
Scenario: Verify Display of Sales Funnel Page

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Sales Funnels link
    Then Sales Funnels page should be displayed

@WW_SM_006
@smoke
Scenario: Verify Display of Sales Team Page

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Sales Teams link
    Then Sales Teams page should be displayed


@WW_SM_007
@smoke
Scenario Outline: Verify User is able to Add and Delete the  new role

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Roles and Permissions link
    Then Roles and Permissions page should be displayed
    And I Click on Add Role button
    And I enter the role name <RoleName>   
    When I click on Add Role button in slider
  # Then Validation message should be displayed
    And i click on three dots icon
    And I click on Delete option
    When I click on Delete button in popup
   # Then Validation mesage hould be displayed


   Examples: 
   | RoleName            |
   | Auto Sales manager1 |


@WW_SM_008
@smoke
Scenario Outline: Verify user is able to Add and Delete the sales funnel

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Sales Funnels link
    Then Sales Funnels page should be displayed
    And I Click on Add Sales Funnel button
    And I enter the sales funnel name <FunnelName>
    When I click on Save button in add sales funnel slider
  # Then Validation message should be displayed
    And I click on three dots icon for ales funnel
    When I click on Delete option for sales funnel 
   # Then Validation mesage hould be displayed

   Examples: 
   | FunnelName          |
   | Automation funnel1  |


@WW_SM_009
@smoke
Scenario Outline: Verify User is Able to Add and delete the UnMapped User 

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on User and Access link
    Then User and Access page should be displayed
    And I Click on Add UnMapped User button
    And I enter the user details <FirstName> <LastName> <Email>
    And I select the User Role <UserRole>
    And I click on Add Sales Team option
    And I select the Sales Team from the drdopdown<Salesteam>
    And I select the team position
    When I click on Save button in add unmapped user slider
    Then Validation message should be displayed <ConfirmMessage>
    And I click on three dots icon for added user
    And I click on Delete option for unmapped user
    When I click on Delete button in unmappeduser popup
    Then User deleted confirmation mesage should be displayed <UserDeleted>

   Examples: 
     | FirstName       | LastName | Email              | UserRole              | SalesTeam            | ConfirmMessage                    | UserDeleted   |
     | Automation user | Test     | autouser@gmail.com | AutomationTestingRole | AutoTestingSalesTeam | User created. Welcome email sent. | User deleted  |


@WW_SM_010
@smoke
Scenario Outline: Verify User is Able to Add and delete the Sales Team

    When I click on Settings Gear Icon
    Then Settings page should be displayed
    And I click on Sales Teams link
    Then Sales Teams page should be displayed
    And I click on Add Sales Team button 
    And I enter the Sales Team Name <SalesTeamName>
    And I select the Branch name <BranchName>
    When I click on Save button in add sales team slider
    Then Sales team created validation message should be displayed <ConfirmMessage>
    And I click on Add Position button
    And I enter the position title <title>
    When I click on save button
    Then Sales team position created validation message should be displayed <Positionvalmsg>
    And I click on three dots icon for added salesteam
    When I click on Delete option for added salesteam
    Then SalesTeam deleted confirmation mesage should be displayed <SalesTeamDeleted>
    
   Examples: 
     | SalesTeamName  | BranchName               | ConfirmMessage     | SalesTeamDeleted    | title        | Positionvalmsg               |
     | autosalesteam  | Sales Center Test Branch | Sales Team created | Sales Team deleted. | SalesManager | Sales team position created  |
     

    



  
       