Feature: ContactUsFunctionality

To test the contact us form on the website

@tag1
Scenario: validate the contact us form with valid data
	Given go to the contact us page
	When enetr all the data in the form
	And click on the submit button
	Then validate the success responce message 

	
@tag1
Scenario: validate the contact us form witout required inputs
	Given go to the contact us page
	When enetr data in filed except the required fields
	And click on the submit button
	Then check the error  



@tag1
Scenario: validate the contact us form witout any data
	Given go to the contact us page
	When click on the submit button
	Then check the error  
  

  