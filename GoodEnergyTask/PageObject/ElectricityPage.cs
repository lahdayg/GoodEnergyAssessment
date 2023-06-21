using GoodEnergyTask.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodEnergyTask.PageObject
{
    class ElectricityPage
    {

        public ElectricityPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement Electricity => driver.FindElement(By.XPath("//h3[contains(text(),'Electricity')]"));
        IWebElement AccountNumber => driver.FindElement(By.XPath("//input[@id='ElecAccountNumber']"));
        IWebElement SerialNumber => driver.FindElement(By.XPath("//input[@id='ElecMeterSerialNumber']"));
        IWebElement Day => driver.FindElement(By.XPath("//select[@id='ElecDateOfReading_Value_Day']"));
        IWebElement Month => driver.FindElement(By.XPath("//select[@id='ElecDateOfReading_Value_Month']"));
        IWebElement Year => driver.FindElement(By.XPath("//select[@id='ElecDateOfReading_Value_Year']"));
        IWebElement MeterReading => driver.FindElement(By.XPath("//input[@id='ElecMeterReadingValue']"));
        IWebElement Submit => driver.FindElement(By.XPath("//button[contains(text(),'Submit')]"));
        IWebElement SuccessMessage => driver.FindElement(By.XPath("//h1[contains(text(),'Sorry, something went wrong, please try to submit ')]"));




        public bool IsElectricityPageDisplayed()
        {
            return Electricity.Displayed;
        }

        public void EnterAccountNumber(string accountnumber)
        {
            AccountNumber.SendKeys(accountnumber);
        }

        public void EnterSerialNumber(string serialnumber)
        {
            SerialNumber.SendKeys(serialnumber);
        }

        public void SelectDateFromDropDown()
        {
            SelectElement select = new SelectElement(Day);
            SelectElement select1 = new SelectElement(Month);
            SelectElement select2 = new SelectElement(Year);

            select.SelectByValue("21");
            select1.SelectByValue("06");
            select2.SelectByValue("2023");
        }

        public void EnterMeterReading(string meterreading)
        {
            MeterReading.SendKeys(meterreading);
        }

        public void ClickOnSubmitButton()
        {
            Submit.Click();
        }

        public bool IsSuccessMessageDisplayed()
        {
            return SuccessMessage.Displayed;
        }

    }
}
