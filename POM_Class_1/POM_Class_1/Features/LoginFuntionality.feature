Feature: LoginFunctionality
	ths login feature is for the checking the login with valid and invalid data

@mytag
Scenario: validate the login functionality with valid inputs
	Given go to the login url
	When enter valid email and password
	Then validate the successful message


	@mytag
Scenario: check the login functionality wiht invlid inputs
	Given go to the login url
	When enter wrong email and password
	Then validate the invalid login message

	
