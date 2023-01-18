using OpenQA.Selenium;

namespace NinjaPixelWeb.PageObjects.CadastroProdutos
{
    public class CadastroProdutosPage
    {
        public static By TituloFuncionalidade = By.XPath("//*[@id=\"product-form\"]/div[1]/h4");

        #region Formulário Novo Produto

        public static By Categoria = By.CssSelector("input[placeholder=\"Gategoria\"]");
        public static By ListaCategoria = By.CssSelector("body > div.el-select-dropdown.el-popper > div.el-scrollbar > div.el-select-dropdown__wrap.el-scrollbar__wrap > ul > li.el-select-dropdown__item.select-primary.hover > span");
        public static By ClickListaCategoria = By.CssSelector(".el-scrollbar__view");

        public static By Nome = By.XPath("//*[@id=\"product-form\"]/div[2]/div[2]/div[1]/div[1]/div/div/div/div/input");
        public static By Preco = By.XPath("//*[@id=\"product-form\"]/div[2]/div[2]/div[1]/div[2]/div/div/div[2]/div/input");
        public static By Produtores = By.CssSelector(".producers");
        public static By Descricao = By.CssSelector("textarea[name=\"description\"]");
        public static By Upload = By.CssSelector("input[id=\"upcover\"]");
        #endregion

        #region Mensagem

        public static By MsgNomeEmBranco = By.XPath("//*[@id=\"product-form\"]/div[2]/div[1]/div[1]/span");
        public static By MsgCategoriaEmBranco = By.XPath("//*[@id=\"product-form\"]/div[2]/div[1]/div[1]/span");
        public static By MsgPrecoEmBranco = By.XPath("//*[@id=\"product-form\"]/div[2]/div[1]/div[1]/span");

        #endregion

        #region Botões

        public static By BtnNovoProduto = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[1]/h4/button/i");
        public static By BtnCadastrar = By.CssSelector("#create-product");
        
        #endregion
    }
}
