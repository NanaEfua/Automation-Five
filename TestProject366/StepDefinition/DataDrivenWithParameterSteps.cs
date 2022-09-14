using System;
using TechTalk.SpecFlow;
using TestProject366.PageObject;

namespace TestProject366.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my first name""(.*)""")]
        public void GivenIEnterMyFirstName(string firstname)
        {
            dataDrivenWithParameterPage.EnterFirstName(firstname);
        }
        
        [Given(@"I enter my last name ""(.*)""")]
        public void GivenIEnterMyLastName(string lastname)
        {
            dataDrivenWithParameterPage.EnterLastName(lastname);
        }
        
        [Given(@"I enter my email address""(.*)""")]
        public void GivenIEnterMyEmailAddress(string emailaddress)
        {
            dataDrivenWithParameterPage.EnterEmailAddress(emailaddress);
        }
        
        [Given(@"I enter my phone number""(.*)""")]
        public void GivenIEnterMyPhoneNumber(string phonenumber)
        {
            dataDrivenWithParameterPage.EnterPhoneNumber(phonenumber);
        }
        
        [Given(@"I click on my gender")]
        public void GivenIClickOnMyGender()
        {
            dataDrivenWithParameterPage.ClickOnGender();
        }


        [Given(@"I select country from dropdown")]
        public void GivenISelectCountryFromDropdown()
        {
            dataDrivenWithParameterPage.SelectCountryFromDropDown();
        }



        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            dataDrivenWithParameterPage.ClickOnSubmitButton();
        }
        
        [Then(@"I can register successfully")]
        public void ThenICanRegisterSuccessfully()
        {
            
        }
    }
}
