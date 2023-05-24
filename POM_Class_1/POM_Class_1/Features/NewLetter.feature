Feature: NewsLetterFunctionality

This feature file is to validate the newsletter
@tag1
Scenario: validate the newsletter with valid email address
	Given I open the homepage
	When I enter the a new email address
	And click the subscribed button
	Then validate the success message


 @tag1 
Scenario: validate the newsletter with registered email address
	Given when I open the homepage
	When i enter the a registered email address
	And click the subscribed button
	Then validate the error message


	 @tag1 
Scenario: validate the newsletter witout email address
	Given when I open the homepage
	When click the subscribed button
	Then validate the empty error message