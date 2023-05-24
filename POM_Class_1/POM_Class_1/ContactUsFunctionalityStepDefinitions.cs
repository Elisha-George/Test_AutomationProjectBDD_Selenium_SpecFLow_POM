using POM_Class_1.PageClass;
using System;
using TechTalk.SpecFlow;

namespace POM_Class_1
{
    

    [Binding]
    public class ContactUsFunctionalityStepDefinitions
    {
        ContactUSPageClass contactUS = new ContactUSPageClass();

        [Given(@"go to the contact us page")]
        public void GivenGoToTheContactUsPage()
        {
            contactUS.DriverInitialize();
            contactUS.OpenBrowserAndUrl();
            contactUS.navigate_contactus();
        }

        [When(@"enetr all the data in the form")]
        public void WhenEnetrAllTheDataInTheForm()
        {
            contactUS.Fill_Fullform();
        }

        [When(@"click on the submit button")]
        public void WhenClickOnTheSubmitButton()
        {
            contactUS.submitForm();
        }

        [Then(@"validate the success responce message")]
        public void ThenValidateTheSuccessResponceMessage()
        {
            contactUS.validateSuccessResponce();
            contactUS.classDispose();
        }

        [When(@"enetr data in filed except the required fields")]
        public void WhenEnetrDataInFiledExceptTheRequiredFields()
        {
            contactUS.notRequiredData();

        }

        [Then(@"check the error")]
        public void ThenCheckTheError()
        {
            contactUS.checkError();
            contactUS.classDispose();

        }
    }
}
