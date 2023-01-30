using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using NinjaPixelWeb.PageObjects;
using System;
using System.IO;

namespace NinjaPixelWeb.Steps
{
    public class LoginSteps : Hooks
    {
        public static void CheckLogin()
        {
            //Garantir que o arquivo LoginConfig.json exista
            if (!File.Exists("Deploy\\LoginConfig.json"))
            {
                Assert.Fail("LoginConfig.json não foi encontrado");
            }

            //Necessário tratar possíveis excessões vindas da Leitura do arquivo, precidso garantir que as variáveis também exista.
            try
            {
                string TituloFuncionalidade = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("TituloFuncionalidade").ToString();
                string TextoElemento = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("BotaoEntrar").ToString();

                Assert.AreEqual(TituloFuncionalidade, Driver.FindElement(LoginPage.TituloFuncionalidade).Text);
                Assert.AreEqual(TextoElemento, Driver.FindElement(LoginPage.BtnEntrar).Text);
            }
            catch (Exception e)
            {
                Assert.Fail("Não foi possível recuperar informações do arquivo LoginConfig.json", e.Message, e.StackTrace, e.InnerException);
            }

            Assert.IsTrue(Driver.FindElement(LoginPage.ImgLogo).Displayed);
            Assert.IsTrue(Driver.FindElement(LoginPage.Email).Displayed);
            Assert.IsTrue(Driver.FindElement(LoginPage.Senha).Displayed);
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
