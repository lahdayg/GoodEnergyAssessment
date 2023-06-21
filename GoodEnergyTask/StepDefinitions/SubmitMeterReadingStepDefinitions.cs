using GoodEnergyTask.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GoodEnergyTask.StepDefinitions
{
    [Binding]
    public class SubmitMeterReadingStepDefinitions
    {
        HomePage homePage;
        AboutYouPage aboutYouPage;
        ElectricityPage electricityPage;

        public SubmitMeterReadingStepDefinitions()
        {
            homePage = new HomePage();
            aboutYouPage = new AboutYouPage();  
            electricityPage= new ElectricityPage();

        }


        [Given(@"I navigate to good energy website ""([^""]*)""")]
        public void GivenINavigateToGoodEnergyWebsite(string url)
        {
            homePage.NavigateToWebsite(url);
        }

        [Given(@"I click on Electricity")]
        public void GivenIClickOnElectricity()
        {
            homePage.ClickOnElectricity();
        }

        [Given(@"I tick the box for first meter reading")]
        public void GivenITickTheBoxForFirstMeterReading()
        {
            homePage.ClickOnTickBox();
        }

        [When(@"I click on Next")]
        public void WhenIClickOnNext()
        {
            homePage.ClickOnNextButton();
        }

        [Then(@"the about you page should be displayed")]
        public void ThenTheAboutYouPageShouldBeDisplayed()
        {
            Assert.That(aboutYouPage.IsAboutYouPageDisplayed);
        }

        [Then(@"I enter my name ""([^""]*)""")]
        public void ThenIEnterMyName(string name)
        {
            aboutYouPage.EnterName(name);
        }

        [Then(@"I enter my email address ""([^""]*)""")]
        public void ThenIEnterMyEmailAddress(string email)
        {
            aboutYouPage.EnterEmail(email);
        }

        [Then(@"I enter my postcode ""([^""]*)""")]
        public void ThenIEnterMyPostcode(string postcode)
        {
            aboutYouPage.EnterPostcode(postcode);
        }

        [Then(@"the electricity page should be displayed")]
        public void ThenTheElectricityPageShouldBeDisplayed()
        {
            Assert.That(electricityPage.IsElectricityPageDisplayed);
        }

        [Then(@"I enter the account number ""([^""]*)""")]
        public void ThenIEnterTheAccountNumber(string accountnumber)
        {
            electricityPage.EnterAccountNumber(accountnumber);
        }

        [Then(@"I enter meter serial number ""([^""]*)""")]
        public void ThenIEnterMeterSerialNumber(string serialnumber)
        {
            electricityPage.EnterSerialNumber(serialnumber);
        }

        [Then(@"I enter date of reading")]
        public void ThenIEnterDateOfReading()
        {
            electricityPage.SelectDateFromDropDown();
        }

        [Then(@"I enter meter reading ""([^""]*)""")]
        public void ThenIEnterMeterReading(string meterreading)
        {
            electricityPage.EnterMeterReading(meterreading);
        }

        [When(@"I click on Submit")]
        public void WhenIClickOnSubmit()
        {
            electricityPage.ClickOnSubmitButton();
        }

        [Given(@"I accept all cookies")]
        public void GivenIAcceptAllCookies()
        {
            homePage.ClickOnAcceptCookies();
        }

        [Then(@"the submission should be made successfully")]
        public void ThenTheSubmissionShouldBeMadeSuccessfully()
        {
            Assert.That(electricityPage.IsSuccessMessageDisplayed);
        }

        [Then(@"a message should appear on the screen to please enter your postcode")]
        public void ThenAMessageShouldAppearOnTheScreenToPleaseEnterYourPostcode()
        {
            Assert.That(aboutYouPage.IsEnterYourPostcodeDisplayed);
        }





    }
}
