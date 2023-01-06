using OpenQA.Selenium;

namespace NinjaPixelWeb.PageObjects
{
    public class LoginPage
    {
        public static By ImgLogo = By.XPath("/html/body/div[1]/div[2]/div/div/div[1]/div/div/div/div[1]/img");
        public static By TituloFuncionalidade = By.XPath("/html/body/div[1]/div[2]/div/div/div[1]/div/div/div/div[1]/h4");
        public static By Email = By.XPath("//*[@id=\"emailId\"]");
        public static By Senha = By.XPath("//*[@id=\"passId\"]");
        public static By BtnEntrar = By.XPath("/html/body/div[1]/div[2]/div/div/div[1]/div/div/div/div[3]/button");

        public static By MsgInformeEmail = By.XPath("/html/body/div[1]/div[2]/div/div/div[1]/div/div/div/div[2]/div[3]/span/b");
        public static By MsgInformeSenha = By.XPath("/html/body/div[1]/div[2]/div/div/div[1]/div/div/div/div[2]/div[3]/span/b");
        public static By MsgInvalido = By.CssSelector("body > div:nth-child(1) > div.login-page > div > div > div.content > div > div > div > div.card-body > div.alert.alert-dismissible.fade.show.mb-0.mt-3.alert-danger");
    }
}
