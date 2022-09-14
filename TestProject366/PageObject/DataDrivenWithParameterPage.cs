using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject366.Utilities;

namespace TestProject366.PageObject
{
    class DataDrivenWithParameterPage
    {

        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='basicBootstrapForm']/div[1]/div[1]/input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("#eid > input"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Gender => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(5) > div > label:nth-child(2) > input"));
        IWebElement Country => driver.FindElement(By.CssSelector("select[id='countries']"));
        
        IWebElement SubmitButton => driver.FindElement(By.CssSelector("button[id='submitbtn']"));

        public void EnterFirstName(string firstname)
        {
            FirstName.SendKeys(firstname);
        }


        public void EnterLastName(string lastname)
        {
            LastName.SendKeys(lastname);
        }


        public void EnterEmailAddress(string emailaddress)
        {
            EmailAddress.SendKeys(emailaddress);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterPhoneNumber(string phonenumber)
        {
            PhoneNumber.SendKeys(phonenumber);
        }


        public void ClickOnGender()
        {
            Gender.Click();
        }


        public void ClickOnSubmitButton()
        {
            SubmitButton.Click();
        }

        public void SelectCountryFromDropDown()
        {
            SelectElement select = new SelectElement(Country);
            select.SelectByText("Select Country");
        }



    }
}
