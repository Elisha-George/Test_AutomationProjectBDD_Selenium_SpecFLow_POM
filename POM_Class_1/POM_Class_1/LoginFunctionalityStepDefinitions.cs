using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class LoginFunctionalityStepDefinitions
    {
        LoginPageClass loginPageClass = new LoginPageClass();

        [Given(@"go to the login url")]
        public void GivenGoToTheLoginUrl()
        {
            loginPageClass.DriverInitialize();
            loginPageClass.OpenBrowserAndUrl();
            loginPageClass.goto_url();
        }

        [When(@"enter valid email and password")]
        public void WhenEnterValidEmailAndPassword()
        {
            loginPageClass.ValidLogin();
        }

        [Then(@"validate the successful message")]
        public void ThenValidateTheSuccessfulMessage()
        {
            loginPageClass.SuccessfulMessageValidation();
            loginPageClass.classDispose();
        }

        [When(@"enter wrong email and password")]
        public void WhenEnterWrongEmailAndPassword()
        {
            loginPageClass.InvalidLogin();
        }

        [Then(@"validate the invalid login message")]
        public void ThenValidateTheInvalidLoginMessage()
        {
            loginPageClass.UnsuccessfulMessageValidation();
            loginPageClass.classDispose();
        }
    }
}
