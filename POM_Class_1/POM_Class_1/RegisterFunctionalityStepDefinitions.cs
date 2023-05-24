using OpenQA.Selenium.Chrome;
using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    [Binding]
    public class RegisterFunctionalityStepDefinitions
    {
        RegisterPageClass registerPageClass = new RegisterPageClass();

        [Given(@"naviagate to the register page url")]
        public void GivenNaviagateToTheRegisterPageUrl()
        {
            registerPageClass.DriverInitialize();
            registerPageClass.OpenBrowserAndUrl();
            registerPageClass.goto_url();
        }

        [When(@"enter valid personal info and singin info")]
        public void WhenEnterValidPersonalInfoAndSinginInfo()
        {
            registerPageClass.ValidRegister();
        }

        [When(@"click on create button to register the user")]
        public void WhenClickOnCreateButtonToRegisterTheUser()
        {
            registerPageClass.ClickCreate();
        }

        [Then(@"validate successful register message")]
        public void ThenValidateSuccessfulRegisterMessage()
        {
            registerPageClass.SuccessfulMessageValidation();
            registerPageClass.classDispose();
        }

        [When(@"enter valid personal info and invalid sigin info")]
        public void WhenEnterValidPersonalInfoAndInvalidSiginInfo()
        {
            registerPageClass.InvlaidSing_inInfo();
        }

        [Then(@"validate unsuccessful register message")]
        public void ThenValidateUnsuccessfulRegisterMessage()
        {
            registerPageClass.Unsuccessful_invalidmessage();
            registerPageClass.classDispose();

        }

        [Then(@"click on create button to register the user")]
        public void ThenClickOnCreateButtonToRegisterTheUser()
        {
            registerPageClass.ClickCreate();
        }

        [Then(@"validate empty input error message")]
        public void ThenValidateEmptyInputErrorMessage()
        {
            registerPageClass.Empty_validation();
            registerPageClass.classDispose();

        }
    }
}
