
@Login
Feature: Login

@Smoke @WW_LG_001
Scenario: Login with valid credentials
	Given Home page
	When Login attempt
	Then Login successful


@Smoke @WW_LG_002
Scenario Outline: Login with invalid credentials
	Given Home page
	When Login attempt <Username> <Password>
	Then Login failed due to invalid credentials <CredentialsError>
	
	Examples:  
      | Username                  | Password   | CredentialsError              |
	  | ntambad_evry@workwave.com | WorkWave22 | Invalid username or password  |
		 


