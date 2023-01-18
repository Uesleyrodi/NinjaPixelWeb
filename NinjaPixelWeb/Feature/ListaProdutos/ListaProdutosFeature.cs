using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.Steps;
using NinjaPixelWeb.Steps.CadastroProdutos;
using NinjaPixelWeb.Steps.SideBar;
using System;

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
    }
}
