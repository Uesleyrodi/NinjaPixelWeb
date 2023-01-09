using OpenQA.Selenium;

namespace NinjaPixelWeb.PageObjects.SideBar
{
    public class MenuTopoPage
    {
        public static By MinimizaLateral = By.XPath("//*[@id=\"minimizeSidebar\"]");
        public static By CadastroProduto = By.XPath("//*[@id=\"navigation\"]/ul/ul/li[1]/a/i");
        public static By ItemNavegacao = By.XPath("//*[@id=\"navigation\"]/ul/ul/li[2]/a/i");
        public static By ItemCadastroProduto = By.XPath("//*[@id='navigation']/ul/ul/li[2]/ul/a[1]");
        public static By ItemApiDoc = By.XPath("//*[@id=\"navigation\"]/ul/ul/li[2]/ul/a[2]");
        public static By ItemSair = By.XPath("//*[@id=\"navigation\"]/ul/ul/li[2]/ul/a[3]");
    }
}
