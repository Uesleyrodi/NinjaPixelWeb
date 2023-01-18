﻿using OpenQA.Selenium;

namespace NinjaPixelWeb.PageObjects.CadastroProdutos
{
    public class ListagemProdutosPage
    {
        #region Texto

        public static By TituloFuncionalidade = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[1]/h4");

        #endregion

        #region Mensagens

        public static By MsgProdutoNaoEncontradoLista = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[2]/div[3]/span");

        #endregion

        #region Input

        public static By PesquisaNome = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[2]/div/form/div/input");

        #endregion

        #region Botões

        public static By NovoCadastroProdutos = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/div/div/div[1]/div/div[1]/h4/button/i");
        public static By BtnPesquisar = By.CssSelector("#search-product");
        public static By BtnApagarProduto = By.CssSelector("body > div:nth-child(1) > div.wrapper > div.main-panel > div > div > div > div > div > div.card-body > div.table-full-width.table-products > table > tbody > tr > td.td-actions.text-right > button > i");

        #endregion

        #region Formulário

        public static By FormNome = By.CssSelector("body > div:nth-child(1) > div.wrapper > div.main-panel > div > div > div > div > div > div.card-body > div.table-full-width.table-products > table > tbody > tr > td:nth-child(2)");
        public static By FormCategoria = By.CssSelector("body > div:nth-child(1) > div.wrapper > div.main-panel > div > div > div > div > div > div.card-body > div.table-full-width.table-products > table > tbody > tr > td:nth-child(3)");
        public static By FormDescricao = By.CssSelector("body > div:nth-child(1) > div.wrapper > div.main-panel > div > div > div > div > div > div.card-body > div.table-full-width.table-products > table > tbody > tr > td:nth-child(4)");
        public static By FormPreco = By.CssSelector("body > div:nth-child(1) > div.wrapper > div.main-panel > div > div > div > div > div > div.card-body > div.table-full-width.table-products > table > tbody > tr > td:nth-child(6)");

        #endregion
    }
}
