using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.CadastroProdutos;

namespace NinjaPixelWeb.Steps.CadastroProdutos
{
    public class CadastroProdutosSteps : Hooks
    {
        public static void CheckNomeFuncionalidadeCadastro()
        {
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.TituloFuncionalidade).Displayed, "Cadastro de produtos");
        }
    }
}
