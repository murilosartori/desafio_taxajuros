using DomainTaxaDeJuros;
using System;

namespace RepositoryTaxaDeJuros
{
    public class RepositoryTaxaJuros
    {
        public TaxaJuros GetTaxaJuros()
        {
            return new TaxaJuros
            {
                valorTaxaJuros = Convert.ToDecimal(0.01)
            };
        } 
    }
}
