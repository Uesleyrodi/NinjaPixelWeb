using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.CadastroProdutos;

namespace NinjaPixelWeb.Steps.CadastroProdutos
{
    public class ListagemProdutosSteps : Hooks
    {
        public static void CheckNomeFuncionalidadeCadastro()
        {
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.TituloFuncionalidade).Displayed, "Cadastro de produtos");
        }

        public static void CheckMensagemProdutoNaoEncontrado()
        {
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.MsgProdutoNaoEncontradoLista).Displayed, "Puxa! não encontramos nada aqui :(");
        }
    }
}
