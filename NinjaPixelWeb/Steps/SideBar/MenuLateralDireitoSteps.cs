using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.SideBar;

namespace NinjaPixelWeb.Steps.SideBar
{
    public class MenuLateralDireitoSteps : Hooks
    {

        public static void CheckNomeUsuario()
        {
            Assert.IsTrue(Driver.FindElement(MenuLateralDireitoPage.NomeUsuario).Displayed);
        }

        public static void CheckRecuoMenuLateral()
        {
            Assert.IsTrue(Driver.FindElement(MenuLateralDireitoPage.MenuCadastro).Enabled, "CADASTRO");
            Assert.IsTrue(Driver.FindElement(MenuLateralDireitoPage.MenuApi).Enabled, "API DOC");
            Assert.IsTrue(Driver.FindElement(MenuLateralDireitoPage.MenuBlog).Enabled, "BLOG");
        }

        public static void CheckRedirecionamentoBanner()
        {
            var UrlBlog = Driver.Url;
            Assert.AreEqual(UrlBlog, "http://qaninja.io/");
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

        public static void CheckRedirecionamentoBlog()
        {
            foreach (var handle in Driver.WindowHandles)
            {
                Driver.SwitchTo().Window(handle);
            }
            Driver.SwitchTo().Window(Driver.WindowHandles[1]);

            var UrlBlog = Driver.Url;
            Assert.AreEqual(UrlBlog, "http://qaninja.io/");
        }

        public static void CheckRedirecionamentoCadastro()
        {
            Driver.FindElement(MenuLateralDireitoPage.MenuApi).Click();
        }

        public static void ClickImgBanner()
        {
            Driver.FindElement(MenuLateralDireitoPage.ImgBanner).Click();
        }
        public static void ClickMenuCadastro()
        {
            Driver.FindElement(MenuLateralDireitoPage.MenuCadastro).Click();
        }

        public static void ClickMenuApi()
        {
            Driver.FindElement(MenuLateralDireitoPage.MenuApi).Click();
        }

        public static void ClickBlog()
        {
            Driver.FindElement(MenuLateralDireitoPage.MenuBlog).Click();
        }
    }
}
