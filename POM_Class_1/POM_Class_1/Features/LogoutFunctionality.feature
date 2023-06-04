Feature: LogoutFunctionality

To check the working the logout feature 

@tag1
Scenario: validate the logout functionality
	Given when I  navigate to the url 
	And i login to the account
	When I click the logout button
	Then validate the message
