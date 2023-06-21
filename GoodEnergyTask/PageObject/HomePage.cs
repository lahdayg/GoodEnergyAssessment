using GoodEnergyTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodEnergyTask.PageObject
{
    class HomePage
    {
        public HomePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Electricity => driver.FindElement(By.XPath("//label[text()='Electricity']"));
        IWebElement TickBox => driver.FindElement(By.XPath("//*[@id=\"is-this-first-meter-reading\"]/label"));
        IWebElement NextButton => driver.FindElement(By.XPath("//button[contains(text(),'Next')]"));
        IWebElement AcceptCookes => driver.FindElement(By.XPath("//button[contains(text(),'Allow all cookies')]"));


        public void ClickOnElectricity()
        {
            Electricity.Click();
        }

        public void ClickOnTickBox()
        {
            TickBox.Click();
        }

        public void ClickOnNextButton() 
        {
            NextButton.Click();
        }

        public void ClickOnAcceptCookies()
        {
            AcceptCookes.Click();
        }

        public void NavigateToWebsite(string url) 
        {
            driver.Navigate().GoToUrl(url);
        }



    }
}
