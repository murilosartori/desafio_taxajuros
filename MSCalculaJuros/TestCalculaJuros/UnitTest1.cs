using NUnit.Framework;
using RepositoryCalculaJuros;
using RepositoryCalculaJuros.WebService;
using System.Net;
using DomainCalculaJuros;

namespace TestCalculaJuros
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VerificaWSTaxaDeJuros200()
        {
            Assert.IsTrue((new RepositoryTaxaJuros().GetTaxaJuros().StatusCode) == HttpStatusCode.OK);
        }

        [Test]
        public void VerificaValorFinal()
        {
            decimal resultadoEsperado = 105.10M;
            CalculaJuros valorFinal = new RepositoryJurosComposto().CalculaJurosComposto(100, 5);
            Assert.IsTrue(resultadoEsperado == valorFinal.ValorFinal);
        }
    }
}