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

        public static void CheckProdutoCadastrado()
        {
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.FormNome).Displayed);
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.FormCategoria).Displayed);
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.FormDescricao).Displayed);
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.FormPreco).Displayed);
        }

        public static void CheckMensagemApagarProduto()
        {
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.MsgApagarProduto).Displayed, "Deseja apagar este produto?");
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.BtnSim).Displayed);
            Assert.IsTrue(Driver.FindElement(ListagemProdutosPage.BtnNao).Displayed);
        }

        public static void ClickApagarProduto()
        {
            Driver.FindElement(ListagemProdutosPage.BtnApagarProduto).Click();
        }

        public static void ClickNao()
        {
            Driver.FindElement(ListagemProdutosPage.BtnNao).Click();
        }

        public static void ClickSim()
        {
            Driver.FindElement(ListagemProdutosPage.BtnSim).Click();
        }
    }
}
