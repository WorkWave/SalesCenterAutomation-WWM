
@Login

Feature: Login
	I want to be able to login to the application.


@Smoke
@Login_positive
@WW_LG_001
Scenario: Login with valid credentials
	Given Home page
	When Login attempt
	Then Login successful

@Login_negative
@WW_LG_002
Scenario Outline: Login with invalid credentials
	Given Home page
	When Login attempt <Username> <Password>
	Then Login failed due to invalid credentials <CredentialsError>
	
	Examples:  
      | Username                  | Password   | CredentialsError     |
	  | ntambad_evry@workwave.com | WorkWave22 | Please log in again. |
		 


