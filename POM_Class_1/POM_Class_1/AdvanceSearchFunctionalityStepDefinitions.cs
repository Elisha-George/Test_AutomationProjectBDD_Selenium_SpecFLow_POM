using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class AdvanceSearchFunctionalityStepDefinitions
    {

        AdvanceSearch advanceSearch = new AdvanceSearch();

        [Given(@"click on advance search and navigate to it")]
        public void GivenClickOnAdvanceSearchAndNavigateToIt()
        {
            advanceSearch.DriverInitialize();
            advanceSearch.OpenBrowserAndUrl();
            advanceSearch.navigateToAdvanceSearch();
        }

        [Given(@"all the the deatils are filled")]
        public void GivenAllTheTheDeatilsAreFilled()
        {
            advanceSearch.FillFormDetails();
        }

        [When(@"click on the search button")]
        public void WhenClickOnTheSearchButton()
        {
            advanceSearch.ClickSearch();
        }

        [Then(@"validate the product success")]
        public void ThenValidateTheProductSuccess()
        {
            advanceSearch.ValidateSuccess();
            advanceSearch.classDispose();
        }

        [Given(@"the name of the product is filled")]
        public void GivenTheNameOfTheProductIsFilled()
        {

            advanceSearch.FillNameOnly();
        }

        [Given(@"the price field is filled with alphabets")]
        public void GivenThePriceFieldIsFilledWithAlphabets()
        {
            advanceSearch.InvliadPrice();
        }

        [Then(@"check the invlid field error")]
        public void ThenCheckTheInvlidFieldError()
        {
            advanceSearch.InvliadPrice();
            advanceSearch.classDispose();
        }

        [Then(@"validate the product")]
        public void ThenValidateTheProduct()
        {
            advanceSearch.CheckEmptyError();
            advanceSearch.classDispose();

        }
    }
}
