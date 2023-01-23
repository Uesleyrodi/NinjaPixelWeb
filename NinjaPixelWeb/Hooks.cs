using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Console;
using OpenQA.Selenium.Support.Events;
using System;
using System.Diagnostics;
using System.Threading;

namespace NinjaPixelWeb
{
    public class Hooks
    {
        private static ChromeDriver ChromeDriver;
        public static EventFiringWebDriver Driver;

        [TestInitialize]
        public void MyTestInitialize()
        {
            LigandoContainers();
            ChromeDriver = new ChromeDriver("Deploy");
            ChromeDriver.Url = "http://localhost:3000/login";
            ChromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Window.Maximize();

            Driver = new EventFiringWebDriver(ChromeDriver);
        }

        [TestCleanup]
        public void MyTestCleanup()
        {
            Driver.Quit();
            ChromeDriver.Quit();
            DesligandoContainer();
        }

        public void LigandoContainers()
        {
            System.Diagnostics.Process.Start("C:\\NinjaPixelWeb\\upDocker.bat");
            Thread.Sleep(11000);
        }
        public void DesligandoContainer()
        {
            System.Diagnostics.Process.Start("C:\\NinjaPixelWeb\\stopDocker.bat");
            Thread.Sleep(11000);
        }
    }
}