using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class ReviewFunctionalityStepDefinitions
    {
        ReviewPageClass reviews = new ReviewPageClass();

        [Given(@"Navigate to the hompage and click on the product")]
        public void GivenNavigateToTheHompageAndClickOnTheProduct()
        {
            reviews.DriverInitialize();
            reviews.OpenBrowserAndUrl();
            reviews.goToProductDetail();
        }

        [Given(@"Click on Reviews section")]
        public void GivenClickOnReviewsSection()
        {
            reviews.clickReviewsSection();
        }

        [Given(@"(.*) stars and all data is filled")]
        public void GivenStarsAndAllDataIsFilled(int p0)
        {
            reviews.reviewFormSubmission();
        }

        [When(@"clicke on submit button")]
        public void WhenClickeOnSubmitButton()
        {
            reviews.clickSubmit();
        }

        [Then(@"validate of the review is submitted successfully")]
        public void ThenValidateOfTheReviewIsSubmittedSuccessfully()
        {
            reviews.validateSuccessMessage();
            reviews.classDispose();
        }

        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            reviews.clickSubmit();
        }

        [Then(@"Check the error to fill all required fields")]
        public void ThenCheckTheErrorToFillAllRequiredFields()
        {
            reviews.checkErrorMessage();
            reviews.classDispose();

        }
    }
}
