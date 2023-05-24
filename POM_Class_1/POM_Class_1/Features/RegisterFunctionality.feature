Feature: RegisterFunctionality

to validate the registration page by putting valid and invalid data

@tag1
Scenario: validate the registereration form for new user with valid data
	Given naviagate to the register page url
	When enter valid personal info and singin info
	And click on create button to register the user
	Then validate successful register message



@tag1
Scenario: validate the registereration form for new user with invalid Singin information
	Given naviagate to the register page url
	When enter valid personal info and invalid sigin info
	And click on create button to register the user
	Then validate unsuccessful register message


		
@tag1
Scenario: validate the registereration form for new user without any data
	Given naviagate to the register page url
	Then click on create button to register the user
	Then validate empty input error message

