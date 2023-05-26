using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class WishlistFeatureStepDefinitions
    {
        WishlistPageClass wishlist = new WishlistPageClass();

        [Given(@"navigate to the homepage to select wishlist")]
        public void GivenNavigateToTheHomepageToSelectWishlist()
        {
            wishlist.DriverInitialize();
            wishlist.OpenBrowserAndUrl();

        }

        [When(@"item is added to the wishlist")]
        public void WhenItemIsAddedToTheWishlist()
        {
            wishlist.addItemsToWishlist();
        }

        [Then(@"Validate the error to login")]
        public void ThenValidateTheErrorToLogin()
        {
            wishlist.checkErrorMessage();
            wishlist.classDispose();
        }

        [When(@"login to the system")]
        public void WhenLoginToTheSystem()
        {
            wishlist.loginToAddWishlist();

        }

        [Then(@"Validate the success message")]
        public void ThenValidateTheSuccessMessage()
        {
            wishlist.validateSuccessrMessage();
            wishlist.classDispose();

        }
    }
}
