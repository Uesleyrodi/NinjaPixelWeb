using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.SideBar;

namespace NinjaPixelWeb.Steps.SideBar
{
    public class SidebarSteps : Hooks
    {
        public static void CheckUsuario()
        {
            Assert.IsTrue(Driver.FindElement(SidebarPage.NomeUsuario).Displayed, "Uesley");
        }
    }
}
