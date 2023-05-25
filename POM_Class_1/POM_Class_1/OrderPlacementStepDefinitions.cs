using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class OrderPlacementStepDefinitions
    {
        OrderPlace_PageClass orderPlace = new OrderPlace_PageClass();

        [Given(@"navigate to homepage to select the product")]
        public void GivenNavigateToHomepageToSelectTheProduct()
        {

            orderPlace.DriverInitialize();
            orderPlace.OpenBrowserAndUrl();
        }

        [Given(@"select the size and color of the product and to cart")]
        public void GivenSelectTheSizeAndColorOfTheProductAndToCart()
        {
            orderPlace.select_features();
        }

        [Given(@"click on add to cart")]
        public void GivenClickOnAddToCart()
        {
            orderPlace.addToCart();
        }

        [Given(@"got to the cart option and click to proceed checkout")]
        public void GivenGotToTheCartOptionAndClickToProceedCheckout()
        {
            orderPlace.CartProceed();
        }

        [Given(@"enter all the details for the check out and click next")]
        public void GivenEnterAllTheDetailsForTheCheckOutAndClickNext()
        {
            orderPlace.fill_form();
        }

        [When(@"placing the order")]
        public void WhenPlacingTheOrder()
        {
            orderPlace.placeOrder();
        }

        [Then(@"validate the order confirmation message")]
        public void ThenValidateTheOrderConfirmationMessage()
        {
            orderPlace.validateSuccess();
        }

        [Given(@"check the warniing message")]
        public void GivenCheckTheWarniingMessage()
        {
            orderPlace.checkWarning();
        }

        [When(@"click on the add to cart button on next page")]
        public void WhenClickOnTheAddToCartButtonOnNextPage()
        {
            throw new PendingStepException();
        }

        [Then(@"validate the erro to fill all the required fields")]
        public void ThenValidateTheErroToFillAllTheRequiredFields()
        {
            orderPlace.emptyCart_CheckError();
        }
    }
}
