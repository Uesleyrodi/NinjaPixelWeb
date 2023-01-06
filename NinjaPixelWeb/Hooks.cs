using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;

namespace NinjaPixelWeb
{
    public class Hooks
    {
        private static ChromeDriver ChromeDriver;
        private static EventFiringWebDriver Driver;

        [TestInitialize]
        public void MyTestInitialize()
        {
            ChromeDriver = new ChromeDriver("Deploy");
            ChromeDriver.Url = "";
            ChromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Window.Maximize();

            Driver = new EventFiringWebDriver(ChromeDriver);
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            ChromeDriver.Quit();
            Driver.Quit();
        }
    }
}