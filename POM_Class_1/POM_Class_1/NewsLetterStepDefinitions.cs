using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class NewsLetterStepDefinitions
    {
        NewsLetterPageClass newsLetterPageClass = new NewsLetterPageClass();

        [Given(@"I open the homepage")]
        public void GivenIOpenTheHomepage()
        {
            newsLetterPageClass.DriverInitialize();

            newsLetterPageClass.OpenBrowserAndUrl();
        }

        [When(@"I enter the a new email address")]
        public void WhenIEnterTheANewEmailAddress()
        {
            newsLetterPageClass.NewsLetter_New();
        }

        [When(@"click the subscribed button")]
        public void WhenClickTheSubscribedButton()
        {
            newsLetterPageClass.clickSubscribe();
        }

        [Then(@"validate the success message")]
        public void ThenValidateTheSuccessMessage()
        {
            newsLetterPageClass.validate_successMsg();
            newsLetterPageClass.classDispose();

        }

        [Given(@"when I open the homepage")]
        public void GivenWhenIOpenTheHomepage()
        {
            newsLetterPageClass.DriverInitialize();

            newsLetterPageClass.OpenBrowserAndUrl();

        }

        [When(@"i enter the a registered email address")]
        public void WhenIEnterTheARegisteredEmailAddress()
        {
            newsLetterPageClass.NewsLetter_Registered();
        }

        [Then(@"validate the error message")]
        public void ThenValidateTheErrorMessage()
        {
            newsLetterPageClass.validate_ErrorMsg();
            newsLetterPageClass.classDispose();

        }
        [Then(@"validate the empty error message")]
        public void ThenValidateTheEmptyErrorMessage()
        {
            newsLetterPageClass.validate_EmptyMsg();
        }
    }
}
