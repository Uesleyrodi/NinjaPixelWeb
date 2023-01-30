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
                Assert.Fail($"Não foi possível recuperar informações do arquivo LoginConfig.json {e.Message}, {e.StackTrace}, {e.InnerException}");
            }

            Assert.IsTrue(Driver.FindElement(LoginPage.ImgLogo).Displayed);
            Assert.IsTrue(Driver.FindElement(LoginPage.Email).Displayed);
            Assert.IsTrue(Driver.FindElement(LoginPage.Senha).Displayed);
        }

        public static void CheckMsgInformeEmail()
        {
            if(!File.Exists("Deploy\\LoginConfig.json"))
            {
                Assert.Fail("LoginConfig.json não foi encontrado");
            }

            try
            {
                string Mensagem = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("MsgInformeEmail").ToString();
                Assert.AreEqual(Mensagem, Driver.FindElement(LoginPage.MsgInformeEmail).Text);
            }
            catch(Exception e)
            {
                Assert.Fail($"Não foi possível recuperar informações do arquivo LoginConfig.json {e.Message}, {e.StackTrace}, {e.InnerException}");
            }
        }

        public static void CheckMsgInformeSenha()
        {
            VerificaArquivoExistente();

            try
            {
                string Mensagem = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("MsgInformeSenha").ToString();
                Assert.AreEqual(Mensagem, Driver.FindElement(LoginPage.MsgInformeSenha).Text);
            }
            catch(Exception e)
            {
                Assert.Fail($"Não foi possível recuperar informações do arquivo LoginConfig.json {e.Message}, {e.StackTrace}, {e.InnerException}");
            }
        }

        public static void CheckMsgInvalido()
        {
            VerificaArquivoExistente();
            try
            {
                string Mensagem = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("MsgInvalido").ToString();
                Assert.AreEqual(Mensagem, Driver.FindElement(LoginPage.MsgInvalido).Text);
            }
            catch(Exception e)
            {
                Assert.Fail($"Não foi possível recuperar informações do arquivo LoginConfig.json {e.Message}, {e.StackTrace}, {e.InnerException}");
            }
        }

        public static void SetCredeciais(string email, string senha)
        {
            Driver.FindElement(LoginPage.Email).SendKeys(email);
            Driver.FindElement(LoginPage.Senha).SendKeys(senha);
        }

        public static void SetEmail()
        {
            VerificaArquivoExistente();

            try
            {
                string Email = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("Email").ToString();
                Driver.FindElement(LoginPage.Email).SendKeys(Email);
            }

            catch (Exception e)
            {
                Assert.Fail($"Não foi possível recuperar informações do arquivo LoginConfig.json {e.Message}, {e.StackTrace}, {e.InnerException}");
            }
        }

        public static void SetSenha()
        {
            if(!File.Exists("Deploy\\LoginConfig.json"))
            {
                Assert.Fail("LoginConfig.json não foi encontrado");
            }

            try
            {
                string Senha = JObject.Parse(File.ReadAllText("Deploy\\LoginConfig.json")).SelectToken("Senha").ToString();
                Driver.FindElement(LoginPage.Senha).SendKeys(Senha);
            }

            catch (Exception e)
            {
                Assert.Fail($"Não foi possível recuperar informações do arquivo LoginConfig.json {e.Message}, {e.StackTrace}, {e.InnerException}");
            }
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

        public static void VerificaArquivoExistente()
        {
            if (!File.Exists("Deploy\\LoginConfig.json"))
            {
                Assert.Fail("LoginConfig.json não foi encontrado");
            }
        }
    }
}
