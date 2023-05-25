Feature: OrderPlacement

To check the process of order placement with porducts, without products and with more than one producs

@tag1
Scenario: validate the order placement feature 
	Given navigate to homepage to select the product
	And select the size and color of the product and to cart 
	And click on add to cart
	And got to the cart option and click to proceed checkout
	And enter all the details for the check out and click next
	When placing the order
	Then validate the order confirmation message


	@tag1
Scenario: validate the order placement feature without selecting any product
	Given navigate to homepage to select the product
	And click on add to cart
	And check the warniing message
	When click on the add to cart button on next page
	Then validate the erro to fill all the required fields
