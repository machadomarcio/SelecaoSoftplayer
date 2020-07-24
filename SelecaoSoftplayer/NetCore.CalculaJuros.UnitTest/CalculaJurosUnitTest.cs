using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCore.CalculaJuros.Controllers;
using System;

namespace NetCore.CalculaJuros.UnitTest
{
    [TestClass]
    public class CalculaJurosUnitTest
    {
        [TestMethod]
        public void CalculaJurosUnitTest_deve_retornar_o_valor_correto_quando_quando_valorinicia_igual_cem_por_cinco_meses()
        {
            //Arrange
            var valorInicial = 100M;
            var quantidadeMeses = 5;
            var taxaJuros = 0.01M;

            //Act
            var calculoJuroComposto = new JuroComposto(valorInicial, quantidadeMeses, taxaJuros);

            //Assert
            Assert.AreEqual("105,10", calculoJuroComposto.ValorFinal);
        }

        [TestMethod]
        public void CalculaJurosUnitTest_deve_retornar_o_valor_correto_quando_quando_valorinicia_igual_trezendo_cinquenta_e_quinze_por_quinze_meses()
        {
            //Arrange
            var valorInicial = 350.15M;
            var quantidadeMeses = 15;
            var taxaJuros = 0.01M;

            //Act
            var calculoJuroComposto = new JuroComposto(valorInicial, quantidadeMeses, taxaJuros);

            //Assert
            Assert.AreEqual("406,51", calculoJuroComposto.ValorFinal);
        }
    }
}
