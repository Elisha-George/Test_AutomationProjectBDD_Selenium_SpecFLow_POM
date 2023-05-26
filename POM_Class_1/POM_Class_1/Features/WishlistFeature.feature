Feature: WishlistFeature

validate the wishlist functionality


@tag1
Scenario: to validate the working of wishlist with login
	Given navigate to the homepage to select wishlist
	When item is added to the wishlist
	Then Validate the error to login




@tag1
Scenario: to validate the working of wishlist without login 
	Given navigate to the homepage to select wishlist
	When item is added to the wishlist
	And login to the system
	Then Validate the success message 
