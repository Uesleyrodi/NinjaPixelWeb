using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.Steps;
using NinjaPixelWeb.Steps.SideBar;
using System;

namespace NinjaPixelWeb.Feature
{
    [TestClass]
    public class LoginFeature : Hooks
    {
        [TestMethod]
        public void CheckLoginTest()
        {
            Console.WriteLine("Dado: Que usuário deseja acessar plataforma Ninja Pixel");
            Console.WriteLine("Quando: Acessar plataforma");
            Console.WriteLine("Então: O sistema deverá exibir tela de Login");

            LoginSteps.CheckLogin();
        }

        [TestMethod]
        public void DadosBrancosTest()
        {
            Console.WriteLine("Dado: que usuário deseja logar na aplicação");
            Console.WriteLine("E: Manter os campos em brancos");
            Console.WriteLine("Quando: Clicar no botão [Entrar]");
            Console.WriteLine("Então: O sistema deverá informar mensagem de erro ao usuário, mantê-lo na tela de Login.");

            LoginSteps.ClickEntrar();
            LoginSteps.CheckMsgInformeEmail();
        }

        [TestMethod]
        public void PreencherSomenteCampoEmailTest()
        {
            Console.WriteLine("Dado: Que usuário deseja logar na aplicação");
            Console.WriteLine("E: Preencher campo @Email com dados válidos");
            Console.WriteLine("E: Manter o campo @senha em branco");
            Console.WriteLine("Quando: clicar no botão [Entrar]");
            Console.WriteLine("Então: O sistema deverá informar mensagem de erro ao usuário, mantê-lo na tela de Login.");

            LoginSteps.SetEmail("");
            LoginSteps.SetSenha("pwd123");
            LoginSteps.ClickEntrar();
            LoginSteps.CheckMsgInformeSenha();
        }

        [TestMethod]
        public void PreencherSomenteCampoSenhaTest()
        {
            Console.WriteLine("Dado: Que usuário deseja logar na aplicação");
            Console.WriteLine("E: Manter o campo @Email em branco");
            Console.WriteLine("E: Preencher campo @Senha com dado válido");
            Console.WriteLine("Quando: clicar no botão [Entrar]");
            Console.WriteLine("Então: O sistema deverá informar mensagem de erro ao usuário, mantê-lo na tela de Login.");

            LoginSteps.SetEmail("uesley@ninjapixel.com");
            LoginSteps.SetSenha("");
            LoginSteps.ClickEntrar();
            LoginSteps.CheckMsgInformeSenha();
        }

        [TestMethod]
        public void UsuarioSenhaInvalidoTest()
        {
            Console.WriteLine("Dado: Que usuário deseja logar na aplicação");
            Console.WriteLine("E: Preencher os dados @Email e @senha com usuário inválidos");
            Console.WriteLine("Quando: clicar no botão [Entrar]");
            Console.WriteLine("Então: O sistema deverá informar mensagem de erro ao usuário, mantê-lo na tela de Login.");

            LoginSteps.SetCredeciais("uesley@teste.com", "pwd123");
            LoginSteps.ClickEntrar();
            LoginSteps.CheckMsgInvalido();
        }

        [TestMethod]
        public void UsuarioLogado()
        {
            Console.WriteLine("Dado: Que usuário deseja logar na aplicação");
            Console.WriteLine("E: Preencher as credenciais de acessos");
            Console.WriteLine("Quando: clicar no botão [Entrar]");
            Console.WriteLine("Então: O sistema deverá autenticar as credenciais de acesso e direcionar usuário a área logada.");

            LoginSteps.SetCredeciais("uesley@ninjapixel.com", "pwd123");
            LoginSteps.ClickEntrar();
            SidebarSteps.CheckUsuario();
            
        }
    }
}
