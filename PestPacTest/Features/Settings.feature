Feature: Settings
	I want to able to verify the all the settings  pages

Background: 
	Given I am logged in

@WW_ST_001
@WWM-8401
@smoke
Scenario: Verify Display of Settings Home Page
    When Click on Settings Gear Icon
    Then Settings page should be displayed

@WW_ST_002
@smoke
Scenario: Verify Display of Company Setup Page
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And Click on Company Setup link
    Then Company Setup page should be displayed

@WW_ST_003
@smoke
Scenario: Verify Display of Roles and Permission  Page
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And Click on Roles and Permissions link
    Then Roles and Permissions page should be displayed

@WW_ST_004
@smoke
Scenario: Verify Display of User and Access  Page
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And Click on User and Access link
    Then User and Access page should be displayed

@WW_ST_005
@smoke
Scenario: Verify Display of Sales Funnel Page
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And Click on Sales Funnels link
    Then Sales Funnels page should be displayed

@WW_ST_006
@smoke
Scenario: Verify Display of Sales Team Page
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And  Click on Sales Teams link
    Then Sales Teams page should be displayed


@WW_ST_007
@WWM-8403
@smoke
Scenario Outline: Verify User is able to Add and Delete the  new role
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And  Click on Roles and Permissions link
    Then Roles and Permissions page should be displayed
    And  Click on Add Role button
    And  Enter the role name <RoleName>   
    When Click on Add Role button in slider
  # Then Validation message should be displayed
    When Delete the role
   # Then Validation mesage hould be displayed


   Examples: 
   | RoleName            |
   | Auto Sales manager1 |


@WW_ST_008
@WWM-8402
@smoke
Scenario Outline: Verify user is able to Add and Delete the sales funnel
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And  Click on Sales Funnels link
    Then Sales Funnels page should be displayed
    And  Click on Add Sales Funnel button
    And  Enter the sales funnel name <FunnelName>
    When Click on Save button in add sales funnel slider
  # Then Validation message should be displayed
    And Click on three dots icon for ales funnel
    When Click on Delete option for sales funnel 
   # Then Validation mesage hould be displayed

   Examples: 
   | FunnelName          |
   | Automation funnel1  |


@WW_ST_009
@WWM-8406
@smoke
Scenario Outline: Verify User is Able to Add and delete the UnMapped User 
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And  Click on User and Access link
    Then User and Access page should be displayed
    And  Click on Add UnMapped User button
    And  Enter the user details <FirstName> <LastName> <Email>
    And  Select the User Role <UserRole>
    And  Click on Add Sales Team option
    And  Select the Sales Team from the drdopdown<Salesteam>
    And  Select the team position
    When Click on Save button
    Then Validation message should be displayed <ConfirmMessage>
    When Delete the unmapped user
    Then User deleted confirmation mesage should be displayed <UserDeleted>

   Examples: 
     | FirstName       | LastName | Email              | UserRole              | SalesTeam            | ConfirmMessage                    | UserDeleted   |
     | Automation user | Test     | autouser@gmail.com | AutomationTestingRole | AutoTestingSalesTeam | User created. Welcome email sent. | User deleted  |


@WW_ST_010
@WWM-8404
@smoke
Scenario Outline: Verify User is Able to Add and delete the Sales Team
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And  Click on Sales Teams link
    Then Sales Teams page should be displayed
    And  Click on Add Sales Team button 
    And  Enter the Sales Team Name <SalesTeamName>
    And  Select the Branch name <BranchName>
    When Click on Save button in add sales team slider
    Then Sales team created validation message should be displayed <ConfirmMessage>
      
   Examples: 
     | SalesTeamName  | BranchName               | ConfirmMessage     | 
     | autosalesteam  | Sales Center Test Branch | Sales Team created | 

    
@WW_ST_011
@smoke
@WWM-8405
Scenario Outline: Verify Admin Users Can Add Positions to Sales Teams
    When Click on Settings Gear Icon
    Then Settings page should be displayed
    And  Click on Sales Teams link
    Then Sales Teams page should be displayed
    And  Click on Add Sales Team button 
    And  Enter the Sales Team Name <SalesTeamName>
    And  Select the Branch name <BranchName>
    When Click on Save button in add sales team slider
    Then Sales team created validation message should be displayed <ConfirmMessage>
    And  Click on Add Position button
    And  Enter the position title <title>
    When Click on Save button 
    Then Sales team position created validation message should be displayed <Positionvalmsg>
    When Delete the sales team
    Then SalesTeam deleted confirmation mesage should be displayed <SalesTeamDeleted>
    
   Examples: 
     | SalesTeamName   | BranchName               | ConfirmMessage     | SalesTeamDeleted    | title        | Positionvalmsg               |
     | autosalesteam   | Sales Center Test Branch | Sales Team created | Sales Team deleted. | SalesManager | Sales Team Position created  |
     


  
       