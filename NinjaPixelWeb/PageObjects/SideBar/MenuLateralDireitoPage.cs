using OpenQA.Selenium;

namespace NinjaPixelWeb.PageObjects.SideBar
{
    public class MenuLateralDireitoPage
    {
        public static By NomeUsuario = By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/a/span");
        public static By ImgBanner = By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/a/div/img");
        public static By MenuCadastro = By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/ul/li[1]/a/p");
        public static By MenuApi = By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/ul/li[2]/a/p");
        public static By MenuBlog = By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/ul/li[3]/a/p");
    }
}
