using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.SideBar;
using System;
using System.Threading;

namespace NinjaPixelWeb.Steps.SideBar
{
    public class MenuTopoSteps : Hooks
    {
        public static void ClickMinimizaMenuLateral()
        {
            Driver.FindElement(MenuTopoPage.MinimizaLateral).Click();
        }

        public static void ClickCadastroProduto()
        {
            Driver.FindElement(MenuTopoPage.CadastroProduto).Click();
        }

        public static void ClickitemNavegacao()
        {
            Driver.FindElement(MenuTopoPage.ItemNavegacao).Click();
        }

        public static void ClickItemCadastroProduto()
        {
            Driver.FindElement(MenuTopoPage.ItemCadastroProduto).Click();
        }

        public static void ClickItemApiDoc()
        {
            Driver.FindElement(MenuTopoPage.ItemApiDoc).Click();
        }

        public static void ClickSair()
        {
            Driver.FindElement(MenuTopoPage.ItemSair).Click();
        }

        public static void CheckItemNavegacao()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Driver.FindElement(MenuTopoPage.ItemCadastroProduto).Displayed);
            Assert.IsTrue(Driver.FindElement(MenuTopoPage.ItemApiDoc).Displayed);
            Assert.IsTrue(Driver.FindElement(MenuTopoPage.ItemSair).Displayed);
        }

        public static void CheckRedirecionamentoApi()
        {
            foreach (var handle in Driver.WindowHandles)
            {
                Driver.SwitchTo().Window(handle);
            }
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);

            var UrlBlog = Driver.Url;
            Assert.AreEqual(UrlBlog, "http://pixel-api:3333/apidoc/");
        }
    }
}
