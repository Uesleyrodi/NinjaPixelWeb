using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.Steps;
using NinjaPixelWeb.Steps.CadastroProdutos;
using NinjaPixelWeb.Steps.SideBar;
using System;
using System.Threading;

namespace NinjaPixelWeb.Feature
{
    [TestClass]
    public class ListaProdutosFeature : Hooks
    {
        [TestMethod]
        public void ProdutoNaoCadastradoTest()
        {
            Console.WriteLine("Dado: Que deseja acessar funcionalidade 'Cadastro de Produtos'");
            Console.WriteLine("E: Não tenha produtos cadastrados");
            Console.WriteLine("Quando: Acessar funcionalidade 'Cadastro de Produtos'");
            Console.WriteLine("Então: O sistema deverá exibir mensagem de Produtos não encontrados.");

            LoginSteps.Login("papito@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickMenuCadastro();
            ListagemProdutosSteps.CheckMensagemProdutoNaoEncontrado();
        }

        [TestMethod]
        public void PesquisaProdutosTest()
        {
            Console.WriteLine("Dado: Que usuário tenha produto cadastrado");
            Console.WriteLine("E: Acessar tela de Produtos");
            Console.WriteLine("Quando: Preencher campo @PesquisarPorNome e clicar em pesquisar");
            Console.WriteLine("Então: O sistema deverá exibir resultado da busca e exibir na grid");

            LoginSteps.Login("papito@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickMenuCadastro();
            ListagemProdutosSteps.CheckProdutoCadastrado();
        }

        [TestMethod]
        public void FecharModalRemocaoProduto()
        {
            Console.WriteLine("Dado: Que usuário deseja remover produto cadastrado");
            Console.WriteLine("E: Clicar no ícone @ApagarProduto");
            Console.WriteLine("Quando: Clicar botão @Não");
            Console.WriteLine("Então: O sistema deverá fechar a modal e retornar 'Listagem de Produtos'");

            LoginSteps.Login("papito@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickMenuCadastro();
            ListagemProdutosSteps.ClickApagarProduto();
            ListagemProdutosSteps.CheckMensagemApagarProduto();
            ListagemProdutosSteps.ClickNao();
            ListagemProdutosSteps.CheckProdutoCadastrado();
        }

        [TestMethod]
        public void RemoverCadastroProdutos()
        {
            Console.WriteLine("Dado: Que usuário tenha finalizado cadastro de produtos");
            Console.WriteLine("E: Clicar no ícone [Apagar Produto]");
            Console.WriteLine("Quando: Clicar na opção [SIM!]");
            Console.WriteLine("Então: O sistema deverá remover o produto da listagem.");

            LoginSteps.Login("papito@ninjapixel.com", "pwd123");
            MenuLateralDireitoSteps.ClickMenuCadastro();
            ListagemProdutosSteps.ClickApagarProduto();
            ListagemProdutosSteps.ClickSim();
            Thread.Sleep(2000);
            ListagemProdutosSteps.CheckMensagemProdutoNaoEncontrado();
        }
    }
}
