using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.SideBar;

namespace NinjaPixelWeb.Steps.SideBar
{
    public class RightSideBar : Hooks
    {
        public static void CheckNomeUsuario()
        {
            Assert.IsTrue(Driver.FindElement(PageObjects.SideBar.RightSideBar.NomeUsuario).Displayed);
        }
    }
}
