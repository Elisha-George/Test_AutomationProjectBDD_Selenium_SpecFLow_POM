Feature: ReviewFunctionality

To test the review functionality

@tag1
Scenario: to validate the working of review functionality with data
	Given Navigate to the hompage and click on the product
	And Click on Reviews section
	And 5 stars and all data is filled 
	When clicke on submit button
	Then validate of the review is submitted successfully


Scenario: to validate the working of review functionality without data
	Given Navigate to the hompage and click on the product
	And Click on Reviews section
	When click on submit button
	Then Check the error to fill all required fields
