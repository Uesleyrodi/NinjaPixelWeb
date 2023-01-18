using OpenQA.Selenium;

namespace NinjaPixelWeb.PageObjects.CadastroProdutos
{
    public class ListagemProdutosPage
    {
        public static By NovoCadastroProdutos = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[1]/h4/button/i");
        public static By TituloFuncionalidade = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[1]/h4");
        public static By MsgProdutoNaoEncontradoLista = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[2]/div[3]/span");
        public static By CampoPesquisaNome = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[2]/div/form/div/input");
        public static By BtnPesquisar = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[2]/div/form/div/input");
    }
}
