using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects;
using System;

namespace NinjaPixelWeb.Steps
{
    public class LoginSteps : Hooks
    {
        public static void CheckLogin()
        {
            Assert.IsTrue(Driver.FindElement(LoginPage.ImgLogo).Displayed);
            Assert.AreEqual("Login", (Driver.FindElement(LoginPage.TituloFuncionalidade).Text));
            Console.WriteLine(Driver.FindElement(LoginPage.TituloFuncionalidade).Text);
            Assert.IsTrue(Driver.FindElement(LoginPage.Senha).Displayed);
            Assert.IsTrue(Driver.FindElement(LoginPage.BtnEntrar).Displayed);
        }

        public static void CheckMsgInformeEmail()
        {
            Assert.IsTrue(Driver.FindElement(LoginPage.MsgInformeEmail).Displayed, "Opps. Informe o seu email!");
        }

        public static void CheckMsgInformeSenha()
        {
            Assert.IsTrue(Driver.FindElement(LoginPage.MsgInformeSenha).Displayed, "Opps. Informe a sua senha!");
        }

        public static void CheckMsgInvalido()
        {
            Assert.IsTrue(Driver.FindElement(LoginPage.MsgInvalido).Displayed, "Usuário e/ou senha inválidos");
        }

        public static void SetCredeciais(string email, string senha)
        {
            Driver.FindElement(LoginPage.Email).SendKeys(email);
            Driver.FindElement(LoginPage.Senha).SendKeys(senha);
        }

        public static void SetEmail(string email)
        {
            Driver.FindElement(LoginPage.Email).SendKeys(email);
        }

        public static void SetSenha(string senha)
        {
            Driver.FindElement(LoginPage.Senha).SendKeys(senha);
        }

        public static void ClickEntrar()
        {
            Driver.FindElement(LoginPage.BtnEntrar).Click();
        }

        public static void Login(string email, string senha)
        {
            Driver.FindElement(LoginPage.Email).SendKeys(email);
            Driver.FindElement(LoginPage.Senha).SendKeys(senha);
            ClickEntrar();
        }
    }
}
