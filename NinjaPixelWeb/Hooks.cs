using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;
using System.IO;
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
            //LigandoContainers();
            ChromeDriver = new ChromeDriver("Deploy");
            TipoUrl();
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
            //DesligandoContainer();
        }

        public void TipoUrl()
        {
            if (!File.Exists("C:\\NinjaPixelWeb\\NinjaPixelWeb\\Deploy\\HookConfig.json"))
            {
                Assert.Fail("HookConfig.json não foi encontrado");
            }

            try
            {
                string url = JObject.Parse(File.ReadAllText("C:\\NinjaPixelWeb\\NinjaPixelWeb\\Deploy\\HookConfig.json")).SelectToken("UrlDesenvolvimento").ToString();
                ChromeDriver.Url = url;
            }
            catch(Exception e) 
            {
                Assert.Fail($"Não foi possível recuperar as informações do arquivo HookConfig.json {e.Message} {e.StackTrace} {e.InnerException}");
            }
        }

        //public void LigandoContainers()
        //{
        //    System.Diagnostics.Process.Start("C:\\NinjaPixelWeb\\upDocker.bat");
        //    Thread.Sleep(11000);
        //}
        //public void DesligandoContainer()
        //{
        //    System.Diagnostics.Process.Start("C:\\NinjaPixelWeb\\stopDocker.bat");
        //    Thread.Sleep(11000);
        //}
    }
}