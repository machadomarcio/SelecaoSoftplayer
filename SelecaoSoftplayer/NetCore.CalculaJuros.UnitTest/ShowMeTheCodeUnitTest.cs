using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCore.CalculaJuros.Controllers;
using System;

namespace NetCore.CalculaJuros.UnitTest
{
    [TestClass]
    public class ShowMeTheCodeUnitTest
    {
        private readonly ShowMeTheCodeController _showMeTheCodeController;
        private const string UrlGithub = "https://github.com/machadomarcio/SelecaoSoftplayer";

        public ShowMeTheCodeUnitTest()
        {
            _showMeTheCodeController = new ShowMeTheCodeController();
        }

        [TestMethod]
        public void ShowMeTheCodeUnitTest_deve_retornar_string_url_valida()
        {
            var retorno = _showMeTheCodeController.ShowMeTheCode();

            Assert.IsTrue(Uri.TryCreate(retorno, UriKind.RelativeOrAbsolute, out Uri uriResult));
        }

        [TestMethod]
        public void ShowMeTheCodeUnitTest_deve_retornar_o_endereco_de_url_correto()
        {
            var retorno = _showMeTheCodeController.ShowMeTheCode();

            Assert.AreEqual(UrlGithub, retorno);
        }
    }
}
