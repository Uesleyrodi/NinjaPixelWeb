using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.CadastroProdutos;
using NinjaPixelWeb.Steps;
using NinjaPixelWeb.Steps.CadastroProdutos;
using System;

namespace NinjaPixelWeb.Feature
{
    [TestClass]
    public class CadastroProdutosFeature : Hooks
    {
        [TestMethod]
        public void AcessarCadastroProdutoTest()
        {
            Console.WriteLine("Dado: Que usuário deseja cadastrar produtos");
            Console.WriteLine("Quando: Acessar 'Cadastro de Produto'");
            Console.WriteLine("Então: O sistema deverá direcionar usuário a funcionalidade 'Cadastro de Produto'.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            CadastroProdutosSteps.ClickNovoProduto();
            CadastroProdutosSteps.CheckNovoProduto();
        }

        [TestMethod]
        public void CadastroNomeBrancoTest()
        {
            Console.WriteLine("Dado: Que acesse a funcionalidade 'Cadastro de Produtos'");
            Console.WriteLine("E: Manter o campo @nome em branco");
            Console.WriteLine("Quando: Clicar no botão [Cadastrar]");
            Console.WriteLine("Então: O sistema deverá impedir o cadastro de produtos e exibir mensagem de erro.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            CadastroProdutosSteps.ClickNovoProduto();
            CadastroProdutosSteps.ClickCadastrar();
            CadastroProdutosSteps.CheckMensagemNomeBranco();
        }

        [TestMethod]
        public void CadastroCategoriaBrancoTest()
        {
            Console.WriteLine("Dado: Que acesse a funcionalidade 'Cadastro de Produtos'");
            Console.WriteLine("E: Preencher os campos: @Nome, @Preço, @Produtores, @Descrição.");
            Console.WriteLine("E: Manter o campo @Categoria em branco");
            Console.WriteLine("Quando: Clicar no botão 'Cadastrar'");
            Console.WriteLine("Então: O sistema deverá impedir o cadastro de produtos e exibir mensagem de erro.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            CadastroProdutosSteps.ClickNovoProduto();
            CadastroProdutosSteps.SetCategoriaEmBranco();
            CadastroProdutosSteps.CheckMensagemCategoriaBranco();
        }

        [TestMethod]
        public void CadastroPrecoEmBrancoTest()
        {
            Console.WriteLine("Dado: Que acesse a funcionalidade 'Cadastro de Produtos'");
            Console.WriteLine("E: Preencher os campos: @Nome, @Categoria, @Produtores, @Descrição.");
            Console.WriteLine("E: Manter o campo @Preço em branco");
            Console.WriteLine("Quando: Clicar no botão 'Cadastrar'");
            Console.WriteLine("Então: O sistema deverá impedir o cadastro de produtos e exibir mensagem de erro.");

            LoginSteps.Login("uesley@ninjapixel.com", "pwd123");
            CadastroProdutosSteps.ClickNovoProduto();
            CadastroProdutosSteps.SetPrecoEmBranco();
            CadastroProdutosSteps.CheckMensagemPrecoBranco();
        }

        [TestMethod]
        public void CadastroSucesso()
        {
            Console.WriteLine("Dado: Que acesse a funcionalidade 'Cadastro de Produtos'");
            Console.WriteLine("E: Preencher os campos: @Nome, @Categoria, @Preço, @Produtores, @Descrição, @UploadDeImagem");
            Console.WriteLine("Quando: Clicar no botão 'Cadastrar'");
            Console.WriteLine("Então: O sistema deverá validar as informações e exibir o dado na listagem de 'Cadastro de Produtos'.");
        }
    }
}
