using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJuros.Controllers;

namespace NetCore.TaxaJuros.UnitTest
{
    [TestClass]
    public class TaxaJurosUnitTest
    {

        private readonly TaxaJurosController _taxaJurosController;

        public TaxaJurosUnitTest()
        {
            _taxaJurosController = new TaxaJurosController();
        }

        [TestMethod]
        public void TaxaJurosUnitTest_deveria_retornar_a_taxa_de_juro()
        {
            var retorno = _taxaJurosController.GetTaxaJuro();

            Assert.AreEqual(0.01M, retorno);
        }
    }
}
