using DomainCalculaJuros;
using RepositoryCalculaJuros.WebService;
using System;
using Newtonsoft.Json;

namespace RepositoryCalculaJuros
{
    public class RepositoryJurosComposto
    {
        public CalculaJuros CalculaJurosComposto(decimal valorInicial, int tempo)
        {
            CalculaJuros jurosComposto = new CalculaJuros();
            dynamic response = JsonConvert.DeserializeObject<dynamic>(new RepositoryTaxaJuros().GetTaxaJuros().Content);
            decimal taxaJuros = Convert.ToDecimal(response.valorTaxaJuros);

            double juros = 1 + Convert.ToDouble(taxaJuros);
            decimal final = valorInicial * Convert.ToDecimal(Math.Pow(juros, Convert.ToDouble(tempo)));
            jurosComposto.ValorFinal = final - (final % 0.01M);
            return jurosComposto;
        }
    }
}
