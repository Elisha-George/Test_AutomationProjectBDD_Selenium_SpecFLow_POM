Feature: AdvanceSearchFunctionality

To check the advance search functionality feature

@tag1
Scenario: validate the advance search with complete data
	Given click on advance search and navigate to it
	And all the the deatils are filled 
	When click on the search button
	Then validate the product

@tag1
Scenario: validate the advance search by name only
	Given click on advance search and navigate to it
	And the name of the product is filled
	When click on the search button
	Then validate the product

		@tag1
Scenario: validate the advance search with invalid price range
	Given click on advance search and navigate to it
	And the price field is filled with alphabets
	When click on the search button
	Then validate the product

	@tag1
Scenario: validate the advance search without any data
	Given click on advance search and navigate to it
	When click on the search button
	Then validate the product
