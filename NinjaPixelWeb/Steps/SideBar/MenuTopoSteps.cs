using NinjaPixelWeb.PageObjects.SideBar;

namespace NinjaPixelWeb.Steps.SideBar
{
    public class MenuTopoSteps : Hooks
    {
        public static void ClickMinimizaMenuLateral()
        {
            Driver.FindElement(MenuTopoPage.MinimizaLateral).Click();
        }
    }
}
