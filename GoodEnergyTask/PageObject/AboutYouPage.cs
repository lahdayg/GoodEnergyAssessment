using GoodEnergyTask.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodEnergyTask.PageObject
{
    class AboutYouPage
    {
        public AboutYouPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement AboutYou => driver.FindElement(By.XPath("//h3[contains(text(),'About you')]"));
        IWebElement Name => driver.FindElement(By.XPath("//input[@id='Name']"));
        IWebElement Email => driver.FindElement(By.XPath("//input[@id='Email']"));
        IWebElement Postcode => driver.FindElement(By.XPath("//input[@id='Postcode']"));
        IWebElement EnterYourPostcode => driver.FindElement(By.XPath("//span[@id='Postcode-error']"));



        public bool IsAboutYouPageDisplayed()
        {
            return AboutYou.Displayed;
        }

        public void EnterName(string name) 
        {
            Name.SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPostcode(string postcode)
        {
            Postcode.SendKeys(postcode);
        }

        public bool IsEnterYourPostcodeDisplayed()
        {
            return EnterYourPostcode.Displayed;
        }


    }
}
