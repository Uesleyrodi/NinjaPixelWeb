using Microsoft.VisualStudio.TestTools.UnitTesting;
using NinjaPixelWeb.PageObjects.CadastroProdutos;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace NinjaPixelWeb.Steps.CadastroProdutos
{
    public class CadastroProdutosSteps : Hooks
    {
        public static void SetProdutores()
        {
            string[] produtor = { "Kensuke Tanabe", "Ryan Harris", "Vince Joly", "Aaron Walker", "Ryan Powell", "David Wise" };
            foreach (string produtores in produtor)
            {
                Driver.FindElement(CadastroProdutosPage.Produtores).SendKeys(produtores);
                Driver.FindElement(CadastroProdutosPage.Produtores).SendKeys(Keys.Tab);
            }
        }

        public static void SetCategoria()
        {
            Driver.FindElement(CadastroProdutosPage.Categoria).Click();
            Driver.FindElement(CadastroProdutosPage.ClickListaCategoria).Click();
            Driver.FindElement(CadastroProdutosPage.ListaCategoria).Click();
        }

        public static void SetCategoriaEmBranco()
        {
            Driver.FindElement(CadastroProdutosPage.Nome).SendKeys("Donkey Kong");
            Driver.FindElement(CadastroProdutosPage.Preco).SendKeys("250,00");
            SetProdutores();
            Driver.FindElement(CadastroProdutosPage.Descricao).SendKeys("O jogo continua a partir da jogabilidade de plataforma de rolagem lateral da série Donkey Kong Country e vê Donkey Kong e seus amigos viajando por sete ilhas diferentes para derrotar os Snowmads.");
            ClickCadastrar();
        }

        public static void SetPrecoEmBranco()
        {
            Driver.FindElement(CadastroProdutosPage.Nome).SendKeys("Donkey Kong");
            SetProdutores();
            SetCategoria();
            Driver.FindElement(CadastroProdutosPage.Descricao).SendKeys("O jogo continua a partir da jogabilidade de plataforma de rolagem lateral da série Donkey Kong Country e vê Donkey Kong e seus amigos viajando por sete ilhas diferentes para derrotar os Snowmads.");
            ClickCadastrar();
        }

        public static void ClickNovoProduto()
        {
            Driver.FindElement(CadastroProdutosPage.BtnNovoProduto).Click();
        }

        public static void ClickCadastrar()
        {
            Driver.FindElement(CadastroProdutosPage.BtnCadastrar).Click();
        }

        public static void CheckNovoProduto()
        {
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.TituloFuncionalidade).Displayed, "Novo Produto");
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.Nome).Displayed);
            //Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.SelecaoCategoria).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.Preco).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.Produtores).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.Descricao).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.Upload).Displayed);
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.BtnCadastrar).Displayed);
        }

        public static void CheckMensagemNomeBranco()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.MsgNomeEmBranco).Displayed, "Oops - Informe o nome do produto!");
        }

        public static void CheckMensagemCategoriaBranco()
        {
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.MsgCategoriaEmBranco).Displayed, "Oops - Selecione uma categoria!");
        }

        public static void CheckMensagemPrecoBranco()
        {
            Assert.IsTrue(Driver.FindElement(CadastroProdutosPage.MsgPrecoEmBranco).Displayed, "Oops - Informe o preço também!");
        }
    }
}
