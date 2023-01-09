using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.CadastroProdutos;

namespace NinjaPixelWeb.Steps.CadastroProdutos
{
    public class CadastroProdutosSteps : Hooks
    {
        public static void CheckNomeFuncionalidade()
        {
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.TituloFuncionalidade).Displayed, "Cadastro de produtos");
        }
    }
}
