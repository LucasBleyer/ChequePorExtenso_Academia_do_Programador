using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChequePorExtenso.Test
{
    [TestClass]
    public class Testes
    {
        Actions conversor = new Actions();

        [TestMethod]
        [DataRow(1, "Um Real")]
        [DataRow(2, "Dois Reais")]
        [DataRow(3, "Três Reais")]
        [DataRow(4, "Quatro Reais")]
        [DataRow(10, "Dez Reais")]

        [DataRow(11, "Onze Reais")]
        [DataRow(12, "Doze Reais")]
        [DataRow(13, "Treze Reais")]
        [DataRow(14, "Quatorze Reais")]
     

        [DataRow(21, "Vinte e Um Reais")]
        [DataRow(22, "Vinte e Dois Reais")]
        [DataRow(25, "Vinte e Cinco Reais")]
        [DataRow(26, "Vinte e Seis Reais")]

        public void Converter_Unidades_E_Dezenas(double numero, string resultadoEsperado)
        {
            //Arrange
            decimal numeroParaConversao = Convert.ToDecimal(numero);

            //Action
            var resultadoConversao = conversor.Converter(numeroParaConversao);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoConversao);
        }

        [TestMethod]
        [DataRow(105, "Cento e Cinco Reais")]
        [DataRow(155, "Cento e Cinquenta e Cinco Reais")]
        [DataRow(148, "Cento e Quarenta e Oito Reais")]
        [DataRow(169, "Cento e Sessenta e Nove Reais")]

        public void Converter_Centenas(double numero, string resultadoEsperado)
        {
            //Arrange
            decimal numeroParaConversao = Convert.ToDecimal(numero);

            //Action
            var resultadoConversao = conversor.Converter(numeroParaConversao);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoConversao);
        }

        [TestMethod]
        [DataRow(1000, "Um Mil  Reais")]
        [DataRow(1005, "Um Mil e Cinco Reais")]
        [DataRow(1030, "Um Mil e Trinta Reais")]
        [DataRow(3576, "Três Mil Quinhentos e Setenta e Seis Reais")]
        [DataRow(9999, "Nove Mil Novecentos e Noventa e Nove Reais")]
        [DataRow(1100.60 , "Um Mil e Cem Reais e Sessenta Centavos")]
        [DataRow(1110.10, "Um Mil Cento e Dez Reais e Dez Centavos")]

        public void Converter_Milhares(double numero, string resultadoEsperado)
        {
            //Arrange
            decimal numeroParaConversao = Convert.ToDecimal(numero);

            //Action
            var resultadoConversao = conversor.Converter(numeroParaConversao);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoConversao);
        }
    }
}