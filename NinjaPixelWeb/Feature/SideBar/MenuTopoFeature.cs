using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.CadastroProdutos;
using NinjaPixelWeb.Steps;
using NinjaPixelWeb.Steps.CadastroProdutos;
using NinjaPixelWeb.Steps.SideBar;
using System;

namespace NinjaPixelWeb.Feature
{
    [TestClass]
    public class MenuTopoFeature : Hooks
    {
        [TestMethod]
        public void AcessarCadastroProdutoTest()
        {
            Console.WriteLine("Dado: Que deseja acessar 'Cadastro de Produtos'");
            Console.WriteLine("Quando: Acessar menu 'Cadastros de Produtos' no menu superior");
            Console.WriteLine("Então: O sistema deverá direcionar usuário a funcionalidade 'Cadastro de Produtos'");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuTopoSteps.ClickCadastroProduto();
            ListagemProdutosSteps.CheckNomeFuncionalidadeCadastro();
        }

        [TestMethod]
        public void AcessarItemNavegacaoTest()
        {
            Console.WriteLine("Dado: Que deseja acessas as opções do Item de Navegação");
            Console.WriteLine("Quando: Clicar no ícone [Item de Navegação]");
            Console.WriteLine("Então: o sistema deverá exibir as opções 'Cadastro de Produtos', 'API DOC' e 'Sair'.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuTopoSteps.ClickitemNavegacao();
            MenuTopoSteps.CheckItemNavegacao();
        }

        [TestMethod]
        public void ItemNavegacaoCadastroProdutosTest()
        {
            Console.WriteLine("Dado: Que deseja acessar opção 'Cadastro de Produtos' que esta contido dentro do item de navegação");
            Console.WriteLine("E: Clicar no ícone [Item de Navegação]");
            Console.WriteLine("Quando: Clicar na opção [Cadastro de Produtos]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário a funcionalidade 'Cadastro de Produtos'");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuTopoSteps.ClickitemNavegacao();
            MenuTopoSteps.ClickItemCadastroProduto();
            ListagemProdutosSteps.CheckNomeFuncionalidadeCadastro();
        }

        [TestMethod]
        public void ItemNavegacaoApiDocTest()
        {
            Console.WriteLine("Dado: Que deseja acessar opção 'Cadastro de Produtos' que esta contido dentro do item de navegação");
            Console.WriteLine("E: Clicar no ícone [Item de Navegação]");
            Console.WriteLine("Quando: Clicar na opção [API DOC]");
            Console.WriteLine("Então: O sistema deverá direcionar usuário ao link de API DOC.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuTopoSteps.ClickitemNavegacao();
            MenuTopoSteps.ClickItemApiDoc();
            MenuTopoSteps.CheckRedirecionamentoApi();
        }

        [TestMethod]
        public void ItemNavegacaoSaiTest()
        {
            Console.WriteLine("Dado: Que deseja deslogar na aplicação");
            Console.WriteLine("E: Clicar no ícone [Item de Navegação]");
            Console.WriteLine("Quando: Clicar na opção [Sair]");
            Console.WriteLine("Então: O sistema deverá deslogar sessão do usuário e direcionar ao 'Login'.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            MenuTopoSteps.ClickitemNavegacao();
            MenuTopoSteps.ClickSair();
            LoginSteps.CheckLogin();
        }
    }
}
