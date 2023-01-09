using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.Steps;
using NinjaPixelWeb.Steps.CadastroProdutos;
using NinjaPixelWeb.Steps.SideBar;
using System;

namespace NinjaPixelWeb.Feature
{
    [TestClass]
    public class MenuLateralDireitoFeature : Hooks
    {
        [TestMethod]
        public void RecuarMenuLateralTest()
        {
            Console.WriteLine("Dado: Que deseja recuar 'Menu Lateral'");
            Console.WriteLine("Quando: Clicar no ícone [Minimizar barra lateral]");
            Console.WriteLine("Então: O sistema deverá recuar barra de lateral.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuTopoSteps.ClickMinimizaMenuLateral();
            MenuLateralDireitoSteps.CheckRecuoMenuLateral();
        }

        [TestMethod]
        public void ClickLogoTest()
        {
            Console.WriteLine("Dado: Que deseja acessar Blog do QA Ninja");
            Console.WriteLine("Quando: Clicar na imagem [NinjaPixel]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário ao Blog do QA Ninja.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickImgBanner();
            MenuLateralDireitoSteps.CheckRedirecionamentoBanner();
        }

        [TestMethod]
        public void AcessarMenuCadastroTest()
        {
            Console.WriteLine("Dado: Que deseja acessar menu 'Lateral'");
            Console.WriteLine("Quando: Clicar no menu [Cadastro]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário ao menu 'Cadastro'.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickMenuCadastro();
            CadastroProdutosSteps.CheckNomeFuncionalidadeCadastro();
        }

        [TestMethod]
        public void AcessarApiDocsTest()
        {
            Console.WriteLine("Dado: Que deseja acessar menu 'API DOC'");
            Console.WriteLine("Quando: Clicar no menu [API DOC]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário ao menu 'API DOC'");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickMenuApi();
            MenuLateralDireitoSteps.CheckRedirecionamentoApi();
        }

        [TestMethod]
        public void AcessarBlogTest()
        {
            Console.WriteLine("Dado: Que deseja acessar menu 'Blog'");
            Console.WriteLine("Quando: Clicar no menu [BLOG]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário ao Blog do QA Ninja.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickBlog();
            MenuLateralDireitoSteps.CheckRedirecionamentoBlog();
        }
    }
}
